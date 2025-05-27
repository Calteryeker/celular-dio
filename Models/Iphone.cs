namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string model, int memoria) : base(numero, imei, model, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} em seu Iphone ...");

            Thread.Sleep(3000);

            Console.WriteLine($"{nomeApp} foi instalado com sucesso!");
        }
    }
}