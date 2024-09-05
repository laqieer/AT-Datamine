// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001103")]
  [Serializable]
  public sealed class AreaQuestAreaMaster : BaseMaster<AreaQuestAreaData>
  {
    [Token(Token = "0x6006215")]
    [Address(RVA = "0x4ADBECC", Offset = "0x4ADBECC", VA = "0x4ADBECC")]
    public IReadOnlyDictionary<int, AreaQuestAreaData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaData>) null;
    }

    [Token(Token = "0x6006216")]
    [Address(RVA = "0x4ADBED4", Offset = "0x4ADBED4", VA = "0x4ADBED4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006217")]
    [Address(RVA = "0x4ADBF34", Offset = "0x4ADBF34", VA = "0x4ADBF34", Slot = "5")]
    protected override AreaQuestAreaData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaData) null;
    }

    [Token(Token = "0x6006218")]
    [Address(RVA = "0x4ADBF8C", Offset = "0x4ADBF8C", VA = "0x4ADBF8C")]
    public AreaQuestAreaData GetDataFirstByAreaGroupId(int areaGroupId) => (AreaQuestAreaData) null;

    [Token(Token = "0x6006219")]
    [Address(RVA = "0x4ADC094", Offset = "0x4ADC094", VA = "0x4ADC094")]
    public IEnumerable<AreaQuestAreaData> GetDataByAreaGroupId(int areaGroupId)
    {
      return (IEnumerable<AreaQuestAreaData>) null;
    }

    [Token(Token = "0x600621A")]
    [Address(RVA = "0x4ADC19C", Offset = "0x4ADC19C", VA = "0x4ADC19C")]
    public AreaQuestAreaMaster()
    {
    }
  }
}
