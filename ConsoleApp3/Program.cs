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

             var y=x;

             var r=y.GetType();

             Console.WriteLine(y.GetType());

            string name="WWWESFRE4^'";
             string res=RemoveDuplicate(name);
             Console.WriteLine(res);
            Console.ReadKey();
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
