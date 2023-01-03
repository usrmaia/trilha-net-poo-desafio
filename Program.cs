using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("5588981402020", "C20", "asd123", 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("5588958694758", "13 pro", "qwe456", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");