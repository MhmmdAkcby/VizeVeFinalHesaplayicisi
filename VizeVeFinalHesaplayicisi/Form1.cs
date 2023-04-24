namespace VizeVeFinalHesaplayicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int vize, final;
        double ort;
        private void button1_Click(object sender, EventArgs e)
        {
            vize = Convert.ToInt32(MskVize.Text);
            final = Convert.ToInt32(MskFinal.Text);
            ort = (vize * 0.4) + (final * 0.6);
            label4.Text = ort.ToString();

            if (vize > 100)  
            {
                MessageBox.Show("Hatalý giriþ yapýldý");
                Application.Restart();
            }
            if (final > 100) 
            {
                MessageBox.Show("Hatalý Giriþ yapýldý");
                Application.Restart();
            }
             


            if (ort > 80)
            {
                label7.Text = "Ýyi";
            }
            else if (ort > 50)
            {
                label7.Text = "Orta";
            }
            else
            {
                label7.Text = "Kötü";
            }
            label4.Visible = true;
            label7.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MskVize.Text = "";
            MskFinal.Text = "";
        }
    }
}