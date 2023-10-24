using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using SeamenCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace SeamenCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class SeamenCards : BaseUnityPlugin
    {
        private const string ModId = "com.CrappyToast.SeamenCards";
        private const string ModName = "SeamenCards";
        public const string ModInitials = "SeamenCards";

        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?

        public static SeamenCards instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            //building cards:
            //CustomCard.BuildCard<CARDNAME>();

            instance = this;
        }
    }
}
