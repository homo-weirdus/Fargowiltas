using Terraria.ID;

namespace Fargowiltas.Items.Summons.Deviantt
{
    public class HallowChest : BaseSummon
    {
        public override int Type => NPCID.BigMimicHallow;

        public override string NPCName => "Hallowed Mimic";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallow Chest");
            Tooltip.SetDefault("Summons Hallowed Mimic");
        }
    }
}