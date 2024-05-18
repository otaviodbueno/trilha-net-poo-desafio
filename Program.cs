using DesafioPOO.Models;

// Realiza os testes com as classes Nokia e Iphone

Nokia n = new Nokia("12312", "Nokia 3", "333", 32);
Iphone p = new Iphone("93882", "Iphone 15", "111", 512);

Console.WriteLine("Apresentação do Nokia!");
n.ApresentaCelular();
Console.WriteLine("\n");
Console.WriteLine("Apresentação do iPhone!");
p.ApresentaCelular();
Console.WriteLine("\n");
n.Ligar();
p.Ligar();
Console.WriteLine("\n");
n.ReceberLigacao();
p.ReceberLigacao();


