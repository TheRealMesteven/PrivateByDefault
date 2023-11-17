using HarmonyLib;

namespace PrivateByDefault
{
    [HarmonyPatch(typeof(PLUICreateGameMenu), "Enter")]
    internal class CreateGamePatch
    {
        private static void Postfix(PLUICreateGameMenu __instance)
        {
            __instance.IsPrivateGame.isOn = Config.Enabled.Value;
            if (Config.PasswordEnabled.Value) __instance.PasswordField.text = Config.Password.Value;
        }
    }
    [HarmonyPatch(typeof(PLUICreateGameMenu), "ClickEngage")]
    internal class EngagePatch
    {
        private static void Prefix(PLUICreateGameMenu __instance)
        {
            Config.Password.Value = __instance.PasswordField.text;
        }
    }
}
