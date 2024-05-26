using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone1 = new Iphone(numero: "11 999392555", modelo: "XR", imei: "111111", memoria: 128);

Nokia nokia1 = new Nokia(numero: "11 999222212", modelo: "T21", imei: "222222", memoria: 64);

iphone1.InstalarAplicativo("zapzap");
iphone1.Ligar();

nokia1.InstalarAplicativo("insta");
nokia1.ReceberLigacao();