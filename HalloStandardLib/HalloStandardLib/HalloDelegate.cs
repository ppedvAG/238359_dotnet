using System;
using System.Collections.Generic;
using System.Linq;

namespace HalloStandardLib
{
    delegate void EinfacherDelegate();
    delegate void DelegateMitPara(string msg);
    delegate long CalcDele(int a, int b);

    internal class HalloDelegate
    {
        public HalloDelegate()
        {
            EinfacherDelegate meinDele = EinfacheMethode;
            Action meinDeleAlsAction = EinfacheMethode;
            Action meinDeleAlsActionAno = delegate () { Console.WriteLine("Hallo Ano"); };
            Action meinDeleAlsActionAno2 = () => { Console.WriteLine("Hallo Ano"); };
            Action meinDeleAlsActionAno3 = () => Console.WriteLine("Hallo Ano");

            DelegateMitPara deleMitPara = MethodeMitPara;
            Action<string> deleMitParaAlsAction = MethodeMitPara;
            DelegateMitPara deleMitParaAno = delegate (string msg) { Console.WriteLine(msg); };
            DelegateMitPara deleMitParaAno2 = (string msg) => Console.WriteLine(msg);
            DelegateMitPara deleMitParaAno4 = (msg) => Console.WriteLine(msg);
            DelegateMitPara deleMitParaAno5 = x => Console.WriteLine(x);

            CalcDele myCalc = Multiply;
            Func<int, int, long> myCalcAlsFunc = Multiply;
            CalcDele myCalcAno = delegate (int a, int b) { return a + b; };
            CalcDele myCalcAno2 = (int a, int b) => { return a + b; };
            CalcDele myCalcAno3 = (a, b) => { return a + b; };
            CalcDele myCalcAno4 = (a, b) => a + b;

            List<string> texte = new List<string>();
            texte.Where(x => x.StartsWith("b"));
            texte.Where(Filter);

            long result = myCalc.Invoke(3, 4);
        }

        private bool Filter(string arg)
        {
            if (arg.StartsWith("b"))
                return true;
            else
                return false;
        }

        private long Multiply(int a, int b)
        {
            return a * b;
        }

        private long Sum(int a, int b)
        {
            return a + b;
        }

        public void MethodeMitPara(string txt)
        {
            Console.WriteLine("Hallo " + txt);
        }
        public void EinfacheMethode()
        {
            Console.WriteLine("Hallo");
        }
    }
}
