using System;

namespace Loggi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Pacotes = { "888555555123888",
                                 "333333555584333",
                                 "222333555124000",
                                 "000111555874555",
                                 "111888555654777",
                                 "111333555123333",
                                 "555555555123888",
                                 "888333555584333",
                                 "111333555124000",
                                 "333888555584333",
                                 "555888555123000",
                                 "111888555123555",
                                 "888000555845333",
                                 "000111555874000",
                                 "111333555123555"};

            Console.WriteLine("Número total de pacotes para serem lidos: " + Pacotes.Length);

            string[] regra1 = new string[Pacotes.Length];
            string[] regra2 = new string[Pacotes.Length];
            string[] regra3 = new string[Pacotes.Length];
            var regra41 = "Região Sul: ";
            var regra42 = "Região Centro-Oeste: ";
            var regra43 = "Região Nordeste: ";
            var regra44 = "Região Norte: ";
            var regra45 = "Região Sudeste: ";
            string[] regra6 = new string[15];

            // 123
            var vendedor1 = 0;
            //124
            var vendedor2 = 0;
            //845
            var vendedor4 = 0;
            //874
            var vendedor5 = 0;

            // combinação Sul
            var SJ = 0;
            var SL = 0;
            var SE = 0;
            var SB = 0;
            var SBQ = 0;
            // combinação Centro-Oeste
            var CJ = 0;
            var CL = 0;
            var CE = 0;
            var CB = 0;
            var CBQ = 0;
            // combinação Nordeste
            var NEJ = 0;
            var NEL = 0;
            var NEE = 0;
            var NEB = 0;
            var NEBQ = 0;
            // combinação Norte
            var NJ = 0;
            var NL = 0;
            var NE = 0;
            var NB = 0;
            var NBQ = 0;
            // combinação Sudeste
            var SEJ = 0;
            var SEL = 0;
            var SEE = 0;
            var SEB = 0;
            var SEBQ = 0;


            var contador = 0;
            foreach (var item in Pacotes)
            {
                var valido = true;
                contador++;
                var parte1 = item.Substring(0, 3);
                var parte2 = item.Substring(3, 3);
                var parte3 = item.Substring(6, 3);
                var parte4 = item.Substring(9, 3);
                var parte5 = item.Substring(12, 3);


                if (parte1 == "000")
                {
                    regra1[contador - 1] = "Pacote " + contador + ": Sul";
                }
                else if (parte1 == "111")
                {
                    regra1[contador - 1] = "Pacote " + contador + ": Centro-Oeste";
                }
                else if (parte1 == "333")
                {
                    regra1[contador - 1] = "Pacote " + contador + ": Nordeste";
                }
                else if (parte1 == "555")
                {
                    regra1[contador - 1] = "Pacote " + contador + ": Norte";
                }
                else if (parte1 == "888")
                {
                    regra1[contador - 1] = "Pacote " + contador + ": Sudeste";
                }
                if (parte1 == "000" && parte5 == "888")
                {
                    regra3[contador - 1] = "Pacote " + contador;
                }

                if (!(parte5 == "000" || parte5 == "111" || parte5 == "333" || parte5 == "555" || parte5 == "888"))

                    if (parte4 == "594")
                        valido = false;
                if (parte1 == "111")
                    valido = false;

                if (!(parte1 == "000" || parte1 == "111" || parte1 == "333" || parte1 == "555" || parte1 == "888" ||
                    parte2 == "000" || parte2 == "111" || parte2 == "333" || parte2 == "555" || parte2 == "888" ||
                    parte5 == "000" || parte5 == "111" || parte5 == "333" || parte5 == "555" || parte5 == "888"))
                    valido = false;

                if (valido)
                {
                    regra2[contador - 1] = "Pacote Valido " + contador;
                }
                else
                {
                    regra2[contador - 1] = "Pacote Invalido " + contador;
                }

                if (parte2 == "000" & valido)
                {
                    regra41 = regra41 + "Pacote: " + contador + " ";
                }
                else if (parte2 == "111" & valido)
                {
                    regra42 = regra42 + "Pacote: " + contador + " ";
                }
                else if (parte2 == "333" & valido)
                {
                    regra43 = regra43 + "Pacote: " + contador + " ";
                }
                else if (parte2 == "555" & valido)
                {
                    regra44 = regra44 + "Pacote: " + contador + " ";
                }
                else if (parte2 == "888" & valido)
                {
                    regra45 = regra45 + "Pacote: " + contador + " ";
                }


                if (parte4 == "123" & valido)
                {
                    vendedor1++;
                }
                else if (parte4 == "124" & valido)
                {
                    vendedor2++;
                }
                else if (parte4 == "845" & valido)
                {
                    vendedor4++;
                }
                else if (parte4 == "874" & valido)
                {
                    vendedor5++;
                }


                if (parte2 == "000" & parte5 == "000" & valido)
                {
                    SJ++;
                }
                else if (parte2 == "000" & parte5 == "111" & valido)
                {
                    SL++;
                }
                else if (parte2 == "000" & parte5 == "333" & valido)
                {
                    SE++;
                }
                else if (parte2 == "000" & parte5 == "555" & valido)
                {
                    SB++;
                }
                else if (parte2 == "000" & parte5 == "888" & valido)
                {
                    SBQ++;
                }
                else if (parte2 == "111" & parte5 == "000" & valido)
                {
                    CJ++;
                }
                else if (parte2 == "111" & parte5 == "111" & valido)
                {
                    CL++;
                }
                else if (parte2 == "111" & parte5 == "333" & valido)
                {
                    CE++;
                }
                else if (parte2 == "111" & parte5 == "555" & valido)
                {
                    CB++;
                }
                else if (parte2 == "111" & parte5 == "888" & valido)
                {
                    CBQ++;
                }
                else if (parte2 == "333" & parte5 == "000" & valido)
                {
                    NEJ++;
                }
                else if (parte2 == "333" & parte5 == "111" & valido)
                {
                    NEL++;
                }
                else if (parte2 == "333" & parte5 == "333" & valido)
                {
                    NEE++;
                }
                else if (parte2 == "333" & parte5 == "555" & valido)
                {
                    NEB++;
                }
                else if (parte2 == "333" & parte5 == "888" & valido)
                {
                    NEBQ++;
                }
                else if (parte2 == "555" & parte5 == "000" & valido)
                {
                    NJ++;
                }
                else if (parte2 == "555" & parte5 == "111" & valido)
                {
                    NL++;
                }
                else if (parte2 == "555" & parte5 == "333" & valido)
                {
                    NE++;
                }
                else if (parte2 == "555" & parte5 == "555" & valido)
                {
                    NB++;
                }
                else if (parte2 == "555" & parte5 == "888" & valido)
                {
                    NBQ++;
                }
                else if (parte2 == "888" & parte5 == "000" & valido)
                {
                    SEJ++;
                }
                else if (parte2 == "888" & parte5 == "111" & valido)
                {
                    SEL++;
                }
                else if (parte2 == "888" & parte5 == "333" & valido)
                {
                    SEE++;
                }
                else if (parte2 == "888" & parte5 == "555" & valido)
                {
                    SEB++;
                }
                else if (parte2 == "888" & parte5 == "888" & valido)
                {
                    SEBQ++;
                }
                //  if (parte1 == "000")
                //else if (parte1 == "111")
                //else if (parte1 == "333")
                //else if (parte1 == "555")
                //else if (parte1 == "888")
            }
            foreach (var x in regra1)
            {
                if (x != null)
                {
                    Console.WriteLine("O destino do pacote é:");
                    Console.WriteLine(x);
                    Console.WriteLine("");
                }
            }
            foreach (var x in regra2)
            {
                if (x != null)
                {
                    Console.WriteLine("Lista se os pacotes são válidos ou não:");
                    Console.WriteLine(x);
                    Console.WriteLine("");
                }
            }
            foreach (var x in regra3)
            {
                if (x != null)
                {
                    Console.WriteLine("O pacotes com brinquedo para o Sul é:");
                    Console.WriteLine(x);
                    Console.WriteLine("");
                }

            }
            Console.WriteLine("Pacotes por região");
            Console.WriteLine("");
            Console.WriteLine(regra41);
            Console.WriteLine("");
            Console.WriteLine(regra42);
            Console.WriteLine("");
            Console.WriteLine(regra43);
            Console.WriteLine("");
            Console.WriteLine(regra44);
            Console.WriteLine("");
            Console.WriteLine(regra45);
            Console.WriteLine("");

            Console.WriteLine("Regiões de destino por tipo de produto");
            Console.WriteLine("");
            Console.WriteLine("Sul: Jóias: " + SJ + ", Livros: " + SL + ", Eletrônicos: " + SE + ", Bebidas: " + SB + ", Brinquedos: " + SBQ);
            Console.WriteLine("");
            Console.WriteLine("Centro-Oeste: Jóias: " + CJ + ", Livros: " + CL + ", Eletrônicos: " + CE + ", Bebidas: " + CB + ", Brinquedos: " + CBQ);
            Console.WriteLine("");
            Console.WriteLine("Nordeste: Jóias: " + NEJ + ", Livros: " + NEL + ", Eletrônicos: " + NE + ", Bebidas: " + NEB + ", Brinquedos: " + NEBQ);
            Console.WriteLine("");
            Console.WriteLine("Norte: Jóias: " + NJ + ", Livros: " + NL + ", Eletrônicos: " + NE + ", Bebidas: " + NB + ", Brinquedos: " + NBQ);
            Console.WriteLine("");
            Console.WriteLine("Sudeste: Jóias: " + SEJ + ", Livros: " + SEL + ", Eletrônicos: " + SEE + ", Bebidas: " + SEB + ", Brinquedos: " + SEBQ);


            Console.WriteLine("");
            Console.WriteLine("Estágio 2021");
            Console.ReadKey();
        }

    }
}
