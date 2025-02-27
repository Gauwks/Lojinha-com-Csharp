using System;

namespace Lojinha_DS
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Bem-Vindo(a) à nossa lojinha!");
            Console.WriteLine("Faça seu pedido: ");
            Console.WriteLine("Jaquetas:");
            Console.WriteLine("\t- j Jaqueta Addidas Preta - R$199,99");
            Console.WriteLine("\t- j1 Jaqueta Addidas Azul - R$199,99");
            Console.WriteLine("\t- j2 Adidas Jaqueta Adicolor Classics SST Originals - R$279,99 \n");
            Console.WriteLine("Tênis:");
            Console.WriteLine("\t- a Tênis Nike Air Jordan 5 - R$1709,99");
            Console.WriteLine("\t- ab Tênis Adidas Breaknet Feminino - Branco - R$189,99");
            Console.WriteLine("\t- a2 Tênis Fila Player Masculino - Marinho/Vermelho - R$200,49 \n");
            Console.WriteLine("Camisetas:");
            Console.WriteLine("\t- ad Camiseta Anime Dandadan - R$44,99");
            Console.WriteLine("\t- s Camisa São Paulo 25/26 - R$349,99");
            Console.WriteLine("\t- c Camiseta Boxy Com Estampa Charlie Brown Jr - R$79,90");
            switch (Console.ReadLine())
             {
                case "j" : Console.WriteLine("Jaqueta Addidas Preta foi adicionada ao carrinho: R$199,99");
                    break;
 
                case "j1": Console.WriteLine("j1 Jaqueta Addidas Azul - R$199,99");
                    break;

                case "j2":
                    Console.WriteLine("Adidas Jaqueta Adicolor Classics SST Originals foi adicionada ao: R$279,999");
                    break;
                case "a":
                    Console.WriteLine("Tênis Nike Air Jordan 5 adicionado ao carrinho: R$199,99");
                    break;
                case "ab": Console.WriteLine("Tênis Adidas Breaknet Feminino - Branco foi adicionado ao carrinho: R$189,99");
                    break;
                case "a2": Console.WriteLine("Tênis Fila Player Masculino - Marinho/Vermelho foi adicionado ao carrinho: R$200,49");
                    break;
                case "ad"; Console.WriteLine("Camiseta Anime Dandadan foi adicionada ao carrinho: R$44,99");
                    break;
                case "s": Console.WriteLine("Camisa São Paulo 25/26 foi adicioanada: R$349,99");
                    break;
                case "c": Console.WriteLine("Camiseta Boxy Com Estampa Charlie Brown Jr foi adicionada ao carrinho: R$79,90");
                    break;
                default: Console.WriteLine("Selecione uma opção válida.");
                    break;
            }
               
        }
    }
}
