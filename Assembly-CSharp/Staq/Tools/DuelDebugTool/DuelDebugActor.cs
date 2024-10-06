// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x200097C")]
  [Serializable]
  public class DuelDebugActor : IDuelDebugToolCharacterSettings
  {
    [Token(Token = "0x4002C17")]
    [FieldOffset(Offset = "0x10")]
    public bool IsAvailable;
    [Token(Token = "0x4002C18")]
    [FieldOffset(Offset = "0x14")]
    public int StyleId;
    [Token(Token = "0x4002C19")]
    [FieldOffset(Offset = "0x18")]
    public string DuelMotionType;
    [Token(Token = "0x4002C1A")]
    [FieldOffset(Offset = "0x20")]
    public string SkillMotionType;
    [Token(Token = "0x4002C1B")]
    [FieldOffset(Offset = "0x28")]
    public string OverrideMotionType;
    [Token(Token = "0x4002C1C")]
    [FieldOffset(Offset = "0x30")]
    public int WeaponId;
    [Token(Token = "0x4002C1D")]
    [FieldOffset(Offset = "0x38")]
    public string WeaponClassType;
    [Token(Token = "0x4002C1E")]
    [FieldOffset(Offset = "0x40")]
    public int VehicleStyleId;
    [Token(Token = "0x4002C1F")]
    [FieldOffset(Offset = "0x44")]
    public SexTypeEnum Gender;
    [Token(Token = "0x4002C20")]
    [FieldOffset(Offset = "0x48")]
    public bool IsBadStatus;
    [Token(Token = "0x4002C21")]
    [FieldOffset(Offset = "0x4C")]
    public BattleBadStatusTypeEnum BadStatusType;

    [Token(Token = "0x60035ED")]
    [Address(RVA = "0x3530F30", Offset = "0x3530F30", VA = "0x3530F30")]
    public DuelDebugActor Clone() => (DuelDebugActor) null;

    [Token(Token = "0x60035EE")]
    [Address(RVA = "0x3530FE0", Offset = "0x3530FE0", VA = "0x3530FE0")]
    public static DuelDebugActor CreateDefaultAttacker() => (DuelDebugActor) null;

    [Token(Token = "0x60035EF")]
    [Address(RVA = "0x35310CC", Offset = "0x35310CC", VA = "0x35310CC")]
    public static DuelDebugActor CreateDefaultDefender() => (DuelDebugActor) null;

    [Token(Token = "0x60035F0")]
    [Address(RVA = "0x35310D0", Offset = "0x35310D0", VA = "0x35310D0")]
    public static DuelDebugActor CreateDefaultAttackerSupporter() => (DuelDebugActor) null;

    [Token(Token = "0x60035F1")]
    [Address(RVA = "0x35311B8", Offset = "0x35311B8", VA = "0x35311B8")]
    public static DuelDebugActor CreateDefaultDefenderSupporter() => (DuelDebugActor) null;

    [Token(Token = "0x60035F2")]
    [Address(RVA = "0x35311BC", Offset = "0x35311BC", VA = "0x35311BC", Slot = "4")]
    public bool GetIsAvailable() => new bool();

    [Token(Token = "0x60035F3")]
    [Address(RVA = "0x35311C4", Offset = "0x35311C4", VA = "0x35311C4", Slot = "5")]
    public string GetWeaponClass() => (string) null;

    [Token(Token = "0x60035F4")]
    [Address(RVA = "0x35311CC", Offset = "0x35311CC", VA = "0x35311CC", Slot = "7")]
    public int GetWeaponID() => new int();

    [Token(Token = "0x60035F5")]
    [Address(RVA = "0x35311D4", Offset = "0x35311D4", VA = "0x35311D4", Slot = "8")]
    public int GetCharacterID() => new int();

    [Token(Token = "0x60035F6")]
    [Address(RVA = "0x3531280", Offset = "0x3531280", VA = "0x3531280", Slot = "9")]
    public int GetCharacterStyleID() => new int();

    [Token(Token = "0x60035F7")]
    [Address(RVA = "0x3531288", Offset = "0x3531288", VA = "0x3531288", Slot = "10")]
    public string GetDuelMotionType() => (string) null;

    [Token(Token = "0x60035F8")]
    [Address(RVA = "0x3531290", Offset = "0x3531290", VA = "0x3531290", Slot = "11")]
    public string GetCommonSkillMotionType() => (string) null;

    [Token(Token = "0x60035F9")]
    [Address(RVA = "0x3531298", Offset = "0x3531298", VA = "0x3531298", Slot = "6")]
    public string GetOverrideMotionType() => (string) null;

    [Token(Token = "0x60035FA")]
    [Address(RVA = "0x35312A0", Offset = "0x35312A0", VA = "0x35312A0", Slot = "12")]
    public int GetVehicleStyleID() => new int();

    [Token(Token = "0x60035FB")]
    [Address(RVA = "0x35312A8", Offset = "0x35312A8", VA = "0x35312A8", Slot = "13")]
    public SexTypeEnum GetGender() => new SexTypeEnum();

    [Token(Token = "0x60035FC")]
    [Address(RVA = "0x35312B0", Offset = "0x35312B0", VA = "0x35312B0", Slot = "14")]
    public bool GetIsAbnormalState() => new bool();

    [Token(Token = "0x60035FD")]
    [Address(RVA = "0x35312B8", Offset = "0x35312B8", VA = "0x35312B8", Slot = "15")]
    public BattleBadStatusTypeEnum GetAbnormalState() => new BattleBadStatusTypeEnum();

    [Token(Token = "0x60035FE")]
    [Address(RVA = "0x35312C0", Offset = "0x35312C0", VA = "0x35312C0", Slot = "16")]
    public int GetMaxHP() => new int();

    [Token(Token = "0x60035FF")]
    [Address(RVA = "0x35312C8", Offset = "0x35312C8", VA = "0x35312C8", Slot = "17")]
    public int GetCurrentHP() => new int();

    [Token(Token = "0x6003600")]
    [Address(RVA = "0x3530FD8", Offset = "0x3530FD8", VA = "0x3530FD8")]
    public DuelDebugActor()
    {
    }
  }
}
