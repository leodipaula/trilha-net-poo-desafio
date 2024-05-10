using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nSmartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: "32");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "789456123", modelo: "Modelo 15", imei: "222222222", memoria: "16");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");