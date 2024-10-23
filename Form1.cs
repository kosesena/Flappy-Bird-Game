using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class Form1 : Form
    {
        int BoruHızı = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent(); // Mevcut oluşturulmuş bileşenlerin çağrılması
            // Double buffering'i aktif et
            this.DoubleBuffered = true;

        }

     
        private void GameTimerEvent(object sender, EventArgs e)
        {
            Flappybird.Top += gravity;
            PipeDown.Left -= BoruHızı;
            PipeUp.Left -= BoruHızı;
            ScoreText.Text = "Score: " + score;
            if(PipeDown.Left < -150)
            {
                PipeDown.Left = 950;
                score++;

            }
            if(PipeUp.Left < -180)
            {
                PipeUp.Left = 950;
                score++;
            }
            if (Flappybird.Bounds.IntersectsWith(PipeDown.Bounds) ||Flappybird.Bounds.IntersectsWith(PipeUp.Bounds)|| Flappybird.Bounds.IntersectsWith(Ground.Bounds))
            {
                EndGame();
            }
        }


        private void Gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = 5;
            }
        }

        private void EndGame()
        {
            GameTimer.Stop(); // Oyunu durdur
            ScoreText.Visible = false;
            
            // Game Over resmini ekranın ortasında olacak şekilde ayarladım
            gameOverPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi boyuta göre ayarlar
            gameOverPictureBox.Location = new Point(
                (this.ClientSize.Width - gameOverPictureBox.Width) / 2, (this.ClientSize.Height - gameOverPictureBox.Height) / 2);
            gameOverPictureBox.Size = new Size(200, 100); //Resmin boyutlarını ayarlar
           
            // Game Over resminin arka plan rengini değiştirme
            Bitmap gameOverImage = new Bitmap(Properties.Resources.game_over_sprite.Width,Properties.Resources.game_over_sprite.Height);
            //Arka plan rengini belirlediğiniz RGB ile doldurun
            using (Graphics g = Graphics.FromImage(gameOverImage))
            {
                //Arka planı seçilen renk ile doldurun
                g.Clear(Color.FromArgb(77, 193, 203));
                g.DrawImage(Properties.Resources.game_over_sprite, new Point(0, 0));
            }
            //PictureBox'a bu yeni resmi atayın
            gameOverPictureBox.Image = gameOverImage;
            gameOverPictureBox.Visible = true; // Resmi görünür yap
        }
    }

    }

