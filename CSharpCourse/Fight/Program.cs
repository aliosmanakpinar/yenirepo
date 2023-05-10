using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir dövüş oyunu düşün 
            //Rakip vs Player tarzında olacak.
            //3 Vuruş tipi olacak , low-mid-high şeklinde ( low-düşük hasar , mid-orta hasar , high-yüksek hasar )
            //Sıra sıra vurma şeklinde olacak.

            Opponent opponent = new Opponent(200);


            Random rnd = new Random();
            int pc, player, pchp, playerhp, secim, yüzde;

            pchp = 200;
            Console.WriteLine("PC HP= {0}", pchp);
            playerhp = 200;
            Console.WriteLine("Player HP = {0}", playerhp);



            Console.WriteLine("*************************");

            Console.WriteLine("1- Low Damage (25 Damage) %100 luck ");
            Console.WriteLine("2- Mid Damage (50 Damage) %60 luck");
            Console.WriteLine("3- High Damage (100 Damage) %25 luck");

            Console.WriteLine("*************************");


            bool sart = false;

            while (sart == false)
            {
                Console.Write("Bir secim yapiniz : ");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    pchp -= 25;
                    Console.WriteLine("*** LOW DAMAGE ATTIN , RAKIBIN CANI = {0} ***", pchp);
                    
                }

                if (secim == 2)
                {
                    yüzde = rnd.Next(1, 100);
                    
                    if (yüzde <= 40)
                    {
                        Console.WriteLine("*** HEDEFI ISKALADIN ***");
                        
                    }
                    else if (yüzde > 40)
                    {
                        if (pchp < 50)
                        {
                            pchp -= pchp;
                            Console.WriteLine("*** MID DAMAGE ATTIN , RAKIBIN CANI = {0} ***", pchp);
                        }
                        else
                        {
                            pchp -= 50;
                            Console.WriteLine("*** MID DAMAGE ATTIN , RAKIBIN CANI = {0} ***", pchp);
                            
                        }

                    }

                }

                if (secim == 3)
                {
                    yüzde = rnd.Next(1, 100);
                    
                    if (yüzde <= 25)
                    {
                        if (pchp < 100)
                        {
                            pchp -= pchp;
                            Console.WriteLine("*** HIGH DAMAGE ATTIN , RAKIBIN CANI = {0} ***", pchp);

                        }
                        else
                        {
                            pchp -= 100;
                            Console.WriteLine("*** HIGH DAMAGE ATTIN , RAKIBIN CANI = {0} ***", pchp);
                            
                        }

                    }
                    else if (yüzde > 25)
                    {
                        Console.WriteLine("*** HEDEFI ISKALADIN ***");
                        
                    }
                }
                if (pchp == 0)
                {
                    Console.WriteLine("Oyunu kazandınız.");
                    break;
                }



                pc = rnd.Next(1, 4);

                Console.WriteLine("Rakibin secimi = {0}", pc);
                if (pc == 1)
                {
                    playerhp -= 25;
                    Console.WriteLine("*** LOW DAMAGE YEDIN CANIN = {0} ***", playerhp);
                }
                if (pc == 2)
                {
                    if (playerhp < 50)
                    {
                        playerhp -= playerhp;
                        Console.WriteLine("*** MID DAMAGE YEDIN CANIN = {0} ***", playerhp);
                    }
                    else
                    {
                        playerhp -= 50;
                        Console.WriteLine("*** MID DAMAGE YEDIN CANIN = {0} ***", playerhp);
                    }
                    
                }
                if (pc == 3)
                {
                    yüzde = rnd.Next(1, 100);

                    if (yüzde <= 50)
                    {
                        if (playerhp < 100)
                        {
                            playerhp -= playerhp;
                            Console.WriteLine("*** HIGH DAMAGE YEDIN CANIN = {0} ***", playerhp);
                        }
                        else
                        {
                            playerhp -= 100;
                            Console.WriteLine("*** HIGH DAMAGE YEDIN CANIN = {0} ***", playerhp);
                        }
                       
                    }
                    else if (yüzde > 50)
                    {
                        Console.WriteLine("*** RAKIP ISKALADI ***");
                    }
                }
                if (playerhp == 0 )
                {
                    Console.WriteLine("Oyunu Kaybettiniz.");
                    break;
                }
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
