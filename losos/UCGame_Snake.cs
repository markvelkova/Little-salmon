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
        List<Point> snake = new List<Point>();
        Point direction = new Point(1, 0);
        Point food;
        int tileSize = 20; 
        public UCGame_Snake()
        {
            InitializeComponent();
            snake.Add(new Point(5,5));
            Timer_GameTimer.Start();
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return keyData == Keys.Left || keyData == Keys.Right ||
                   keyData == Keys.Up || keyData == Keys.Down || base.IsInputKey(keyData);
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var segment in snake)
            {
                g.FillRectangle(Brushes.Green, new Rectangle(segment.X * tileSize, segment.Y * tileSize, tileSize, tileSize));
            }

            g.FillRectangle(Brushes.Red, new Rectangle(food.X * tileSize, food.Y * tileSize, tileSize, tileSize));
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Point newHead = new Point(snake[0].X + direction.X, snake[0].Y + direction.Y);
            snake.Insert(0, newHead);

            if (newHead != food)
            {
                if (snake.Count != 1)
                    snake.RemoveAt(snake.Count - 1);
            }
            else
                food = GenerateNewFood();

            Panel_Field.Invalidate();
        }

        private Point GenerateNewFood()
        {
            food = new Point(0, 0);
            food.X = random.Next(0, Panel_Field.Width / tileSize);
            food.Y = random.Next(0, Panel_Field.Height / tileSize);
            return food;
        }

        public void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    MessageBox.Show("Up key pressed");
                    if (direction.X != new Point(0, 1).X & direction.Y != new Point(0, 1).Y) 
                        direction = new Point(0, -1);
                    break;
                case Keys.S:
                    MessageBox.Show("Down key pressed");
                    if (direction.X != new Point(0, -1).X & direction.Y != new Point(0, -1).Y) 
                        direction = new Point(0, 1);
                    break;
                case Keys.A:
                    MessageBox.Show("Left key pressed");
                    if (direction.X != new Point(1, 0).X & direction.Y != new Point(1,0).Y) 
                        direction = new Point(-1, 0);
                    break;
                case Keys.D:
                    MessageBox.Show("Right key pressed");
                    if (direction.X != new Point(-1, 0).X & direction.Y != new Point(-1, 0).Y) 
                        direction = new Point(1, 0);
                    break;
            }
        }

        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
