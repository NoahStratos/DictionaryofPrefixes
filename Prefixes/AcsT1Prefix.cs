using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using System.IO;
using System.Collections.Generic;
using Terraria.ID;
using DictionaryOfPrefixes;

namespace DictionaryOfPrefixes.Prefixes
{
    public class AcsT1Prefix : ModPrefix
    {
        Mod calamityMod = ModLoader.GetMod("CalamityMod");

        private int damage;
        private int crit;
        private int moveSpeed;
        private int meleeSpeed;
        private int defense;
        private int statManaMax2;
        private float endurance;
        private int tier;
        
        public override float RollChance(Item item)
        {
            return 1f;
        }
        public override bool CanRoll(Item item)
        {
            return true;
        }
        public override PrefixCategory Category { get { return PrefixCategory.Accessory; } }

        public AcsT1Prefix()
        {
        }

        public AcsT1Prefix(int damage, int crit, int moveSpeed, int meleeSpeed, int defense, int statManaMax2, float endurance, int tier)
        {

            this.damage = damage;
            this.crit = crit;
            this.moveSpeed = moveSpeed;
            this.meleeSpeed = meleeSpeed;
            this.defense = defense;
            this.statManaMax2 = statManaMax2;
            this.endurance = endurance;
            this.tier = tier;

        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                mod.AddPrefix("Enraged", new AcsT1Prefix(5, 0, 0, 0, 0, 0, 0, 5));
                mod.AddPrefix("Berserk", new AcsT1Prefix(0, 0, 0, 5, 0, 0, 0, 5));
                mod.AddPrefix("Wimpy", new AcsT1Prefix(-2, 0, 0, 0, 0, 0, 0, -2));
                mod.AddPrefix("Puny", new AcsT1Prefix(-4, 0, 0, 0, 0, 0, 0, -4));
                mod.AddPrefix("Unwieldy", new AcsT1Prefix(0, 0, 0, -2, 0, 0, 0, -2));
                mod.AddPrefix("Clumsy", new AcsT1Prefix(0, 0, 0, -4, 0, 0, 0, -4));
                mod.AddPrefix("Fragile", new AcsT1Prefix(0, 0, 0, 0, -4, 0, 0, -4));
                mod.AddPrefix("Yielding", new AcsT1Prefix(0, 0, 0, 0, -2, 0, 0, -2));
                mod.AddPrefix("Slothful", new AcsT1Prefix(0, 0, -4, 0, 0, 0, 0, -4));
                mod.AddPrefix("Tired", new AcsT1Prefix(0, 0, -2, 0, 0, 0, 0, -2));
                mod.AddPrefix("Mysterious", new AcsT1Prefix(0, 0, 0, 0, 0, 40, 0, 5));
                if (calamityMod != null)
                {
                    if (NPC.downedMoonlord)
                    {
                        mod.AddPrefix("Sturdy", new AcsT1Prefix(0, 0, 0, 0, 10, 0, 1.25f, 5));
                    }
                    else if (Main.hardMode)
                    {
                        mod.AddPrefix("Sturdy", new AcsT1Prefix(0, 0, 0, 0, 7, 0, 1.25f, 5));
                    }
                    else
                    {
                        mod.AddPrefix("Sturdy", new AcsT1Prefix(0, 0, 0, 0, 5, 0, 1.25f, 5));
                    }
                    mod.AddPrefix("Endurable", new AcsT1Prefix(0, 0, 0, 0, 0, 0, 2, 4));
                }
                else
                {
                    mod.AddPrefix("Sturdy", new AcsT1Prefix(0, 0, 0, 0, 5, 0, 0, 5));
                    mod.AddPrefix("Endurable", new AcsT1Prefix(0, 0, 0, 0, 0, 0, 1, 4));
                }
            }
            return false;
        }
        public override void Apply(Item item)
        {

            item.GetGlobalItem<AEUpdate1>().damage = damage;
            item.GetGlobalItem<AEUpdate1>().crit = crit;
            item.GetGlobalItem<AEUpdate1>().moveSpeed = moveSpeed;
            item.GetGlobalItem<AEUpdate1>().meleeSpeed = meleeSpeed;
            item.GetGlobalItem<AEUpdate1>().defense = defense;
            item.GetGlobalItem<AEUpdate1>().statManaMax2 = statManaMax2;
            item.GetGlobalItem<AEUpdate1>().endurance = endurance;
        }
        public override void ModifyValue(ref float valueMult)
        {
            float multiplier = 1f * (1 + tier * 0.05f);
            valueMult *= multiplier;
        }
    }
}