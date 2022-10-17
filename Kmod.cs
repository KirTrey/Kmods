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
                ItemID.SpookyWood,
            });
            RecipeGroup.RegisterGroup("CorruptedWood", group);
        }
    
    }
}