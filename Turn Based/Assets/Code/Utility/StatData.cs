using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatData
{
    public enum StatTypes
    {
        Attack, Special_Attack, Defense, Special_Defense, Speed
    }

    public StatTypes statType; //Type of stat referenced
    public float statValue; //Actual value of the stat
    [Range(-6, 6)] public int statStage; //Value stage, how many times it was reduced or increased
}
