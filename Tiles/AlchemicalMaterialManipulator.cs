using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace calamityVanillaItemRecipeChanges.Tiles
{
    public class AlchemicalMaterialManipulator : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Alchemical Material Manipulator");
            AddMapEntry(new Color(200, 200, 200), name);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.LunarCraftingStation };
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("AlchemicalMaterialManipulator"));
        }
    }
}