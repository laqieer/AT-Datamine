// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SupportRankMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001370")]
  [Serializable]
  public sealed class SupportRankMaster : BaseMaster<SupportRankData>
  {
    [Token(Token = "0x6006D6A")]
    [Address(RVA = "0x46FC8B8", Offset = "0x46FC8B8", VA = "0x46FC8B8")]
    public IReadOnlyDictionary<int, SupportRankData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SupportRankData>) null;
    }

    [Token(Token = "0x6006D6B")]
    [Address(RVA = "0x46FC8C0", Offset = "0x46FC8C0", VA = "0x46FC8C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006D6C")]
    [Address(RVA = "0x46FC920", Offset = "0x46FC920", VA = "0x46FC920", Slot = "5")]
    protected override SupportRankData LoadEntity(IMasterDataReader reader)
    {
      return (SupportRankData) null;
    }

    [Token(Token = "0x6006D6D")]
    [Address(RVA = "0x46FC978", Offset = "0x46FC978", VA = "0x46FC978")]
    public SupportRankData GetData(SupportRankTypeEnum supportRank) => (SupportRankData) null;

    [Token(Token = "0x6006D6E")]
    [Address(RVA = "0x46FCAFC", Offset = "0x46FCAFC", VA = "0x46FCAFC")]
    public SupportRankData GetDataByExp(int exp) => (SupportRankData) null;

    [Token(Token = "0x6006D6F")]
    [Address(RVA = "0x46FCC8C", Offset = "0x46FCC8C", VA = "0x46FCC8C")]
    public IReadOnlyCollection<SupportRankData> GetList(
      SupportRankTypeEnum startRank,
      SupportRankTypeEnum endRank)
    {
      return (IReadOnlyCollection<SupportRankData>) null;
    }

    [Token(Token = "0x6006D70")]
    [Address(RVA = "0x46FCDA8", Offset = "0x46FCDA8", VA = "0x46FCDA8")]
    public IReadOnlyCollection<SupportRankData> GetListByExp(int exp1, int exp2)
    {
      return (IReadOnlyCollection<SupportRankData>) null;
    }

    [Token(Token = "0x6006D71")]
    [Address(RVA = "0x46FD014", Offset = "0x46FD014", VA = "0x46FD014")]
    public SupportRankMaster()
    {
    }
  }
}
