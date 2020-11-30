using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using ThisMod.Items.Tiles;

namespace ThisMod.Items.Tiles
{
	public class DarkBlock : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A pitch black block.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 9999999;
			item.value = 1;
			item.rare = ItemRarityID.Gray;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = mod.TileType("DarkBlockTile");
			item.placeStyle = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.AddTile(ItemID.WorkBench);
			recipe.SetResult(this, 700);
			recipe.AddRecipe();
		}
	}
}