using System;
using System.Collections.Generic;

namespace Laborator1
{
    public class Subp
    {
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
        public static void thread1()
        {
            
        }
        public static void thread2()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subp s = new Subp();
            int numar = 70;
            var lista = new List<String>();
        }
    }
}
