using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.Items
{
	public class FlexBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flex Blade");
			Tooltip.SetDefault("That's a lotta damage!");
		}
		public override void SetDefaults()
		{
			item.damage = 90;
			item.melee = true;
			item.width = 46;
			item.height = 48;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 10;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("FlexBeam");
			item.shootSpeed = 20f;
			item.value = 50000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FlexGel", 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
