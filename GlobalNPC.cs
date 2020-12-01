using calamityVanillaItemRecipeChanges.Items;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges
{
	class MyGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.Vulture)
			{
				if (Main.rand.NextFloat() < .50f) {
					Item.NewItem(npc.getRect(), mod.ItemType("DesertFeather"));
				}
			}

			if (npc.type == NPCID.BloodZombie)
			{
				if (Main.rand.NextFloat() < .50f) {
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.Drippler)
			{
				if (Main.rand.NextFloat() < .50f) {
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.TheBride)
			{
				if (Main.rand.NextFloat() < .50f) {
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.TheGroom)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.Clown)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.Arapaima)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("MurkyPaste"));
				}
			}

			if (npc.type == NPCID.SpikedJungleSlime)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("MurkyPaste"));
				}
			}

			if (npc.type == NPCID.Derpling)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BeetleJuice"));
				}
			}

			if (npc.type == NPCID.WanderingEye)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BlightedLens"));
				}
			}

			if (npc.type == NPCID.Skeleton)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("AncientBoneDust"));
				}
			}

			if (npc.type == NPCID.GreekSkeleton)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("AncientBoneDust"));
				}
			}

			if (npc.type == NPCID.ArmoredSkeleton)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("AncientBoneDust"));
				}
			}

			if (npc.type == NPCID.SkeletonArcher)
			{
				if (Main.rand.NextFloat() < .25f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("AncientBoneDust"));
				}
			}

			if (npc.type == NPCID.IceTortoise)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("EssenceOfEleum"));
				}
			}

			if (npc.type == NPCID.IcyMerman)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("EssenceOfEleum"));
				}
			}

			if (npc.type == NPCID.IceElemental)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("EssenceOfEleum"));
				}
			}

			if (npc.type == NPCID.IceGolem)
			{
					Item.NewItem(npc.getRect(), mod.ItemType("EssenceOfEleum"), 2);
			}
			// Addtional if statements here if you would like to add drops to other vanilla npc.
		}
	}
}
