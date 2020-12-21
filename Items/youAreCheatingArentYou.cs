using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
	public class youAreCheatingArentYou : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("youAreCheatingArentYou"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Your gonna have a bad time");
		}

		public override void SetDefaults() 
		{
			item.damage = 300;
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{

			//	ACCESSORIES

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EndlessQuiver);
			recipe.AddIngredient(ItemID.PixieDust, 10);
			recipe.AddIngredient(mod.ItemType("BlightedLens"), 5);
			recipe.AddIngredient(ItemID.SoulofLight, 8);
			recipe.AddTile(TileID.CrystalBall);
			recipe.SetResult(ItemID.MagicQuiver);
			recipe.AddRecipe();

			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddIngredient(ItemID.ViciousPowder, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.GuideVoodooDoll);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 2);
			recipe.AddIngredient(ItemID.VilePowder, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.GuideVoodooDoll);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 2);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceSkates);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Aglet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Aglet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 15);
			recipe.AddIngredient(ItemID.Cloud, 15);
			recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AnkletoftheWind);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 15);
			recipe.AddIngredient(mod.ItemType("MurkyPaste"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Bezoar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 4);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.SnowBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BlizzardinaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 2);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.Cloud, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CloudinaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FeralClaws);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Frog, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrogLeg);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaBucket, 5);
			recipe.AddIngredient(ItemID.Obsidian, 25);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LavaBucket, 5);
			recipe.AddIngredient(ItemID.Obsidian, 25);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LavaCharm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 10);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 10);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ItemID.Hellstone, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ObsidianRose);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DesertFeather"), 10);
			recipe.AddIngredient(ItemID.Feather, 6);
			recipe.AddIngredient(ItemID.Bottle);
			recipe.AddIngredient(ItemID.SandBlock, 70);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SandstorminaBottle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterWalkingPotion, 8);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WaterWalkingBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 7);
			recipe.AddIngredient(ItemID.JungleRose);
			recipe.AddIngredient(ItemID.JungleGrassSeeds, 5);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.FlowerBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HandWarmer);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.HermesBoots);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.GreaterHealingPotion);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.AdhesiveBandage);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 50);
			recipe.AddIngredient(mod.ItemType("AncientBoneDust"), 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ArmorPolish);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 30);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Blindfold);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddIngredient(ItemID.SoulofNight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.CelestialMagnet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Timer1Second);
			recipe.AddIngredient(ItemID.PixieDust, 15);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FastClock);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AncientCloth, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FlyingCarpet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TurtleShell, 3);
			recipe.AddIngredient(mod.ItemType("EssenceOfEleum"), 9);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FrozenTurtleShell);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Megaphone);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 10);
			recipe.AddIngredient(ItemID.GoldDust, 5);
			recipe.AddIngredient(ItemID.SpelunkerGlowstick, 5);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 10);
			recipe.AddIngredient(ItemID.GoldDust, 5);
			recipe.AddIngredient(ItemID.SpelunkerGlowstick, 5);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Nazar);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddIngredient(ItemID.SoulofNight, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TrifoldMap);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.AddIngredient(mod.ItemType("BeetleJuice"), 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Vitamins);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 80);
			recipe.AddIngredient(ItemID.Cloud, 40);
			recipe.AddIngredient(ItemID.WhiteString);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(ItemID.ShinyRedBalloon);
			recipe.AddRecipe();

			//	AMMUNITION

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.EmptyBullet, 20);
			recipe.AddIngredient(ItemID.ExplosivePowder);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RocketI, 20);
			recipe.AddRecipe();

			//	ARMOR

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 4);
			recipe.AddIngredient(ItemID.Leather);
			recipe.AddIngredient(ItemID.BorealWood, 12);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.EskimoHood);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddIngredient(ItemID.Leather);
			recipe.AddIngredient(ItemID.BorealWood, 18);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.EskimoCoat);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.AddIngredient(ItemID.Leather);
			recipe.AddIngredient(ItemID.BorealWood, 15);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.EskimoPants);
			recipe.AddRecipe();

			//	CONSUMABLES

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Worm);
			recipe.AddIngredient(ItemID.GlowingMushroom, 15);
			recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(ItemID.TruffleWorm);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 5);
			recipe.AddIngredient(ItemID.PinkGel);
			recipe.AddIngredient(ItemID.HealingPotion);
			recipe.AddIngredient(ItemID.Ruby);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LifeCrystal);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 15);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.LihzahrdPowerCell);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 15);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(ItemID.LihzahrdPowerCell);
			recipe.AddRecipe();

			//	CRAFTING MATERIALS

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Lens);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(ItemID.BlackLens);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vertebrae, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Leather);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Leather);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Leather);
			recipe.AddRecipe();

			// CRAFTING STATIONS

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 25);
			recipe.AddIngredient(ItemID.SnowBlock, 15);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMachine);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SunplateBlock, 10);
			recipe.AddIngredient(ItemID.Cloud, 5);
			recipe.AddIngredient(ItemID.RainCloud, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SkyMill);
			recipe.AddRecipe();

			//	POTIONS

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.AmmoReservationPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.ArcheryPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.BattlePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.BuilderPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.CalmingPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.CratePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.TrapsightPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.EndurancePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.Feather);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.FishingPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.FlipperPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.GenderChangePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.GillsPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.GravitationPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.HeartreachPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.HunterPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.InfernoPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.InvisibilityPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.IronskinPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.LifeforcePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.LovePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.MagicPowerPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.ManaRegenerationPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.MiningPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.NightOwlPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.ObsidianSkinPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.RagePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.RegenerationPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.ShinePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.SonarPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.SpelunkerPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.StinkPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.SummoningPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.SwiftnessPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.TeleportationPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.ThornsPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.TitanPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.WarmthPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.WaterWalkingPotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.WormholePotion);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(mod.ItemType("BloodOrb"), 10);
			recipe.AddTile(TileID.AlchemyTable);
			recipe.SetResult(ItemID.WrathPotion);
			recipe.AddRecipe();

			//	TOOLS

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 3);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BugNet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 3);
			recipe.AddIngredient(ItemID.Cobweb, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BugNet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 20);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.Glass, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagicMirror);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenKey);
			recipe.AddIngredient(ItemID.Obsidian, 20);
			recipe.AddIngredient(ItemID.Bone, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowKey);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 30);
			recipe.AddIngredient(ItemID.ChaosFish, 5);
			recipe.AddIngredient(ItemID.PixieDust, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RodofDiscord);
			recipe.AddRecipe();

			//	WEAPONS

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddIngredient(ItemID.Waterleaf, 3);
			recipe.AddIngredient(ItemID.WaterCandle);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(ItemID.WaterBolt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleIceBlock, 20);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedIceBlock, 20);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkIceBlock, 20);
			recipe.AddIngredient(ItemID.SnowBlock, 10);
			recipe.AddIngredient(ItemID.Shiverthorn);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(ItemID.IceBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Shuriken, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Shuriken, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 6);
			recipe.AddIngredient(ItemID.Gel, 40);
			recipe.AddIngredient(ItemID.PinkGel, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SlimeStaff);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBroadsword);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBroadsword);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Starfury);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ThrowingKnife, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ThrowingKnife, 50);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.Torch, 3);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WandofSparking);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddIngredient(ItemID.UnicornHorn, 3);
			recipe.AddIngredient(ItemID.LightShard);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.EnchantedSword);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Muramasa);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Muramasa);
			recipe.AddRecipe();
		}
	}
}