using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class BlightedLens : ModItem
    {
		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 5600;
            item.rare = 5;
        }


    }
}
