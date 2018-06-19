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

            Strukturka zero1 = new Strukturka();
            Strukturka jeden1 = new Strukturka();
            Strukturka dwa1 = new Strukturka();
            Strukturka trzy1 = new Strukturka();
            Strukturka cztery1 = new Strukturka();
            Strukturka piec1 = new Strukturka();
            Strukturka szesc1 = new Strukturka();
            Strukturka siedem1 = new Strukturka();
            Strukturka osiem1 = new Strukturka();
            Strukturka dziewiec1 = new Strukturka();

            Strukturka kropka = new Strukturka();
            Strukturka mnoz = new Strukturka();
            Strukturka dziel = new Strukturka();
            Strukturka dodaw = new Strukturka();
            Strukturka odej = new Strukturka();
            Strukturka pot = new Strukturka();

            Strukturka mnoz1 = new Strukturka();
            Strukturka dziel1 = new Strukturka();
            Strukturka dodaw1 = new Strukturka();
            Strukturka odej1 = new Strukturka();
            Strukturka pot1 = new Strukturka();

            Strukturka srednik = new Strukturka();
            Strukturka pusty = new Strukturka();
            Strukturka error = new Strukturka();

            S.InitStrukturka(nawO, nawO, '\n');
            nawO.InitStrukturka(zero, zero, '(');
            nawZ.InitStrukturka(mnoz, mnoz1, ')');

            zero.InitStrukturka(kropka, jeden, '0');
            jeden.InitStrukturka(kropka, dwa, '1');
            dwa.InitStrukturka(kropka, trzy, '2');
            trzy.InitStrukturka(kropka, cztery, '3');
            cztery.InitStrukturka(kropka, piec, '4');
            piec.InitStrukturka(kropka, szesc, '5');
            szesc.InitStrukturka(kropka, siedem, '6');
            siedem.InitStrukturka(kropka, osiem, '7');
            osiem.InitStrukturka(kropka, dziewiec, '8');
            dziewiec.InitStrukturka(kropka, null, '9');

            zero1.InitStrukturka(srednik, jeden1, '0');
            jeden1.InitStrukturka(srednik, dwa1, '1');
            dwa1.InitStrukturka(srednik, trzy1, '2');
            trzy1.InitStrukturka(srednik, cztery1, '3');
            cztery1.InitStrukturka(srednik, piec1, '4');
            piec1.InitStrukturka(srednik, szesc1, '5');
            szesc1.InitStrukturka(srednik, siedem1, '6');
            siedem1.InitStrukturka(srednik, osiem1, '7');
            osiem1.InitStrukturka(srednik, dziewiec1, '8');
            dziewiec1.InitStrukturka(srednik, null, '9');

            mnoz.InitStrukturka(nawO, dziel, '*');
            dziel.InitStrukturka(nawO, dodaw, ':');
            dodaw.InitStrukturka(nawO, odej, '+');
            odej.InitStrukturka(nawO, pot, '-');
            pot.InitStrukturka(nawO, nawZ, '^');

            mnoz1.InitStrukturka(nawO, dziel1, '*');
            dziel1.InitStrukturka(nawO, dodaw1, ':');
            dodaw1.InitStrukturka(nawO, odej1, '+');
            odej1.InitStrukturka(nawO, pot1, '-');
            pot1.InitStrukturka(nawO, zero, '^');

            srednik.InitStrukturka(nawO, mnoz, ';');
            kropka.InitStrukturka(zero1, srednik, '.');
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
