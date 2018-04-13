using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.NPCs
{
	public class LilGlob : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Li'l Glob");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DesertLamiaLight];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 24;
			npc.defense = 6;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 150f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertLamiaLight;
			animationType = NPCID.DesertLamiaLight;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.DungeonNormal.Chance * 0.15f;
        }
		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemID.Book, 1 + Main.rand.Next(4));
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