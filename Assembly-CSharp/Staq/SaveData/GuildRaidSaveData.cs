// Decompiled with JetBrains decompiler
// Type: staq.SaveData.GuildRaidSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FlatBuffers;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003D22")]
  public class GuildRaidSaveData
  {
    [Token(Token = "0x4010CF9")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, GuildRaidSaveData.GuildRaidLocalData> guildRaidLocalData;

    [Token(Token = "0x17005034")]
    private string LocalPersistPath
    {
      [Token(Token = "0x6018910"), Address(RVA = "0x29445A8", Offset = "0x29445A8", VA = "0x29445A8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17005035")]
    private string GetPath
    {
      [Token(Token = "0x6018911"), Address(RVA = "0x29445F8", Offset = "0x29445F8", VA = "0x29445F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018912")]
    [Address(RVA = "0x2944640", Offset = "0x2944640", VA = "0x2944640")]
    public void Load()
    {
    }

    [Token(Token = "0x6018913")]
    [Address(RVA = "0x29448BC", Offset = "0x29448BC", VA = "0x29448BC")]
    private GuildRaidSaveData.GuildRaidLocalData GetData(int raidId)
    {
      return (GuildRaidSaveData.GuildRaidLocalData) null;
    }

    [Token(Token = "0x6018914")]
    [Address(RVA = "0x294492C", Offset = "0x294492C", VA = "0x294492C")]
    public bool TryGetLapNum(int raidId, out int clearLapNum) => new bool();

    [Token(Token = "0x6018915")]
    [Address(RVA = "0x2944958", Offset = "0x2944958", VA = "0x2944958")]
    public void UpdateSaveData(int raidIdOfDataToUpdated, int latestClearLapNum)
    {
    }

    [Token(Token = "0x6018916")]
    [Address(RVA = "0x2944B20", Offset = "0x2944B20", VA = "0x2944B20")]
    public void Delete()
    {
    }

    [Token(Token = "0x6018917")]
    [Address(RVA = "0x2944A74", Offset = "0x2944A74", VA = "0x2944A74")]
    private void Save()
    {
    }

    [Token(Token = "0x6018918")]
    [Address(RVA = "0x2944B50", Offset = "0x2944B50", VA = "0x2944B50")]
    private VectorOffset CreateVectorOffset(FlatBufferBuilder flatBufferBuilder)
    {
      return new VectorOffset();
    }

    [Token(Token = "0x6018919")]
    [Address(RVA = "0x2944C98", Offset = "0x2944C98", VA = "0x2944C98")]
    public GuildRaidSaveData()
    {
    }

    [Token(Token = "0x2003D23")]
    public class GuildRaidLocalData
    {
      [Token(Token = "0x4010CFA")]
      [FieldOffset(Offset = "0x10")]
      public readonly int RaidId;
      [Token(Token = "0x4010CFB")]
      [FieldOffset(Offset = "0x14")]
      public int ClearLapNum;

      [Token(Token = "0x601891A")]
      [Address(RVA = "0x2944890", Offset = "0x2944890", VA = "0x2944890")]
      public GuildRaidLocalData(int raidId, int clearLapNum)
      {
      }
    }
  }
}
