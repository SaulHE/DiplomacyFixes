﻿using MBOptionScreen.Attributes;
using MBOptionScreen.Attributes.v2;
using MBOptionScreen.Settings;
using TaleWorlds.Localization;

namespace DiplomacyFixes
{
    class Settings : AttributeSettings<Settings>
    {
        private const string HeadingKingdomDiplomacy = "{=sBw5Qzq3}Kingdom Diplomacy";
        private const string HeadingInfluenceCostsScaling = "{=9PlT57Nl}Influence Costs/Scaling";
        private const string HeadingInfluenceCostsFlat = "{=BazjeCZw}Influence Costs/Flat";
        private const string HeadingMessengers = "{=nueOs6m9}Messengers";
        private const string HeadingInfluenceCosts = "{=SEViwYTl}Influence Costs";

        public override string Id { get; set; } = "DiplomacyFixesSettings_1";

        public override string ModuleFolderName { get; } = "DiplomacyFixes";

        public override string ModName { get; } = new TextObject("{=MYz8nKqq}Diplomacy Fixes").ToString();

        [SettingPropertyBool(displayName: "{=6m1SspFW}Enable Player Kingdom Diplomacy Control", Order = 0, RequireRestart = false, HintText = "{=N5EouSSj}Gives the player total control over their kingdom's war and peace declarations.")]
        [SettingPropertyGroup(HeadingKingdomDiplomacy)]
        public bool PlayerDiplomacyControl { get; set; } = true;

        [SettingPropertyBool(displayName: "{=WbOKuWbQ}Enable Influence Costs", Order = -1, RequireRestart = false, HintText = "{=K2vLGalN}If disabled, this removes all costs for war and peace declaration actions. Default value is true.")]
        [SettingPropertyGroup(HeadingInfluenceCosts, isMainToggle: true)]
        public bool EnableInfluenceCostsForDiplomacyActions { get; set; } = true;

        [SettingPropertyBool(displayName: "{=P1g6Ht1e}Enable Scaling Influence Cost", Order = 0, RequireRestart = false, HintText = "{=xfVFBxfj}If enabled, this will scale influence costs based on your kingdom size. Otherwise, flat influence costs are used. Default value is true.")]
        [SettingPropertyGroup(HeadingInfluenceCosts)]
        public bool ScalingInfluenceCosts { get; set; } = true;

        [SettingPropertyFloatingInteger(displayName: "{=TvAYJv5Q}Scaling Influence Cost Multiplier", 0, 100, Order = 1, RequireRestart = false, HintText = "{=AQ5gRYN6}Multiplier for the scaling influence costs. Default value is 5.")]
        [SettingPropertyGroup(HeadingInfluenceCosts, order: 0)]
        public float ScalingInfluenceCostMultiplier { get; set; } = 5.0f;

        [SettingPropertyInteger(displayName: "{=OnTeAgin}Flat Declare War Influence Cost", 0, 10000, Order = 2, RequireRestart = false, HintText = "{=O5XvybTI}Influence cost for declaring war on another kingdom. Default value is 100.")]
        [SettingPropertyGroup(HeadingInfluenceCosts, order: 1)]
        public int DeclareWarInfluenceCost { get; set; } = 100;

        [SettingPropertyInteger("{=iNsXQD2q}Flat Make Peace Influence Cost", 0, 10000, Order = 3, RequireRestart = false, HintText = "{=WB5zdvdT}Influence cost for making peace with another kingdom. Default value is 100.")]
        [SettingPropertyGroup(HeadingInfluenceCosts)]
        public int MakePeaceInfluenceCost { get; set; } = 100;

        [SettingPropertyInteger("{=ZRlNvsev}Minimum War Duration in Days", 0, 500, Order = 1, RequireRestart = false, HintText = "{=vuFT5ns8}The minimum duration (in days) that a war can last before proposing peace. Default value is 10.")]
        [SettingPropertyGroup(HeadingKingdomDiplomacy)]
        public int MinimumWarDurationInDays { get; set; } = 10;

        [SettingPropertyInteger("{=4MzQHMVj}Declare War Cooldown in Days", 0, 500, Order = 2, RequireRestart = false, HintText = "{=q2duqN8d}The minimum duration (in days) to declare war after making peace. Default value is 10.")]
        [SettingPropertyGroup(HeadingKingdomDiplomacy)]
        public int DeclareWarCooldownInDays { get; set; } = 10;

        [SettingPropertyInteger("{=qeDOmURl}Send Messenger Influence Cost", 0, 10000, RequireRestart = false, HintText = "{=Lkos6GQb}Influence cost for sending a messenger to another leader. Default value is 20.")]
        [SettingPropertyGroup(HeadingMessengers)]
        public int SendMessengerInfluenceCost { get; set; } = 100;

        [SettingPropertyInteger("{=nnXi6MmH}Messenger Travel Time in Days", 0, 500, RequireRestart = false, HintText = "{=zkvCGLuK}The amount of time (in days) a messenger takes to reach a kingdom's leader. Default value is 3.")]
        [SettingPropertyGroup(HeadingMessengers)]
        public int MessengerTravelTime { get; set; } = 3;
    }
}
