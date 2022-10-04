using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace TerraStory;

internal class FrameSystem : ModSystem
{
    internal static List<Player> ActivePlayers = new();
    internal static List<Player> ActiveAlivePlayers = new();

    public override void PostUpdatePlayers()
    {
        ActivePlayers.Clear();
        ActivePlayers = Main.player.Where(i => i.active).ToList();
        ActiveAlivePlayers = ActivePlayers.Where(i => !i.DeadOrGhost).ToList();
    }
}