using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraStory.Content.NPCs;

[AutoloadBossHead]
public class Zakum : ModNPC
{
    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Zakum");

        Main.npcFrameCount[Type] = 1;
        NPCID.Sets.MPAllowedEnemies[Type] = true;
        NPCID.Sets.BossBestiaryPriority.Add(Type);
        NPCID.Sets.DebuffImmunitySets.Add(Type, new NPCDebuffImmunityData
        {
            ImmuneToAllBuffsThatAreNotWhips = true,
        });
    }

    public override void SetDefaults()
    {
        NPC.width = 110;
        NPC.height = 110;
        NPC.damage = 400;
        NPC.defense = 400;
        NPC.lifeMax = 100000;
        NPC.HitSound = SoundID.NPCHit1;
        NPC.DeathSound = SoundID.NPCDeath1;
        NPC.knockBackResist = 0f;
        NPC.noGravity = true;
        NPC.noTileCollide = true;
        NPC.value = Item.buyPrice(1);
        NPC.SpawnWithHigherTime(30);
        NPC.boss = true;
        NPC.npcSlots = 10f;
        NPC.aiStyle = -1;
        // NPC.BossBar = ModContent.GetInstance<MinionBossBossBar>();
        if (!Main.dedServ)
        {
            // Music = MusicLoader.GetMusicSlot(Mod, "Assets/Music/Ropocalypse2");
        }
    }

    public override void OnKill()
    {
    }

    public override bool CanHitPlayer(Player target, ref int cooldownSlot)
    {
        cooldownSlot = ImmunityCooldownID.Bosses;
        return true;
    }

    public override void AI()
    {
        NPC.dontTakeDamage = true;
        NPC.EncourageDespawn(10);
    }
}