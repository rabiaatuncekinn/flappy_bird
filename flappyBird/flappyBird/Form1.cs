namespace flappyBird
{
    public partial class Form1 : Form
    {
        int boruHizi = 20;
        int gravity = 20;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            boruAlt.Left -= boruHizi;
            boruUst.Left -= boruHizi;
            boruAlt1.Left -= boruHizi;
            boruUst1.Left -= boruHizi;
            boruAlt2.Left -= boruHizi;
            boruUst2.Left -= boruHizi;

            scoreText.Text = "Score: " + score;

            if (boruAlt.Left < -150 && boruUst.Left < -180)
            {
                boruAlt.Left = 1400;
                boruUst.Left = 1550;

                score++;
            }
            if (boruAlt1.Left < -150 && boruUst1.Left < -180)
            {
                boruAlt1.Left = 1400;
                boruUst1.Left = 1550;

                score++;
            }
            if (boruAlt2.Left < -150 && boruUst2.Left < -180)
            {
                boruAlt2.Left = 1500;
                boruUst2.Left = 1750;

                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(boruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(boruUst.Bounds) || flappyBird.Bounds.IntersectsWith(zemin.Bounds) || flappyBird.Bounds.IntersectsWith(boruAlt1.Bounds) || flappyBird.Bounds.IntersectsWith(boruUst1.Bounds)|| flappyBird.Bounds.IntersectsWith(boruAlt2.Bounds) || flappyBird.Bounds.IntersectsWith(boruUst2.Bounds))
            {
                endGame();
            }
            if (score > 10)
            {
                boruHizi = 30;

            }
            if (flappyBird.Top < -25)
            {
                endGame();

            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over! Score:" + score;

        }

        private void boruAlt_Click(object sender, EventArgs e)
        {

        }

        private void boruUst1_Click(object sender, EventArgs e)
        {

        }
    }
}
