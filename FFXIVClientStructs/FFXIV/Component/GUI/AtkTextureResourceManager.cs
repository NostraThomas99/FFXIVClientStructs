using FFXIVClientStructs.FFXIV.Component.Exd;

namespace FFXIVClientStructs.FFXIV.Component.GUI;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x58)]
public unsafe partial struct AtkTextureResourceManager {
    [FieldOffset(0x00)] public StdLinkedList<Pointer<AtkTextureResource>> LoadedTextures;
    [FieldOffset(0x18)] public int DefaultTextureVersion;
    [FieldOffset(0x20)] public ExdModule* ExdModule;
    [FieldOffset(0x28)] public int IconLanguageSheetId;
    [FieldOffset(0x2C)] public int IconLanguage;
    // Icon ranges are inclusive: id ∈ [a,b]
    [FieldOffset(0x30)] internal FixedSizeArray4<StdPair<uint, uint>> _localizedIconRange;
    [FieldOffset(0x50)] public uint LocalizedIconRangeCount;
}
