using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using System.IO;
using System.Collections.Generic;
using Terraria.ID;

namespace DictionaryOfPrefixes.Prefixes
{
    public class AcsT2Prefix : ModPrefix
    {
        Mod calamityMod = ModLoader.GetMod("CalamityMod");

        private int rangedDamage;
        private int minionDamage;
        private int meleeDamage;
        private int magicDamage;
        private int meleeCrit;
        private int rangedCrit;
        private int magicCrit;
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

        public AcsT2Prefix()
        {
        }

        public AcsT2Prefix(int rangedDamage, int minionDamage, int meleeDamage, int magicDamage, int meleeCrit, int rangedCrit, int magicCrit, int tier)
        {

            this.rangedDamage = rangedDamage;
            this.minionDamage = minionDamage;
            this.meleeDamage = meleeDamage;
            this.magicDamage = magicDamage;
            this.meleeCrit = meleeCrit;
            this.rangedCrit = rangedCrit;
            this.magicCrit = magicCrit;
            this.tier = tier;

        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                mod.AddPrefix("Ethereal", new AcsT2Prefix(0, 0, 0, 5, 0, 0, 0, 4));
                mod.AddPrefix("Mundane", new AcsT2Prefix(0, 0, 0, -3, 0, 0, 0, -2));
                mod.AddPrefix("Reigning", new AcsT2Prefix(0, 4, 0, 0, 0, 0, 0, 3));
                mod.AddPrefix("Reverent", new AcsT2Prefix(0, 3, 0, 0, 0, 0, 0, 2));
                mod.AddPrefix("Dominating", new AcsT2Prefix(0, 5, 0, 0, 0, 0, 0, 4));
                mod.AddPrefix("Brave", new AcsT2Prefix(0, 0, 4, 0, 0, 0, 0, 3));
                mod.AddPrefix("Heroic", new AcsT2Prefix(0, 0, 5, 0, 0, 0, 0, 4));
                mod.AddPrefix("Chivalrous", new AcsT2Prefix(0, 0, 3, 0, 0, 0, 0, 2));
                mod.AddPrefix("Notorious", new AcsT2Prefix(0, -3, 0, 0, 0, 0, 0, -2));
                mod.AddPrefix("Repulsive", new AcsT2Prefix(0, -5, 0, 0, 0, 0, 0, -4));
                mod.AddPrefix("Cowardly", new AcsT2Prefix(0, 0, -5, 0, 0, 0, 0, -4));
                mod.AddPrefix("Timid", new AcsT2Prefix(0, 0, -3, 0, 0, 0, 0, -2));
                mod.AddPrefix("Honoring", new AcsT2Prefix(5, 0, 0, 0, 0, 0, 0, 4));
                mod.AddPrefix("Tactical", new AcsT2Prefix(4, 0, 0, 0, 0, 0, 0, 3));
                mod.AddPrefix("Uniform", new AcsT2Prefix(2, 0, 0, 0, 0, 0, 0, 1));
                mod.AddPrefix("Soldierly", new AcsT2Prefix(3, 0, 0, 0, 0, 0, 0, 2));
                mod.AddPrefix("Fabled", new AcsT2Prefix(0, 0, 0, 4, 0, 0, 0, 3));
                mod.AddPrefix("Peculiar", new AcsT2Prefix(0, 0, 0, 2, 0, 0, 0, 1));
                mod.AddPrefix("Lax", new AcsT2Prefix(-3, 0, 0, 0, 0, 0, 0, -2));
                mod.AddPrefix("Naive", new AcsT2Prefix(-5, 0, 0, 0, 0, 0, 0, -4));
                if (calamityMod != null)
                {
                    mod.AddPrefix("Ballistic", new AcsT2Prefix(0, 0, 0, 0, 0, 4, 0, 4));
                    mod.AddPrefix("Militant", new AcsT2Prefix(0, 0, 0, 0, 0, 2, 0, 2));
                    mod.AddPrefix("Bewitched", new AcsT2Prefix(0, 0, 0, 0, 0, 0, 4, 4));
                    mod.AddPrefix("Enchanted", new AcsT2Prefix(0, 0, 0, 0, 0, 0, 2, 2));
                    mod.AddPrefix("Vengeful", new AcsT2Prefix(0, 0, 0, 0, 4, 0, 0, 4));
                    mod.AddPrefix("Defiant", new AcsT2Prefix(0, 0, 0, 0, 2, 0, 0, 2));
                }
                else
                {
                    mod.AddPrefix("Ballistic", new AcsT2Prefix(0, 0, 0, 0, 0, 5, 0, 4));
                    mod.AddPrefix("Militant", new AcsT2Prefix(0, 0, 0, 0, 0, 3, 0, 2));
                    mod.AddPrefix("Bewitched", new AcsT2Prefix(0, 0, 0, 0, 0, 0, 5, 4));
                    mod.AddPrefix("Enchanted", new AcsT2Prefix(0, 0, 0, 0, 0, 0, 3, 2));
                    mod.AddPrefix("Vengeful", new AcsT2Prefix(0, 0, 0, 0, 5, 0, 0, 4));
                    mod.AddPrefix("Defiant", new AcsT2Prefix(0, 0, 0, 0, 3, 0, 0, 2));
                }
            }
            return false;
        }
        public override void Apply(Item item)
        {

            item.GetGlobalItem<AEUpdate2>().rangedDamage = rangedDamage;
            item.GetGlobalItem<AEUpdate2>().minionDamage = minionDamage;
            item.GetGlobalItem<AEUpdate2>().meleeDamage = meleeDamage;
            item.GetGlobalItem<AEUpdate2>().magicDamage = magicDamage;
            item.GetGlobalItem<AEUpdate2>().meleeCrit = meleeCrit;
            item.GetGlobalItem<AEUpdate2>().rangedCrit = rangedCrit;
            item.GetGlobalItem<AEUpdate2>().magicCrit = magicCrit;
        }
        public override void ModifyValue(ref float valueMult)
        {
            float multiplier = 1f * (1 + tier * 0.05f);
            valueMult *= multiplier;
        }
    }
}