using System;
using System.Windows.Forms;
using System.IO;

namespace CSh_WForm_Agenda
{
    public partial class Menu : Form
    {
        private static bool flag = false;
        public Menu()
        {
            InitializeComponent();
            if (!flag)
            {
                lerFich();
                flag = true;
            } 
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            escreveFich();
            Application.Exit();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inserir ins = new Inserir();
            ins.Show();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar lis = new Listar();
            lis.Show();
        }

        //Fechar app sempre que o X for premido
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        //Escrever contactos no ficheiro
        public static void escreveFich()
        {
            StreamWriter wr = new StreamWriter(@"agenda.txt", true);
            foreach(Contacto c in Inserir.agenda)
            {
                wr.WriteLine(c.toStringToFich());
            }
            wr.Close();
        }
       
        //Ler contactos do ficheiro
        public static void lerFich()
        {
            if (File.Exists(@"agenda.txt"))
            {
                StreamReader sr = new StreamReader(@"agenda.txt");
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();
                    string[] divisao = linha.Split('|');
                    Contacto c = new Contacto(divisao[0], divisao[1], int.Parse(divisao[2]));
                    Inserir.agenda.Add(c);
                }
                sr.Close();
            }
        }

    }
}
