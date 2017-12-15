using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayvsArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int miliarda = 100000000;
            //int[] miliardaPole = new int[miliarda];
            //ArrayList miliardaAlist = new ArrayList();

            //Random r = new Random();

            //Stopwatch stopky = new Stopwatch();
            //stopky.Start();

            //for (int i = 0; i < miliardaPole.Length; i++)
            //{
            //    miliardaPole[i] = r.Next();
            //}
            //stopky.Stop();
            //Console.WriteLine("naplnenie pola{0}", stopky.Elapsed);

            //stopky.Restart();
            //for(int i = 0; i < miliarda; i++)
            //{
            //    miliardaAlist.Add(r.Next());
            //}
            //stopky.Stop();
            //Console.WriteLine("naplnenie Arraylistu {0}", stopky.Elapsed);

            //stopky.Restart();
            //Array.Sort(miliardaPole);
            //stopky.Stop();
            //Console.WriteLine("sort array{0}", stopky.Elapsed);

            //stopky.Restart();
            //miliardaAlist.Sort();
            //stopky.Stop();
            //Console.WriteLine("sort alist {0}", stopky.Elapsed);

            string vstup = "bgvhh776";
            try
            {
                int nula = 0;
                int cislo = 10 / nula;
                //int cislo = int.Parse(vstup);
            }
            catch(System.IO.IOException exception)
            {
                throw exception;
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {

            }


            Console.ReadLine();
        }
    }
}
