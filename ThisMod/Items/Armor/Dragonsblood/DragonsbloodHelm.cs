using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using ThisMod.Items.Armor.Dragonsblood;

namespace ThisMod.Items.Armor.Dragonsblood
{
	[AutoloadEquip(EquipType.Head)]
	public class DragonsbloodHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded helmet.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemType<DragonsbloodPlate>() && legs.type == ItemType<DragonsbloodLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Thays alotta damage";
			player.allDamage -= 0.8f;
			player.meleeDamage -= 0.8f;
			player.thrownDamage -= 0.8f;
			player.rangedDamage -= 0.8f;
			player.magicDamage -= 0.8f;
			player.minionDamage -= 0.8f;
			/* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
		}
	}
}