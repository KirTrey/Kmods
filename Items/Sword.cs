using Kmod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace Kmod.Items
{
	public class Sword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ShadowSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic sword.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 300;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<TestProjectile>();
			Item.shootSpeed = 25;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
				.AddIngredient(ItemID.Ebonwood, 25)
				.AddIngredient(ItemID.DemoniteBar, 10)
				.AddIngredient(ItemID.LightsBane, 1)
				.AddTile(TileID.DemonAltar)
				.Register();

		}
	}
}
