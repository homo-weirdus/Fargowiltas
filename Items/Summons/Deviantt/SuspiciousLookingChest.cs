using Terraria.ID;

namespace Fargowiltas.Items.Summons.Deviantt
{
    public class SuspiciousLookingChest : BaseSummon
    {
        public override int Type => NPCID.Mimic;

        public override string NPCName => "Mimic";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Suspicious Looking Chest");
            Tooltip.SetDefault("Summons Mimic");
        }
    }
}