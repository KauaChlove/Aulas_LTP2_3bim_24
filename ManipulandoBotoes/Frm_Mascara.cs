using System.ComponentModel;
using System.Globalization;
using System.Linq;
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

            Msk_TextBox.Leave += (s, ev) => // Adiciona um evento de valida��o diretamente no bot�o
            {
                DateTime result;
                if (!DateTime.TryParseExact(Msk_TextBox.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out result)) //analisa se a hora est� correta, de acordo com a formata��o da m�scara.
                {
                    MessageBox.Show("Por favor, insira uma hora v�lida no formato HH:MM.", "Hora Inv�lida",MessageBoxButtons.OK, MessageBoxIcon.Error); //Se o valor inserido n�o bater com a m�scara, aparecer� uma mensagem de erro.
                }
                else
                { 
                    int hours = int.Parse(Msk_TextBox.Text.Substring(0, 2));
                    int minutes = int.Parse(Msk_TextBox.Text.Substring(3, 2)); // Verifica se as horas est�o no intervalo de 00 a 23 e os minutos no intervalo de 00 a 59.

                    if (hours > 23 || minutes > 59)
                    {
                        MessageBox.Show("Por favor, insira uma hora v�lida.", "Hora Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error); //caso n�o estejam nesse intervalo, dar� erro.
                    }
                }
            };
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

            Msk_TextBox.Leave += (s, ev) => 
            {
                DateTime result;
                if (!DateTime.TryParseExact(Msk_TextBox.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                {
                    MessageBox.Show("Por favor, insira uma data v�lida.", "Data Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
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

            Msk_TextBox.Leave += (s, ev) =>
            {
                bool temMaiuscula = false;
                bool temMinuscula = false;
                bool temEspecial = false;
                bool temNumero = false;
                string senha = Msk_TextBox.Text;

                foreach (char a in senha)
                {
                    if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(a)) temMaiuscula = true;
                    if ("abcdefghijklmnopqrstuvwxyz".Contains(a)) temMinuscula = true;
                    if ("!@#$%^&*()_+=-`~[]{}|\\;:'\",.<>?/".Contains(a)) temEspecial = true;
                    if ("0123456789".Contains(a)) temNumero = true;

                    if (temMaiuscula && temMinuscula && temEspecial && temNumero) break;
                }

                if (temMaiuscula && temMinuscula && temEspecial && temNumero && senha.Length >= 8)
                {
                    Lbl_Conteudo.Text = "Senha V�lida";
                }
                else
                {
                    Lbl_Conteudo.Text = "Senha Inv�lida";
                    MessageBox.Show("A senha deve ter pelo menos 8 caracteres, incluindo uma letra mai�scula, uma letra min�scula, um n�mero e um caractere especial.", "Senha Inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }
    }
}
