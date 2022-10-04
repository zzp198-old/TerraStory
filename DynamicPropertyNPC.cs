using System;
using Terraria;
using Terraria.ModLoader;

namespace TerraStory;

public class DynamicPropertyNPC : GlobalNPC
{
    public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
    {
        if (FrameSystem.ActivePlayers.Count < 2)
        {
            return;
        }

        damage = (int)(damage * MathF.Pow(0.9f, FrameSystem.ActiveAlivePlayers.Count));
        knockback *= MathF.Pow(0.75f, FrameSystem.ActiveAlivePlayers.Count);
        crit &= Main.rand.NextBool(FrameSystem.ActiveAlivePlayers.Count);
    }

    public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        // if (FrameSystem.ActivePlayers.Count < 2)
        // {
        //     return;
        // }

        // damage = (int)(damage * MathF.Pow(0.8f, FrameSystem.ActiveAlivePlayers.Count));
        // knockback *= MathF.Pow(0.6f, FrameSystem.ActiveAlivePlayers.Count);
        // crit &= Main.rand.NextBool(FrameSystem.ActiveAlivePlayers.Count);
        
        damage = (int)(damage * MathF.Pow(0.1f, FrameSystem.ActiveAlivePlayers.Count));
        knockback *= MathF.Pow(0.1f, FrameSystem.ActiveAlivePlayers.Count);
        crit &= Main.rand.NextBool(FrameSystem.ActiveAlivePlayers.Count);
    }
}