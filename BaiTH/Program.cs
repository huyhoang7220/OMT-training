using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH
{
    class Program
    {

        static void Main(string[] args)
        {
            string s;
            do
            {
                Console.WriteLine("Nhap s :");
                s = Console.ReadLine().Trim();
            } while (s.Length < 1);

            s = s.Trim();
            bool x = false;
            if (s.Contains(" "))
            {
                x = true;
            }
            List<string> termsList = new List<string>();
            int first = s.IndexOf(" ");
            for (int i = 0; i <= s.Length - 1; i++)
            {
                s = s.Replace(" ", "");
            }
            if (x == true)
            {
                s = s.Substring(0, first) + " " + s.Substring(first);
            }


            char[] SubName = s.ToCharArray();
            for (int i = 0; i <= SubName.Length - 1; i++)
            {

                if (i == SubName.Length - 1 && (SubName.Length - 1) % 2 == 0)
                {
                    termsList.Add(SubName[i] + "" + "_");

                }
                else
                {
                    termsList.Add(SubName[i] + "" + SubName[i + 1]);
                    i = i + 1;

                }
            }
            Console.WriteLine("[" + string.Join(",", termsList) + "]");
            Console.ReadLine();
        }
    }
}