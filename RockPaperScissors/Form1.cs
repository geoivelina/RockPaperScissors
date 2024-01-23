using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            switch (computerTurn)
            {
                case 1:
                    pictureBox1.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\paper.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\scissors.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\rock.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (playerTurn)
            {
                case 1:
                    pictureBox2.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\paper.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\scissors.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"C:\Users\User\source\repos\RockPaperScissors\rock.jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            determineWInner(computerTurn, playerTurn);

        }
        public void determineWInner(int comuter, int player)
        {
            if (comuter == 1 && player == 2)
            {
                label1.Text = "Player wins!";
            }
            else if (comuter == 1 && player == 3)
            {
                label1.Text = "Computer wins!";
            }
            else if (comuter == 2 && player == 1)
            {
                label1.Text = "Computer wins!";
            }
            else if (comuter == 2 && player == 3)
            {
                label1.Text = "Player wins!";
            }
            else if (comuter == 3 && player == 1)
            {
                label1.Text = "Player wins!";
            }
            else if (comuter == 3 && player == 2)
            {
                label1.Text = "Computer wins!";
            }
            else 
            {
                label1.Text = "Draw game!";
            }
        }
    }
}
