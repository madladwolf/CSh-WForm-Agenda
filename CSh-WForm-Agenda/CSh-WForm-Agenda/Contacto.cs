namespace CSh_WForm_Agenda
{
    public class Contacto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public Contacto() { }
        public Contacto(string n, string e, int t)
        {
            Nome = n; Email = e; Telefone = t;
        }
        public Contacto(Contacto c)
        {
            Nome = c.Nome; Email = c.Email; Telefone = c.Telefone;
        }

        public override string ToString()
        {
            return Nome + " " + Email + " " + Telefone;
        }
        public string toStringToFich()
        {
            return Nome + " | " + Email + " | " + Telefone;
        }
    }
}
