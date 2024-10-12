using System.Drawing.Imaging;

namespace SimplePaint
{
    public partial class FormPrincipal : Form
    {
        private bool flagPintar = false;
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagBorracha = false;
        private Image imagemSalvar;
        private Graphics graphicsImagemSalvar;
        public FormPrincipal()
        {
            InitializeComponent();

            var overColor = Color.DarkSlateGray;
            buttonBorracha.FlatAppearance.MouseOverBackColor = overColor;
            buttonLimpar.FlatAppearance.MouseOverBackColor = overColor;
            buttonSalvar.FlatAppearance.MouseOverBackColor = overColor;

            for (int i = 2; i <= 100; i += 2)
            {
                comboBoxEspessuraCaneta.Items.Add(i);
            }
            comboBoxEspessuraCaneta.Text = "10";
            comboBoxEspessuraCaneta.IntegralHeight = false;
            comboBoxEspessuraCaneta.MaxDropDownItems = 5;

            graphicsPainelPintura = painelPintura.CreateGraphics();
            espessuraCaneta = float.Parse(comboBoxEspessuraCaneta.Text);

            corBorracha = painelPintura.BackColor;

            imagemSalvar = new Bitmap(painelPintura.Width, painelPintura.Height);
            graphicsImagemSalvar = Graphics.FromImage(imagemSalvar);
            graphicsImagemSalvar.Clear(painelPintura.BackColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            var corEscolhida = colorDialog.ShowDialog();
            if (corEscolhida == DialogResult.OK)
            {
                buttonCorCaneta.BackColor = colorDialog.Color;
            }
        }

        private void painelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void painelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void painelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar)
            {
                if (!flagBorracha)
                {
                    graphicsPainelPintura.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta),
                    new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                    graphicsImagemSalvar.DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta),
                    new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura.DrawRectangle(new Pen(corBorracha, espessuraCaneta),
                    new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));

                    graphicsImagemSalvar.DrawRectangle(new Pen(corBorracha, espessuraCaneta),
                    new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }

            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza? Todo o desenho será apagado.", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                graphicsPainelPintura.Clear(Color.White);
                imagemSalvar = new Bitmap(painelPintura.Width, painelPintura.Height);
                graphicsImagemSalvar = Graphics.FromImage(imagemSalvar);
                graphicsImagemSalvar.Clear(painelPintura.BackColor);
            }
        }

        private void comboBoxEspessuraCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color;
                }
            }
            else
            {
                if (!flagBorracha)
                {
                    flagBorracha = true;
                    buttonBorracha.BackColor = corBorracha;
                }
                else
                {
                    flagBorracha = false;
                    buttonBorracha.BackColor = Color.Black;
                }

            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Portable Network Graphics|.png|Arquivo JPEG|.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemSalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        private void painelPintura_Resize(object sender, EventArgs e)
        {
            graphicsPainelPintura = painelPintura.CreateGraphics();
            var imagemTemporaria = new Bitmap(painelPintura.Width, painelPintura.Height);
            var graphcsImgTemp = Graphics.FromImage(imagemTemporaria);
            graphcsImgTemp.DrawImage(imagemSalvar, 0, 0);
            imagemSalvar = imagemTemporaria;
            graphicsImagemSalvar = graphcsImgTemp;
        }
    }
}
