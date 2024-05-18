namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string Modelo;

        private string IMEI;

        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ApresentaCelular()
        {
            Console.WriteLine($"O aparelho é de número {Numero}, seu modelo é {Modelo} e possui uma memoria de {Memoria} GB");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}