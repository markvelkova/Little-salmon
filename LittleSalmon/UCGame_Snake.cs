using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSalmon
{
    public partial class UCGame_Snake : GamesUserControlParent
    {
        
        Random random = new Random();
        List<SnakeSegment> snake = new List<SnakeSegment>();
        // Initial direction of the snake
        Point direction = new Point(1, 0);

        SnakeFoodUnit food = new();
        int BigFoodProb = 10; // 10% chance for big food
        int TotalReward = 0; // Total reward for the snake, not used in this version but can be useful for future enhancements

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

            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one

            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            this.Focus();

            UsefulForDesign.CenterControlHorizontally(Label_ArrowHint);
            UpdateRewardLabel();

            myButton_Return.TabStop = false;

            MaxX = Panel_Field.Width / tileSize;
            MaxY = Panel_Field.Height / tileSize;
        }

        private void UpdateRewardLabel()
        {
            Label_Reward.Text = "Total Reward: " + TotalReward;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Reset the game state
            TotalReward = 0;
            UpdateRewardLabel();
            snake.Clear();
            direction = new Point(1, 0);
            snake.Add(new SnakeSegment(new Point(5, 5), SnakeHeadColour));
            food = GenerateNewFood();
            Timer_GameTimer.Start();
            Panel_Field.Invalidate();

            // they tended to steal the focus from the game panel
            myButton_Return.Enabled = false;
            myButton_Start.Enabled = false;

            this.Focus();
        }

        private void HandleGameEnd()
        {
            Timer_GameTimer.Stop();
            myButton_Return.Enabled = true;
            myButton_Start.Enabled = true;
            UpdateStats(); // Update the Stats with the total reward and the record, if neccwessary
            MainForm.thePet.AddFood(TotalReward); // Add the total reward to the Pet's food count
            MessageBox.Show("Game Over! You collided with yourself.");
        }

        private void UpdateStats()
        {
            MainForm.theStats.AdjustStat("Snake food eaten", TotalReward);
            if (TotalReward > MainForm.theStats.GetStat("Snake record"))
            {
                MainForm.theStats.AdjustStat("Snake record", TotalReward);
            }
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

        public void Snake_KeyDown(object? sender, KeyEventArgs e)
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
        private void Snake_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
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

            foreach (var foodPosition in food.Positions)
                g.FillRectangle(FoodColour, new Rectangle(foodPosition.X * tileSize, foodPosition.Y * tileSize, tileSize, tileSize));
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

            MoveHeadColour(); // change old head colour based on the second newHead

            snake.Insert(0, newHead);
            if (!IsOnFood(newHead))
            {
                if (snake.Count != 1) // must not delete the head
                    snake.RemoveAt(snake.Count - 1);
                if (food is BigSnakeFoodUnit bigFood)
                {
                    bigFood.timeLeft--;
                    if (bigFood.timeLeft <= 0)
                    {
                        // Big food has expired, generate new food
                        food = GenerateNewFood();
                    }
                }
            }
            else
            {
                HandleFoodConsumption();
                food = GenerateNewFood();
                
            }
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

        private bool IsOnFood(SnakeSegment newHead)
        {
            return food.Positions.Any(foodPosition => foodPosition == newHead.Position);
        }
        #endregion

        #region food

        private class SnakeFoodUnit
        {
            public List<Point> Positions = new();
            public int value => Positions.Count;
            public SnakeFoodUnit(Point position)
            {
                Positions.Add(position);
                
            }
            public SnakeFoodUnit()
            {

            }
        }

        private class BigSnakeFoodUnit : SnakeFoodUnit
        {
            public int timeLeft = 20; // Time left for the big food to exist, in gameTicks
            public BigSnakeFoodUnit(Point position) : base(position)
            {
                Positions.Add(new Point(position.X + 1, position.Y));
                Positions.Add(new Point(position.X, position.Y + 1));
                Positions.Add(new Point(position.X + 1, position.Y + 1));
            }
        }


        private SnakeFoodUnit GenerateNewFood()
        {
            Point foodPoint = new Point(0, 0);
            foodPoint.X = random.Next(0, Panel_Field.Width / tileSize);
            foodPoint.Y = random.Next(0, Panel_Field.Height / tileSize);
            
            while (snake.Any(segment => segment.Position == foodPoint))
            {
                foodPoint.X = random.Next(0, Panel_Field.Width / tileSize);
                foodPoint.Y = random.Next(0, Panel_Field.Height / tileSize);
            }

            if (random.Next(0, 100) < BigFoodProb)
            {
                return new BigSnakeFoodUnit(foodPoint);
            }
            else
            {
                return new SnakeFoodUnit(foodPoint);
            }
        }



        private void HandleFoodConsumption()
        {
            
            TotalReward += food.value;
            UpdateRewardLabel();
        }

        #endregion
    }
}
