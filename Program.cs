using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// So copiar do video agora lUIZ PARA SABER SE ESTA FUNCINANDO.

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", models: "modelo1", imei: "1111111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Whatapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "123456", models: "modelo2", imei: "1111111111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo(nomeApp: "Telegram");


