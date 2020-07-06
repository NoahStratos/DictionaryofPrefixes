using System.Collections.Generic;
using Terraria.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace DictionaryOfPrefixes.Prefixes
{
    public class UniversalPrefix : ModPrefix
    {
        internal static List<byte> UniversalPrefixes = new List<byte>();
        internal int critBonus = 0;
        internal float damageMult = 1f;
        internal float knockbackMult = 1f;

        public override PrefixCategory Category { get { return PrefixCategory.AnyWeapon;} }

        public UniversalPrefix() { }

        public UniversalPrefix(float damageMult = 1f, float knockbackMult = 1f, int critBonus = 0)
        {
            this.damageMult = damageMult;
            this.knockbackMult = knockbackMult;
            this.critBonus = critBonus;
        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                AddUniversalPrefix(mod, UniversalPrefixType.Brutal, 1.0f, 0.9f, 8);
                AddUniversalPrefix(mod, UniversalPrefixType.Cruel, 1.15f, 1.0f, 0);
                AddUniversalPrefix(mod, UniversalPrefixType.Dreadful, 0.82f, 0.9f, 0);
                AddUniversalPrefix(mod, UniversalPrefixType.Serious, 1.1f, 1.0f, 7);
                AddUniversalPrefix(mod, UniversalPrefixType.Wretched, 0.85f, 0.7f, 0);
                AddUniversalPrefix(mod, UniversalPrefixType.Angelic, 1.0f, 1.15f, 5);
            }
            return false;
        }

        public override void ModifyValue(ref float valueMult) { valueMult *= 1; }

        public override bool CanRoll(Item item) { return true; }

        public override float RollChance(Item item) { return 1f; }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult = this.damageMult;
            knockbackMult = this.knockbackMult;
            critBonus = this.critBonus;
        }

        static void AddUniversalPrefix(Mod mod, UniversalPrefixType prefixType, float damageMult = 1f, float knockbackMult = 1f, int critBonus = 0)
        {
            mod.AddPrefix(prefixType.ToString(), new UniversalPrefix(damageMult, knockbackMult, critBonus));
            UniversalPrefixes.Add(mod.GetPrefix(prefixType.ToString()).Type);
        }
    }

    public enum UniversalPrefixType : byte
    {
        None,
        Brutal,
        Cruel,
        Dreadful,
        Serious,
        Wretched,
        Angelic
    }
}
