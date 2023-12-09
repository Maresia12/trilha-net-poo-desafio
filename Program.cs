using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234546", modelo: "Modelo N1", imei: "111111", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("jogo da cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "456544444", modelo: "i20", imei:"2222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");