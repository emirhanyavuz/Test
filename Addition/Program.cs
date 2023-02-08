class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string val1 = Console.ReadLine();
            string val2 = Console.ReadLine();


            Console.WriteLine("SONUÇ : " + Sum(val1, val2));
        }

    }

    public static string Sum(string val1, string val2)
    {
        int eldeVar = 0;
        int donguSayaci = val1.Length - 1;

        bool val1BasamagiDahaBuyuk = val1.Length - val2.Length > 0;
        bool val2BasamagiDahaBuyuk = val2.Length - val1.Length > 0;

        char[] sonuc = val1BasamagiDahaBuyuk == true ? new char[val1.Length + 1] : new char[val2.Length + 1];

        int fark = val1BasamagiDahaBuyuk == true ? val1.Length - val2.Length : -(val1.Length - val2.Length);

        if (val1BasamagiDahaBuyuk)
        {

            int geciciToplama1 = 0;

            for (int x = val1.Length - 1; x > fark - 1; x--)
            {
                geciciToplama1 = Convert.ToInt32(val1[x].ToString()) + Convert.ToInt32(val2[x - fark].ToString()) + eldeVar;
                if (geciciToplama1 >= 10)
                {

                    eldeVar = 1;
                    sonuc[x] = geciciToplama1.ToString()[1];



                }
                else
                {
                    eldeVar = 0;
                    sonuc[x] = geciciToplama1.ToString()[0];
                }


            }
            for (int i = fark - 1; i >= 0; i--)
            {
                int geciciToplama = Convert.ToInt32(val1[i].ToString()) + eldeVar;

                if (geciciToplama >= 10)
                {
                    if (i == 0)
                    {
                        for (int z = donguSayaci + 1; z > donguSayaci - 1; z--)
                        {
                            sonuc[z] = sonuc[z - 1];
                        }
                        sonuc[i + 1] = geciciToplama.ToString()[1];
                        sonuc[i] = geciciToplama.ToString()[0];
                        eldeVar = 0;

                    }
                    else
                    {
                        eldeVar = 1;
                        sonuc[i] = geciciToplama.ToString()[1];

                    }


                }
                else
                {
                    eldeVar = 0;
                    sonuc[i] = geciciToplama.ToString()[0];
                }







            }



        }
        else if (val2BasamagiDahaBuyuk)
        {

            int geciciToplama1 = 0;

            for (int x = val2.Length - 1; x > fark - 1; x--)
            {
                geciciToplama1 = Convert.ToInt32(val2[x].ToString()) + Convert.ToInt32(val1[x - fark].ToString()) + eldeVar;
                if (geciciToplama1 >= 10)
                {

                    eldeVar = 1;
                    sonuc[x] = geciciToplama1.ToString()[1];



                }
                else
                {
                    eldeVar = 0;
                    sonuc[x] = geciciToplama1.ToString()[0];
                }


            }
            for (int i = fark - 1; i >= 0; i--)
            {
                int geciciToplama = Convert.ToInt32(val2[i].ToString()) + eldeVar;

                if (geciciToplama >= 10)
                {
                    if (i == 0)
                    {
                        for (int z = donguSayaci + 1; z > donguSayaci - 1; z--)
                        {
                            sonuc[z] = sonuc[z - 1];
                        }
                        sonuc[i + 1] = geciciToplama.ToString()[1];
                        sonuc[i] = geciciToplama.ToString()[0];
                        eldeVar = 0;

                    }
                    else
                    {
                        eldeVar = 1;
                        sonuc[i] = geciciToplama.ToString()[1];

                    }


                }
                else
                {
                    eldeVar = 0;
                    sonuc[i] = geciciToplama.ToString()[0];
                }


            }
        }

        else
        {
            for (int i = donguSayaci; i >= 0; i--)
            {
                int geciciToplama = Convert.ToInt32(val1[i].ToString()) + Convert.ToInt32(val2[i].ToString()) + eldeVar;

                if (geciciToplama >= 10)
                {
                    if (i == 0)
                    {

                        sonuc[1] = geciciToplama.ToString()[1];
                        sonuc[0] = geciciToplama.ToString()[0];
                        eldeVar = 0;

                    }
                    else
                    {
                        eldeVar = 1;
                        sonuc[i] = geciciToplama.ToString()[1];

                    }


                }
                else
                {
                    eldeVar = 0;
                    sonuc[i] = geciciToplama.ToString()[0];
                }


            }

        }

        string gercekSonuc = "";

        for (int i = 0; i < sonuc.Length; i++)
        {
            gercekSonuc += sonuc[i];
        }

        return gercekSonuc;






    }
}