// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFailedConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E14")]
  [Serializable]
  public sealed class BattleFailedConditionMaster : BaseMaster<BattleFailedConditionData>
  {
    [Token(Token = "0x4004319")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleFailedConditionData>> mapData;

    [Token(Token = "0x60055CC")]
    [Address(RVA = "0x3E2E668", Offset = "0x3E2E668", VA = "0x3E2E668")]
    public IReadOnlyDictionary<int, BattleFailedConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleFailedConditionData>) null;
    }

    [Token(Token = "0x60055CD")]
    [Address(RVA = "0x3E2E670", Offset = "0x3E2E670", VA = "0x3E2E670", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055CE")]
    [Address(RVA = "0x3E2E6D0", Offset = "0x3E2E6D0", VA = "0x3E2E6D0", Slot = "5")]
    protected override BattleFailedConditionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleFailedConditionData) null;
    }

    [Token(Token = "0x60055CF")]
    [Address(RVA = "0x3E2E740", Offset = "0x3E2E740", VA = "0x3E2E740")]
    private void OnLoadEntity(BattleFailedConditionData entity)
    {
    }

    [Token(Token = "0x60055D0")]
    [Address(RVA = "0x3E2E8BC", Offset = "0x3E2E8BC", VA = "0x3E2E8BC")]
    public List<BattleFailedConditionData> GetListByGroupID(int groupId)
    {
      return (List<BattleFailedConditionData>) null;
    }

    [Token(Token = "0x60055D1")]
    [Address(RVA = "0x3E2E978", Offset = "0x3E2E978", VA = "0x3E2E978")]
    public BattleFailedConditionMaster()
    {
    }
  }
}
