using System.Collections.Generic;

namespace FishingChestsExpanded
{
    public class ModConfig
    {
        public bool EnableMod { get; set; } = true;
        public int VanillaLootChance { get; set; } = 0;
        public int ChanceForTreasureChest { get; set; } = -1;
        public int MaxItems { get; set; } = 10;
        public int ItemsBaseMaxValue { get; set; } = 100;
        public int MinItemValue { get; set; } = 20;
        public int MaxItemValue { get; set; } = -1;
        public int CoinBaseMin { get; set; } = 20;
        public int CoinBaseMax { get; set; } = 100;
        public float IncreaseRate { get; set; } = 0.2f;
        public Dictionary<string, int> ItemListChances { get; set; } = new Dictionary<string, int>
        {
            {"MeleeWeapon", 100},
            {"Shirt", 10},
            {"Pants", 10},
            {"Hat", 10},
            {"Boots", 100},
            {"BigCraftable", 100},
            {"Ring", 100},
            {"Seed", 100},
            {"Mineral", 100},
            {"Relic", 100},
            {"Cooking", 25},
            {"Fish", 25},
            {"BasicObject", 20}
        };
    }
}
