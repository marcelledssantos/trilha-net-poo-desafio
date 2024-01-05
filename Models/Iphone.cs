namespace DesafioPOO.Models
{
 public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria) : base(numero, modelo, memoria)
        {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Seu Iphone esta instalando {nomeApp}...");
        }
    }
}