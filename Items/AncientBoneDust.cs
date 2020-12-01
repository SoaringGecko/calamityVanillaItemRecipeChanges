using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class AncientBoneDust : ModItem
    {
		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 100;
            item.rare = 1;
        }


    }
}
