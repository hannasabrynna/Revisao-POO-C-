using BancoC_.Models;

// Testes com a classe Conta

Conta c1 = new Conta(123, 4100, false);

c1.Depositar(30);
c1.ExibirSaldo();
c1.Sacar(100);
c1.ExibirSaldo();
