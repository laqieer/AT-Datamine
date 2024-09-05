// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFailedConditionNameMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E12")]
  [Serializable]
  public sealed class BattleFailedConditionNameMaster : BaseMaster<BattleFailedConditionNameData>
  {
    [Token(Token = "0x4004317")]
    public const string TEXT_AB = "text_masterdata_battle";

    [Token(Token = "0x60055C3")]
    [Address(RVA = "0x3E2E35C", Offset = "0x3E2E35C", VA = "0x3E2E35C")]
    public IReadOnlyDictionary<int, BattleFailedConditionNameData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleFailedConditionNameData>) null;
    }

    [Token(Token = "0x60055C4")]
    [Address(RVA = "0x3E2E364", Offset = "0x3E2E364", VA = "0x3E2E364", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055C5")]
    [Address(RVA = "0x3E2E3C4", Offset = "0x3E2E3C4", VA = "0x3E2E3C4", Slot = "5")]
    protected override BattleFailedConditionNameData LoadEntity(IMasterDataReader reader)
    {
      return (BattleFailedConditionNameData) null;
    }

    [Token(Token = "0x60055C6")]
    [Address(RVA = "0x3E2E41C", Offset = "0x3E2E41C", VA = "0x3E2E41C")]
    public BattleFailedConditionNameMaster()
    {
    }
  }
}
