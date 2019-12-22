using System;
using PlantTree.tree;

namespace PlantTree
{
    class Program
    {
        static void Main(string[] args)
        {
            People wangxin = new People { Name = "王新", haveEnergy = 20000 };
            People yefei = new People { Name = "叶飞", haveEnergy = 50000 };

            wangxin.Plant(new JunJunTree());
            wangxin.Plant(new SuoSuoTree());
            Console.WriteLine(wangxin.haveEnergy);

            yefei.Plant(new JunJunTree());
            yefei.Plant(new SuoSuoTree());
            Console.WriteLine(yefei.haveEnergy);

            Console.ReadLine();
        }
    }
}
