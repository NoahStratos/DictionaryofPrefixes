using System;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.Exceptions;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Terraria.ID;

namespace DictionaryOfPrefixes
{
    public class AEUpdate1 : GlobalItem
    {

        public static GameCulture ActiveCulture
        {
            get
            {
                return LanguageManager.Instance.ActiveCulture;
            }
        }
        public int damage;
        public int crit;
        public int moveSpeed;
        public int meleeSpeed;
        public int defense;
        public int statManaMax2;
        public float endurance;
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public override GlobalItem Clone(Item item, Item itemClone)
        {
            AEUpdate1 myClone = (AEUpdate1)base.Clone(item, itemClone);

            myClone.damage = damage;
            myClone.crit = crit;
            myClone.moveSpeed = moveSpeed;
            myClone.meleeSpeed = meleeSpeed;
            myClone.defense = defense;
            myClone.statManaMax2 = statManaMax2;
            myClone.endurance = endurance;
            return myClone;
        }
        public override bool NewPreReforge(Item item)
        {

            damage = 0;
            crit = 0;
            moveSpeed = 0;
            meleeSpeed = 0;
            defense = 0;
            statManaMax2 = 0;
            endurance = 0;
            return base.NewPreReforge(item);
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ActiveCulture == GameCulture.Polish)
            {
                if (damage > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "damage", "+" + damage + "% pkt. obrażeń");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (crit > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "crit", "+" + crit + "% szansy na trafienie krytyczne");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (moveSpeed > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "moveSpeed", "+" + moveSpeed + "% szybkości poruszania się");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (meleeSpeed > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "meleeSpeed", "+" + meleeSpeed + "% szybkości walki w zwarciu");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (defense > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "defense", "+" + defense + " pkt. obrony");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (statManaMax2 > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "statManaMax2", "+" + statManaMax2 + " pkt. many");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (endurance > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "endurance", "+" + endurance + "% zmniejszone obrażenia");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (damage < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "damage", damage + "% pkt. obrażeń");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (moveSpeed < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "moveSpeed", moveSpeed + "% szybkości poruszania się");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (meleeSpeed < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "meleeSpeed", meleeSpeed + "% szybkości walki w zwarciu");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (defense < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "defense", defense + " pkt. obrony");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
            }
            else
            {
                if (damage > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "damage", "+" + damage + "% damage");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (crit > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "crit", "+" + crit + "% critical strike chance");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (moveSpeed > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "moveSpeed", "+" + moveSpeed + "% movement speed");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (meleeSpeed > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "meleeSpeed", "+" + meleeSpeed + "% melee speed");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (defense > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "defense", "+" + defense + " defense");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (statManaMax2 > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "statManaMax2", "+" + statManaMax2 + " mana");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (endurance > 0)
                {
                    TooltipLine line = new TooltipLine(mod, "endurance", "+" + endurance + "% damage reduction");
                    line.isModifier = true;
                    tooltips.Add(line);
                }
                if (damage < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "damage", damage + "% damage");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (moveSpeed < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "moveSpeed", moveSpeed + "% movement speed");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (meleeSpeed < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "meleeSpeed", meleeSpeed + "% melee speed");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
                if (defense < 0)
                {
                    TooltipLine line = new TooltipLine(mod, "defense", defense + " defense");
                    line.isModifier = true;
                    line.isModifierBad = true;
                    tooltips.Add(line);
                }
            }
        }
    
        public override void UpdateEquip(Item item, Player player)
        {
            if (item.prefix > 0)
            {
                player.rangedDamage += damage * .01f;
                player.minionDamage += damage * .01f;
                player.meleeDamage += damage * .01f;
                player.magicDamage += damage * .01f;
                player.thrownDamage += damage * .01f;
                player.meleeCrit += crit;
                player.rangedCrit += crit;
                player.magicCrit += crit;
                player.thrownCrit += crit;
                player.moveSpeed += moveSpeed * .01f;
                player.meleeSpeed += meleeSpeed * .01f;
                player.statDefense += defense;
                player.statManaMax2 += statManaMax2;
                player.endurance += endurance * .01f;
            }
        }
        public override void NetSend(Item item, BinaryWriter writer)
        {

            writer.Write(damage);
            writer.Write(crit);
            writer.Write(moveSpeed);
            writer.Write(meleeSpeed);
            writer.Write(defense);
            writer.Write(statManaMax2);
            writer.Write(endurance);

        }
        public override void NetReceive(Item item, BinaryReader reader)
        {
            damage = reader.ReadInt32();
            crit = reader.ReadInt32();
            moveSpeed = reader.ReadInt32();
            meleeSpeed = reader.ReadInt32();
            defense = reader.ReadInt32();
            statManaMax2 = reader.ReadInt32();
            endurance = reader.ReadInt32();

        }
    }
}