using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class BloodOrb : ModItem
    {
		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 120;
            item.rare = 1;
        }


    }
}
