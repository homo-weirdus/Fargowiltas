using Terraria.ID;

namespace Fargowiltas.Items.Summons.Mutant
{
    public class CultistSummon : BaseSummon
    {
        public override int Type => NPCID.CultistBoss;

        public override string NPCName => "Lunatic Cultist";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zealot's Possession");
            Tooltip.SetDefault("Summons the Lunatic Cultist\nDoes not spawn the pillars on death");
        }
    }
}