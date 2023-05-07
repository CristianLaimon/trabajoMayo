using trabajoMayo.Figuras;

namespace trabajoMayo
{
    public partial class Form1 : Form
    {
        static Triangulo triangulo;
        static Rombo rombo;
        static Trapecio trapecio;
        static Hexagono hexagono;

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
            label13.Text = "";
            label18.Text = "";
            label19.Text = "";
            triangulo = new Triangulo();
            rombo = new Rombo();
            trapecio = new Trapecio();
            hexagono = new Hexagono();
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            MostrarPanel(2);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            MostrarPanel(3);
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            MostrarPanel(4);
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            MostrarPanel(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                triangulo.MoverArriba(pictureBox1);
            }
            if (radioButton2.Checked == true)
            {
                rombo.MoverArriba(pictureBox1);
            }
            if (radioButton3.Checked == true)
            {
                trapecio.MoverArriba(pictureBox1);
            }
            if (radioButton4.Checked == true)
            {
                hexagono.MoverArriba(pictureBox1);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                triangulo.MoverAbajo(pictureBox1);
            }
            if (radioButton2.Checked == true)
            {
                rombo.MoverAbajo(pictureBox1);
            }
            if (radioButton3.Checked == true)
            {
                trapecio.MoverAbajo(pictureBox1);
            }
            if (radioButton4.Checked == true)
            {
                hexagono.MoverAbajo(pictureBox1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                triangulo.MoverIzquierda(pictureBox1);
            }
            if (radioButton2.Checked == true)
            {
                rombo.MoverIzquierda(pictureBox1);
            }
            if (radioButton3.Checked == true)
            {
                trapecio.MoverIzquierda(pictureBox1);
            }
            if (radioButton4.Checked == true)
            {
                hexagono.MoverIzquierda(pictureBox1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                triangulo.MoverDerecha(pictureBox1);
            }
            if (radioButton2.Checked == true)
            {
                rombo.MoverDerecha(pictureBox1);
            }
            if (radioButton3.Checked == true)
            {
                trapecio.MoverDerecha(pictureBox1);
            }
            if (radioButton4.Checked == true)
            {
                hexagono.MoverDerecha(pictureBox1);
            }
        }

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
                    triangulo.Lado = (int)numericUpDown1.Value;
                    triangulo.DibujarPoligono(pictureBox1);
                    triangulo.CalcularArea();
                    triangulo.CalcularPerimetro();
                    label5.Text = triangulo.Perimetro.ToString("0. ##");
                    label4.Text = triangulo.Area.ToString(("0. ##"));
                    triangulo.Creado = true;
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
                        MessageBox.Show("La diagonal menor no puede valer mas que la mayor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        rombo.DiagonalMayor = (int)numericUpDown2.Value;
                        rombo.DiagonalMenor = (int)numericUpDown3.Value;
                        rombo.DibujarPoligono(pictureBox1);
                        rombo.CalcularArea();
                        label8.Text = rombo.Area.ToString("0. ##");
                        rombo.CalcularPerimetro();
                        label9.Text = rombo.Perimetro.ToString("0. ##");
                        rombo.Creado = true;
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
                    trapecio.BaseMayor = (int)numericUpDown4.Value;
                    trapecio.BaseMenor = (int)numericUpDown5.Value;
                    trapecio.Altura = (int)numericUpDownTrapecioAltura.Value;

                    if ((int)numericUpDown4.Value >= (int)numericUpDown5.Value)
                    {
                        trapecio.DibujarPoligono(pictureBox1);
                        trapecio.CalcularPerimetro();
                        trapecio.CalcularArea();
                        label12.Text = trapecio.Area.ToString("0. ##");
                        label13.Text = trapecio.Perimetro.ToString("0. ##");
                        trapecio.Creado = true;
                    }
                    else
                    {
                        MessageBox.Show("La base maenor no puede valer mas que la mayor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    hexagono.Lado = (int)numericUpDown6.Value;
                    hexagono.DibujarPoligono(pictureBox1);
                    hexagono.CalcularPerimetro();
                    hexagono.CalcularArea();
                    label19.Text = hexagono.Perimetro.ToString("0. ##");
                    label18.Text = hexagono.Area.ToString("0. ##");
                    hexagono.Creado = true;
                }
            }
        }
        #endregion

        private void MostrarPanel(int groupBoxElegido)
        {
            groupBox2.Visible = groupBoxElegido == 2;
            groupBox3.Visible = groupBoxElegido == 3;
            groupBox4.Visible = groupBoxElegido == 4;
            groupBox5.Visible = groupBoxElegido == 5;
        }

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    if (radioButton1.Checked == true)
                    {
                        triangulo.MoverArriba(pictureBox1);
                    }
                    if (radioButton2.Checked == true)
                    {
                        rombo.MoverArriba(pictureBox1);
                    }
                    if (radioButton3.Checked == true)
                    {
                        trapecio.MoverArriba(pictureBox1);
                    }
                    if (radioButton4.Checked == true)
                    {
                        hexagono.MoverArriba(pictureBox1);
                    }
                    break;
                case Keys.Down:
                    if (radioButton1.Checked == true)
                    {
                        triangulo.MoverAbajo(pictureBox1);
                    }
                    if (radioButton2.Checked == true)
                    {
                        rombo.MoverAbajo(pictureBox1);
                    }
                    if (radioButton3.Checked == true)
                    {
                        trapecio.MoverAbajo(pictureBox1);
                    }
                    if (radioButton4.Checked == true)
                    {
                        hexagono.MoverAbajo(pictureBox1);
                    }
                    break;
                case Keys.Left:
                    if (radioButton1.Checked == true)
                    {
                        triangulo.MoverIzquierda(pictureBox1);
                    }
                    if (radioButton2.Checked == true)
                    {
                        rombo.MoverIzquierda(pictureBox1);
                    }
                    if (radioButton3.Checked == true)
                    {
                        trapecio.MoverIzquierda(pictureBox1);
                    }
                    if (radioButton4.Checked == true)
                    {
                        hexagono.MoverIzquierda(pictureBox1);
                    }
                    break;
                case Keys.Right:
                    if (radioButton1.Checked == true)
                    {
                        triangulo.MoverDerecha(pictureBox1);
                    }
                    if (radioButton2.Checked == true)
                    {
                        rombo.MoverDerecha(pictureBox1);
                    }
                    if (radioButton3.Checked == true)
                    {
                        trapecio.MoverDerecha(pictureBox1);
                    }
                    if (radioButton4.Checked == true)
                    {
                        hexagono.MoverDerecha(pictureBox1);
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}