using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losos
{
    public partial class UCGame_Snake: UserControl
    {
        
        Random random = new Random();
        List<SnakeSegment> snake = new List<SnakeSegment>();
        // Initial direction of the snake
        Point direction = new Point(1, 0);
        Point food;
        int tileSize = 20; 

        Brush SnakeHeadColour = Brushes.Black;
        Brush SnakeBodyColour1 = Brushes.Green;
        Brush SnakeBodyColour2 = Brushes.DarkGreen;

        Brush FoodColour = Brushes.Red;

        static int MaxX;
        static int MaxY;
        public UCGame_Snake()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            this.Focus();

            Button_ReturnButton.TabStop = false;

            MaxX = Panel_Field.Width / tileSize;
            MaxY = Panel_Field.Height / tileSize;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Reset the game state
            snake.Clear();
            direction = new Point(1, 0);
            snake.Add(new SnakeSegment(new Point(5, 5), SnakeHeadColour));
            food = GenerateNewFood();
            Timer_GameTimer.Start();
            Panel_Field.Invalidate();

            Button_ReturnButton.Enabled = false;
            Button_Start.Enabled = false;

            this.Focus();
        }

        private void HandleGameEnd()
        {
            Timer_GameTimer.Stop();
            Button_ReturnButton.Enabled = true;
            Button_Start.Enabled = true;
            MessageBox.Show("Game Over! You collided with yourself.");
        }

        #region keyhandling
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Focus();
            this.KeyDown += Snake_KeyDown;
            this.PreviewKeyDown += Snake_PreviewKeyDown;
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return keyData == Keys.Left || keyData == Keys.Right ||
                   keyData == Keys.Up || keyData == Keys.Down || base.IsInputKey(keyData);
        }

        public void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction.X != new Point(0, 1).X & direction.Y != new Point(0, 1).Y)
                        direction = new Point(0, -1);
                    break;
                case Keys.Down:
                    if (direction.X != new Point(0, -1).X & direction.Y != new Point(0, -1).Y)
                        direction = new Point(0, 1);
                    break;
                case Keys.Left:
                    if (direction.X != new Point(1, 0).X & direction.Y != new Point(1, 0).Y)
                        direction = new Point(-1, 0);
                    break;
                case Keys.Right:
                    if (direction.X != new Point(-1, 0).X & direction.Y != new Point(-1, 0).Y)
                        direction = new Point(1, 0);
                    break;
            }
        }
        private void Snake_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }
        #endregion

        #region snake movement

        private class SnakeSegment
        {
            public Point Position;
            public int X => Position.X;
            public int Y => Position.Y;
            public Brush FillBrush { get; set; }
            public SnakeSegment(Point position, Brush fillBrush)
            {
                Position = position;
                FillBrush = fillBrush;
            }
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var segment in snake)
            {
                g.FillRectangle(segment.FillBrush, new Rectangle(segment.X * tileSize, segment.Y * tileSize, tileSize, tileSize));
            }

            g.FillRectangle(FoodColour, new Rectangle(food.X * tileSize, food.Y * tileSize, tileSize, tileSize));
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            MoveSnake();
            Panel_Field.Invalidate();
        }

        private void MoveSnake()
        {
            SnakeSegment newHead = GetNewHead();

            CheckCollisionWithSelf(newHead);

            MoveHeadColour(); // change old head colour based on the second segment

            snake.Insert(0, newHead);
            if (newHead.Position != food)
            {
                if (snake.Count != 1) // must not delete the head
                    snake.RemoveAt(snake.Count - 1);
            }
            else
                food = GenerateNewFood();

            
        }
        private void MoveHeadColour()
        {
            if (snake.Count >= 2)
            {
                if (snake[1].FillBrush == SnakeBodyColour1)
                    snake[0].FillBrush = SnakeBodyColour2;
                else
                    snake[0].FillBrush = SnakeBodyColour1;
            }
            else
            {
                snake[0].FillBrush = SnakeBodyColour1;
            }
        }

        private int Mod(int a, int n)
        {
            return ((a % n) + n) % n;
        }

        private SnakeSegment GetNewHead()
        {
            int newX = Mod(snake[0].X + direction.X, MaxX);
            int newY = Mod(snake[0].Y + direction.Y, MaxY);
            return new SnakeSegment (new Point(newX, newY), SnakeHeadColour);
        }
        private void CheckCollisionWithSelf(SnakeSegment newHead)
        {
            foreach (var segment in snake)
            {
                if (segment.Position == newHead.Position)
                {
                    // Game over: snake collided with itself
                    HandleGameEnd();
                    return;
                }
            }
        }
        #endregion

        #region food

        private class SnakeFoodUnit
        {
            public List<Point> Positions = new();
            public SnakeFoodUnit(Point position, bool isBig)
            {
                Positions.Add(position);
                if (isBig)
                {
                    Positions.Add(new Point(position.X + 1, position.Y));
                    Positions.Add(new Point(position.X, position.Y + 1));
                    Positions.Add(new Point(position.X + 1, position.Y + 1));
                }

            }
        }

        private Point GenerateNewFood()
        {
            food = new Point(0, 0);
            food.X = random.Next(0, Panel_Field.Width / tileSize);
            food.Y = random.Next(0, Panel_Field.Height / tileSize);
            return food;
        }

        #endregion


        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
