using ProblemPlecakowy;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            int n_int = 0;

            if (!int.TryParse(n, out n_int) || int.Parse(n) < 0) textBox1.BackColor = Color.Red;
            else textBox1.BackColor = Color.Green;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string seed = textBox2.Text;
            int seed_int = 0;
            if (!int.TryParse(seed, out seed_int) || int.Parse(seed) < 0) textBox2.BackColor = Color.Red;
            else textBox2.BackColor = Color.Green;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string capacity = textBox3.Text;
            int capacity_int = 0;


            if (!int.TryParse(capacity, out capacity_int) || int.Parse(capacity) < 0) textBox3.BackColor = Color.Red;
            else textBox3.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            string seed = textBox2.Text;
            string capacity = textBox3.Text;

           
            
            int n_int, seed_int, capacity_int = 0;

            if (!int.TryParse(n, out n_int)
                || !int.TryParse(seed, out seed_int) 
                || !int.TryParse(capacity, out capacity_int)
                || int.Parse(n) < 0
                || int.Parse(seed) < 0
                || int.Parse(capacity) < 0) return;



            Problem problem = new Problem(n_int, seed_int);
            Result result = problem.Solve(capacity_int);

            richTextBox1.Text = result.ToString();
            richTextBox2.Text = problem.ToString();


        }

        

        
    }
}
