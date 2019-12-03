using System;
using System.Collections.Generic;
using System.Text;
using PlantTree.tree;

namespace PlantTree
{
    class People
    {
        public string Name { get; set; }
        public int haveEnergy { get; set; }
        public void Plant<T>(T tree)where T:TreeBase
        {
            if (haveEnergy>=tree.needEnergy())
            {
                haveEnergy = haveEnergy - tree.needEnergy();
                Console.WriteLine("恭喜"+this.Name+"种植成功一颗："+tree.treeName());
            }
            else
            {
                Console.WriteLine("很抱歉，你的能量不足！！！无法种植"+tree.treeName());
            }
        }
    }
}
