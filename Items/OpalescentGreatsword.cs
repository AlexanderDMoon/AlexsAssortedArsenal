using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class OpalescentGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Opalescent Greatsword");
			Tooltip.SetDefault("Fires a variety of gemstone sword beams.");
		}

        public override void SetDefaults()
        {
            item.damage = 68;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SwordBeamDiamond");
            item.shootSpeed = 12f;
            item.crit = 16;
        }

        private int[] _opalescentSword = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAmethyst"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamTopaz"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamSapphire"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamEmerald"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamRuby"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamDiamond"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAmber"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAquamarine"),
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamPenumbrite")
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            int numberProjectiles = 6;

            for (int i = 0; i < numberProjectiles; i++)
            {
                type = Main.rand.Next(_opalescentSword);
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CopperMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TinMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "IronMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LeadMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SilverMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TungstenMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GoldMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PlatinumMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "AdamantiteStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            /////////////////////////////////////////////////////////////

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CopperMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TinMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "IronMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LeadMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SilverMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TungstenMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GoldMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PlatinumMetalligemGreatsword", 1);
            recipe.AddIngredient(mod, "TitaniumStatusblade", 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}