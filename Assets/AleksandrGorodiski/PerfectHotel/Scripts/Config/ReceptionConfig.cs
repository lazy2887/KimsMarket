using System;
using UnityEngine;

namespace Game.Config
{
    [Serializable]
    [CreateAssetMenu(menuName = "config/receptionconfig")]
    public sealed class ReceptionConfig : ScriptableObject
    {
        public int EntranceFee = 1;
        public ReceptionLvlConfig[] Lvls;
    }

    [Serializable]
    public sealed class ReceptionLvlConfig
    {
        public int TargetUpdateProgress;
        public int ReceptionistCount;
        public int Price;
    }
}

