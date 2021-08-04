using System;

namespace architektura
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wybierz operacje, MOV lub XCHG: ");
            string polecenie = Console.ReadLine();

            if (polecenie == "MOV")
            {
                Console.WriteLine("Podaj pierwszą komórkę: ");
                string kom1 = Console.ReadLine();
                Console.WriteLine("Podaj wartość pierwszej komórki (4 bity): ");
                string kom11 = Console.ReadLine();

                Console.WriteLine("Podaj drugą komórkę: ");
                string kom2 = Console.ReadLine();
                Console.WriteLine("Podaj wartość drugiej komórki (4 bity): ");
                string kom22 = Console.ReadLine();
                Console.WriteLine(" ");

                if (kom11.Length > 4)
                {
                    Console.WriteLine("Za długi rejestr");
                }
                else if (kom22.Length > 4)
                {
                    Console.WriteLine("Za długi rejestr");
                }
                else if (kom11.Length < 4)
                {
                    Console.WriteLine("Za krótki rejestr");
                }
                else if (kom22.Length < 4)
                {
                    Console.WriteLine("Za krótki rejestr");
                }
                else
                {


                    Console.WriteLine("Podane dane do operacji MOV: ");
                    Console.WriteLine("Komórka pierwsza: " + kom11 + " Komórka druga: " + kom22);



                    if (kom1 == "AX" && kom2 == "AX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("AX pierwsza komórka = " + kom11);
                        Console.WriteLine("AX druga komórka = " + kom22);
                    }
                    else if (kom1 == "AX" && kom2 == "BX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("AX = " + kom11);
                        Console.WriteLine("BX = " + kom22);
                    }
                    else if (kom1 == "AX" && kom2 == "CX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("AX = " + kom11);
                        Console.WriteLine("CX = " + kom22);
                    }
                    else if (kom1 == "AX" && kom2 == "DX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("AX = " + kom11);
                        Console.WriteLine("DX = " + kom22);
                    }
                    else if (kom1 == "BX" && kom2 == "AX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("BX = " + kom11);
                        Console.WriteLine("AX = " + kom22);
                    }
                    else if (kom1 == "BX" && kom2 == "BX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("BX pierwsza komórka = " + kom11);
                        Console.WriteLine("BX druga komórka = " + kom22);
                    }
                    else if (kom1 == "BX" && kom2 == "CX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("BX = " + kom11);
                        Console.WriteLine("CX = " + kom22);
                    }
                    else if (kom1 == "BX" && kom2 == "DX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("BX = " + kom11);
                        Console.WriteLine("DX = " + kom22);
                    }
                    else if (kom1 == "CX" && kom2 == "AX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("CX = " + kom11);
                        Console.WriteLine("AX = " + kom22);
                    }
                    else if (kom1 == "CX" && kom2 == "BX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("CX = " + kom11);
                        Console.WriteLine("BX = " + kom22);
                    }
                    else if (kom1 == "CX" && kom2 == "CX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("CX pierwsza komórka = " + kom11);
                        Console.WriteLine("CX druga komórka = " + kom22);
                    }
                    else if (kom1 == "CX" && kom2 == "DX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("CX = " + kom11);
                        Console.WriteLine("DX = " + kom22);
                    }
                    else if (kom1 == "DX" && kom2 == "AX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("DX = " + kom11);
                        Console.WriteLine("AX = " + kom22);
                    }
                    else if (kom1 == "DX" && kom2 == "BX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("DX = " + kom11);
                        Console.WriteLine("BX = " + kom22);
                    }
                    else if (kom1 == "DX" && kom2 == "CX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("DX = " + kom11);
                        Console.WriteLine("CX = " + kom22);
                    }
                    else if (kom1 == "DX" && kom2 == "DX")
                    {
                        kom11 = kom22;
                        Console.WriteLine(" ");
                        Console.WriteLine("Dane po operacji MOV: ");
                        Console.WriteLine("DX pierwsza komórka = " + kom11);
                        Console.WriteLine("DX druga komórka = " + kom22);
                    }

                    else
                    {
                        Console.WriteLine("Podano złą nazwę komórki");
                    }
                    Console.ReadKey();
                }
            }

            else if (polecenie == "XCHG")
            {
                Console.WriteLine("Komórka pierwsza jest przenoszona do komórki drugiej.");
                Console.WriteLine(" ");
                Console.WriteLine("Podaj pierwszą komórkę: ");
                string kom1 = Console.ReadLine();
                Console.WriteLine("Podaj wartość pierwszej komórki (4 bity): ");
                string kom11 = Console.ReadLine();
                Console.WriteLine("Podaj drugą komórkę: ");
                string kom2 = Console.ReadLine();
                Console.WriteLine("Podaj wartość drugiej komórki (4 bity): ");
                string kom22 = Console.ReadLine();
                if (kom11.Length > 4)
                {
                    Console.WriteLine("Za długi rejestr");
                }
                else if (kom22.Length > 4)
                {
                    Console.WriteLine("Za długi rejestr");
                }
                else if (kom11.Length < 4)
                {
                    Console.WriteLine("Za krótki rejestr");
                }
                else if (kom22.Length < 4)
                {
                    Console.WriteLine("Za krótki rejestr");
                }
                else
                {
                    Console.WriteLine("Podane dane do operacji XCHG: ");
                    Console.WriteLine("Komórka pierwsza: " + kom11 + " Komórka druga: " + kom22);
                    Console.WriteLine(" ");
                    Console.WriteLine("Dane po operacji XCHG: ");
                    if (kom1 == "AX" && kom2 == "AX")
                    {
                        string zmienna = "";

                        Console.WriteLine("AX pierwsza komórka = " + zmienna);
                        Console.WriteLine("AX druga komórka = " + kom11);
                    }
                    else if (kom1 == "AX" && kom2 == "BX")
                    {
                        string zmienna = "";

                        Console.WriteLine("AX komórka = " + zmienna);
                        Console.WriteLine("BX komórka = " + kom11);
                    }
                    else if (kom1 == "AX" && kom2 == "CX")
                    {
                        string zmienna = "";

                        Console.WriteLine("AX komórka = " + zmienna);
                        Console.WriteLine("CX komórka = " + kom11);
                    }
                    else if (kom1 == "AX" && kom2 == "DX")
                    {
                        string zmienna = "";

                        Console.WriteLine("AX komórka = " + zmienna);
                        Console.WriteLine("DX komórka = " + kom11);
                    }
                    else if (kom1 == "BX" && kom2 == "AX")
                    {
                        string zmienna = "";

                        Console.WriteLine("BX komórka = " + zmienna);
                        Console.WriteLine("AX komórka = " + kom11);
                    }
                    else if (kom1 == "BX" && kom2 == "BX")
                    {
                        string zmienna = "";

                        Console.WriteLine("BX pierwsza komórka = " + zmienna);
                        Console.WriteLine("BX druga komórka = " + kom11);
                    }
                    else if (kom1 == "BX" && kom2 == "CX")
                    {
                        string zmienna = "";

                        Console.WriteLine("BX komórka = " + zmienna);
                        Console.WriteLine("CX komórka = " + kom11);
                    }
                    else if (kom1 == "BX" && kom2 == "DX")
                    {
                        string zmienna = "";

                        Console.WriteLine("BX komórka = " + zmienna);
                        Console.WriteLine("DX komórka = " + kom11);
                    }
                    else if (kom1 == "CX" && kom2 == "AX")
                    {
                        string zmienna = "";

                        Console.WriteLine("CX komórka = " + zmienna);
                        Console.WriteLine("AX komórka = " + kom11);
                    }
                    else if (kom1 == "CX" && kom2 == "BX")
                    {
                        string zmienna = "";

                        Console.WriteLine("CX komórka = " + zmienna);
                        Console.WriteLine("BX komórka = " + kom11);
                    }
                    else if (kom1 == "CX" && kom2 == "CX")
                    {
                        string zmienna = "";

                        Console.WriteLine("CX pierwsza komórka = " + zmienna);
                        Console.WriteLine("CX druga komórka = " + kom11);
                    }
                    else if (kom1 == "CX" && kom2 == "DX")
                    {
                        string zmienna = "";

                        Console.WriteLine("CX komórka = " + zmienna);
                        Console.WriteLine("DX komórka = " + kom11);
                    }
                    else if (kom1 == "DX" && kom2 == "AX")
                    {
                        string zmienna = "";

                        Console.WriteLine("DX komórka = " + zmienna);
                        Console.WriteLine("AX komórka = " + kom11);
                    }
                    else if (kom1 == "DX" && kom2 == "BX")
                    {
                        string zmienna = "";

                        Console.WriteLine("DX komórka = " + zmienna);
                        Console.WriteLine("BX komórka = " + kom11);
                    }
                    else if (kom1 == "DX" && kom2 == "CX")
                    {
                        string zmienna = "";

                        Console.WriteLine("DX komórka = " + zmienna);
                        Console.WriteLine("CX komórka = " + kom11);
                    }
                    else if (kom1 == "DX" && kom2 == "DX")
                    {
                        string zmienna = "";

                        Console.WriteLine("DX pierwsza komórka = " + zmienna);
                        Console.WriteLine("DX druga komórka = " + kom11);
                    }
                    else if (kom11.Length < 4 | kom22.Length < 4)
                    {
                        Console.WriteLine("Za długi rejestr");
                    }

                    else
                    {
                        Console.WriteLine("Podaną złą nazwę komórki");
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Nie znane polecenie");
                Console.ReadKey();
            }


        }
    }
}
