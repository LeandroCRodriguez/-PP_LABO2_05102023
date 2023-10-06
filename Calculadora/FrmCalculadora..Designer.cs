namespace Calculadora
{
    partial class FrmCalculadora
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnOperar = new Button();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            txtSegundoOperador = new TextBox();
            txtPrimerOperador = new TextBox();
            cmbOperacion = new ComboBox();
            lblResultado = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 51);
            label1.Name = "label1";
            label1.Size = new Size(192, 47);
            label1.TabIndex = 0;
            label1.Text = "Resultado:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbBinario);
            groupBox1.Controls.Add(rdbDecimal);
            groupBox1.Location = new Point(222, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Representar el resultado en";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(119, 56);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_checkedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(17, 56);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_checkedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 261);
            label2.Name = "label2";
            label2.Size = new Size(204, 32);
            label2.TabIndex = 2;
            label2.Text = "Primer operador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(421, 261);
            label3.Name = "label3";
            label3.Size = new Size(228, 32);
            label3.TabIndex = 3;
            label3.Text = "Segundo operador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(261, 261);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 4;
            label4.Text = "Operacion";
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.ButtonHighlight;
            btnOperar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(12, 382);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(204, 42);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += BtnOperar;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonHighlight;
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(431, 382);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(204, 42);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonHighlight;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(222, 382);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 42);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(431, 321);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(204, 23);
            txtSegundoOperador.TabIndex = 3;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(12, 321);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(204, 23);
            txtPrimerOperador.TabIndex = 1;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(261, 321);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(276, 63);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 40);
            lblResultado.TabIndex = 15;
            lblResultado.Click += lblResultado_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(lblResultado);
            Controls.Add(cmbOperacion);
            Controls.Add(txtPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno Leandro Rodríguez";
            FormClosing += FrmCalculadora_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button s;
        private Button btnOperar;
        private Button button4;
        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
        private ComboBox cmbOperacion;
        private Label lblResultado;
    }
}