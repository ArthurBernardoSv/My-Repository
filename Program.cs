using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PetShop loja = new PetShop();

        Console.WriteLine("🐾 Bem-vindo ao PetShop!");
        Console.Write("Quantos animais deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nCadastro do animal #{i + 1}");

            Console.Write("É um cachorro ou gato? (c/g): ");
            string tipo = Console.ReadLine().ToLower();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Raça: ");
            string raca = Console.ReadLine();

            Console.Write("Cor: ");
            string cor = Console.ReadLine();

            if (tipo == "c")
            {
                Cachorro c = new Cachorro(nome, idade, raca, cor);
                loja.AdicionarAnimal(c);
            }
            else if (tipo == "g")
            {
                Gato g = new Gato(nome, idade, raca, cor);
                loja.AdicionarAnimal(g);
            }
            else
            {
                Console.WriteLine("Tipo inválido. Animal ignorado.");
            }
        }

        Console.WriteLine("\n📋 Lista de animais cadastrados:");
        loja.ListarAnimais();
    }
}

class PetShop
{
    private List<Animal> animais = new List<Animal>();

    public void AdicionarAnimal(Animal a)
    {
        animais.Add(a);
    }

    public void ListarAnimais()
    {
        foreach (Animal a in animais)
        {
            a.ExibirInfo();
            a.EmitirSom();
            Console.WriteLine();
        }
    }
}

class Animal
{
    public string nome;
    public int idade;

    public Animal(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico");
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }
}

class Cachorro : Animal
{
    public string raca;
    public string cor;

    public Cachorro(string nome, int idade, string raca, string cor) : base(nome, idade)
    {
        this.raca = raca;
        this.cor = cor;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("AU AU");
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Raça: {raca}");
        Console.WriteLine($"Cor: {cor}");
    }
}

class Gato : Animal
{
    public string raca;
    public string cor;

    public Gato(string nome, int idade, string raca, string cor) : base(nome, idade)
    {
        this.raca = raca;
        this.cor = cor;
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau");
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Raça: {raca}");
        Console.WriteLine($"Cor: {cor}");
    }
}
