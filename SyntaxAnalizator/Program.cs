using System;
using static SyntaxAnalizator.SyntaxStructure;

namespace SyntaxAnalizator
{
    class Program
    {
        static void Main(string[] args)
        {
            SyntaxStructure syntaxStructure = new SyntaxStructure("(1.2*3)+5-(23.4+3)^3;8:13;".ToCharArray());
            var head = syntaxStructure.Head;
            int i = 0;
            try
            {
                while (SyntaxStructure._iterator != SyntaxStructure.Syntax.Length - 1)
                {
                    head = head.Next();
                    Console.WriteLine(i++ + " " + SyntaxStructure._iterator + " " + head.Value.ToString() + " " + SyntaxStructure.Syntax[SyntaxStructure._iterator]);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Składnia jest nie poprawna, na pozycji {0} wystąpił nie poprawny symbol: \"{1}\"", SyntaxStructure._iterator, SyntaxStructure.Syntax[SyntaxStructure._iterator]);
                return;
            }
            Console.WriteLine("składnia jest poprawna");
        }
    }
}
