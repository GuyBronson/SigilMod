using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Sigil.Items
{
	public class ClimateController : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Climate Controller");
			Tooltip.SetDefault("Provides immunity to On Fire and Frozen");
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
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}
	}
}