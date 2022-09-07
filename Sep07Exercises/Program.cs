using Sep07;

namespace Sep07Exercises
{
    internal class Program
    {
        public delegate string stren5(string spo, string spo1);
        public delegate string stren6(string hon);
        static void Main(string[] args)
        {
            Console.WriteLine("Ques 01");
            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            strin s1 = new strin();
            stren s2 = new stren(s1.stringlen);
            s2(m);
            Console.WriteLine("Question 2");
            Console.WriteLine("Enter username");
            string g = Console.ReadLine();
            stren s3 = new stren(s1.greet);
            s3(g);
            Console.WriteLine("Question 3");
            Console.WriteLine("Enter the two numbers");
            int yu = Convert.ToInt32(Console.ReadLine());
            int uy = Convert.ToInt32(Console.ReadLine());
            integer mi = new integer();
            stren2[] d3 = new stren2[3] { mi.Add, mi.Sub, mi.Multiply };
            stren2 d4 = (stren2)MulticastDelegate.Combine(d3);
            d4(yu, uy);
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter productId and product name");
            Products mo = new Products();
            mo.PId = Convert.ToInt32(Console.ReadLine());
            mo.Name = Console.ReadLine();
            stren3 poi = new stren3(mo.Display);
            poi(mo);
            Console.WriteLine("Question 5");
            Console.WriteLine("Enter the year,Month,date");
            int yr = Convert.ToInt32(Console.ReadLine());
            int mon = Convert.ToInt32(Console.ReadLine());
            int dt = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(yr, mon, dt);
            emp.Joining = t;
            stren4 se = new stren4(emp.Expyrs);
            int poiu = se(emp.Joining);
            Console.WriteLine($"Years of exp {poiu}");
            Console.WriteLine("Question 6");
            Console.WriteLine("Enter strings to Concatenate");
            string yum = Console.ReadLine();
            string muy = Console.ReadLine();
            stren5 dpo = delegate (string so, string su)
            {
                return so + su;
            };
            string sod = dpo(yum, muy);
            Console.WriteLine($"Concatenated string is {sod}");
            Console.WriteLine("Question 7");
            Console.WriteLine("Enter the string");
            string kon = Console.ReadLine();
            stren6 df = delegate (string ki)
            {
                string p = " ";
                for (int i = 0; i < ki.Length; i++)
                {
                    if (i == 0)
                    {
                        p += char.ToUpper(ki[i]);
                    }
                    else
                    {
                        p += ki[i];
                    }
                }

                return p;
            };
            string pon = df(kon);
            Console.WriteLine($"First case upper => {pon}");
            Console.ReadLine();
        }
    }
}