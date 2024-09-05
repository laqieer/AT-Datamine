// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveTypeLandScoreMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DD4")]
  [Serializable]
  public sealed class MoveTypeLandScoreMaster : BaseMaster<MoveTypeLandScoreData>
  {
    [Token(Token = "0x4004236")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<MoveTypeLandScoreData>> moveTypeLandScoreTable;

    [Token(Token = "0x6005469")]
    [Address(RVA = "0x3AA524C", Offset = "0x3AA524C", VA = "0x3AA524C")]
    public IReadOnlyDictionary<int, MoveTypeLandScoreData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MoveTypeLandScoreData>) null;
    }

    [Token(Token = "0x600546A")]
    [Address(RVA = "0x3AA5254", Offset = "0x3AA5254", VA = "0x3AA5254", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600546B")]
    [Address(RVA = "0x3AA52B4", Offset = "0x3AA52B4", VA = "0x3AA52B4", Slot = "5")]
    protected override MoveTypeLandScoreData LoadEntity(IMasterDataReader reader)
    {
      return (MoveTypeLandScoreData) null;
    }

    [Token(Token = "0x600546C")]
    [Address(RVA = "0x3AA5324", Offset = "0x3AA5324", VA = "0x3AA5324")]
    private void OnLoadEntity(MoveTypeLandScoreData entity)
    {
    }

    [Token(Token = "0x600546D")]
    [Address(RVA = "0x3AA5328", Offset = "0x3AA5328", VA = "0x3AA5328")]
    private void GroupingByMoveTypeId(MoveTypeLandScoreData entity)
    {
    }

    [Token(Token = "0x600546E")]
    [Address(RVA = "0x3AA5480", Offset = "0x3AA5480", VA = "0x3AA5480")]
    public IReadOnlyCollection<MoveTypeLandScoreData> GetListByMoveData(MoveData moveData)
    {
      return (IReadOnlyCollection<MoveTypeLandScoreData>) null;
    }

    [Token(Token = "0x600546F")]
    [Address(RVA = "0x3AA5540", Offset = "0x3AA5540", VA = "0x3AA5540")]
    public MoveTypeLandScoreMaster()
    {
    }
  }
}
