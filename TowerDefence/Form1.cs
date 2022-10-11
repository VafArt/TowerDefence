namespace TowerDefence
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer _timer;

        public Form1()
        {
            InitializeComponent();
            panel2.Height = (int)Math.Round(((Height - 39) * 0.15));
            panel1.Height = (int)Math.Round(((Height - 39) * 0.85));
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel2.Height = (int)Math.Round(((Height - 39) * 0.2));
            panel1.Height = (int)Math.Round(((Height - 39) * 0.8));

            panel3.Width = panel2.Width / 6;
            panel4.Width = panel2.Width / 6;
            panel5.Width = panel2.Width / 6;
        }
    }
}