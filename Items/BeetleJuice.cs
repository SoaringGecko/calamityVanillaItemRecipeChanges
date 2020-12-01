using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class BeetleJuice : ModItem
    {
		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 1600;
            item.rare = 5;
        }


    }
}
