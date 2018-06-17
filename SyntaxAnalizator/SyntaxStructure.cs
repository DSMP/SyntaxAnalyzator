using System;

namespace SyntaxAnalizator
{
    public class SyntaxStructure
    {
        static public int _iterator = 0;
        static public char[] Syntax { get; private set; }
        public Strukturka Head { get; private set; }
        public SyntaxStructure(char[] syntax)
        {
            Strukturka S = new Strukturka();
            Strukturka nawO = new Strukturka();
            Strukturka nawZ = new Strukturka();
            Strukturka zero = new Strukturka();
            Strukturka jeden = new Strukturka();
            Strukturka dwa = new Strukturka();
            Strukturka trzy = new Strukturka();
            Strukturka cztery = new Strukturka();
            Strukturka piec = new Strukturka();
            Strukturka szesc = new Strukturka();
            Strukturka siedem = new Strukturka();
            Strukturka osiem = new Strukturka();
            Strukturka dziewiec = new Strukturka();
            Strukturka kropka = new Strukturka();
            Strukturka mnoz = new Strukturka();
            Strukturka dziel = new Strukturka();
            Strukturka dodaw = new Strukturka();
            Strukturka odej = new Strukturka();
            Strukturka pot = new Strukturka();
            Strukturka srednik = new Strukturka();
            Strukturka pusty = new Strukturka();
            Strukturka error = new Strukturka();

            S.InitStrukturka(nawO, nawO, '\n');
            nawO.InitStrukturka(zero, zero, '(');
            nawZ.InitStrukturka(mnoz, pusty, ')');
            zero.InitStrukturka(kropka, jeden, '0');
            jeden.InitStrukturka(kropka, dwa, '1');
            dwa.InitStrukturka(kropka, trzy, '2');
            trzy.InitStrukturka(kropka, cztery, '3');
            cztery.InitStrukturka(kropka, piec, '4');
            piec.InitStrukturka(kropka, szesc, '5');
            szesc.InitStrukturka(kropka, siedem, '6');
            siedem.InitStrukturka(kropka, osiem, '7');
            osiem.InitStrukturka(kropka, dziewiec, '8');
            dziewiec.InitStrukturka(kropka, mnoz, '9');
            mnoz.InitStrukturka(nawO, dziel, '*');
            dziel.InitStrukturka(nawO, dodaw, ':');
            dodaw.InitStrukturka(nawO, odej, '+');
            odej.InitStrukturka(nawO, pot, '-');
            pot.InitStrukturka(nawO, srednik, '^');
            srednik.InitStrukturka(nawO, nawZ, ';');
            kropka.InitStrukturka(nawO, zero, '.');
            pusty.InitStrukturka(null, error, 'E');
            error.InitStrukturka(null, null, '@');
            Syntax = syntax;
            Head = S;
        }
        public class Strukturka
        {
            public void InitStrukturka(Strukturka strukYes, Strukturka strukNo, char value)
            {
                _yes = strukYes;
                _no = strukNo;
                Value = value;
            }
            public Strukturka Next()
            {
                char value = Syntax[_iterator];
                if (Value == value)
                {
                    Console.WriteLine(Value);
                    _iterator++;
                    return _yes;
                }
                else
                {
                    return _no;
                }
            }
            Strukturka _yes;
            Strukturka _no;
            public char Value { get; private set; }
        }
    }
}
