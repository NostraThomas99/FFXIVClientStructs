using FFXIVClientStructs.FFXIV.Component.GUI.AtkModuleInterface;

namespace FFXIVClientStructs.FFXIV.Client.Game.UI;

// Client::Game::UI::Revive
//   Component::GUI::AtkModuleInterface::AtkEventInterface
[StructLayout(LayoutKind.Explicit, Size = 0x30)]
[GenerateInterop]
[Inherits<AtkEventInterface>]
public partial struct Revive {
    //[FieldOffset(0x10)] public byte Stage;
    [FieldOffset(0x14)] public float Timer;
    [FieldOffset(0x24)] public byte ReviveState;
}
