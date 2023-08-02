using UnityEngine;

namespace Game.Config
{
    [SerializeField]
    [CreateAssetMenu(menuName = "config/areaconfig")]
    public sealed class AreaConfig : ScriptableObject
    {
        [Min(1)] public int Number;
        [Min(1)] public int TargetLvl;
        public int PricePurchase;
    }
}
