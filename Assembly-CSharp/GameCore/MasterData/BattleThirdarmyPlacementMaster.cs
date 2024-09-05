// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyPlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E70")]
  [Serializable]
  public sealed class BattleThirdarmyPlacementMaster : BaseMaster<BattleThirdarmyPlacementData>
  {
    [Token(Token = "0x6005815")]
    [Address(RVA = "0x3E45F48", Offset = "0x3E45F48", VA = "0x3E45F48")]
    public IReadOnlyDictionary<int, BattleThirdarmyPlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleThirdarmyPlacementData>) null;
    }

    [Token(Token = "0x6005816")]
    [Address(RVA = "0x3E45F50", Offset = "0x3E45F50", VA = "0x3E45F50", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005817")]
    [Address(RVA = "0x3E45FB0", Offset = "0x3E45FB0", VA = "0x3E45FB0", Slot = "5")]
    protected override BattleThirdarmyPlacementData LoadEntity(IMasterDataReader reader)
    {
      return (BattleThirdarmyPlacementData) null;
    }

    [Token(Token = "0x6005818")]
    [Address(RVA = "0x3E46008", Offset = "0x3E46008", VA = "0x3E46008")]
    public BattleThirdarmyPlacementMaster()
    {
    }
  }
}
