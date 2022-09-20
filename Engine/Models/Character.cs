using Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Character : IAttributes
    {
        private string _armor, _description, _name, _weapon;
        private int _armorDef, _gold, _HP, _level, _MAXHP, _MP, _MAXMP, _weaponDMG;
        private List<string> _inventory = new List<string>();
        private int[] _spellDMG = new int[5]; // 5 total spells to account for dmg
        private string[] _spells = new string[5]; //5 total spells to account for

        public string Name { get => _name; set => _name = value; }

        public string Description { get => _description; set => _description = value; }

        public int Level { get => _level; set => _level = value; }

        public string Weapon { get => _weapon; set => _weapon = value; }

        public int WeaponAtk { get => _weaponDMG; set => _weaponDMG = value; }

        public string Armor { get => _armor; set => _armor = value; }

        public int ArmorDef { get => _armorDef; set => _armorDef = value; }

        public string[] Spells { get => _spells; set => _spells = value; }

        public int[] SpellDamage { get => _spellDMG; set => _spellDMG = value; }

        public int Gold { get => _gold; set => _gold = value; }

        public List<string> Inventory { get => _inventory; set => _inventory = value; }

        int IAttributes.HP { get => _HP; set => _HP = value; }

        int IAttributes.MP { get => _MP; set => _MP = value;}

        int IAttributes.MAXHP { get => _MAXHP; set => _MAXHP = value;}

        int IAttributes.MAXMP { get => _MAXMP; set => _MAXMP = value; }

        //---------------------------------------- //Character Creation// ----------------------------------------//

        public Character(string inName, string inDesc, string inStartingWeapon, int inWeaponAtk)
        {
            Name = inName;
            Description = inDesc;
            Weapon = inStartingWeapon;
            WeaponAtk = inWeaponAtk;

            // -- Set all values to specified inits -- // 
            ArmorDef = 0;
            Level = 1;
            _MP = 10;
            _MAXMP = 10; // to be upgraded by level factor as progress is made
            _HP = 100;
            _MAXHP = 100; // to be upgraded by level factor as progress is made
            Gold = 10; // start with 10

            // -- Set all lists to inits -- //
            List<string> tempInventory = _inventory;
            tempInventory.Add(inStartingWeapon);
            setInventory(tempInventory);

            string[] tempSpells = _spells;
            tempSpells[0] = "Self-heal"; // init beginner spell
            setSpells(tempSpells);

            int[] tempSpellDMG = _spellDMG;
            tempSpellDMG[0] = -5; // adds health -> (HP - spellDMG)
            setSpellDamage(tempSpellDMG);
        }// end user defined constructor 

        private void setSpellDamage(int[] tempSpellDMG)
        {
            throw new NotImplementedException();
        }

        private void setSpells(string[] tempSpells)
        {
            throw new NotImplementedException();
        }

        private void setInventory(List<string> tempInventory)
        {
            throw new NotImplementedException();
        }

    }// end Character class


}// end namespace
