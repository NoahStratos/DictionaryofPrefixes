using System.Collections.Generic;
using Terraria.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace DictionaryOfPrefixes.Prefixes
{
    public class CommonPrefix : ModPrefix
    {
        internal static List<byte> CommonPrefixes = new List<byte>();
        internal int critBonus = 0;
        internal float damageMult = 1f;
        internal float knockbackMult = 1f;
        internal float useTimeMult = 1f;

        public override PrefixCategory Category { get { return PrefixCategory.AnyWeapon;} }

        public CommonPrefix() { }

        public CommonPrefix(float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0)
        {
            this.damageMult = damageMult;
            this.knockbackMult = knockbackMult;
            this.useTimeMult = useTimeMult;
            this.critBonus = critBonus;
        }

        public override bool Autoload(ref string name)
        {
            if (base.Autoload(ref name))
            {
                AddCommonPrefix(mod, CommonPrefixType.Stubborn, 1.05f, 1.15f, 1.2f, 0);
                AddCommonPrefix(mod, CommonPrefixType.Barbaric, 1.0f, 0.92f, 1.0f, 5);
                AddCommonPrefix(mod, CommonPrefixType.Blistering, 1.0f, 1.0f, 0.85f, 0);
                AddCommonPrefix(mod, CommonPrefixType.Lousy, 0.9f, 0.9f, 1.15f, 0);
                AddCommonPrefix(mod, CommonPrefixType.Unstable, 0.77f, 0.93f, 0.87f, 2);
            }
            return false;
        }

        public override void ModifyValue(ref float valueMult) { valueMult *= 1; }

        public override bool CanRoll(Item item)
        {

            if (item.noUseGraphic == true && item.melee == true) {
                return false; }
            else {
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
        }

        static void AddCommonPrefix(Mod mod, CommonPrefixType prefixType, float damageMult = 1f, float knockbackMult = 1f, float useTimeMult = 1f, int critBonus = 0)
        {
            mod.AddPrefix(prefixType.ToString(), new CommonPrefix(damageMult, knockbackMult, useTimeMult, critBonus));
            CommonPrefixes.Add(mod.GetPrefix(prefixType.ToString()).Type);
        }
    }

    public enum CommonPrefixType : byte
    {
        None,
        Stubborn,
        Barbaric,
        Blistering,
        Lousy,
        Unstable
    }
}
