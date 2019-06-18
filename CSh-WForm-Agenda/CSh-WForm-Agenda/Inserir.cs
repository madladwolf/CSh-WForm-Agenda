using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSh_WForm_Agenda
{
    public partial class Inserir : Form
    {
        public static List<Contacto> agenda = new List<Contacto>();
        public Inserir()
        {
            InitializeComponent();
            txt_nome.Select();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_nome.Text = "";
            txt_telefone.Text = "";
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string email = txt_email.Text;
            int telef;
            try { telef = int.Parse(txt_telefone.Text); }
            catch { telef = 0; }
            Contacto c = new Contacto(nome, email, telef);
            agenda.Add(c);
            MessageBox.Show(c.ToString());
            btn_limpar_Click(sender, e);

            /*
             * agenda.Add(new Contacto(nome,email,telef));
             * MessageBox.Show(agenda[agenda.Count-1].toString());
        
            */

        }
    }
}
