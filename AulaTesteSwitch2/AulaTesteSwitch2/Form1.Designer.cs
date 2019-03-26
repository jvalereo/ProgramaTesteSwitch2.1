namespace AulaTesteSwitch2
{
    partial class Form1
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
            this.CboSemanas = new System.Windows.Forms.ComboBox();
            this.BtnAvanca = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dias da Semanas";
            // 
            // CboSemanas
            // 
            this.CboSemanas.FormattingEnabled = true;
            this.CboSemanas.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.CboSemanas.Location = new System.Drawing.Point(49, 96);
            this.CboSemanas.Name = "CboSemanas";
            this.CboSemanas.Size = new System.Drawing.Size(162, 21);
            this.CboSemanas.TabIndex = 1;
            this.CboSemanas.SelectedIndexChanged += new System.EventHandler(this.CboSemanas_SelectedIndexChanged);
            // 
            // BtnAvanca
            // 
            this.BtnAvanca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvanca.Location = new System.Drawing.Point(59, 154);
            this.BtnAvanca.Name = "BtnAvanca";
            this.BtnAvanca.Size = new System.Drawing.Size(141, 35);
            this.BtnAvanca.TabIndex = 2;
            this.BtnAvanca.Text = "Proxímo Exemplo";
            this.BtnAvanca.UseVisualStyleBackColor = true;
            this.BtnAvanca.Click += new System.EventHandler(this.BtnAvanca_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(194, 216);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(78, 33);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnAvanca);
            this.Controls.Add(this.CboSemanas);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula Teste Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox CboSemanas;
        private System.Windows.Forms.Button BtnAvanca;
        private System.Windows.Forms.Button BtnSair;
    }
}

