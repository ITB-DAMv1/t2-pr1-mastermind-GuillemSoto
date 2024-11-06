using System;
public class Mastermind
{
    public static void Main(string[] args)
    {
        const int num=2643;
        const string intro ="Introdueix un número de dificultat";
        const string introNum ="Introdueix un numero de 4 xifres, les seves xifres han d'estar entre 1 i 6";
        const string nov ="Dificultat novell: 10 intents(1)";
        const string afc ="Dificultat aficionat: 6 intents(2)";
        const string exp ="Dificultat expert: 4 intents(3)";
        const string mas ="Dificultat Master: 3 intents(4)";
        const string prs ="Dificultat personalitzada(Qualsevol altre numero)";
        const string prsInt ="Quants intents vols tenir?";
        const string si= "O";
        const string casi= "!";
        const string no= "X";
        string resultat = "";
        int userNum=0;
        int uX1;
        int uX2;
        int uX3;
        int uX4;
        int x1=num/1000;
        int x2=num/100%10;
        int x3=num/10%10;
        int x4=num%10;
        //Calculem quan val cada xifra del número a descobrir
        int intents=1;
        int maxIntents;
        Console.WriteLine(intro);
        Console.WriteLine(nov);
        Console.WriteLine(afc);
        Console.WriteLine(exp);
        Console.WriteLine(mas);
        Console.WriteLine(prs);
        //Fem un menú per escollir la dificultat
        int userDif=int.Parse(Console.ReadLine());
        if (userDif == 1)
        {
            maxIntents=11;
        }
        else if(userDif==2)
        {
            maxIntents=7;
        }
        else if(userDif==3)
        {
            maxIntents=5;
        }
        else if(userDif==4)
        {
            maxIntents=4;
        }
        else
        {
            Console.WriteLine(prsInt);
            maxIntents=int.Parse(Console.ReadLine())+1;
        }
        //Mirem quina dificultat vol, si escull la personalitzada haurem de preguntar el número d'intents
        do
        {
            if(intents<maxIntents)
            {
                Console.WriteLine(introNum);
                userNum=int.Parse(Console.ReadLine());
                uX1=userNum/1000;
                uX2=userNum/100%10;
                uX3=userNum/10%10;
                uX4=userNum%10;
        //Calculem les xifres del nombre que ens doni l'usuari de la mateixa forma que abans.
                if(uX1<=6&&uX1>0&&uX2<=6&&uX2>0&&uX3<=6&&uX3>0&&uX4<=6&&uX4>0)
                {
                    if(x1==uX1)
                    {
                        resultat=resultat+si;
                    }
                    else if (uX1==x2||uX1==x3||uX1==x4)
                    {
                        resultat=resultat+casi;
                    }
                    else
                    {
                        resultat=resultat+no;
                    }
                    if(x2==uX2)
                    {
                        resultat=resultat+si;
                    }
                    else if (uX2==x1||uX2==x3||uX2==x4)
                    {
                        resultat=resultat+casi;
                    }
                    else
                    {
                        resultat=resultat+no;
                    }
                    if(x3==uX3)
                    {
                        resultat=resultat+si;
                    }
                    else if (uX3==x2||uX3==x1||uX3==x4)
                    {
                        resultat=resultat+casi;
                    }
                    else
                    {
                        resultat=resultat+no;
                    }
                    if(x4==uX4)
                    {
                        resultat=resultat+si;
                    }
                    else if (uX4==x2||uX4==x3||uX4==x1)
                    {
                        resultat=resultat+casi;
                    }
                    else
                    {
                        resultat=resultat+no;
                    }
                    Console.WriteLine(resultat);
                    resultat="";
        //Mitjançant una concatenació d'strings anem comprovant per cada xifra quina resposta hem de donar i la emmagatzemem
                }
                else
                {
                    Console.WriteLine("Format de numero incorrecte, -1 intent");
                }
            }
            else
            {
                Console.WriteLine("Has perdut");
            }
            intents=intents+1;
        }
        while(userNum!=num&&intents<maxIntents+1);
        if(userNum==num)
        {
            Console.WriteLine("Has guanyat");
            Console.WriteLine(@"                      /^--^\     /^--^\     /^--^\"); 
            Console.WriteLine(@"                      \____/     \____/     \____/");
            Console.WriteLine(@"                     /      \   /      \   /      \");
            Console.WriteLine(@"                    |        | |        | |        |");
            Console.WriteLine(@"                     \__  __/   \__  __/   \__  __/");
            Console.WriteLine(@"|^|^|^|^|^|^|^|^|^|^|^|^\ \^|^|^|^/ /^|^|^|^|^\ \^|^|^|^|^|^|^|^|^|^|^|^|");
            Console.WriteLine(@"| | | | | | | | | | | | |\ \| | |/ /| | | | | | \ \ | | | | | | | | | | |");
            Console.WriteLine(@"########################/ /######\ \###########/ /#######################");
            Console.WriteLine(@"| | | | | | | | | | | | \/| | | | \/| | | | | |\/ | | | | | | | | | | | |");
            Console.WriteLine(@"|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|");
        }
    }
}