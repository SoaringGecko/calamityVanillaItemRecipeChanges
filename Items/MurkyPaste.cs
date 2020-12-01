using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class MurkyPaste : ModItem
    {
		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 200;
            item.rare = 1;
        }


    }
}
