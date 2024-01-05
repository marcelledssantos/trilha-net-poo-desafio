namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string numero { get; set; }
        private string modelo;
        private int memoria;

        public Smartphone(string numero, string modelo, int memoria)
        {
            numero = numero;
            modelo = modelo;
            memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}