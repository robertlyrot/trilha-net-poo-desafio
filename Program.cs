using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smarthphone Nokia:");
Nokia nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone:");
Iphone iphone = new Iphone (numero: "654321", modelo: "Modelo 2", imei: "22222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");