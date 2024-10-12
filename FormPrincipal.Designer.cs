namespace SimplePaint
{
    partial class FormPrincipal
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
            Personalizar = new GroupBox();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            buttonBorracha = new Button();
            label2 = new Label();
            comboBoxEspessuraCaneta = new ComboBox();
            buttonCorCaneta = new Button();
            label1 = new Label();
            painelPintura = new Panel();
            Personalizar.SuspendLayout();
            SuspendLayout();
            // 
            // Personalizar
            // 
            Personalizar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Personalizar.Controls.Add(buttonSalvar);
            Personalizar.Controls.Add(buttonLimpar);
            Personalizar.Controls.Add(buttonBorracha);
            Personalizar.Controls.Add(label2);
            Personalizar.Controls.Add(comboBoxEspessuraCaneta);
            Personalizar.Controls.Add(buttonCorCaneta);
            Personalizar.Controls.Add(label1);
            Personalizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Personalizar.ForeColor = Color.White;
            Personalizar.Location = new Point(8, 12);
            Personalizar.Name = "Personalizar";
            Personalizar.Size = new Size(935, 80);
            Personalizar.TabIndex = 0;
            Personalizar.TabStop = false;
            Personalizar.Text = "Personalizar";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = Color.Black;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(673, 31);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(86, 26);
            buttonSalvar.TabIndex = 6;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Black;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(581, 31);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(86, 26);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonBorracha
            // 
            buttonBorracha.BackColor = Color.Black;
            buttonBorracha.FlatStyle = FlatStyle.Flat;
            buttonBorracha.Location = new Point(489, 31);
            buttonBorracha.Name = "buttonBorracha";
            buttonBorracha.Size = new Size(86, 26);
            buttonBorracha.TabIndex = 4;
            buttonBorracha.Text = "Borracha";
            buttonBorracha.UseVisualStyleBackColor = false;
            buttonBorracha.MouseDown += buttonBorracha_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 36);
            label2.Name = "label2";
            label2.Size = new Size(156, 18);
            label2.TabIndex = 3;
            label2.Text = "Espessura da caneta";
            // 
            // comboBoxEspessuraCaneta
            // 
            comboBoxEspessuraCaneta.FormattingEnabled = true;
            comboBoxEspessuraCaneta.Location = new Point(399, 31);
            comboBoxEspessuraCaneta.Name = "comboBoxEspessuraCaneta";
            comboBoxEspessuraCaneta.Size = new Size(65, 26);
            comboBoxEspessuraCaneta.TabIndex = 2;
            comboBoxEspessuraCaneta.SelectedIndexChanged += comboBoxEspessuraCaneta_SelectedIndexChanged;
            // 
            // buttonCorCaneta
            // 
            buttonCorCaneta.BackColor = Color.Blue;
            buttonCorCaneta.FlatStyle = FlatStyle.Flat;
            buttonCorCaneta.Location = new Point(135, 34);
            buttonCorCaneta.Name = "buttonCorCaneta";
            buttonCorCaneta.Size = new Size(75, 23);
            buttonCorCaneta.TabIndex = 1;
            buttonCorCaneta.UseVisualStyleBackColor = false;
            buttonCorCaneta.Click += buttonCorCaneta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 0;
            label1.Text = "Cor da caneta";
            // 
            // painelPintura
            // 
            painelPintura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            painelPintura.BackColor = Color.White;
            painelPintura.Location = new Point(8, 104);
            painelPintura.Name = "painelPintura";
            painelPintura.Size = new Size(935, 334);
            painelPintura.TabIndex = 1;
            painelPintura.MouseDown += painelPintura_MouseDown;
            painelPintura.MouseMove += painelPintura_MouseMove;
            painelPintura.MouseUp += painelPintura_MouseUp;
            painelPintura.Resize += painelPintura_Resize;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(955, 450);
            Controls.Add(painelPintura);
            Controls.Add(Personalizar);
            Name = "FormPrincipal";
            ShowIcon = false;
            Text = "Simple Paint";
            Load += Form1_Load;
            Personalizar.ResumeLayout(false);
            Personalizar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Personalizar;
        private ComboBox comboBoxEspessuraCaneta;
        private Button buttonCorCaneta;
        private Label label1;
        private Label label2;
        private Button buttonBorracha;
        private Button buttonSalvar;
        private Button buttonLimpar;
        private Panel painelPintura;
    }
}
