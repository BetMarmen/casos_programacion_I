namespace pjPromedioNotas
{
    partial class FormPromedio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerN = new System.Windows.Forms.TextBox();
            this.txtSegundaN = new System.Windows.Forms.TextBox();
            this.txtTercerN = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promedio de Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segunda Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tercer Nota";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrimerN
            // 
            this.txtPrimerN.Location = new System.Drawing.Point(130, 77);
            this.txtPrimerN.Name = "txtPrimerN";
            this.txtPrimerN.Size = new System.Drawing.Size(100, 27);
            this.txtPrimerN.TabIndex = 4;
            this.txtPrimerN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSegundaN
            // 
            this.txtSegundaN.Location = new System.Drawing.Point(130, 121);
            this.txtSegundaN.Name = "txtSegundaN";
            this.txtSegundaN.Size = new System.Drawing.Size(100, 27);
            this.txtSegundaN.TabIndex = 5;
            // 
            // txtTercerN
            // 
            this.txtTercerN.Location = new System.Drawing.Point(130, 164);
            this.txtTercerN.Name = "txtTercerN";
            this.txtTercerN.Size = new System.Drawing.Size(100, 27);
            this.txtTercerN.TabIndex = 6;
            this.txtTercerN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(130, 252);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 31);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(222, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Promedio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(130, 209);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(100, 27);
            this.txtCalcular.TabIndex = 11;
            // 
            // FormPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 304);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTercerN);
            this.Controls.Add(this.txtSegundaN);
            this.Controls.Add(this.txtPrimerN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPromedio";
            this.Text = "FormPromedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrimerN;
        private TextBox txtSegundaN;
        private TextBox txtTercerN;
        private Button btnClear;
        private Button btnCalcular;
        private Button btnSalir;
        private Label label5;
        private TextBox txtCalcular;
    }
}