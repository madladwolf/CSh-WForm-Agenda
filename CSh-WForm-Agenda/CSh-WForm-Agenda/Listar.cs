using System;
using System.Windows.Forms;

namespace CSh_WForm_Agenda
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
            preencheLb();
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btb_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        //Preenche a listBox
        private void preencheLb()
        {
            foreach(Contacto c in Inserir.agenda)
            {
                lst_agenda.Items.Add(c.ToString());
            }
            if(Inserir.agenda.Count == 0) lst_agenda.Items.Add("Sem contactos");
        }
    }
}
