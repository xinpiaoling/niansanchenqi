using System;
using System.Collections.Generic;
using System.Text;

namespace PlantTree.tree
{
    public abstract class TreeBase
    {
        public abstract string treeName();
        public abstract int needEnergy();
    }
    public  class SuoSuoTree:TreeBase
    {

        public override int needEnergy()
        {
            return  19224;
        }

        public override string treeName()
        {
            return "梭梭树";
        }
    }
     public  class JunJunTree :TreeBase
    {


        public override int needEnergy()
        {
            return  15023;
        }

        public override string treeName()
        {
            return "俊俊树";
        }
    }
    public class ShaShaTree : TreeBase
    {
        public override string treeName()
        {
            return "沙沙树";
        }
        public override int needEnergy()
        {
            return 11566;
        }

    }
}
