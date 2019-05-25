using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp202
{
    class Program
    {
        static bool skobi(string n)
        {
            int duljinata = n.Length;
            if (duljinata % 2 == 1)

            {
                return false;
            }
            else
            {
                if (n.Substring(0, 1) != "(")

                {
                    return false;
                }
                else if (n.Substring(duljinata - 1, 1) != ")")

                {
                    return false;
                }
                else
                {
                    int broi = 0;
                    char skoba = '(';
                    foreach (char c in n)
                    {
                        if (c == skoba)
                        {
                            broi++;
                        }
                    }
                    int broi2 = 0;
                    skoba = ')';
                    foreach (char c in n)
                    {
                        if (c == skoba)
                        {
                            broi2++;
                        }
                    }
                    if (broi == broi2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi izrechenie sus skobi: ");
            string skobite = Console.ReadLine();
            Console.WriteLine(skobi(skobite));
            Console.ReadLine();
        }
    }
}
