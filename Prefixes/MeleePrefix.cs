using System.Collections.Generic;
using Terraria.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace DictionaryOfPrefixes.Prefixes
{
    public class MeleePrefix : ModPrefix
    {
        internal static List<byte> MeleePrefixes = new List<byte>();
        internal int critBonus = 0;
        internal float damageMult = 1f;
        internal float knockbackMult = 1f;
        internal float scaleMult = 1f;
        internal float useTimeMult = 1f;

		public override PrefixCategory Category { get { return PrefixCategory.Melee; } }

        public MeleePrefix() { }

        public MeleePrefix(float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0, float scaleMult = 1f)
        {
            this.damageMult = damageMult;
            this.knockbackMult = knockbackMult;
            this.useTimeMult = useTimeMult;
            this.critBonus = critBonus;
            this.scaleMult = scaleMult;
        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                AddMeleePrefix(mod, MeleePrefixType.Fierce, 0.95f, 0.95f, 0.82f, 0, 1f);
                AddMeleePrefix(mod, MeleePrefixType.Brash, 0.95f, 1.0f, 1.0f, 0, 1.15f);
                AddMeleePrefix(mod, MeleePrefixType.Gigantic, 1.0f, 1.0f, 1.0f, 0, 1.25f);
                AddMeleePrefix(mod, MeleePrefixType.Petite, 1.0f, 1.0f, 0.85f, 0, 0.9f);
                AddMeleePrefix(mod, MeleePrefixType.Reckless, 0.82f, 1.0f, 0.9f, 2, 1.0f);
                AddMeleePrefix(mod, MeleePrefixType.Tearing, 1.1f, 1.0f, 0.9f, 5, 1.0f);
                AddMeleePrefix(mod, MeleePrefixType.Draggy, 0.93f, 0.93f, 1.2f, 0, 1.0f);
            }
            return false;
        }

        public override void ModifyValue(ref float valueMult) { valueMult *= 1; }

        public override bool CanRoll(Item item)
        {

            if (item.noUseGraphic == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override float RollChance(Item item) { return 1f; }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult = this.damageMult;
            knockbackMult = this.knockbackMult;
            useTimeMult = this.useTimeMult;
            critBonus = this.critBonus;
            scaleMult = this.scaleMult;
        }

        static void AddMeleePrefix(Mod mod, MeleePrefixType prefixType, float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0, float scaleMult = 1f)
        {
            mod.AddPrefix(prefixType.ToString(), new MeleePrefix(damageMult, knockbackMult, useTimeMult, critBonus, scaleMult));
            MeleePrefixes.Add(mod.GetPrefix(prefixType.ToString()).Type);
        }
    }

    public enum MeleePrefixType : byte
    {
        None,
        Fierce,
        Brash,
        Gigantic,
        Petite,
        Reckless,
        Tearing,
        Draggy
    }
}
