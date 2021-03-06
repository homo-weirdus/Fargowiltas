using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Fargowiltas.Items.Misc
{
    public class DevianttsSundial : ModItem
    {
        public override string Texture => "Fargowiltas/Items/Misc/PortableSundial";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deviantt's Sundial");
            Tooltip.SetDefault("'For getting through those early nights'\nActivates the Enchanted Sundial effect\nCan only be used once");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.rare = ItemRarityID.Blue;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return !Main.fastForwardTime;
        }

        public override bool UseItem(Player player)
        {
            Main.sundialCooldown = 0;
            if (Main.netMode == NetmodeID.MultiplayerClient)
            {
                NetMessage.SendData(MessageID.Assorted1, number: Main.myPlayer, number2: 3f);
                return true;
            }

            Main.fastForwardTime = true;
            NetMessage.SendData(MessageID.WorldData);
            Main.PlaySound(SoundID.Item4, player.position);

            return true;
        }
    }
}