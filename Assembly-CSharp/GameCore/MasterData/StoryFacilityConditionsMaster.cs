// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityConditionsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001218")]
  [Serializable]
  public sealed class StoryFacilityConditionsMaster : BaseMaster<StoryFacilityConditionsData>
  {
    [Token(Token = "0x40056A5")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryFacilityConditionsData> groupTable;

    [Token(Token = "0x6006723")]
    [Address(RVA = "0x4D2CD2C", Offset = "0x4D2CD2C", VA = "0x4D2CD2C")]
    public IReadOnlyDictionary<int, StoryFacilityConditionsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityConditionsData>) null;
    }

    [Token(Token = "0x6006724")]
    [Address(RVA = "0x4D2CD34", Offset = "0x4D2CD34", VA = "0x4D2CD34", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006725")]
    [Address(RVA = "0x4D2CEA0", Offset = "0x4D2CEA0", VA = "0x4D2CEA0", Slot = "5")]
    protected override StoryFacilityConditionsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityConditionsData) null;
    }

    [Token(Token = "0x6006726")]
    [Address(RVA = "0x4D2CD9C", Offset = "0x4D2CD9C", VA = "0x4D2CD9C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006727")]
    [Address(RVA = "0x4D2CF10", Offset = "0x4D2CF10", VA = "0x4D2CF10")]
    private void OnLoadEntity(StoryFacilityConditionsData entity)
    {
    }

    [Token(Token = "0x6006728")]
    [Address(RVA = "0x4D2CF68", Offset = "0x4D2CF68", VA = "0x4D2CF68")]
    public List<StoryFacilityConditionsData> GetList(int label)
    {
      return (List<StoryFacilityConditionsData>) null;
    }

    [Token(Token = "0x6006729")]
    [Address(RVA = "0x4D2CFC0", Offset = "0x4D2CFC0", VA = "0x4D2CFC0")]
    public StoryFacilityConditionsMaster()
    {
    }
  }
}
