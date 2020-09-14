using System;
public delegate void TikHandler(Object sender);
public delegate void TokHandler(Object sneder);
class clock
{
    public event TikHandler onTik;
    public event TokHandler onTok;
    public void tik()
    {
        onTik(this);
    }
    public void tok()
    {
        onTok(this);
    }

}
namespace w2q4
{
    class Program
    {
        static void showTik(Object clk)
        {
            Console.WriteLine("Tik");
            return;
        }
        static void showTok(Object clk)
        {
            Console.WriteLine("Tok");
            return;
        }
        static void Main(string[] args)
        {
            clock myClock = new clock();
            myClock.onTik += new TikHandler(showTik);
            myClock.onTok += new TokHandler(showTok);
            myClock.tik();
            myClock.tok();
        }
    }
}
