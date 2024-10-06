// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C8")]
  [Serializable]
  public sealed class StyleMasterBonusConditionMaster : BaseMaster<StyleMasterBonusConditionData>
  {
    [Token(Token = "0x6006103")]
    [Address(RVA = "0x28DC38C", Offset = "0x28DC38C", VA = "0x28DC38C")]
    public IReadOnlyDictionary<int, StyleMasterBonusConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleMasterBonusConditionData>) null;
    }

    [Token(Token = "0x6006104")]
    [Address(RVA = "0x28DC394", Offset = "0x28DC394", VA = "0x28DC394", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006105")]
    [Address(RVA = "0x28DC3F4", Offset = "0x28DC3F4", VA = "0x28DC3F4", Slot = "5")]
    protected override StyleMasterBonusConditionData LoadEntity(IMasterDataReader reader)
    {
      return (StyleMasterBonusConditionData) null;
    }

    [Token(Token = "0x6006106")]
    [Address(RVA = "0x28DC44C", Offset = "0x28DC44C", VA = "0x28DC44C")]
    public StyleMasterBonusConditionMaster()
    {
    }
  }
}
