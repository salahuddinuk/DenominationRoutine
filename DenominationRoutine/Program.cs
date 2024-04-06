using System.Text;

namespace DenominationRoutine
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            int[] breakdown = new int[3];
            int[] denom = { 10, 50, 100 };

            Dictionary<int, string> map = new Dictionary<int, string>();

            map = GetChange(30);

            Console.WriteLine(30);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(50);
            Console.WriteLine(50);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(60);
            Console.WriteLine(60);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(80);
            Console.WriteLine(80);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(100);
            Console.WriteLine(100);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(140);
            Console.WriteLine(140);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(230);
            Console.WriteLine(230);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(370);
            Console.WriteLine(370);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(610);
            Console.WriteLine(610);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");

            map = GetChange(980);
            Console.WriteLine(980);
            foreach (var i in map)
            {
                Console.WriteLine("{0} - {1}", i.Key, i.Value);
            }
            Console.WriteLine("--------------------");
        }
        static Dictionary<int, string> GetChange(int amount)
        {
            int[] trays = new int[3] {10, 50, 100};

            Dictionary<int, string> res = new Dictionary<int, string>();
            int counter = 0;
            for (int i = 0 ;  i < trays.Length; i++)
            {
                int v = amount / trays[i];
                //int min = amount / v;
                int remainder=amount % trays[i];
                StringBuilder sb= new StringBuilder();
                if (v > 0)
                {
                    sb.Append(v.ToString() + " x " + trays[i].ToString());
                    //res.Add(counter++, trays[i].ToString() + " x " + v.ToString());

                    //if (min < amount)
                    //    sb.Append((v-1).ToString() + " x " + trays[i].ToString());

                    for (int j = 0; j < trays.Length; j++)
                    {
                        int vv = remainder / trays[j];
                        remainder = remainder % trays[j];
                        if (vv > 0)
                        {
                            sb.Append(" + ");
                            sb.Append(vv.ToString() + " x " + trays[j].ToString());
                            //res.Add(counter++, trays[j].ToString() + " x " + vv.ToString());
                        }
                    }
                }
                
                

                res.Add(counter++, sb.ToString());

                //if (trays[i] == amount)
                //    res.Add(trays[i], 1);
                //else if (trays[i] < amount)
                //    res.Add(trays[i], (trays[i]))
                //int remainder = trays[i] % amount;
                //if (remainder > 0)
                //    res.Add(trays[i], remainder);
                //else if (trays[i] == amount)
                //    res.Add(trays[i], 1);

            }
            return res;
        }
    }
    class Converter
    {
        //classs variable
        private int currency;



        public void converter(int currency, int[] breakdown, int[] denom)
        {

            int diff = currency;
            int x = 0;

            while (diff > 0)
            {
                breakdown[x] = diff / (denom[x]);
                diff = diff % denom[x];
                x++;
            }

        }

    }

}
