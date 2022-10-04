using Terraria;
using Terraria.ModLoader;

namespace TerraStory;

public class TerraStoryPlayer : ModPlayer
{
    public uint Exp;
    public uint Level;

    public Item Head;
    public Item Body;
    public Item Leg;

    public Item Weapon;
    public Item SubWeapon;
    
    
    
    public override void Load()
    {
    }

    public override void PreUpdate()
    {
    }
}