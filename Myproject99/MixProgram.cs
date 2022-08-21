using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject99       /*abstract class method*/
{
    abstract class Animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("hmm");

        }
    }
    class Cow : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("the cow say:hmma");
        }

    }
    class mixprogram
    {
        static void Main(string[] args)
        {
            Cow mycow = new Cow();
            mycow.animalsound();
            mycow.sleep();
        }
    }

    interface IAnimals               /*Interface method with single child*/
    {
        void animaalsound();

    }
    class Coww : IAnimals
    {
        public void animaalsound()
        {
            Console.WriteLine("the cow says:hmaa");
        }
    }
    class Progrmainter
    {
        static void Main(string[] args)
        {
            Coww m = new Coww();
            m.animaalsound();


        }
    }

    interface Cake                        /*Interface method with multiple  child*/
    {
        void cakebake();
    }
    class Strawberry : Cake
    {
        public void cakebake()
        {
            Console.WriteLine("the strawberry is red");
        }
    }
    class Blackforrest : Cake
    {
        public void cakebake()
        {
            Console.WriteLine("the blackforrest is black");
        }
    }
    class Programfood
    {
        static void Main(string[] args)
        {
            Cake ck;
            ck = new Strawberry();
            ck.cakebake();
            ck = new Blackforrest();
            ck.cakebake();

        }
    }




    class OverDdemo                    /* Overloading method demo with dif varible and change in signature(parameter)*/
    {
        public static int mulDisplay(int one, int two)
        {
            return one * two;
        }
        public static int mulDisplay(int one, int two, int three)
        {
            return one * two * three;

        }
        public static int mulDisplay(int one, int two, int three, int four)
        {
            return one * two * three * four;
        }

    }
    class Programo
    {
        public static void Main()
        {
            OverDdemo m = new OverDdemo();
            Console.WriteLine("mul of two num" + OverDdemo.mulDisplay(12, 7));
            Console.WriteLine("mul of three num" + OverDdemo.mulDisplay(3, 12, 4));
            Console.WriteLine("mul of four num" + OverDdemo.mulDisplay(7, 8, 5, 4));
        }

    }
    class Prrogram
    {
        public void display(int a)
        {
            Console.WriteLine("argument " + a);
        }
        public void display(int a, int b)
        {
            Console.WriteLine("argument" + a + "and" + b);

        }
        class argue
        {
            static void Main(string[] args)
            {
                Prrogram p = new Prrogram();
                p.display(122);
                p.display(12, 44);

            }
        }
    }
    class Cfg
    {
        public int add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public double add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
    }
    class Cfgee
    {
        static void Main(string[] args)
        {
            Cfg ob = new Cfg();
            int sum2 = ob.add(1, 3, 5);
            Console.WriteLine("sum of three int " + sum2);
            double sum3 = ob.add(2.2, 4.2, 5.2);
            Console.WriteLine("sum of three double " + sum3);

        }
    }
    class Baseclass                  /* Override method demo started */
    {
        public virtual void gfg()
        {
            Console.WriteLine("Base class");
        }
    }
    class Derivedclass : Baseclass
    {
        public override void gfg()
        {
            Console.WriteLine("derived class");
        }
    }
     class Rj
     {
        static void Main(string[] args)
        {
        Derivedclass d = new Derivedclass();
        d.gfg();
            
        }
     }
    class Parrent
    {

        public virtual void add(int a, int b)
        {
            int sum = a+b ;
            Console.WriteLine("summ"+sum );
        }
    }
    class Child:Parrent
    {
        public override void add(int a, int b) 
        {
            int  sum = a + b;
            Console.WriteLine("sum"+sum );
        }
    }
    class Fam
    {
        static void Main(string[] args)
        {
            Child b = new Child();
            b.add(3, 4);
            Parrent p = new Child();
            p.add(3, 6);

        }
    }
    class Employee
    {
        private int id;
        private String name;
       
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 100;
            int eid = e.Id;
            Console.WriteLine(eid );
            e.Name = "Anil";
            Console.WriteLine(e.Name);
        }
    }
    





    class Array4                    /*Demo of Array*/
    {
        static void Main(string []args)
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 5, 1 } };
            for (int i=0;i<a.GetLength(0);i++)
            {
                int sum = 0;
                int j;
                for (j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                    Console.WriteLine(a[i, j] + " ");

                }
                Console.WriteLine("sum=" + sum);
                Console.WriteLine();

            }
        }
        /*class Nodublicate
        {
            static void Main(string[] args)
            {
                int[] arr = { 9, 4, 9, 6 };
                int n = arr.Length;
            }
            static int firstRepeat(int []arr,int n)
            {
                for (int i=0;i<n;i++)
                {
                    int j;
                    for (j = 0; j < n; j++)
                        if (i != j && arr[i] == arr[j])
                            break;
                    if (j == n)
                        return arr[i];
                }
                return-1
            }
            Console.WriteLine(firstRepeat();
        }*/

    }

    class SortArray
    {
        private static int j;

        static void Main(string[] args)
        {
            char[] a = { 'z', 'n', 'a', 'q', 'u', 'o', 'z' };
            for (int i = 0; i < a.Length; i++)
            {
                for (j = i+1; j <a.Length; j++)
                {
                    if (a[i]>a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));

        }
    }
    class Aanagram
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] a1 = input1.ToLower().ToCharArray();
            char[] a2 = input2.ToLower().ToCharArray();

            Array.Sort(a1);
            Array.Sort(a2);

            string s1 = new string(a1);
            string s2 = new string(a2);

            if (s1==s2)
            {
                Console.WriteLine("anagram");

            }
            else
            {
                Console.WriteLine("not Anagram");
            }

        }
    }
    class duplicatechar
    {
        static void Main(string[] args)
        {
            string str = "Great responsibility";
            int count;
            char [] string1 = str.ToCharArray();
            Console.WriteLine("duplicate char in string ");
            for (int i=0;i< string1.Length;i++)
            {
                count = 1;
                for (int j=i+1;j<string1.Length;j++)
                {
                    if (string1[i]==string1[j]&&string1[i]!='0')
                    {
                        count++;
                        string1[j] = '0';

                    }
                }
                if (count>1&& string1  [i]!='0')
                    Console.WriteLine(string1 [i]);
            }
        }
    }
}
