using trabajoMayo.Figuras;

namespace trabajoMayo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            label4.Text = "";
            label5.Text = "";
            label8.Text = "";
            label9.Text = "";
            label12.Text = "";
            label14.Text = "";
            label18.Text = "";
            label19.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Aun no ingresa la medida del lado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Triangulo triangulos = new Triangulo();
                    triangulos.DibujarPoligono(pictureBox1, (int)numericUpDown1.Value, 0, 0);
                }
            }
            if (radioButton2.Checked == true)
            {
                if (numericUpDown2.Value == 0 || numericUpDown3.Value == 0)
                {
                    MessageBox.Show("Aun no ingresa la medida de las diagonales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Rombo rombos = new Rombo();
                    rombos.DibujarPoligono(pictureBox1, 0, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
                }
            }
            if (radioButton3.Checked == true)
            {

            }
            if (radioButton4.Checked == true)
            {

            }
        }
    }
}