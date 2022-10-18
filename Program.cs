using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i1 = new Iphone(numero: "213", modelo: "IPHONE XS", imei: "ANC123", memoria: 64);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Nokia n1 = new Nokia(numero: "213", modelo: "NOKIA XS", imei: "ANC123", memoria: 64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");