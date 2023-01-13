using DesafioPOO.Models;


Smartphone nokia = new Nokia("99 9 9999-9999", "Modelo 1", "1234567890", 128);
Smartphone iphone = new Iphone("99 9 8888-7777", "Modelo 2", "1234567890", 128);


Console.WriteLine("Teste Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Teste IPhone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");