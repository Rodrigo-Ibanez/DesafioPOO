using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Nokia N = new Nokia(numero: "12378258", modelo: "nokia1", imei: "1111",memoria: 64);

N.Ligar();
N.InstalarAplicativo("facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone I = new Iphone(numero: "98745632", modelo: "iphone1", imei: "2222",memoria: 254);

I.ReceberLigacao();
I.InstalarAplicativo("whatsapp");

