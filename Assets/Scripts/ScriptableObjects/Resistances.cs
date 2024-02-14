using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    public class Resistances : ScriptableObject
    {
        double PhysicalResistance { get; set; }
        double MagicalResistance { get; set; }
        double FireResistance { get; set; }
        double LightningResistance { get; set; }
        double FrostResistance { get; set; }
        double HolyResistance { get; set; }
        double DarkResistance { get; set; }
        double BlightResistance { get; set; }
        double ToxicResistance { get; set; }
        double EmotionalResistance { get; set; }
    }
}
