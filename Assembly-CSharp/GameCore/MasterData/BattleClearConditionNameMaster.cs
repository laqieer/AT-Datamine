// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleClearConditionNameMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E05")]
  [Serializable]
  public sealed class BattleClearConditionNameMaster : BaseMaster<BattleClearConditionNameData>
  {
    [Token(Token = "0x40042FA")]
    public const string TEXT_AB = "text_masterdata_battle";

    [Token(Token = "0x6005585")]
    [Address(RVA = "0x3AB1B88", Offset = "0x3AB1B88", VA = "0x3AB1B88")]
    public IReadOnlyDictionary<int, BattleClearConditionNameData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleClearConditionNameData>) null;
    }

    [Token(Token = "0x6005586")]
    [Address(RVA = "0x3AB1B90", Offset = "0x3AB1B90", VA = "0x3AB1B90", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005587")]
    [Address(RVA = "0x3AB1BF0", Offset = "0x3AB1BF0", VA = "0x3AB1BF0", Slot = "5")]
    protected override BattleClearConditionNameData LoadEntity(IMasterDataReader reader)
    {
      return (BattleClearConditionNameData) null;
    }

    [Token(Token = "0x6005588")]
    [Address(RVA = "0x3AB1C48", Offset = "0x3AB1C48", VA = "0x3AB1C48")]
    public BattleClearConditionNameMaster()
    {
    }
  }
}
