using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace DictionaryOfPrefixes
{
    class DictionaryOfPrefixes : Mod
    {
        internal static DictionaryOfPrefixes mod;

        public static DictionaryOfPrefixes Instance;
        public DictionaryOfPrefixes()
        {
            Properties = new ModProperties()
            {
                Autoload = true
            };
        }
	}
}
