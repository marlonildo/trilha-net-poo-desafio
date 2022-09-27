using DesafioPOO.Models;

Console.WriteLine("Nokia tijolo");
Smartphone nokia = new Nokia("999888777", "Nokia tijolin modelo 1 azul", "abcd1234", 10);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("0110010101", "Iphone sem fone e sem carregador", "XYZYXYZX", 30);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("I-apps");