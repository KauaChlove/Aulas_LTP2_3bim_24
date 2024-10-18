using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace ManipulandoBotoes
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }   

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;

        }

        private void Msk_TextBox_Validating(object sender, CancelEventArgs e) {
            if (Msk_TextBox.Mask == "00/00/0000")
            {
                // Validação para data (dd/MM/yyyy)
                if (!DateTime.TryParseExact(Msk_TextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show("Data inválida. Insira uma data válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.Yes;

        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TextBox.Text;
        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            Lbl_Conteudo.Text = "";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            Msk_TextBox.RightToLeft = RightToLeft.No;
        }
    }
}
