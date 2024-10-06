// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMoveCountInvEffectRatioMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E20")]
  [Serializable]
  public sealed class BattleMoveCountInvEffectRatioMaster : 
    BaseMaster<BattleMoveCountInvEffectRatioData>,
    IBattleGroupEffectDataGetter<BattleMoveCountInvEffectRatioData>
  {
    [Token(Token = "0x400434D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleMoveCountInvEffectRatioData>> mapByGroup;

    [Token(Token = "0x600560E")]
    [Address(RVA = "0x3E31474", Offset = "0x3E31474", VA = "0x3E31474")]
    public IReadOnlyDictionary<int, BattleMoveCountInvEffectRatioData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleMoveCountInvEffectRatioData>) null;
    }

    [Token(Token = "0x600560F")]
    [Address(RVA = "0x3E3147C", Offset = "0x3E3147C", VA = "0x3E3147C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005610")]
    [Address(RVA = "0x3E314DC", Offset = "0x3E314DC", VA = "0x3E314DC", Slot = "5")]
    protected override BattleMoveCountInvEffectRatioData LoadEntity(IMasterDataReader reader)
    {
      return (BattleMoveCountInvEffectRatioData) null;
    }

    [Token(Token = "0x6005611")]
    [Address(RVA = "0x3E3154C", Offset = "0x3E3154C", VA = "0x3E3154C")]
    private void OnLoadEntity(BattleMoveCountInvEffectRatioData entity)
    {
    }

    [Token(Token = "0x6005612")]
    [Address(RVA = "0x3E316A0", Offset = "0x3E316A0", VA = "0x3E316A0", Slot = "6")]
    public BattleMoveCountInvEffectRatioData GetByGroupAndValue(int groupId, int value)
    {
      return (BattleMoveCountInvEffectRatioData) null;
    }

    [Token(Token = "0x6005613")]
    [Address(RVA = "0x3E31850", Offset = "0x3E31850", VA = "0x3E31850")]
    public BattleMoveCountInvEffectRatioMaster()
    {
    }
  }
}
