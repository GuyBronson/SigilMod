using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.NPCs
{
	public class FlexSeal : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flex Seal");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Shark];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 9999;
			npc.defense = 9999;
			npc.lifeMax = 50;
			npc.rarity = 4;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 50000f;
			npc.knockBackResist = 0.7f;
			npc.aiStyle = 16;
			aiType = NPCID.Shark;
			animationType = NPCID.Shark;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return !spawnInfo.playerSafe && Main.hardMode ? SpawnCondition.OceanMonster.Chance * 0.001f : 0f;
        }
		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("FlexGel"), 25 + Main.rand.Next(25));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(241, 242);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}