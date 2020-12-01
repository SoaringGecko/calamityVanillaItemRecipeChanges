using Terraria.ID;
using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges.Items
{
    class EssenceOfEleum : ModItem
    {
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Essence of Eleum");
			Tooltip.SetDefault("The essence of cold creatures");
		}

		public override void SetDefaults()
		{
            item.maxStack = 999;
            item.consumable = false;
            item.value = 4000;
            item.rare = 5;
        }


    }
}
