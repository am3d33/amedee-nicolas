namespace amedee_nicolas
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pground = new System.Windows.Forms.PictureBox();
            this.Pplayer = new System.Windows.Forms.PictureBox();
            this.timerGravity = new System.Windows.Forms.Timer(this.components);
            this.timerup = new System.Windows.Forms.Timer(this.components);
            this.timerdroite = new System.Windows.Forms.Timer(this.components);
            this.timergauche = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pground
            // 
            this.Pground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pground.Location = new System.Drawing.Point(-142, 343);
            this.Pground.Name = "Pground";
            this.Pground.Size = new System.Drawing.Size(990, 141);
            this.Pground.TabIndex = 0;
            this.Pground.TabStop = false;
            // 
            // Pplayer
            // 
            this.Pplayer.BackColor = System.Drawing.Color.Maroon;
            this.Pplayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pplayer.BackgroundImage")));
            this.Pplayer.Location = new System.Drawing.Point(451, 107);
            this.Pplayer.Name = "Pplayer";
            this.Pplayer.Size = new System.Drawing.Size(42, 57);
            this.Pplayer.TabIndex = 1;
            this.Pplayer.TabStop = false;
            this.Pplayer.Click += new System.EventHandler(this.Pplayer_Click);
            // 
            // timerGravity
            // 
            this.timerGravity.Enabled = true;
            this.timerGravity.Interval = 10;
            this.timerGravity.Tick += new System.EventHandler(this.timerGravity_Tick);
            // 
            // timerup
            // 
            this.timerup.Interval = 10;
            this.timerup.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerdroite
            // 
            this.timerdroite.Interval = 10;
            this.timerdroite.Tick += new System.EventHandler(this.timerdroite_Tick);
            // 
            // timergauche
            // 
            this.timergauche.Interval = 10;
            this.timergauche.Tick += new System.EventHandler(this.timergauche_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(100, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pplayer);
            this.Controls.Add(this.Pground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Pground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pground;
        private System.Windows.Forms.PictureBox Pplayer;
        private System.Windows.Forms.Timer timerGravity;
        private System.Windows.Forms.Timer timerup;
        private System.Windows.Forms.Timer timerdroite;
        private System.Windows.Forms.Timer timergauche;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

