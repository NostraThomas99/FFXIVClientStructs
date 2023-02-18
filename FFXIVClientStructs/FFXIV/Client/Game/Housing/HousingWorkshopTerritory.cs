﻿[StructLayout(LayoutKind.Explicit, Size = 0xB8C0)]
public unsafe partial struct HousingWorkshopTerritory
{
    [FixedSizeArray<AirshipData>(4)]
    [FieldOffset(0x60)] public fixed byte AirshipDataList[0x1C8 * 4];
    
    [FieldOffset(0x7D8)] public byte ActiveAirshipId; // 0-3, 255 if none
    [FieldOffset(0x7D9)] public byte AirshipCount;
    [FieldOffset(0x7DA)] public byte AirshipMax; // Unsure but seems to always say 4 for it so probably how many you are allowed to own

    [FixedSizeArray<SubmersibleData>(4)]
    [FieldOffset(0x2960)] public fixed byte SubmersibleDataList[0x2320 * 4];

    [FixedSizeArray<Pointer<SubmersibleData>>(5)]
    [FieldOffset(0xB5E0)] public fixed byte SubmersibleDataPointerList[0x8 * 5]; // 0-3 is the same as SubmersibleDataList, 4 is the one you are currently using
}

[StructLayout(LayoutKind.Explicit, Size = 0x1C8)]
public unsafe partial struct AirshipData
{
    [FieldOffset(0xC)] public int RegisterTime; // currently a theory will confirm on a later point when i craft a 2nd airship
    [FieldOffset(0x14)] public byte RankId;
    [FieldOffset(0x18)] public int ReturnTime;
    [FieldOffset(0x1C)] public uint CurrentExp;
    [FieldOffset(0x20)] public uint NextLevelExp;

    [FieldOffset(0x28)] public ushort HullId; // AirshipExplorationPart Key
    [FieldOffset(0x30)] public ushort SternId; // AirshipExplorationPart Key
    [FieldOffset(0x32)] public ushort BowId; // AirshipExplorationPart Key
    [FieldOffset(0x34)] public ushort BridgeId; // AirshipExplorationPart Key

    [FieldOffset(0x36)] public ushort Surveillance;
    [FieldOffset(0x38)] public ushort Retrieval;
    [FieldOffset(0x40)] public ushort Speed;
    [FieldOffset(0x42)] public ushort Range;
    [FieldOffset(0x44)] public ushort Favor;

    [FieldOffset(0x42)] public fixed byte Route[5]; // AirshipExplorationPoint Key

    [FieldOffset(0x3F)] public fixed byte Name[20];

    /// <summary>Gets the registered time as a <see cref="DateTime"/> object</summary>
    public DateTime GetRegisterTime() => DateTime.UnixEpoch.AddSeconds(RegisterTime);

    /// <summary>Gets the return time as a <see cref="DateTime"/> object</summary>
    public DateTime GetReturnTime() => DateTime.UnixEpoch.AddSeconds(ReturnTime);
}

[StructLayout(LayoutKind.Explicit, Size = 0x2320)]
public unsafe partial struct SubmersibleData
{
    [FieldOffset(0x0)] public SubmersibleData* Self;
    [FieldOffset(0x0E)] public byte RankId;
    [FieldOffset(0x10)] public int RegisterTime;
    [FieldOffset(0x14)] public int ReturnTime;

    [FieldOffset(0x22)] public fixed byte Name[20];

    [FieldOffset(0x3A)] public ushort HullId; // SubmarinePart Key
    [FieldOffset(0x3C)] public ushort SternId; // SubmarinePart Key
    [FieldOffset(0x3E)] public ushort BowId; // SubmarinePart Key
    [FieldOffset(0x40)] public ushort BridgeId; // SubmarinePart Key

    [FieldOffset(0x42)] public fixed byte Route[5]; // SubmarineExploration Key

    [FieldOffset(0x4A)] public ushort SurveillanceBase;
    [FieldOffset(0x4C)] public ushort RetrievalBase;
    [FieldOffset(0x4E)] public ushort SpeedBase;
    [FieldOffset(0x50)] public ushort RangeBase;
    [FieldOffset(0x52)] public ushort FavorBase;

    [FieldOffset(0x54)] public ushort SurveillanceBonus;
    [FieldOffset(0x56)] public ushort RetrievalBonus;
    [FieldOffset(0x58)] public ushort SpeedBonus;
    [FieldOffset(0x5A)] public ushort RangeBonus;
    [FieldOffset(0x5C)] public ushort FavorBonus;

    /// <summary>Gets the registered time as a <see cref="DateTime"/> object</summary>
    public DateTime GetRegisterTime() => DateTime.UnixEpoch.AddSeconds(RegisterTime);

    /// <summary>Gets the return time as a <see cref="DateTime"/> object</summary>
    public DateTime GetReturnTime() => DateTime.UnixEpoch.AddSeconds(ReturnTime);
}