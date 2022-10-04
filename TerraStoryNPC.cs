using System;
using Terraria;
using Terraria.ModLoader;

namespace TerraStory;

public class TerraStoryNPC : GlobalNPC
{
    public uint Level;
    public uint HealthRete;

    public override bool InstancePerEntity => true;

    public override void OnKill(NPC npc)
    {
        for (var i = 0; i < npc.playerInteraction.Length; i++)
        {
            if (npc.playerInteraction[i])
            {
                Main.player[i].GetModPlayer<TerraStoryPlayer>().Exp += GetExpDrop();
                Main.NewText(Main.player[i].GetModPlayer<TerraStoryPlayer>().Exp);
            }
        }
    }

    public override void SetDefaults(NPC npc)
    {
        Level = (uint)(npc.lifeMax / 100);
    }

    public uint GetExpDrop()
    {
        return Level switch
        {
            > 9 => 17,
            9 => 15,
            8 => 13,
            7 => 12,
            6 => 10,
            5 => 8,
            4 => 6,
            3 => 5,
            2 => 4,
            1 => 3,
            0 => 0,
        };
    }
}