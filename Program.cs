using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "40028922", modelo: "Modelo 1", imei: "222222", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "40028923", modelo: "Modelo 2", imei: "333333", memoria: 1);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");