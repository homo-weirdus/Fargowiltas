using Terraria;
using Terraria.DataStructures;
using Terraria.ID;

namespace Fargowiltas.Items.CaughtNPCs
{
    public class Abominationn : BaseCaughtNPC
    {
        public override string Texture => "Fargowiltas/NPCs/Abominationn";

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'I sure wish I was a boss.'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.makeNPC = (short)mod.NPCType("Abominationn");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 25));
        }
    }

    public class Angler : BaseCaughtNPC
    {
        public override int Type => NPCID.Angler;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You'd be a great helper minion!'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.bait = 15;
        }
    }

    public class ArmsDealer : BaseCaughtNPC
    {
        public override int Type => NPCID.ArmsDealer;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Keep your hands off my gun, buddy!'");
        }
    }

    public class Clothier : BaseCaughtNPC
    {
        public override int Type => NPCID.Clothier;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Thanks again for freeing me from my curse.'");
        }
    }

    public class Cyborg : BaseCaughtNPC
    {
        public override int Type => NPCID.Cyborg;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'My expedition efficiency was critically reduced when a projectile impacted my locomotive actuator.'");
        }
    }

    public class Demolitionist : BaseCaughtNPC
    {
        public override string Texture => "Terraria/NPC_38";

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'It's a good day to die!'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.makeNPC = NPCID.Demolitionist;
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 25));
        }
    }

    public class Deviantt : BaseCaughtNPC
    {
        public override string Texture => "Fargowiltas/NPCs/Deviantt";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deviantt");
            Tooltip.SetDefault("'Embrace suffering... and while you're at it, embrace another purchase!'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.makeNPC = (short)mod.NPCType("Deviantt");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 23));
        }
    }

    public class Dryad : BaseCaughtNPC
    {
        public override int Type => NPCID.Dryad;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Be safe; Terraria needs you!'");
        }
    }

    public class DyeTrader : BaseCaughtNPC
    {
        public override int Type => NPCID.DyeTrader;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'My dear, what you're wearing is much too drab.'");
        }
    }

    public class GoblinTinkerer : BaseCaughtNPC
    {
        public override int Type => NPCID.GoblinTinkerer;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Looking for a gadgets expert? I'm your goblin!'");
        }
    }

    //golfer here

    public class Guide : BaseCaughtNPC
    {
        public override int Type => NPCID.Guide;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'They say there is a person who will tell you how to survive in this land.'");
        }

        public override void PostUpdate()
        {
            if (item.lavaWet && !NPC.AnyNPCs(NPCID.WallofFlesh))
            {
                NPC.SpawnWOF(item.position);
                item.TurnToAir();
            }
        }
    }

    public class LumberJack : BaseCaughtNPC
    {
        public override string Texture => "Fargowiltas/NPCs/LumberJack";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The LumberJack");
            Tooltip.SetDefault("'I eat a bowl of woodchips for breakfast... without any milk.'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.makeNPC = (short)mod.NPCType("LumberJack");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 25));
        }
    }

    public class Mechanic : BaseCaughtNPC
    {
        public override int Type => NPCID.Mechanic;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Always buy more wire than you need!'");
        }
    }

    public class Merchant : BaseCaughtNPC
    {
        public override int Type => NPCID.Merchant;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Did you say gold? I'll take that off of ya.'");
        }
    }

    public class Mutant : BaseCaughtNPC
    {
        public override string Texture => "Fargowiltas/NPCs/Mutant";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mutant");
            Tooltip.SetDefault("'You're lucky I'm on your side.'");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.makeNPC = (short)mod.NPCType("Mutant");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 25));
        }
    }

    public class Nurse : BaseCaughtNPC
    {
        public override int Type => NPCID.Nurse;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Show me where it hurts.'");
        }
    }

    public class Painter : BaseCaughtNPC
    {
        public override int Type => NPCID.Painter;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'I know the difference between turquoise and blue-green. But I won't tell you.'");
        }
    }

    public class PartyGirl : BaseCaughtNPC
    {
        public override int Type => NPCID.PartyGirl;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'We have to talk. It's... it's about parties.'");
        }
    }

    public class Pirate : BaseCaughtNPC
    {
        public override int Type => NPCID.Pirate;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Stay off me booty, ya scallywag!'");
        }
    }

    public class SantaClaus : BaseCaughtNPC
    {
        public override int Type => NPCID.SantaClaus;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa Claus");
            Tooltip.SetDefault("'What? You thought I wasn't real?'");
        }
    }

    public class SkeletonMerchant : BaseCaughtNPC
    {
        public override int Type => NPCID.SkeletonMerchant;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You would not believe some of the things people throw at me... Wanna buy some of it?'");
        }
    }

    public class Steampunker : BaseCaughtNPC
    {
        public override int Type => NPCID.Steampunker;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Show me some gears!'");
        }

    }
    public class Stylist : BaseCaughtNPC
    {
        public override int Type => NPCID.Stylist;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Did you even try to brush your hair today?'");
        }
    }

    public class Tavernkeep : BaseCaughtNPC
    {
        public override int Type => NPCID.DD2Bartender;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'What am I doing here...'");
        }
    }

    public class TaxCollector : BaseCaughtNPC
    {
        public override int Type => NPCID.TaxCollector;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You again? Suppose you want more money!?'");
        }
    }

    public class TravellingMerchant : BaseCaughtNPC
    {
        public override int Type => NPCID.TravellingMerchant;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'I sell wares from places that might not even exist!'");
        }
    }

    public class Truffle : BaseCaughtNPC
    {
        public override int Type => NPCID.Truffle;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Everyone in this town feels a bit off.'");
        }
    }

    public class WitchDoctor : BaseCaughtNPC
    {
        public override int Type => NPCID.WitchDoctor;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Which doctor am I? The Witch Doctor am I.'");
        }
    }

    public class Wizard : BaseCaughtNPC
    {
        public override int Type => NPCID.Wizard;

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Want me to pull a coin from behind your ear? No? Ok.'");
        }
    }

    //zoologist here
}