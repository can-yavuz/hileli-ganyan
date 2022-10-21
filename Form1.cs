namespace horse_race

{
    public partial class horse_race : Form
    {

        int finish_line = 852;
        int speed1 = 15;
        int speed2 = 15;
        int speed3 = 15;
        int speed4 = 15;
        int speed5 = 15;

        public horse_race()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            speed1 = 25;
            button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speed2 = 25;
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speed3 = 25;
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            speed4 = 25;
            button1_Click(sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            speed5 = 25;
            button1_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speed5 = 25;
            button1_Click(sender, e);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Random rastgele_sayi = new Random();

            int rastgelesayi1 = rastgele_sayi.Next(5, speed1);
            int rastgelesayi2 = rastgele_sayi.Next(5, speed2);
            int rastgelesayi3 = rastgele_sayi.Next(5, speed3);
            int rastgelesayi4 = rastgele_sayi.Next(5, speed4);
            int rastgelesayi5 = rastgele_sayi.Next(5, speed5);



            pictureBox1.Location = new Point(rastgelesayi1 + pictureBox1.Location.X, 28);
            pictureBox2.Location = new Point(rastgelesayi2 + pictureBox2.Location.X, 128);
            pictureBox3.Location = new Point(rastgelesayi3 + pictureBox3.Location.X, 228);
            pictureBox4.Location = new Point(rastgelesayi4 + pictureBox4.Location.X, 328);
            pictureBox5.Location = new Point(rastgelesayi5 + pictureBox5.Location.X, 428);


            if (pictureBox1.Location.X >= finish_line)
            {
                timer1.Enabled = false;
                MessageBox.Show("1st horse won the race..!");
                Controls.Clear(); 
                speed1 = 15;
                speed2 = 15;
                speed3 = 15;
                speed4 = 15;
                speed5 = 15;
                InitializeComponent();

            }

            else if (pictureBox2.Location.X >= finish_line)
            {
                timer1.Enabled = false;
                MessageBox.Show("2nd horse won the race..!");
                Controls.Clear();
                speed1 = 15;
                speed2 = 15;
                speed3 = 15;
                speed4 = 15;
                speed5 = 15;
                InitializeComponent();
            }

            else if (pictureBox3.Location.X >= finish_line)
            {
                timer1.Enabled = false;
                MessageBox.Show("3rd horse won the race..!");
                Controls.Clear();
                speed1 = 15;
                speed2 = 15;
                speed3 = 15;
                speed4 = 15;
                speed5 = 15;
                InitializeComponent();
            }

            else if (pictureBox4.Location.X >= finish_line)
            {
                timer1.Enabled = false;
                MessageBox.Show("4th horse won the race..!");
                Controls.Clear();
                speed1 = 15;
                speed2 = 15;
                speed3 = 15;
                speed4 = 15;
                speed5 = 15;
                InitializeComponent();
            }

            else if (pictureBox5.Location.X >= finish_line)
            {
                timer1.Enabled = false;
                MessageBox.Show("5th horse won the race..!");
                Controls.Clear();
                speed1 = 15;
                speed2 = 15;
                speed3 = 15;
                speed4 = 15;
                speed5 = 15;
                InitializeComponent();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}