using static System.Net.Mime.MediaTypeNames;

namespace TowerDefence
{
    public partial class Form1 : Form
    {
        private Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        PointF dpi = PointF.Empty;

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;

            MinimumSize = new Size(resolution.Width / 2, resolution.Height / 2);
            Width = resolution.Width / 2;
            Height = resolution.Height / 2;

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

            if (Width >= resolution.Width / 2 && Width <= resolution.Width / 1.5)
            {
                button1.Font = new Font("Arial", 9);
                button2.Font = new Font("Arial", 9);
                button3.Font = new Font("Arial", 9);
                button4.Font = new Font("Arial", 9);
                button5.Font = new Font("Arial", 9);
                button6.Font = new Font("Arial", 9);
                button7.Font = new Font("Arial", 9);
            }

            if (Width >= resolution.Width / 1.5)
            {
                button1.Font = new Font("Arial", 13);
                button2.Font = new Font("Arial", 13);
                button3.Font = new Font("Arial", 13);
                button4.Font = new Font("Arial", 13);
                button5.Font = new Font("Arial", 13);
                button6.Font = new Font("Arial", 13);
                button7.Font = new Font("Arial", 13);
            }

            if (Width >= resolution.Width)
            {
                button1.Font = new Font("Arial", 18);
                button2.Font = new Font("Arial", 18);
                button3.Font = new Font("Arial", 18);
                button4.Font = new Font("Arial", 18);
                button5.Font = new Font("Arial", 18);
                button6.Font = new Font("Arial", 18);
                button7.Font = new Font("Arial", 18);
            }

            //var threadParameters = new System.Threading.ThreadStart(delegate { SizeChangedHandler(); });
            //var thread2 = new System.Threading.Thread(threadParameters);
            //thread2.Start();
        }

        public void SizeChangedHandler()
        {
            if (button1.InvokeRequired)
            {
                // Call this same method but append THREAD2 to the text
                Action sizeChangedHandler = delegate { SizeChangedHandler(); };
                button1.Invoke(sizeChangedHandler);
            }
            else
            {
                if (Width >= resolution.Width / 2 && Width <= resolution.Width / 1.5)
                {
                    button1.Font = new Font("Arial", 9);
                }

                if (Width >= resolution.Width / 1.5)
                {
                    button1.Font = new Font("Arial", 13);
                }

                if (Width >= resolution.Width)
                {
                    button1.Font = new Font("Arial", 18);
            }   }
        }
    }
}