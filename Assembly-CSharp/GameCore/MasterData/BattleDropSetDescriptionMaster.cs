// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropSetDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E34")]
  [Serializable]
  public sealed class BattleDropSetDescriptionMaster : BaseMaster<BattleDropSetDescriptionData>
  {
    [Token(Token = "0x600567F")]
    [Address(RVA = "0x3E37370", Offset = "0x3E37370", VA = "0x3E37370")]
    public IReadOnlyDictionary<int, BattleDropSetDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDropSetDescriptionData>) null;
    }

    [Token(Token = "0x6005680")]
    [Address(RVA = "0x3E37378", Offset = "0x3E37378", VA = "0x3E37378", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005681")]
    [Address(RVA = "0x3E373D8", Offset = "0x3E373D8", VA = "0x3E373D8", Slot = "5")]
    protected override BattleDropSetDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDropSetDescriptionData) null;
    }

    [Token(Token = "0x6005682")]
    [Address(RVA = "0x3E37430", Offset = "0x3E37430", VA = "0x3E37430")]
    public BattleDropSetDescriptionMaster()
    {
    }
  }
}
