using System;

namespace SyntaxAnalizator
{
    public class SyntaxStructure
    {
        public int _iterator = 0;
        public char[] Syntax { get; private set; }
        public SyntaxStructure(char[] syntax)
        {
            Strukturka S, nawO, nawZ, zero, jeden, dwa, trzy, cztery, piec, szesc, siedem, osiem, dziewiec, kropka, mnoz, dziel, dodaw, odej, pot, srednik, pusty;
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
            mnoz.InitStrukturka(zero, dziel, '*');
            dziel.InitStrukturka(zero, dodaw, ':');
            dodaw.InitStrukturka(zero, odej, '+');
            odej.InitStrukturka(zero, pot, '-');
            pot.InitStrukturka(zero, srednik, '^');
            srednik.InitStrukturka(pusty, nawZ, ';');
            Syntax = syntax;
        }
        struct Strukturka
        {
            public void InitStrukturka(Strukturka strukYes, Strukturka strukNo, char value)
            {
                _yes = strukYes;
                _no = strukNo;
                _value = value;
            }
            public Strukturka Next()
            {
                char value = Syntax[_iterator];
                if (_value == value)
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
            char _value;
        }
    }
}
