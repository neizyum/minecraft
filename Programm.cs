using System.Security.Cryptography.X509Certificates;

namespace blyaaaaaaaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stak stk = new stak();
            int numnum = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < 12; i++) stk.push(rnd.Next(-54,50));
            stak sec = new stak();
            while (true)
            {
                try{
                if (stk.peak() % numnum != 0)
                {
                    sec.push(stk.peak());
                    stk.pop();
                }

                }
                catch (Exception) { break; }
            }

        }
    }
}
