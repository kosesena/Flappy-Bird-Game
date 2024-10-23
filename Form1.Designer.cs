namespace Flappybird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.PipeUp = new System.Windows.Forms.PictureBox();
            this.Flappybird = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameOverPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappybird.Properties.Resources._base;
            this.Ground.Location = new System.Drawing.Point(-1, 414);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(945, 83);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.BackColor = System.Drawing.Color.Transparent;
            this.PipeDown.Image = global::Flappybird.Properties.Resources.pipe;
            this.PipeDown.Location = new System.Drawing.Point(633, 268);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(37, 149);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 1;
            this.PipeDown.TabStop = false;
            // 
            // PipeUp
            // 
            this.PipeUp.BackgroundImage = global::Flappybird.Properties.Resources.background_day;
            this.PipeUp.Image = global::Flappybird.Properties.Resources.pipedown;
            this.PipeUp.Location = new System.Drawing.Point(514, 0);
            this.PipeUp.Name = "PipeUp";
            this.PipeUp.Size = new System.Drawing.Size(42, 180);
            this.PipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeUp.TabIndex = 2;
            this.PipeUp.TabStop = false;
            // 
            // Flappybird
            // 
            this.Flappybird.BackColor = System.Drawing.Color.Transparent;
            this.Flappybird.Image = global::Flappybird.Properties.Resources.bird;
            this.Flappybird.Location = new System.Drawing.Point(172, 194);
            this.Flappybird.Name = "Flappybird";
            this.Flappybird.Size = new System.Drawing.Size(49, 37);
            this.Flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappybird.TabIndex = 3;
            this.Flappybird.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(438, 463);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(72, 22);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score:0";
            this.ScoreText.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // gameOverPictureBox
            // 
            this.gameOverPictureBox.Location = new System.Drawing.Point(394, 194);
            this.gameOverPictureBox.Name = "gameOverPictureBox";
            this.gameOverPictureBox.Size = new System.Drawing.Size(222, 75);
            this.gameOverPictureBox.TabIndex = 5;
            this.gameOverPictureBox.TabStop = false;
            this.gameOverPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Flappybird.Properties.Resources.background_day;
            this.ClientSize = new System.Drawing.Size(939, 494);
            this.Controls.Add(this.gameOverPictureBox);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Flappybird);
            this.Controls.Add(this.PipeUp);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox PipeUp;
        private System.Windows.Forms.PictureBox Flappybird;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox gameOverPictureBox;
    }
}

