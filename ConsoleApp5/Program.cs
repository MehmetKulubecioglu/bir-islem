using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayilar;
            Console.WriteLine("Hoş Geldiniz \n1-Sayıları Random Üret\n2-Sayıları Gir");
            Sayilar = Convert.ToInt32(Console.ReadLine());


            Random rasgele = new Random();
            int[] TekBasamakliSayi = new int[5];
            int IkiBasamakliSayi, UcbasamakliSayi;

            if (Sayilar == 1)
            {



                for (int i = 0; i < 5; i++)
                {
                    TekBasamakliSayi[i] = rasgele.Next(1, 10);
                }


                for (; ; )
                {
                    IkiBasamakliSayi = rasgele.Next(10, 100);
                    if (IkiBasamakliSayi % 10 == 0)
                        break;
                }

                UcbasamakliSayi = rasgele.Next(100, 999);



                Console.WriteLine("\n1.sayı: " + TekBasamakliSayi[0] +
                    "\n2.sayi: " + TekBasamakliSayi[1] +
                    "\n3.sayı: " + TekBasamakliSayi[2] +
                    "\n4.sayı: " + TekBasamakliSayi[3] +
                    "\n5.sayı: " + TekBasamakliSayi[4] +
                    "\n6.sayı: " + IkiBasamakliSayi +
                    "\nHedef Sayı:  " + UcbasamakliSayi);
                

            }
            else 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i + 1 + ".sayi: ");
                    TekBasamakliSayi[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("6.sayi (10 un katı):");
                IkiBasamakliSayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hedef Sayı: ");
                UcbasamakliSayi = Convert.ToInt32(Console.ReadLine());

                
            }
            int bolum, kalan, temp, bolum2, kalan2;
            bolum = UcbasamakliSayi / IkiBasamakliSayi;
            kalan = UcbasamakliSayi - (IkiBasamakliSayi * bolum);
            bolum2 = bolum + 1;
            kalan2 = IkiBasamakliSayi * bolum2 - UcbasamakliSayi;
            for (int i = 0; i < 5; i++)
            {
                if (TekBasamakliSayi[i]==bolum)
                {
                    temp = TekBasamakliSayi[i];
                    TekBasamakliSayi[i] = TekBasamakliSayi[4];
                    TekBasamakliSayi[4] = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        if (kalan == TekBasamakliSayi[j])
                        {
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[j] + "+" + temp * IkiBasamakliSayi + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                        if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[2] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[2] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1]+ TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2]+TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                        {
                            int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[2] * TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                        {
                            int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2]+ "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }
                        else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3])
                        {
                            int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3];
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "+" + temp2 + "=" + UcbasamakliSayi);
                            break;
                        }





                    break;
                }


                else if(TekBasamakliSayi[0]+TekBasamakliSayi[1]==bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if(kalan==TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if(kalan==TekBasamakliSayi[0]+TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if(kalan==TekBasamakliSayi[0]+TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if(kalan==TekBasamakliSayi[1]+TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if(kalan== TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if(kalan==TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[0] + TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[3];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if(kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;


                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if(TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = t + t2 + t3 + t4;
                    
                    if(kalan == TekBasamakliSayi[4])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[4] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan == TekBasamakliSayi[3])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[3] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan == TekBasamakliSayi[2])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[2] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }
                }

                else if(TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5, t6;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = TekBasamakliSayi[4];
                    t6 = t + t2 + t3 + t4 + t5;
                    Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "+" + t5 + "=" + t6 + "\n" + IkiBasamakliSayi + "*" + t6 + "=" + UcbasamakliSayi);
                }



                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[0] * TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[3];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "+" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;


                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "+" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = t * t2 * t3 * t4;

                    if (kalan == TekBasamakliSayi[4])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[4] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan == TekBasamakliSayi[3])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[3] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan == TekBasamakliSayi[2])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[2] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "+" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum)
                {
                    int t, t2, t3, t4, t5, t6;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = TekBasamakliSayi[4];
                    t6 = t * t2 * t3 * t4 * t5;
                    Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "*" + t5 + "=" + t6 + "\n" + IkiBasamakliSayi + "*" + t6 + "=" + UcbasamakliSayi);
                }












            }

            for (int i = 0; i < 5; i++)
            {
                if (TekBasamakliSayi[i]==bolum2)
                {
                    temp = TekBasamakliSayi[i];
                    TekBasamakliSayi[i] = TekBasamakliSayi[4];
                    TekBasamakliSayi[4] = 0;

                    for (int j = 0; j < 5; j++)
                    {
                        if (kalan2 == TekBasamakliSayi[j])
                        {
                            Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + temp * IkiBasamakliSayi + "-" + TekBasamakliSayi[j] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }

                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[2] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[2] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "+" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[2] * TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }
                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3])
                    {
                        int temp2 = TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3];
                        Console.WriteLine(temp + "*" + IkiBasamakliSayi + "=" + temp * IkiBasamakliSayi + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "*" + TekBasamakliSayi[3] + "=" + temp2 + "\n" + temp * IkiBasamakliSayi + "-" + temp2 + "=" + UcbasamakliSayi);
                        break;
                    }

                    break;

                }


                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[0] + TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }





                else if (TekBasamakliSayi[0] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }


                else if (TekBasamakliSayi[0] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = t + t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }


                else if (TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[3];
                    t2 = TekBasamakliSayi[4];
                    t3 = t + t2;
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = TekBasamakliSayi[4];
                    t4 = t + t2 + t3;


                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = t + t2 + t3 + t4;

                    if (kalan2 == TekBasamakliSayi[4])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[4] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan2 == TekBasamakliSayi[3])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[3] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan2 == TekBasamakliSayi[2])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[2] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] + TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] + TekBasamakliSayi[2] + TekBasamakliSayi[3] + TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t + t2 + t3 + t4;

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "+" + t2 + "+" + t3 + "+" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }
                }








                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "+" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[0] * TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }





                else if (TekBasamakliSayi[0] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }


                else if (TekBasamakliSayi[0] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }




                else if (TekBasamakliSayi[1] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[1] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = t * t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[4];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }


                else if (TekBasamakliSayi[2] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[2] = TekBasamakliSayi[3];
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }



                else if (TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3;

                    t = TekBasamakliSayi[3];
                    t2 = TekBasamakliSayi[4];
                    t3 = t * t2;
                    TekBasamakliSayi[3] = 0;
                    TekBasamakliSayi[4] = 0;
                    for (int m = 0; m < 5; m++)
                    {
                        if (kalan2 == TekBasamakliSayi[m])
                        {
                            Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + t3 * IkiBasamakliSayi + "\n" + t3 * IkiBasamakliSayi + "-" + TekBasamakliSayi[m] + "=" + UcbasamakliSayi);
                            break;
                        }
                    }
                    if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1] + TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "+" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2];
                        Console.WriteLine(t + "*" + t2 + "=" + t3 + "\n" + IkiBasamakliSayi + "*" + t3 + "=" + IkiBasamakliSayi * t3 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "*" + TekBasamakliSayi[2] + "=" + temp2 + "\n" + IkiBasamakliSayi * t3 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[3];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[0] = TekBasamakliSayi[2];
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[4];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;
                    TekBasamakliSayi[1] = TekBasamakliSayi[3];

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4;
                    t = TekBasamakliSayi[2];
                    t2 = TekBasamakliSayi[3];
                    t3 = TekBasamakliSayi[4];
                    t4 = t * t2 * t3;


                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + IkiBasamakliSayi * t4 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] + TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] + TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "+" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }

                    else if (kalan2 == TekBasamakliSayi[0] * TekBasamakliSayi[1])
                    {
                        int temp2 = TekBasamakliSayi[0] * TekBasamakliSayi[1];
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "=" + t4 + "\n" + IkiBasamakliSayi + "*" + t4 + "=" + IkiBasamakliSayi * t4 + "\n" + TekBasamakliSayi[0] + "*" + TekBasamakliSayi[1] + "=" + temp2 + "\n" + IkiBasamakliSayi * t4 + "-" + temp2 + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[3];
                    t5 = t * t2 * t3 * t4;

                    if (kalan2 == TekBasamakliSayi[4])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[4] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[2];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan2 == TekBasamakliSayi[3])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[3] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[1] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[1];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan2 == TekBasamakliSayi[2])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[2] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[0] * TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[0];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan2 == TekBasamakliSayi[1])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[1] + "=" + UcbasamakliSayi);
                    }
                }

                else if (TekBasamakliSayi[1] * TekBasamakliSayi[2] * TekBasamakliSayi[3] * TekBasamakliSayi[4] == bolum2)
                {
                    int t, t2, t3, t4, t5;
                    t = TekBasamakliSayi[1];
                    t2 = TekBasamakliSayi[2];
                    t3 = TekBasamakliSayi[3];
                    t4 = TekBasamakliSayi[4];
                    t5 = t * t2 * t3 * t4;

                    if (kalan2 == TekBasamakliSayi[0])
                    {
                        Console.WriteLine(t + "*" + t2 + "*" + t3 + "*" + t4 + "=" + t5 + "\n" + IkiBasamakliSayi + "*" + t5 + "=" + IkiBasamakliSayi * t5 + "\n" + IkiBasamakliSayi * t5 + "-" + TekBasamakliSayi[0] + "=" + UcbasamakliSayi);
                    }
                }




            }


            Console.ReadLine();
            
        }
    }
}
