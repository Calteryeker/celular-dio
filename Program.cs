using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia cellNokia = new Nokia("12345678", "987654321", "A-Nokia-1", 8);
cellNokia.Ligar();
cellNokia.ReceberLigacao();
cellNokia.InstalarAplicativo("Steam");

Iphone cellIphone = new Iphone("11223344", "543219876", "I-phone-1", 10);
cellIphone.Ligar();
cellIphone.ReceberLigacao();
cellIphone.InstalarAplicativo("Whatsapp");
