// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleElementChainMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E10")]
  [Serializable]
  public sealed class BattleElementChainMaster : BaseMaster<BattleElementChainData>
  {
    [Token(Token = "0x60055BA")]
    [Address(RVA = "0x3E2DECC", Offset = "0x3E2DECC", VA = "0x3E2DECC")]
    public IReadOnlyDictionary<int, BattleElementChainData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleElementChainData>) null;
    }

    [Token(Token = "0x60055BB")]
    [Address(RVA = "0x3E2DED4", Offset = "0x3E2DED4", VA = "0x3E2DED4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055BC")]
    [Address(RVA = "0x3E2DF34", Offset = "0x3E2DF34", VA = "0x3E2DF34", Slot = "5")]
    protected override BattleElementChainData LoadEntity(IMasterDataReader reader)
    {
      return (BattleElementChainData) null;
    }

    [Token(Token = "0x60055BD")]
    [Address(RVA = "0x3E2DF8C", Offset = "0x3E2DF8C", VA = "0x3E2DF8C")]
    public int GetTotalReduceResistRate(int chainCount) => new int();

    [Token(Token = "0x60055BE")]
    [Address(RVA = "0x3E2E104", Offset = "0x3E2E104", VA = "0x3E2E104")]
    public BattleElementChainMaster()
    {
    }
  }
}
