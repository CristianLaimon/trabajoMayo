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
            labelTrapecioArea.Text = "";
            labelTrapecioPerimetro.Text = "";
            label18.Text = "";
            label19.Text = "";
        }

        private void MostrarPanel(int groupBoxElegido)
        {
            groupBox2.Visible = groupBoxElegido == 2;
            groupBox3.Visible = groupBoxElegido == 3;
            groupBox4.Visible = groupBoxElegido == 4;
            groupBox5.Visible = groupBoxElegido == 5;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeterminarFigura();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                DeterminarFigura();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Triangulo triangulo = new Triangulo();
                triangulo.MoverArriba(pictureBox1, (int)numericUpDown1.Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Triangulo triangulo = new Triangulo();
                triangulo.MoverAbajo(pictureBox1, (int)numericUpDown1.Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Triangulo triangulo = new Triangulo();
                triangulo.MoverIzquierda(pictureBox1, (int)numericUpDown1.Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Triangulo triangulo = new Triangulo();
                triangulo.MoverDerecha(pictureBox1, (int)numericUpDown1.Value);
            }
        }

        #region EventosRadioButtons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPanel(2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPanel(3);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPanel(4);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPanel(5);
        }
        #endregion

        #region DeterminarFigura
        private void DeterminarFigura()
        {

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Aun no selecciona una figura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (radioButton1.Checked == true)
            {
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Aun no ingresa la medida del lado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Triangulo triangulo = new Triangulo();
                    triangulo.Lado = (int)numericUpDown1.Value;
                    triangulo.DibujarPoligono(pictureBox1);
                    triangulo.CalcularArea();
                    triangulo.CalcularPerimetro();
                    label5.Text = triangulo.Perimetro.ToString("0. ##");
                    label4.Text = triangulo.Area.ToString(("0. ##"));
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
                    if (numericUpDown3.Value > numericUpDown2.Value)
                    {
                        MessageBox.Show("La diagonal menor, no puede valer mas que la mayor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Rombo rombo = new Rombo();
                        rombo.DiagonalMayor = (int)numericUpDown2.Value;
                        rombo.DiagonalMenor = (int)numericUpDown3.Value;
                        rombo.DibujarPoligono(pictureBox1);
                        rombo.CalcularArea();
                        label8.Text = rombo.Area.ToString("0. ##");
                        rombo.CalcularPerimetro();
                        label9.Text = rombo.Perimetro.ToString("0. ##");
                    }
                }
            }


            if (radioButton3.Checked == true)
            {
                if (numericUpDown4.Value == 0 || numericUpDown5.Value == 0)
                {
                    MessageBox.Show("Aun no ingresa la medida de las bases", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Trapecio trapecio = new Trapecio();
                    trapecio.BaseMayor = (int)numericUpDown4.Value;
                    trapecio.BaseMenor = (int)numericUpDown5.Value;
                    trapecio.Altura = (int)numericUpDownTrapecioAltura.Value;

                    if ((int)numericUpDown4.Value >= (int)numericUpDown5.Value)
                    {
                        trapecio.DibujarPoligono(pictureBox1);
                        trapecio.CalcularPerimetro();
                        trapecio.CalcularArea();
                        labelTrapecioArea.Text = trapecio.Area.ToString();
                        labelTrapecioPerimetro.Text = trapecio.Perimetro.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, la base menor es más grande que la mayor, intenta con una medida más pequeña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


            if (radioButton4.Checked == true)
            {
                if (numericUpDown6.Value == 0)
                {
                    MessageBox.Show("Aun no ingresa la medida del lado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Hexagono hexagono = new Hexagono();
                    hexagono.Lado = (int)numericUpDown6.Value;
                    hexagono.DibujarPoligono(pictureBox1);
                    hexagono.CalcularPerimetro();
                    label19.Text = hexagono.Perimetro.ToString("0. ##");
                    hexagono.CalcularArea();
                    label18.Text = hexagono.Area.ToString("0. ##");
                }
            }

        
        }
#endregion

        #region EnterFocusNumericUpDownEvents
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }

        private void numericUpDownTrapecioAltura_ValueChanged(object sender, EventArgs e)
        {
            button1.Focus();

        }
        #endregion

        
    }
}