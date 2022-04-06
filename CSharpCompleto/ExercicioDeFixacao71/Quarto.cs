namespace Section0671_Vetores
{
    public class Quarto
    {
        public int? Codigo { get; set; }
        public string Reservista { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "\r\n" + Codigo + ": " + Reservista + ", " + Email + ".";
        }
    }
}
