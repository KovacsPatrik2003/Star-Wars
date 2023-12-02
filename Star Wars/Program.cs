using System;
using System.Collections.Generic;
using System.Linq;

namespace Star_Wars
{
    public enum AirplaneCategory
    {
        vadaszgep,
        felderito,
        lopakodo,
        bombazo,
        csatahajo
    }
    class Program
    {
        static public List<double> AirPlaneList;
        static void Main(string[] args)
        {
            
            Random random = new Random();
            BinaryTree<Urhajo> tree = new BinaryTree<Urhajo>();
            tree.eventHandler += Tree_eventHandler;
            AirPlaneList = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                int r=random.Next(1, 40);
                int r2=random.Next(1, 40);
                int r3 = random.Next(0, 5);
                Urhajo seged = new Urhajo(r, r2, (AirplaneCategory)r3);
                //Console.WriteLine($"{seged.Koltseg}, {seged.HarciEro}, {seged.Airplane}");
                tree.Add(seged);

            }
            Console.WriteLine("Enter the king's budget: ");
            int maxCost = int.Parse(Console.ReadLine());
            Console.WriteLine("The king's max budget for the army is : "+maxCost);
            tree.InOrder();
            
            AirPlaneList.Sort();
            AirPlaneList.Reverse();
            //foreach (var item in AirPlaneList)
            //{
            //    Console.WriteLine($"{Math.Round(item, 2)}");
            //}
            Webshop ws = new Webshop(AirPlaneList);
            List<Urhajo> outputs = ws.Optimalization(tree, maxCost);
            Console.WriteLine();
            foreach (var item in outputs)
            {
                Console.WriteLine($"{item.Koltseg}, {item.HarciEro}, {item.Airplane}");
            }
            List<Urhajo> h = new List<Urhajo>();
            tree.MakeList(ref h);
            Console.ReadKey();
            List<Urhajo> result = ws.Shopping(h,maxCost);
            Console.WriteLine("Your items: ");
            for (int i = 0; i < result.Count(); i++)
            {
                Console.WriteLine(result[i].Airplane);
            }
            
        }
        private static void Tree_eventHandler(Urhajo value)
        {
            
            Console.WriteLine($"{value.Koltseg}, {value.HarciEro}, {value.Airplane}, {AirPlaneList.Count()}");
            double a=(double)value.HarciEro  / value.Koltseg;
            AirPlaneList.Add(a);
        }
    }
}
