using PulsarModLoader;
using PulsarModLoader.CustomGUI;
using UnityEngine;

namespace PrivateByDefault
{
    public class Mod : PulsarMod
    {
        public override string HarmonyIdentifier() => "Mest.PrivateByDefault";
        public override string Name => "Private By Default";
        public override string Version => "0.0.1";
        public override string Author => "Mest";
        public override string ShortDescription => "When creating a game, default setting is private.";
    }
    internal class Config : ModSettingsMenu
    {
        public override void Draw()
        {
            GUILayout.BeginHorizontal();
            Enabled.Value = GUILayout.Toggle(Enabled.Value, "Private games by default");
            PasswordEnabled.Value = GUILayout.Toggle(PasswordEnabled.Value, "Use last password");
            GUILayout.Label($"Last Password: {Password.Value}");
            GUILayout.EndHorizontal();
        }

        public override string Name() => "Private By Default Config";
        public static SaveValue<bool> Enabled = new SaveValue<bool>("Enabled", true);
        public static SaveValue<bool> PasswordEnabled = new SaveValue<bool>("PasswordEnabled", true);
        public static SaveValue<string> Password = new SaveValue<string>("Password", "");
    }
}
