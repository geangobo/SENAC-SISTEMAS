using _14_PROJETO_BANCOeCLIENTE;

Cliente p1 = new Cliente("GEAN GOBO DA CRUZ", "gobogean@gmail.com", "1234", 2850.99, true, true);

Cliente p2 = new Cliente("Anderson Silva", "silva@gmail.com", "2134", 1500.00, false, true);

p1.mostra();
p1.contabancaria.mostrar2();

p2.mostra();
p2.contabancaria.mostrar2();