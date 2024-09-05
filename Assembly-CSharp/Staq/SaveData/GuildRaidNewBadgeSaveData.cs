// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GuildRaidNewBadgeSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D20")]
  public class GuildRaidNewBadgeSaveData
  {
    [Token(Token = "0x4010CF5")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<int, GuildRaidNewBadgeSaveData.GuildRaidNewBadgeData> guildRaidNewBadgeData;

    [Token(Token = "0x17005033")]
    private static string Path
    {
      [Token(Token = "0x6018902"), Address(RVA = "0x2943CA8", Offset = "0x2943CA8", VA = "0x2943CA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018903")]
    [Address(RVA = "0x2943CF8", Offset = "0x2943CF8", VA = "0x2943CF8")]
    public string GetPath() => (string) null;

    [Token(Token = "0x6018904")]
    [Address(RVA = "0x2943D40", Offset = "0x2943D40", VA = "0x2943D40")]
    public void DeleteFile()
    {
    }

    [Token(Token = "0x6018905")]
    [Address(RVA = "0x2943D6C", Offset = "0x2943D6C", VA = "0x2943D6C")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018906")]
    [Address(RVA = "0x2943D84", Offset = "0x2943D84", VA = "0x2943D84")]
    public void Load()
    {
    }

    [Token(Token = "0x6018907")]
    [Address(RVA = "0x29440A0", Offset = "0x29440A0", VA = "0x29440A0")]
    public void Save()
    {
    }

    [Token(Token = "0x6018908")]
    [Address(RVA = "0x2943F04", Offset = "0x2943F04", VA = "0x2943F04")]
    public bool IsExist() => new bool();

    [Token(Token = "0x6018909")]
    [Address(RVA = "0x2943F18", Offset = "0x2943F18", VA = "0x2943F18")]
    private void ExchangeSaveData(staq.SaveSchema.GuildRaidNewBadgeData dataList)
    {
    }

    [Token(Token = "0x601890A")]
    [Address(RVA = "0x294414C", Offset = "0x294414C", VA = "0x294414C")]
    private VectorOffset CreateGuildRaidNewBadgeDataVector(FlatBufferBuilder fbb)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x601890B")]
    [Address(RVA = "0x29442FC", Offset = "0x29442FC", VA = "0x29442FC")]
    public bool GetIsOpen(int raidId) => new bool();

    [Token(Token = "0x601890C")]
    [Address(RVA = "0x2944388", Offset = "0x2944388", VA = "0x2944388")]
    public bool GetIsHeld(int raidId) => new bool();

    [Token(Token = "0x601890D")]
    [Address(RVA = "0x2944414", Offset = "0x2944414", VA = "0x2944414")]
    public void UpdateGuildRaidNewBadgeData(int raidId, bool isOpen, bool isHeld)
    {
    }

    [Token(Token = "0x601890E")]
    [Address(RVA = "0x294452C", Offset = "0x294452C", VA = "0x294452C")]
    public GuildRaidNewBadgeSaveData()
    {
    }

    [Token(Token = "0x2003D21")]
    public class GuildRaidNewBadgeData
    {
      [Token(Token = "0x4010CF6")]
      [FieldOffset(Offset = "0x10")]
      public int RaidId;
      [Token(Token = "0x4010CF7")]
      [FieldOffset(Offset = "0x14")]
      public bool IsOpen;
      [Token(Token = "0x4010CF8")]
      [FieldOffset(Offset = "0x15")]
      public bool IsHeld;

      [Token(Token = "0x601890F")]
      [Address(RVA = "0x29442BC", Offset = "0x29442BC", VA = "0x29442BC")]
      public GuildRaidNewBadgeData(int raidId, bool isOpen, bool isHeld)
      {
      }
    }
  }
}
