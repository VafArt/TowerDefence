using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using TowerDefence.Defenders;
using TowerDefence.Factories;
using static System.Net.Mime.MediaTypeNames;

namespace TowerDefence
{
    public partial class Form1 : Form
    {
        private Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

        PointF dpi = PointF.Empty;
        bool currentlyAnimating = false;

        ILevel Level { get; set; }

        //public void AnimateImage()
        //{
        //    if (!currentlyAnimating)
        //    {
        //        //Begin the animation only once.
        //        ImageAnimator.Animate(Level.Lines[0].Defenders[0].Image, new EventHandler(this.OnFrameChanged));
        //        currentlyAnimating = true;
        //    }
        //}

        //private void OnFrameChanged(object o, EventArgs e)
        //{

        //    //Force a call to the Paint event handler.
        //    pictureBox1.Invalidate();
        //}

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            ////Begin the animation.
            //AnimateImage();

            ////Get the next frame ready for rendering.
            //ImageAnimator.UpdateFrames();

            ////Draw the next frame in the animation.
            //e.Graphics.DrawImage(Level.Lines[0].Defenders[0].Image,
            //    0f,
            //    (float)(0.43 * pictureBox1.Height - Level.Lines[0].Defenders[0].HeightScale * pictureBox1.Height),
            //    (float)Level.Lines[0].Defenders[0].WidthScale * pictureBox1.Width,
            //    (float)Level.Lines[0].Defenders[0].HeightScale * pictureBox1.Height);
        }

        public Form1()
        {
            InitializeComponent();

            var animationTimer = new System.Windows.Forms.Timer();

            var currentFrame = 0;
            var image = pictureBox2.Image;
            var dims = image.FrameDimensionsList;
            var dim = new System.Drawing.Imaging.FrameDimension(dims[0]);
            animationTimer.Tick += (obj, args) =>
            {
                image.SelectActiveFrame(dim, currentFrame);
                pictureBox2.Invalidate();
                currentFrame++;

                if (currentFrame == image.GetFrameCount(dim))
                    currentFrame = 0;
            };
            animationTimer.Interval = 100;

            animationTimer.Start();
            ////
            var levelBuilder = new LevelBuilder(Width, 10);
            levelBuilder.AddAttackers();
            Level = levelBuilder.Build();
            Level.Lines[0].Defenders.Add(new MinigunOrkFactory().Create());
            Level.Lines[1].Defenders.Add(new MinigunOrkFactory().Create());
            Level.Lines[2].Defenders.Add(new MinigunOrkFactory().Create());

            DoubleBuffered = true;

            MinimumSize = new Size(resolution.Width / 2, resolution.Height / 2);
            Width = resolution.Width / 2;
            Height = resolution.Height / 2;

            using (Graphics g = this.CreateGraphics())
            {
                dpi.X = g.DpiX;
                dpi.Y = g.DpiY;
            }

            panel1.Height = (int)Math.Round(((Height - 39) * 0.85));
            panel2.Height = (int)Math.Round(((Height - 39) * 0.15));

            panel3.Width = panel2.Width / 12;
            panel4.Width = panel2.Width / 12;
            panel5.Width = panel2.Width / 12;
            panel6.Width = panel2.Width / 12;
            panel7.Width = panel2.Width / 12;

            button1.Height = panel2.Height / 3;
            button2.Height = panel2.Height / 3;
            button3.Height = panel2.Height / 3;

            if (dpi.X > 150)
            {
                button1.Font = new Font("Arial", 9);
                button2.Font = new Font("Arial", 9);
                button3.Font = new Font("Arial", 9);
                button4.Font = new Font("Arial", 9);
                button5.Font = new Font("Arial", 9);
                button6.Font = new Font("Arial", 9);
                button7.Font = new Font("Arial", 9);
            }
            else
            {
                button1.Font = new Font("Arial", 14);
                button2.Font = new Font("Arial", 14);
                button3.Font = new Font("Arial", 14);
                button4.Font = new Font("Arial", 14);
                button5.Font = new Font("Arial", 14);
                button6.Font = new Font("Arial", 14);
                button7.Font = new Font("Arial", 14);
            }

            pictureBox1.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Height = (int)Math.Round(((Height - 39) * 0.85));
            panel2.Height = (int)Math.Round(((Height - 39) * 0.15));

            panel3.Width = panel2.Width / 12;
            panel4.Width = panel2.Width / 12;
            panel5.Width = panel2.Width / 12;
            panel6.Width = panel2.Width / 12;
            panel7.Width = panel2.Width / 12;

            button1.Height = panel2.Height / 3;
            button2.Height = panel2.Height / 3;
            button3.Height = panel2.Height / 3;

            if (Width >= resolution.Width / 2 && Width <= resolution.Width / 1.5 && dpi.X > 150)
            {
                button1.Font = new Font("Arial", 9);
                button2.Font = new Font("Arial", 9);
                button3.Font = new Font("Arial", 9);
                button4.Font = new Font("Arial", 9);
                button5.Font = new Font("Arial", 9);
                button6.Font = new Font("Arial", 9);
                button7.Font = new Font("Arial", 9);
            }

            if (Width >= resolution.Width / 1.5 && dpi.X > 150)
            {
                button1.Font = new Font("Arial", 13);
                button2.Font = new Font("Arial", 13);
                button3.Font = new Font("Arial", 13);
                button4.Font = new Font("Arial", 13);
                button5.Font = new Font("Arial", 13);
                button6.Font = new Font("Arial", 13);
                button7.Font = new Font("Arial", 13);
            }

            if (Width >= resolution.Width && dpi.X > 150)
            {
                button1.Font = new Font("Arial", 18);
                button2.Font = new Font("Arial", 18);
                button3.Font = new Font("Arial", 18);
                button4.Font = new Font("Arial", 18);
                button5.Font = new Font("Arial", 18);
                button6.Font = new Font("Arial", 18);
                button7.Font = new Font("Arial", 18);
            }

            if (Width >= resolution.Width / 2 && Width <= resolution.Width / 1.5 && dpi.X < 150)
            {
                button1.Font = new Font("Arial", 14);
                button2.Font = new Font("Arial", 14);
                button3.Font = new Font("Arial", 14);
                button4.Font = new Font("Arial", 14);
                button5.Font = new Font("Arial", 14);
                button6.Font = new Font("Arial", 14);
                button7.Font = new Font("Arial", 14);
            }

            if (Width >= resolution.Width / 1.5 && dpi.X < 150)
            {
                button1.Font = new Font("Arial", 18);
                button2.Font = new Font("Arial", 18);
                button3.Font = new Font("Arial", 18);
                button4.Font = new Font("Arial", 18);
                button5.Font = new Font("Arial", 18);
                button6.Font = new Font("Arial", 18);
                button7.Font = new Font("Arial", 18);
            }

            if (Width >= resolution.Width && dpi.X < 150)
            {
                button1.Font = new Font("Arial", 22);
                button2.Font = new Font("Arial", 22);
                button3.Font = new Font("Arial", 22);
                button4.Font = new Font("Arial", 22);
                button5.Font = new Font("Arial", 22);
                button6.Font = new Font("Arial", 22);
                button7.Font = new Font("Arial", 22);
            }

        }
    }
}