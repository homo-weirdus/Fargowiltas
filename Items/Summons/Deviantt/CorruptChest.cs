using Terraria.ID;

namespace Fargowiltas.Items.Summons.Deviantt
{
    public class CorruptChest : BaseSummon
    {
        public override int Type => NPCID.BigMimicCorruption;

        public override string NPCName => "Corrupt Mimic";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrupt Chest");
            Tooltip.SetDefault("Summons Corrupt Mimic");
        }
    }
}