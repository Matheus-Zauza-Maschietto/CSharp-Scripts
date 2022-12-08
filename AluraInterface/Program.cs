using AluraInterface.Funcionarios;
using AluraInterface.SistemaInterno;
using System;

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor Ingrid = new Diretor("852741");
    Ingrid.Nome = "Ingrid Novaes";
    Ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("963741");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(Ingrid, "123");
    sistema.Logar(ursula, "963");
}