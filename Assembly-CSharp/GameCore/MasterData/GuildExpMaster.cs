// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildExpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF2")]
  [Serializable]
  public sealed class GuildExpMaster : BaseMaster<GuildExpData>
  {
    [Token(Token = "0x6005D11")]
    [Address(RVA = "0x2790774", Offset = "0x2790774", VA = "0x2790774")]
    public IReadOnlyDictionary<int, GuildExpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, GuildExpData>) null;
    }

    [Token(Token = "0x6005D12")]
    [Address(RVA = "0x279077C", Offset = "0x279077C", VA = "0x279077C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005D13")]
    [Address(RVA = "0x27907DC", Offset = "0x27907DC", VA = "0x27907DC", Slot = "5")]
    protected override GuildExpData LoadEntity(IMasterDataReader reader) => (GuildExpData) null;

    [Token(Token = "0x6005D14")]
    [Address(RVA = "0x2790834", Offset = "0x2790834", VA = "0x2790834")]
    public int GetLevelWithExp(int experision) => new int();

    [Token(Token = "0x6005D15")]
    [Address(RVA = "0x2790850", Offset = "0x2790850", VA = "0x2790850")]
    public GuildExpData GetExpDataWithExp(int experision) => (GuildExpData) null;

    [Token(Token = "0x6005D16")]
    [Address(RVA = "0x2790A14", Offset = "0x2790A14", VA = "0x2790A14")]
    public GuildExpData GetExpDataWithLevel(int level) => (GuildExpData) null;

    [Token(Token = "0x6005D17")]
    [Address(RVA = "0x2790BD4", Offset = "0x2790BD4", VA = "0x2790BD4")]
    public float GetProgressToNextLevel(int experience) => new float();

    [Token(Token = "0x6005D18")]
    [Address(RVA = "0x2790CAC", Offset = "0x2790CAC", VA = "0x2790CAC")]
    public int GetNextLevelNeedExp(int experience) => new int();

    [Token(Token = "0x6005D19")]
    [Address(RVA = "0x2790D70", Offset = "0x2790D70", VA = "0x2790D70")]
    public int GetLevelCap() => new int();

    [Token(Token = "0x6005D1A")]
    [Address(RVA = "0x2790DE8", Offset = "0x2790DE8", VA = "0x2790DE8")]
    public GuildExpMaster()
    {
    }
  }
}
