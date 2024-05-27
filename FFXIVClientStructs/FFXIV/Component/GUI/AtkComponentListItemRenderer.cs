namespace FFXIVClientStructs.FFXIV.Component.GUI;

// Component::GUI::AtkComponentListItemRenderer
//  Component::GUI::AtkComponentButton
//   Component::GUI::AtkComponentBase
//     Component::GUI::AtkEventListener
// common CreateAtkComponent function "E8 ?? ?? ?? ?? 48 8B F8 48 85 C0 0F 84 ?? ?? ?? ?? 49 8B 0F"
// type 14
[GenerateInterop, Inherits<AtkComponentButton>, Inherits<AtkDragDropInterface>(0xF0)]
[StructLayout(LayoutKind.Explicit, Size = 0x1A8)]
public partial struct AtkComponentListItemRenderer {
    [FieldOffset(0x184)] public int ListItemIndex;
}
