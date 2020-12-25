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

			if (npc.type == NPCID.Zombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieElf && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieElfBeard && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieElfGirl && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieEskimo && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieMushroom && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieMushroomHat && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombiePixie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieRaincoat && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieSuperman && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieSweater && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ZombieXmas && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombieCenx && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombieEskimo && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombiePincussion && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombieSlimed && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombieSwamp && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.ArmedZombieTwiggy && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BaldZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigBaldZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigFemaleZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigPincushionZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigRainZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigSlimedZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigSwampZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigTwiggyZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.BigZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.FemaleZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.PincushionZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SlimedZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallBaldZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallFemaleZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallPincushionZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallRainZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallSlimedZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallSwampZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallTwiggyZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SmallZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SwampZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.TwiggyZombie && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DemonEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DemonEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.CataractEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.CataractEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SleepyEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.SleepyEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DialatedEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DialatedEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.GreenEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.GreenEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.PurpleEye && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.PurpleEye2 && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DemonEyeOwl && Main.bloodMoon)
			{
				if (Main.rand.NextFloat() < .50f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BloodOrb"));
				}
			}

			if (npc.type == NPCID.DemonEyeSpaceship && Main.bloodMoon)
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
