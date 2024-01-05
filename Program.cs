using DesafioPOO.Models;

Console.WriteLine("Testes Iphone:");
Smartphone iphone = new Iphone("XXXXXXXXXXX", "Model 14", 128);
iphone.Ligar();
iphone.InstalarAplicativo(".NET");

Console.WriteLine("Testes Nokia:");
Smartphone nokia = new Nokia("XXXXXXXXXXX", "Nokia Cobrinha", 64);
nokia.Ligar();
nokia.InstalarAplicativo("DioPro");