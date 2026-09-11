using MiraAPI.Keybinds;
using MiraAPI.Translation;
using Rewired;

namespace DivaniMods;

[RegisterCustomKeybinds]
public static class DivaniKeybinds
{
    public static MiraKeybind TeleportPortal1 { get; } = new(
        MiraLocaleManager.Get("DivaniMods.Keybind.TeleportPortal1"),
        KeyboardKeyCode.Alpha1);

    public static MiraKeybind TeleportPortal2 { get; } = new(
        MiraLocaleManager.Get("DivaniMods.Keybind.TeleportPortal2"),
        KeyboardKeyCode.Alpha2);
}
