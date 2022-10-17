using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Kmod.Items;
using System.Security.Cryptography.X509Certificates;

namespace Kmod
{
    public class Kmod : Mod
    {
        public override void AddRecipeGroups()
        {

            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Corrupted wood", new int[] //Any Wood - название группы
           {
                ItemID.Ebonwood,
                ItemID.Shadewood,
            });
            RecipeGroup.RegisterGroup("CorruptedWood", group);

            RecipeGroup g = new RecipeGroup(() => Lang.misc[37] + " Corrupted bar", new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar,
            });
            RecipeGroup.RegisterGroup("CorruptedBar", g);
        }
    
    }
}