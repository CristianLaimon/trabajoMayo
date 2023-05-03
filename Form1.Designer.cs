namespace trabajoMayo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCrearTrapecio = new System.Windows.Forms.Button();
            this.buttonCrearTriangulo = new System.Windows.Forms.Button();
            this.buttonCrearRombo = new System.Windows.Forms.Button();
            this.buttonCrearHexagono = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonMoverArriba = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(144, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 363);
            this.panel2.TabIndex = 1;
            // 
            // buttonCrearTrapecio
            // 
            this.buttonCrearTrapecio.Location = new System.Drawing.Point(180, 28);
            this.buttonCrearTrapecio.Name = "buttonCrearTrapecio";
            this.buttonCrearTrapecio.Size = new System.Drawing.Size(116, 48);
            this.buttonCrearTrapecio.TabIndex = 2;
            this.buttonCrearTrapecio.Text = "Trapecio";
            this.buttonCrearTrapecio.UseVisualStyleBackColor = true;
            // 
            // buttonCrearTriangulo
            // 
            this.buttonCrearTriangulo.Location = new System.Drawing.Point(320, 28);
            this.buttonCrearTriangulo.Name = "buttonCrearTriangulo";
            this.buttonCrearTriangulo.Size = new System.Drawing.Size(116, 48);
            this.buttonCrearTriangulo.TabIndex = 3;
            this.buttonCrearTriangulo.Text = "Triángulo";
            this.buttonCrearTriangulo.UseVisualStyleBackColor = true;
            // 
            // buttonCrearRombo
            // 
            this.buttonCrearRombo.Location = new System.Drawing.Point(458, 28);
            this.buttonCrearRombo.Name = "buttonCrearRombo";
            this.buttonCrearRombo.Size = new System.Drawing.Size(116, 48);
            this.buttonCrearRombo.TabIndex = 4;
            this.buttonCrearRombo.Text = "Rombo";
            this.buttonCrearRombo.UseVisualStyleBackColor = true;
            // 
            // buttonCrearHexagono
            // 
            this.buttonCrearHexagono.Location = new System.Drawing.Point(604, 28);
            this.buttonCrearHexagono.Name = "buttonCrearHexagono";
            this.buttonCrearHexagono.Size = new System.Drawing.Size(116, 48);
            this.buttonCrearHexagono.TabIndex = 5;
            this.buttonCrearHexagono.Text = "Hexágono";
            this.buttonCrearHexagono.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCrearRombo);
            this.panel3.Controls.Add(this.buttonCrearHexagono);
            this.panel3.Controls.Add(this.buttonCrearTrapecio);
            this.panel3.Controls.Add(this.buttonCrearTriangulo);
            this.panel3.Location = new System.Drawing.Point(0, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 105);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Crear Figura:";
            // 
            // button5
            // 
            this.button5.Image = global::trabajoMayo.Properties.Resources.arrow1;
            this.button5.Location = new System.Drawing.Point(362, 669);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 52);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = global::trabajoMayo.Properties.Resources.right_arrow1;
            this.button6.Location = new System.Drawing.Point(496, 669);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 52);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonMoverArriba
            // 
            this.buttonMoverArriba.Image = global::trabajoMayo.Properties.Resources.up_arrow1;
            this.buttonMoverArriba.Location = new System.Drawing.Point(432, 613);
            this.buttonMoverArriba.Name = "buttonMoverArriba";
            this.buttonMoverArriba.Size = new System.Drawing.Size(58, 52);
            this.buttonMoverArriba.TabIndex = 10;
            this.buttonMoverArriba.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = global::trabajoMayo.Properties.Resources.down_arrow1;
            this.button8.Location = new System.Drawing.Point(432, 722);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 52);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Movimiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 795);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonMoverArriba);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonCrearTrapecio;
        private Button buttonCrearTriangulo;
        private Button buttonCrearRombo;
        private Button buttonCrearHexagono;
        private Panel panel3;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button buttonMoverArriba;
        private Button button8;
        private Label label2;
    }
}