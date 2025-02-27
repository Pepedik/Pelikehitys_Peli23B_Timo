using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;

namespace Seikkailijanreppu
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Reppu Inv = new Reppu(30, new Vector2(20), 10);
            while (true)
            {
                Console.WriteLine("The backpack contains at the moment " +  " Weight limit 30 Current: " + Inv.Weight + " Space limit 20 current: " + Inv.Space + " items limit 10 current: " + Inv.Item );
                Console.WriteLine("What do you want to add to inventory?");
                string[] Names = { "Arrow", "Sword", "Rope", "Bow", "water", "Food" };
                for (int i = 0; i < Names.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {Names[i]}");
                }
                
                string Answer = Console.ReadLine();
                Items Added = null;
                switch (Answer)
                {
                    case "1":Added = new Arrow("Chickenfeather", "Diamond"); break;
                    case "2":Added = new Sword(30); break;
                    case "3":Added = new Rope(10); break;
                    case "4":Added = new Bow(15); break;                    
                    case "5":Added = new water(15); break;                    
                    case "6":Added = new Food(15); break;
                }
                
                Console.WriteLine("You chose: " + Answer);
                Inv.Add(Added);
            }
        }
    }

    class Reppu
    {
        public bool Add(Items newitems)
        {
            if (Weight + newitems.weight < WeightLimit)
            {
                Inventory.Add(newitems);
                Weight += newitems.weight;
                Item += 1;
                Space += newitems.size;
                return true;
            }
            return false;
        }
        List<Items> Inventory;

        public float Weight { get; private set; } = 0;
        public float Space { get; private set; } = 0;

        public float Item { get; private set; } = 0;
        public float WeightLimit { get; private set; }
        public Vector2 SpaceLimit { get; private set; }
        public float ItemLimit { get; private set; }

        public Reppu(float WeightLimit, Vector2 SpaceLimit, float ItemLimit)
        {
            this.WeightLimit = WeightLimit;
            this.SpaceLimit = SpaceLimit;
            this.ItemLimit = ItemLimit;
            Inventory = new List<Items>();
        }
    }
}
