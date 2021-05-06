using System;

namespace day8_misc
{
    class Program
    {
        static void Main(string[] args)
        {
            //dati1 : 3
            //dati2 : "567"
            //dati3 : "aaboli"
            // int skaitlis;//  = dati1 OK 
            //int skaitlis;//  = dati2 FAIL


            //tiešā pārveidošana
            //signed int/long | -MAX <0 <MAX
            int skaitlis = -6;//  = dati1 OK 
            long ceturtdiena = skaitlis;
            //nāksies pārveidot, jo ... būs prasība salāgot datu tipus ! 
            float sk = skaitlis;
            double sk_liels = sk;


            //unsigned int/long | 0-MAX
            uint b = 120;
            ulong b_lielais = b;

            //typecast

            sk = 4356456.0f;



            
            int float_as_int = (int)sk /* + kautkas */;


            //te nav matemātika !
            //vai rezultāts atbilst vēlamajam ?
            byte int_as_byte = (byte)float_as_int /* + kautkas */;
            byte float_as_byte = (byte)sk /* + kautkas */;

            //long garais = (long)float_as_int;
            //long garais = float_as_int;



            string sk_teksts = "134";

            //šeit jābūt pārliecībai, ka tekstuāla informācija ir skaitlis
            int konverts = Convert.ToInt32(sk_teksts);

            // kā šo risināt ?

            //1. try{...} catch (){...}
            //2. izmantot citu pārveides f() - TryParse()

            int parveides_rez = 0;
            bool rez = Int32.TryParse("123qq", out parveides_rez);

            //string teksts = "Teksts";
            string teksts = null;
            //string[] teksts = new string[10];






            //Nullable Types
            //int manu_auto_skaits = -1;// -1, ja tas ir iespējams

            // metode, kas atgriež 0 - skaitli, ja ir dati ir atrasti
            //                     -1, ja nav atrasti



            //veids, kā pārbauda vai skaitlim ir piešķirta vērtība





            //30 jautājumi vai personīga info, tests

            //atbilžu varianti - parezās atbildes - skaitļi

            //viegli noteikt vai ir sniegta atbilde 

            //bool man_pieder_auto = false;


            int? manu_auto_skaits = null;
            //bool? vai_esmu_ugunsdzeeseejs = null;
            /*
            int jautaajums1 = 0;
            bool jautaajums1_ir_atbildeets = false;

            int jautaajums2 = 0;
            bool jautaajums2_ir_atbildeets = false;

            int jautaajums3 = 0;
            bool jautaajums3_ir_atbildeets = false;

            //...
            int jautaajums30 = 0;
            bool jautaajums30_ir_atbildeets = false;
            */

            //datu ievade ...
            //...
            //...

            int auto_skaits;
            Console.WriteLine("Ievadi auto skaitu ... ");
            bool auto_ievadiits = Int32.TryParse(Console.ReadLine(), out auto_skaits);

            if (auto_ievadiits)
                manu_auto_skaits = auto_skaits;

            //...
            // kāda ir mainīgā vērtība ?
            //
            //1.
            //man nav neviena auto ? manu_auto_skaits == 0
            if (manu_auto_skaits == 0)
            {
                //man nav auto
            }

            //2.
            //man ir auto manu_auto_skaits > 0
            else if (manu_auto_skaits > 0)
            {
                //man ir auto
            }

            //3.
            //nav datu par auto
            //ja manu_auto_skaits == -1
            //
            else
            {
                //nav datu
            }



            //DateTime


            //DateTime saakums = DateTime.Now;
            //string laiks = saakums.ToString("MM/dd/yyyy");
            //Console.WriteLine("Saakums :" + laiks);

            //laiks.Length

            //īsais pieraksts - nav iespējas izmantot laika struktūras datus !!!
            //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            //Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm"));


            //1. string mainigais = ""

            //2.
            //iekļauto ciklu trijos līmeņos.
            // katrs no cikliem izpildās 100 reizes <- lai varētu vienkārši mainīt skaitu !
            // string mainīgajam pievienojam (konkatinējam) tekošo laiku

            //for (100)
            // for (100)
            //  for (100)
            //string  + laiks().ToString("sdfsdf")

            DateTime date = DateTime.Now;
            int cikli = 30;
            int cikls_2 = 1;
            string laiks = date.ToString("dd/MM/yyyy");

            for (int i = 0; i < cikli; i++)
                for (int u = 0; u < cikli; u++)
                    for (int y = 0; y < cikli; y++)
                    {
                        laiks = laiks + DateTime.Now.ToString("dd/MM/yyyy");
                        Console.WriteLine("Cikls: " + cikls_2++);
                    }

            DateTime beigas = DateTime.Now;
            TimeSpan izpildes_laiks = beigas - date;

            Console.WriteLine("Izpildes laiks: " + izpildes_laiks);


            


        }
    }
}
