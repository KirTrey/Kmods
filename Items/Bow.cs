using Kmod.Items;
using Kmod.Projectiles;
using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Kmod.Items
{
    public class Bow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bow");
            Tooltip.SetDefault("A modded bow");
        }

        public override void SetDefaults()
        {
            Item.damage = 25;
            Item.DamageType = DamageClass.Ranged; // класс оружие 
            Item.noMelee = true; // становится нашим орудием
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 25;
            Item.useAnimation = 25;
            Item.useStyle = 5;
            Item.shoot = ProjectileID.PurificationPowder; // это не изменяем
            Item.shootSpeed = 10;             //скорость полета стрелы
            Item.useAmmo = AmmoID.Arrow;  // то чем оно стреляет Bullet пуля, Arrow стрела
            Item.knockBack = 3;
            Item.value = 90000;
            Item.rare = 5;
            Item.UseSound = SoundID.Item5;
            Item.autoReuse = true;
            Item.useTurn = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe(1)
              .AddIngredient(ItemID.Wood, 1)
                      .AddTile(TileID.WorkBenches)
                      .Register();
        }
    }
}