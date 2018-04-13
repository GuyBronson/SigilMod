using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.Items
{
	public class MagicSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magic Sword");
			Tooltip.SetDefault("Spaalonebabuguuscooties.");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.melee = true;
			item.width = 46;
			item.height = 48;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("MagicSwordBeam");
			item.shootSpeed = 20f;
			item.value = 50000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WhiteSword", 1);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
