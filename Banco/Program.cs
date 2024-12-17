using Banco.Clientes;
using Banco.Conta;
using Banco.Enderecos;

Endereco e1 = new Endereco("avenida central  2", "12a", "12hc", "novo gama", "72860110", "GO");

Cliente c1 = new Cliente();

c1.nome = "Rafael";
c1.Cpf = "111111";
c1.Endereco = e1;

Cliente c2 = new Cliente();

c2.nome = "Tie";
c2.Cpf = "2222";
c2.Endereco = e1;

ContaCorrente conta = new ContaCorrente(50.0, c1);

ContaCorrente conta2 = new ContaCorrente(0.0, c2);

ContaHeranca c3 = new ContaHeranca(conta.saldo, c2);


Console.WriteLine(conta.vizualizarSaldo());

conta.sacar(10.0);

Console.WriteLine(conta.vizualizarSaldo());

conta.transferir(10.0, conta2); 

conta.depositar(10.0);
Console.WriteLine(conta.vizualizarSaldo());
Console.WriteLine(conta2.vizualizarSaldo());

c3.depositar(50.0);
Console.WriteLine(c3.vizualizarSaldo());

Console.WriteLine(ContaCorrente.numeroDecontas);

int v1 = 50;

c3.teste(ref v1);

Console.WriteLine($"testando referencia {v1}");

