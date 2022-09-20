using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Interfaces
{
    public interface IAttributes
    {   // Character attribute functionality
        string Name { get;  set; }
        string Description { get;  set; }
        int Level { get;  set; }
        int HP { get;  set; }
        int MP { get;  set; }
        int MAXHP { get;  set; }
        int MAXMP { get;  set; }
        string Weapon { get;  set; }
        int WeaponAtk { get;  set; }
        string Armor { get;  set; }
        int ArmorDef { get;  set; }
        string[] Spells { get;  set; }
        int[] SpellDamage { get;  set; }
        int Gold { get;  set; }
        List<string> Inventory { get;  set; }

    }// end attribute interface
}
