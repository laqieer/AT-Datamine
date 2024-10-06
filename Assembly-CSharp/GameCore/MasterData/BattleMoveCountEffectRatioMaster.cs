// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMoveCountEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1E")]
  [Serializable]
  public sealed class BattleMoveCountEffectRatioMaster : 
    BaseMaster<BattleMoveCountEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleMoveCountEffectRatioData>
  {
    [Token(Token = "0x4004347")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleMoveCountEffectRatioData>> mapByGroup;

    [Token(Token = "0x6005603")]
    [Address(RVA = "0x3E30D10", Offset = "0x3E30D10", VA = "0x3E30D10")]
    public IReadOnlyDictionary<int, BattleMoveCountEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleMoveCountEffectRatioData>) null;
    }

    [Token(Token = "0x6005604")]
    [Address(RVA = "0x3E30D18", Offset = "0x3E30D18", VA = "0x3E30D18", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005605")]
    [Address(RVA = "0x3E30D78", Offset = "0x3E30D78", VA = "0x3E30D78", Slot = "5")]
    protected override BattleMoveCountEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleMoveCountEffectRatioData) null;
    }

    [Token(Token = "0x6005606")]
    [Address(RVA = "0x3E30DE8", Offset = "0x3E30DE8", VA = "0x3E30DE8")]
    private void OnLoadEntity(BattleMoveCountEffectRatioData entity)
    {
    }

    [Token(Token = "0x6005607")]
    [Address(RVA = "0x3E30F3C", Offset = "0x3E30F3C", VA = "0x3E30F3C", Slot = "6")]
    public BattleMoveCountEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleMoveCountEffectRatioData) null;
    }

    [Token(Token = "0x6005608")]
    [Address(RVA = "0x3E310EC", Offset = "0x3E310EC", VA = "0x3E310EC")]
    public BattleMoveCountEffectRatioMaster()
    {
    }
  }
}
