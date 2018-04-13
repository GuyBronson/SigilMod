using Terraria.ModLoader;

namespace Sigil
{
	class Sigil : Mod
	{
		public Sigil()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
