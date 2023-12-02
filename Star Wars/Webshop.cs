using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars
{
    class Webshop
    {
        List<double> rates = new List<double>();
        public List<double> Rates
        {
            get
            {
                return rates;
            }
            set
            {
                rates = value;
            }
        }
        
        public Webshop(List<double> rates)
        {
            this.Rates = rates;
        }
        public List<Urhajo> Optimalization(BinaryTree<Urhajo> tree,int maxCost)
        {
            List<Urhajo> list=new List<Urhajo>();
            tree.MakeList(ref list);
            List<Urhajo> output=new List<Urhajo>();
            for (int i = 0; i < rates.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (rates[i] == (double)list[j].HarciEro / list[j].Koltseg)
                    {
                        if (maxCost >= list[j].Koltseg)
                        {
                            
                            output.Add(list[j]);
                            maxCost-=list[j].Koltseg;
                        }
                    }
                }
            }
            return output;
        }
        public List<Urhajo> Shopping(List<Urhajo> list, int maxCost)
        {
            List<Urhajo> result = new List<Urhajo>();
            string answer=String.Empty;
            
            do
            {
                Console.Clear();
                Console.WriteLine("Your budget: " + maxCost);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{list[i].Koltseg}, {list[i].HarciEro}, {list[i].Airplane}, {i}");
                }
                Console.WriteLine("Enter the number of item you want: ");
                int number = int.Parse(Console.ReadLine());
                if (list[number].Koltseg <= maxCost)
                {
                    result.Add(list[number]);
                    maxCost -= list[number].Koltseg;
                    
                }
                else
                {
                    Console.WriteLine("You do not have enough money.");
                }
                Console.WriteLine("Do you want buy more item? (y/n)");
                answer = Console.ReadLine();
            } while (answer=="y");
            return result;
        }
    }
}
