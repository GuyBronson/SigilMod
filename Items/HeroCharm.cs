using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Sigil.Items
{
	public class HeroCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hero Charm");
			Tooltip.SetDefault("Provides immunity to most advanced debuffs");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.buffImmune[BuffID.WindPushed] = true;
			player.buffImmune[BuffID.VortexDebuff] = true;
			player.buffImmune[BuffID.Webbed] = true;
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.Stoned] = true;
			player.buffImmune[BuffID.Blackout] = true;
			player.buffImmune[BuffID.ShadowFlame] = true;
			player.buffImmune[BuffID.Electrified] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ArachneCharm", 1);
			recipe.AddIngredient(null, "GloryHand", 1);
			recipe.AddIngredient(null, "GoodwillOrb", 1);
			recipe.AddIngredient(null, "SafetyGoggles", 1);
			recipe.AddIngredient(null, "GravityStabilizer", 1);
			recipe.AddIngredient(null, "GoblinTalisman", 1);
			recipe.AddIngredient(null, "RubberCloak", 1);
			recipe.AddIngredient(null, "ClimateController", 1);
			recipe.AddIngredient(ItemID.PocketMirror, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}