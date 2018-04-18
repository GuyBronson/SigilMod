using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Sigil.Items
{
	public class GloryHand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hand of Glory");
			Tooltip.SetDefault("Provides immunity to Blackout");
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
			player.buffImmune[BuffID.Blackout] = true;
		}
	}
}