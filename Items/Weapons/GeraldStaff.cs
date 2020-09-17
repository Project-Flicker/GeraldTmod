using GeraldTMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GeraldTMod.Items
{
	public class GeraldStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gerald Staff");
			Tooltip.SetDefault("Praise Gerald.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 3;
			item.width = 36;
			item.height = 36;
			item.useAnimation = 10;
			item.useTime = 10;
			item.damage = 7;
			item.rare = 0;
			item.noMelee = true;
			item.channel = true;
			item.magic = true;
			item.UseSound = SoundID.Item1;
			item.mana = 50;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<CactusStaffProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}