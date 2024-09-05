// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEffectTypeDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E0D")]
  [Serializable]
  public sealed class BattleEffectTypeDetailMaster : BaseMaster<BattleEffectTypeDetailData>
  {
    [Token(Token = "0x60055AF")]
    [Address(RVA = "0x3E2DA88", Offset = "0x3E2DA88", VA = "0x3E2DA88")]
    public IReadOnlyDictionary<int, BattleEffectTypeDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleEffectTypeDetailData>) null;
    }

    [Token(Token = "0x60055B0")]
    [Address(RVA = "0x3E2DA90", Offset = "0x3E2DA90", VA = "0x3E2DA90", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60055B1")]
    [Address(RVA = "0x3E2DAF0", Offset = "0x3E2DAF0", VA = "0x3E2DAF0", Slot = "5")]
    protected override BattleEffectTypeDetailData LoadEntity(IMasterDataReader reader)
    {
      return (BattleEffectTypeDetailData) null;
    }

    [Token(Token = "0x60055B2")]
    [Address(RVA = "0x3E2DB48", Offset = "0x3E2DB48", VA = "0x3E2DB48")]
    public BattleEffectTypeDetailData GetDataByEffectType(BattleEffectTypeEnum effectType)
    {
      return (BattleEffectTypeDetailData) null;
    }

    [Token(Token = "0x60055B3")]
    [Address(RVA = "0x3E2DC50", Offset = "0x3E2DC50", VA = "0x3E2DC50")]
    public BattleEffectTypeDetailMaster()
    {
    }
  }
}
