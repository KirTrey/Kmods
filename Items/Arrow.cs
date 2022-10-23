using Kmod.Projectiles; // место вашего прожектайла (ниже описано)
using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kmod.Items
{
    public class Arrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bullet ili Strella");
            Tooltip.SetDefault("Opisaniye");
        }

        public override void SetDefaults()
        {
            Item.damage = 41;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.maxStack = 1; //  сколько может содержаться в стаке
            Item.consumable = false;
            Item.shoot = ModContent.ProjectileType<ArrowProjectile>(); // тут указывайте ваш прожектайл
            Item.shootSpeed = 5f; // скорость полета пули
            Item.knockBack = 9;
            Item.rare = 2;
            Item.ammo = AmmoID.Arrow; // Что это Bullet пуля Arrow стреля
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
                      .AddIngredient(ItemID.Wood, 90)
                      .AddTile(TileID.WorkBenches)
                      .Register();
        }
    }
}
