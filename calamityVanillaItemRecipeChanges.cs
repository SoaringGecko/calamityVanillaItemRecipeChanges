using Terraria.ModLoader;

namespace calamityVanillaItemRecipeChanges
{
	public class calamityVanillaItemRecipeChanges : Mod
	{
        public override void PostSetupContent()
        {
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (calamityMod != null)
            {
                throw new System.Exception("You can not run this mod at the same time as Calamity as it makes some recipes easier.");
            }
        }
    }
}