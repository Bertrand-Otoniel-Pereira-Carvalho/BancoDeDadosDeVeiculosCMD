using System;
using Treinar;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro x = new Carro();
            Motos y = new Motos();
            Caminhões z = new Caminhões();

            int OqueQuerFazer, QualTipoDeVeiculo;
            int ContinuarAcao;
            bool AddVeiculo = false, RemoverVeiculo = false, ListarVeiculo = false, ExpressaoNaoValida = false, moto = false, carro = false, caminhão = false, EncerrarPrograma = false;

            while (EncerrarPrograma == false)
            {
                System.Console.WriteLine("\nO que deseja fazer? \n\n 1 - Adicinar Veiculo \n 2 - Remover Veiculo \n 3 - Listar Veiculos \n 4 - Encerrar Programa");

                AcaoQueSeraRealizada(OqueQuerFazer = int.Parse(Console.ReadLine()));

                while (AddVeiculo == true || RemoverVeiculo == true || ListarVeiculo == true)
                {
                    System.Console.WriteLine("De qual tipo de veículo você quer realizar esta ação?\n 1 - Carro \n 2 - Moto \n 3 - Caminhão");
                    DeQualVeiculoEstamosFalando(QualTipoDeVeiculo = int.Parse(Console.ReadLine()));
                    switch (QualTipoDeVeiculo)
                    {
                        case 1:
                            carro = true;
                            while (AddVeiculo == true)
                            {
                                MetodologiaAdicionarVeiculo("carro");
                            }
                            while (RemoverVeiculo == true)
                            {
                                MetodologiaRemoverVeiculo("carro");

                            }
                            while (ListarVeiculo == true)
                            {
                                MetodologiaExibirVeiculos("carro");
                            }
                            break;
                        case 2:
                            moto = true;
                            while (AddVeiculo == true)
                            {
                                MetodologiaAdicionarVeiculo("moto");
                            }
                            while (RemoverVeiculo == true)
                            {
                                MetodologiaRemoverVeiculo("moto");
                            }
                            while (ListarVeiculo == true)
                            {
                                MetodologiaExibirVeiculos("moto");
                            }
                            break;
                        case 3:
                            caminhão = true;
                            while (AddVeiculo == true)
                            {
                                MetodologiaAdicionarVeiculo("caminhão");
                            }
                            while (RemoverVeiculo == true)
                            {
                                MetodologiaRemoverVeiculo("caminhão");
                            }
                            while (ListarVeiculo == true)
                            {
                                MetodologiaExibirVeiculos("caminhão");
                            }
                            break;
                        default:
                            ExpressaoNaoValida = true;
                            break;
                    }
                }

            }
            bool AcaoQueSeraRealizada(int Acao)
            {
                switch (OqueQuerFazer)
                {
                    case 1:
                        return AddVeiculo = true;
                        break;
                    case 2:
                        return RemoverVeiculo = true;
                        break;
                    case 3:
                        return ListarVeiculo = true;
                        break;
                    case 4:
                        return EncerrarPrograma = true;
                        break;
                    default:
                        return ExpressaoNaoValida = true;
                }
            }
            bool DeQualVeiculoEstamosFalando(int Veiculo)
            {
                switch (QualTipoDeVeiculo)
                {
                    case 1:
                        return carro = true;
                        break;
                    case 2:
                        return moto = true;
                        break;
                    case 3:
                        return caminhão = true;
                        break;
                    default:
                        return ExpressaoNaoValida = true;
                }
            }
            bool MetodologiaAdicionarVeiculo(string TipoDeVeiculo)
            {

                if (TipoDeVeiculo == "carro")
                {
                    System.Console.WriteLine($"Digite o nome do {TipoDeVeiculo} que deseja adicionar a lista:");
                    x.Adicionar = Console.ReadLine();
                }
                else if (TipoDeVeiculo == "moto")
                {
                    System.Console.WriteLine($"Digite o nome da {TipoDeVeiculo} que deseja adicionar a lista:");
                    y.Adicionar = Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine($"Digite o nome do {TipoDeVeiculo} que deseja adicionar a lista:");
                    z.Adicionar = Console.ReadLine();
                }
                if (TipoDeVeiculo == "carro" || TipoDeVeiculo == "caminhão")
                {
                    System.Console.WriteLine($"Você quer adicionar outro {TipoDeVeiculo}? ( Digite 1 para sim ou 2 para não) ");
                    ContinuarAcao = int.Parse(Console.ReadLine().Trim().ToLower());
                    if (ContinuarAcao == 1)
                    {
                        return AddVeiculo = true;
                    }
                    else if (ContinuarAcao == 2)
                    {
                        return AddVeiculo = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Expressão inválida");
                        return AddVeiculo = false;
                    }
                }
                else
                {
                    System.Console.WriteLine($"Você quer adicionar outra {TipoDeVeiculo}? ( Digite 1 para sim ou 2 para não) ");
                    ContinuarAcao = int.Parse(Console.ReadLine().Trim().ToLower());
                    if (ContinuarAcao == 1)
                    {
                        return AddVeiculo = true;
                    }
                    else if (ContinuarAcao == 2)
                    {
                        return AddVeiculo = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Expressão inválida");
                        return AddVeiculo = false;
                    }
                }

            }
            bool MetodologiaRemoverVeiculo(string TipoDeVeiculo)
            {
                if (TipoDeVeiculo == "carro")
                {
                    System.Console.WriteLine($"Digite o nome do {TipoDeVeiculo} que quer remover da lista:");
                    x.Remover = Console.ReadLine();
                }
                else if (TipoDeVeiculo == "moto")
                {
                    System.Console.WriteLine($"Digite o nome do {TipoDeVeiculo} que quer remover da lista:");
                    y.Remover = Console.ReadLine();
                }
                else
                {
                    System.Console.WriteLine($"Digite o nome do {TipoDeVeiculo} que quer remover da lista:");
                    z.Remover = Console.ReadLine();
                }
                if (TipoDeVeiculo == "carro" || TipoDeVeiculo == "caminhão")
                {
                    System.Console.WriteLine($"Você quer remover outro {TipoDeVeiculo}? ( Digite 1 para sim ou 2 para não) ");
                    ContinuarAcao = int.Parse(Console.ReadLine().Trim().ToLower());
                    if (ContinuarAcao == 1)
                    {
                        return RemoverVeiculo = true;
                    }
                    else if (ContinuarAcao == 2)
                    {
                        return RemoverVeiculo = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Expressão inválida");
                        return RemoverVeiculo = false;
                    }
                }
                else
                {
                    System.Console.WriteLine($"Você quer remover outra {TipoDeVeiculo}? ( Digite 1 para sim ou 2 para não) ");
                    ContinuarAcao = int.Parse(Console.ReadLine().Trim().ToLower());
                    if (ContinuarAcao == 1)
                    {
                        return RemoverVeiculo = true;
                    }
                    else if (ContinuarAcao == 2)
                    {
                        return RemoverVeiculo = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Expressão inválida");
                        return RemoverVeiculo = false;
                    }
                }
            }
            void MetodologiaExibirVeiculos(string TipoDeVeiculo)
            {
                if (TipoDeVeiculo == "carro")
                {
                    x.Apresentar();
                    ListarVeiculo = false;
                }
                else if (TipoDeVeiculo == "moto")
                {
                    y.Apresentar();
                    ListarVeiculo = false;
                }
                else if (TipoDeVeiculo == "caminhão")
                {
                    z.Apresentar();
                    ListarVeiculo = false;
                }
            }
        }

    }
}