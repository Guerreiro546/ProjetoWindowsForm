namespace ProjetoAula
{
    partial class FormIMC
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
            lbPeso = new Label();
            lbaltura = new Label();
            pbLabel = new PictureBox();
            btnIMC = new Button();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLabel).BeginInit();
            SuspendLayout();
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(12, 9);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 0;
            lbPeso.Text = "peso";
            // 
            // lbaltura
            // 
            lbaltura.AutoSize = true;
            lbaltura.Location = new Point(12, 37);
            lbaltura.Name = "lbaltura";
            lbaltura.Size = new Size(37, 15);
            lbaltura.TabIndex = 1;
            lbaltura.Text = "altura";
            // 
            // pbLabel
            // 
            pbLabel.Image = Properties.Resources.euro;
            pbLabel.InitialImage = Properties.Resources.euro;
            pbLabel.Location = new Point(237, 51);
            pbLabel.Name = "pbLabel";
            pbLabel.Size = new Size(321, 217);
            pbLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLabel.TabIndex = 2;
            pbLabel.TabStop = false;
            // 
            // btnIMC
            // 
            btnIMC.Location = new Point(90, 79);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(75, 23);
            btnIMC.TabIndex = 3;
            btnIMC.Text = "Gerar";
            btnIMC.UseVisualStyleBackColor = true;
            btnIMC.Click += btnIMC_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(65, 1);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Informe o seu peso";
            txtPeso.Size = new Size(114, 23);
            txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.Location = new Point(65, 37);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "informe sua altura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 5;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // FormIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 376);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(btnIMC);
            Controls.Add(pbLabel);
            Controls.Add(lbaltura);
            Controls.Add(lbPeso);
            Name = "FormIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)pbLabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeso;
        private Label lbaltura;
        private PictureBox pbLabel;
        private Button btnIMC;
        private TextBox txtPeso;
        private TextBox txtAltura;
    }
}
