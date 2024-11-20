using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amedee_nicolas
{
    
    public partial class Form1 : Form
       {  private List<PictureBox> plateformes = new List<PictureBox>();
        bool isJumping = false;
   
        private void AjouterPlateforme(int x, int y)
        {
            PictureBox plateforme = new PictureBox
            {
                Width = 100,
                Height = 20,
                BackColor = Color.Brown,
                Location = new Point(x, y)
            };
            plateformes.Add(plateforme); // Ajoute la plateforme à la liste
            this.Controls.Add(plateforme);
            
        }
        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            AjouterPlateforme(e.X, e.Y);
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjouterPlateforme(500, 200);
        }
         bool isOnPlatform=false;
        private void timerGravity_Tick(object sender, EventArgs e)
        {
            

            
            foreach (var plateforme in plateformes)
            {
                if (Pplayer.Bounds.IntersectsWith(plateforme.Bounds) &&!(Pplayer.Top >= plateforme.Bottom )) 
                {
                    isOnPlatform = true;
                    Pplayer.Top = plateforme.Top - Pplayer.Height; 
                    break;
                }else if (Pplayer.Bounds.IntersectsWith(plateforme.Bounds) && Pplayer.Top >= plateforme.Bottom)
                {
                    timerup.Stop();
                    isJumping = false;


                }
                
                
                
            }
            if (isOnPlatform == false && isJumping ==false)
            {

                Pplayer.Top += 10;
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
           isOnPlatform =false;
            isJumping = true;
            Pplayer.Top -= 10;

        }
        


        private void timerdroite_Tick(object sender, EventArgs e)
        {
            Pplayer.Left += 10;
        }

        private void timergauche_Tick(object sender, EventArgs e)
        {
            Pplayer.Left -= 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timerup.Start();
                isJumping = true;
                
            }
            else if (e.KeyCode == Keys.Down)
            {

            }
            else if (e.KeyCode == Keys.Left)
            {
                timerdroite.Start();
            }
            else if (e.KeyCode == Keys.Right)
            {

                timergauche.Start();
            }  
        }
        

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timerup.Stop();
                isJumping = false;
               
            }
            else if (e.KeyCode == Keys.Down)
            {

            }
            else if (e.KeyCode == Keys.Left)
            {
                timerdroite.Stop();
            }
            else if (e.KeyCode == Keys.Right)
            {

                timergauche.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pplayer_Click(object sender, EventArgs e)
        {

        }
       
    }
}
