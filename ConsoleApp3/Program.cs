using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

             int x=5;
             string name="ahmad";

             var y=x;
             object n=name;

             var r=y.GetType();

             Console.WriteLine("int:"+y.GetType());
             Console.WriteLine("string:" + n.GetType());

             var f=new A();
             var s=new A();

             Console.WriteLine(f==s);
             Console.WriteLine(f.Equals(s));

            string input="WWWESFRE4^'";
             string res=RemoveDuplicate(input);
             Console.WriteLine(res);
            Console.ReadKey();
        }


        public class A
        {

        }

        private static string RemoveDuplicate(string name)
        {
           
            List<char> list=new List<char>();
            string result="";
            StringBuilder b=new StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                if (!list.Contains(name[i]))
                {
                    list.Add(name[i]);
                    b.Append(name[i]);
                }
               
            }

            return b.ToString();
        }
    }
}
