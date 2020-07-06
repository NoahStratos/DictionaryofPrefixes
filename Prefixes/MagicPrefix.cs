using System.Collections.Generic;
using Terraria.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace DictionaryOfPrefixes.Prefixes
{
    public class MagicPrefix : ModPrefix
    {
        internal static List<byte> MagicPrefixes = new List<byte>();
        internal int critBonus = 0;
        internal float damageMult = 1f;
        internal float knockbackMult = 1f;
        internal float manaMult = 1f;
        internal float useTimeMult = 1f;

        public override PrefixCategory Category { get { return PrefixCategory.Magic; } }

        public MagicPrefix() { }

        public MagicPrefix(float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0, float manaMult = 1f)
        {
            this.damageMult = damageMult;
            this.knockbackMult = knockbackMult;
            this.useTimeMult = useTimeMult;
            this.critBonus = critBonus;
            this.manaMult = manaMult;
        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                AddMagicPrefix(mod, MagicPrefixType.Abysmal, 0.85f, 0.9f, 1f, 0, 1.1f);
                AddMagicPrefix(mod, MagicPrefixType.Eerie, 1f, 1.15f, 1f, 5, 1.2f);
                AddMagicPrefix(mod, MagicPrefixType.Demented, 1.15f, 1f, 1f, 0, 1.05f);
                AddMagicPrefix(mod, MagicPrefixType.Sinister, 1.15f, 1f, 0.9f, 0, 1.2f);
                AddMagicPrefix(mod, MagicPrefixType.Virtuous, 1.15f, 1f, 1f, 5, 0.9f);
                AddMagicPrefix(mod, MagicPrefixType.Hopeless, 1.0f, 1.0f, 1f, 0, 1.3f);
                AddMagicPrefix(mod, MagicPrefixType.Languid, 1.0f, 1.0f, 1.2f, 0, 1.1f);
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
            useTimeMult = this.useTimeMult;
            critBonus = this.critBonus;
            manaMult = this.manaMult;
        }

        static void AddMagicPrefix(Mod mod, MagicPrefixType prefixType, float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0, float manaMult = 1f)
        {
            mod.AddPrefix(prefixType.ToString(), new MagicPrefix(damageMult, knockbackMult, useTimeMult, critBonus, manaMult));
            MagicPrefixes.Add(mod.GetPrefix(prefixType.ToString()).Type);
        }
    }

    public enum MagicPrefixType : byte
    {
        None,
        Abysmal,
        Eerie,
        Demented,
        Sinister,
        Virtuous,
        Hopeless,
        Languid
    }
}
