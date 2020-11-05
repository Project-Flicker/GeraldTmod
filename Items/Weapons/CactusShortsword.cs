using Terraria.ID;
using Terraria.ModLoader;
//pokkeeeeeeemoooooon
namespace GeraldTmod.Items
{
	public class CactusShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cactus Shortsword");
			Tooltip.SetDefault("Cactus is strong but Gerald is stronger.");
		}

		public override void SetDefaults() 
		{
			item.damage = 9; //uwu
			item.melee = true; //owo
			item.width = 28; //ewe
			item.height = 29; //awa
			item.useTime = 19; //iwi
			item.useAnimation = 19; //lwl
			item.useStyle = 3; //sws
			item.knockBack = 6; //nwn
			item.value = 1251; //mwm
			item.rare = 0; //dwd
			item.UseSound = SoundID.Item1; //hwh
			item.autoReuse = true; //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 14);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
