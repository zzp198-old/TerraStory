﻿namespace TerraStory;

public class ExperienceSystem
{
    public int GetLevel(ulong exp)
    {
        return exp switch
        {
            > 100 => 10,
            > 90 => 9,
            > 80 => 8,
            > 70 => 7,
            > 60 => 6,
            > 50 => 5,
            > 40 => 4,
            > 30 => 3,
            > 20 => 2,
            > 10 => 1,
            _ => 0
        };
    }
}