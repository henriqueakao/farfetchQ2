using System;

namespace farfetchQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira palavra: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra: ");
            string s2 = Console.ReadLine();


            Boolean b = AnagramCheck(s1, s2);

            if(b == true)
            {
                Console.WriteLine("As palavras são anagramas!");
            }
            else
            {
                Console.WriteLine("As palavras não são anagramas!");
            }
        }

        public static Boolean AnagramCheck(string s1, string s2)
        {
            char[] w1 = s1.ToCharArray();
            char[] w2 = s2.ToCharArray();

            Array.Sort(w1);
            Array.Sort(w2);

            if(w1.Length != w2.Length)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < w1.Length; i++)
                {
                    if(w1[i] != w2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
