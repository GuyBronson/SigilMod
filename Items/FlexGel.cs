using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.Items
{
	public class FlexGel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flex Gel");
			Tooltip.SetDefault("Somewhat rubbery but impossibly tough.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 14;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 3;
		}
	}
}