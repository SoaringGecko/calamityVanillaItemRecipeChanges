using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items.Placeable
{
    public class AlchemicalMaterialManipulator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An Ancient Manipulator with the power to change water into potions.");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 14;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 150;
            item.rare = 10;
            item.createTile = ModContent.TileType<Tiles.AlchemicalMaterialManipulator>();
        }

    }
}