using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.Items
{
	public class WhiteSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Sword");
			Tooltip.SetDefault("You mastered using it, now you can have this.");
		}
		public override void SetDefaults()
		{
			item.damage = 73;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 50000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(null, "Sword");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
