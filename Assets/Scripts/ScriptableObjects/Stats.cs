using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    public class Stats : ScriptableObject
    {
        public double Energy { get; set; }
        public double EnergyLimit { get; set; }
        public double Stamina { get; set; }
        public double StaminaLimit { get; set; }
        public double AttackSpeed { get; set; }
        public double BlockChange { get; set; }
        public double EvasionChance { get; set; }
        public double PartyChance { get; set; }
        public double WeightLimit { get; set; }
        public double Pose { get; set; }
        public double Damage { get; set; }
        public Resistances resistances { get; set; }
    }
}
