using System;
using System.Collections.Generic;
using System.Threading;

namespace Laborator1
{
    public class Subp
    {
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("HH:mm:ss:ms");
        }
        public static bool prim1(int valoare)
        {
            if (valoare <= 1)
                return false;
            for (int i = 2; i < valoare; i++)
                if (valoare % i == 0)
                    return false;
            return true;
        }

        public static bool prim2(int valoare)
        {
            if (valoare <= 1)
                return false;
            if (valoare <= 3)
                return true;
            if (valoare % 2 == 0 || valoare % 3 == 0) 
                return false;
            for (int i = 5; i * i <= valoare; i = i + 6)
                if (valoare % i == 0 || valoare % (i + 2) == 0)
                    return false;
            return true;
        }

        public static int cel_mai_mare_prim1(int valoare)
        {
            int nr_prim = 0;
            for (int i = 1; i < valoare; i++)
            {
                if (prim1(i) == true)
                    nr_prim = i;
            }
            return nr_prim;
        }
        public static int cel_mai_mare_prim2(int valoare)
        {
            for(int i = valoare; i>=0; i--)
            {
                if (prim1(i) == true)
                    return i;
            }
            return 0;
        }
    }

    public class ExThread
    {
        static int nr_dat = 54;
        public static List<string> lista = new List<string>();
        Subp subprogram = new Subp();
        public static void thread1()
        {
            int nr_prim;
            lista.Add("Start fir: 1, TimeStamp: " + Subp.GetTimestamp(DateTime.Now) + " Numarul natural dat: " + nr_dat);
            nr_prim = Subp.cel_mai_mare_prim1(54);
            lista.Add("End fir: 1, TimeStamp: " + Subp.GetTimestamp(DateTime.Now) + " Numarul prim: " + nr_prim);


        }
        public static void thread2()
        {
            int nr_prim;
            lista.Add("Start fir: 2, TimeStamp: " + Subp.GetTimestamp(DateTime.Now) + " Numarul natural dat: " + nr_dat);
            nr_prim = Subp.cel_mai_mare_prim2(54);
            lista.Add("End fir: 2, TimeStamp: " + Subp.GetTimestamp(DateTime.Now) + " Numarul prim: " + nr_prim);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread a = new Thread(ExThread.thread1);
            Thread b = new Thread(ExThread.thread2);
            a.Start();
            b.Start();
            a.Join();
            b.Join();
            foreach(var s in ExThread.lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}
