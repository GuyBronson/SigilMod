using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.NPCs
{
	public class ShadowMonsterMan : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Monster Man");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ChaosElemental];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 20;
			npc.defense = 10;
			npc.lifeMax = 400;
			npc.HitSound = SoundID.NPCHit49;
			npc.DeathSound = SoundID.NPCDeath51;
			npc.value = 5000f;
			npc.rarity = 4;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ChaosElemental;
			animationType = NPCID.ChaosElemental;
		}
		public override void AI()
        {
            if (Main.rand.Next(200) == 5)
            {
            npc.position.X = (Main.player[Main.myPlayer].position.X - 300) + Main.rand.Next(600);
            npc.position.Y = (Main.player[Main.myPlayer].position.Y - 300) + Main.rand.Next(600);
            }
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.005f;
        }
		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("FlexGel"));
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