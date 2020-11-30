using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items
{

	public class RecepieHelper : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("why the fvck do you even have this weapon");
		}

		public override void SetDefaults()
		{
			item.value = 1000000;
			item.rare = ItemRarityID.Expert;
			item.width = 1000;
			item.height = 1000;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cog, 30);
			recipe.AddIngredient(ItemID.Handgun, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ClockworkAssaultRifle);
			recipe.AddRecipe();
		}
	}

		/*
		// In this class we separate recipe related code from our main class
		public static class RecipeHelper
		{
			// Here we've made a helper method we can use to shorten our code.
			// This is because many of our recipes follow the same terminology: one ingredient, one result, one possible required tile
			private static void MakeSimpleRecipe(Mod mod, string modIngredient, short resultType, int ingredientStack = 1, int resultStack = 1, string reqTile = null)
			// notice the last parameters can be made optional by specifying a default value
			{
				ModRecipe recipe = new ModRecipe(mod); // make a new recipe for our mod
				recipe.AddIngredient(null, modIngredient, ingredientStack); // add the ingredient, passing null for the mod means it will use our mod, we could also pass mod from the arguments
				if (reqTile != null)
				{ // when a required tile is specified
					recipe.AddTile(null, reqTile); // we add it 
				}

				recipe.SetResult(resultType, resultStack); // set the result to the specified type and with the specified stack.
				recipe.AddRecipe(); // finally, add the recipe
			}

			// Add recipes
			public static void AddExampleRecipes(Mod mod)
			{
				// ExampleItem crafts into the following items
				// Check the method signature of MakeSimpleRecipes for the arguments, this is a method signature:
				// private static void MakeSimpleRecipe(Mod mod, string modIngredient, short resultType, int ingredientStack = 1, int resultStack = 1, string reqTile = null) 

				MakeSimpleRecipe(mod, "ExampleItem", ItemID.Silk, 999);
				MakeSimpleRecipe(mod, "ExampleItem", ItemID.IronOre, 999);
				MakeSimpleRecipe(mod, "ExampleItem", ItemID.GravitationPotion, 20);
				MakeSimpleRecipe(mod, "ExampleItem", ItemID.GoldChest); // notice how we can omit the stack, it has a default value
				MakeSimpleRecipe(mod, "ExampleItem", ItemID.MusicBoxDungeon);

			}
		}

		*/
	}