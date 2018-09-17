using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MoveButton1_Click(object sender, EventArgs e)
        {
            
        }
        //Moves image to the right
        private void RightButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 10 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(ClientRectangle.Width - pictureBox1.Width, pictureBox1.Location.Y);
            }
        }
        //Moves image down
        private void DownButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 10 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, ClientRectangle.Height - pictureBox1.Height);
            }
        }
        //Moves image to the left
        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
        }
        //Moves image up
        private void UpButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 10)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
        }
        //moves image diagonally (north west)
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 10)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
        }
        //moves image diagonally (north east)
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 10)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            }
            if (pictureBox1.Location.X + 10 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(ClientRectangle.Width - pictureBox1.Width, pictureBox1.Location.Y);
            }
        }
        //moves image diagonally (south west)
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 10 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, ClientRectangle.Height - pictureBox1.Height);
            }
            if (pictureBox1.Location.X > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
        }
        //moves image diagonally (south east)
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 10 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, ClientRectangle.Height - pictureBox1.Height);
            }
            if (pictureBox1.Location.X + 10 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(ClientRectangle.Width - pictureBox1.Width, pictureBox1.Location.Y);
            }
        }
    }
}
