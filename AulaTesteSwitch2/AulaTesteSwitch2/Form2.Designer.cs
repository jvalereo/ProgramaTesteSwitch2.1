namespace AulaTesteSwitch2
{
    partial class Form2
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.CboVeiculos = new System.Windows.Forms.ComboBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(47, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Rodizio de Veículos ";
            // 
            // CboVeiculos
            // 
            this.CboVeiculos.FormattingEnabled = true;
            this.CboVeiculos.Items.AddRange(new object[] {
            "1 ou 2",
            "3 ou 4",
            "5 ou 6",
            "7 ou 8",
            "9 ou 0"});
            this.CboVeiculos.Location = new System.Drawing.Point(71, 120);
            this.CboVeiculos.Name = "CboVeiculos";
            this.CboVeiculos.Size = new System.Drawing.Size(130, 21);
            this.CboVeiculos.TabIndex = 1;
            this.CboVeiculos.SelectedIndexChanged += new System.EventHandler(this.CboVeiculos_SelectedIndexChanged);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(17, 66);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(255, 18);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "Selecione o Número Final da Placa";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 164);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 3;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(6, 203);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(88, 31);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(188, 203);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(88, 31);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(100, 203);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(82, 31);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpa";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.CboVeiculos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula Teste Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox CboVeiculos;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnLimpar;
    }
}