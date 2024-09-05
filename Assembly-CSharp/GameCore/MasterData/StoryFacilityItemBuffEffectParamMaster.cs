// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityItemBuffEffectParamMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001222")]
  [Serializable]
  public sealed class StoryFacilityItemBuffEffectParamMaster : 
    BaseMaster<StoryFacilityItemBuffEffectParamData>
  {
    [Token(Token = "0x40056C0")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFacilityItemBuffEffectParamData>> groupingTable;

    [Token(Token = "0x6006752")]
    [Address(RVA = "0x4D2E46C", Offset = "0x4D2E46C", VA = "0x4D2E46C")]
    public IReadOnlyDictionary<int, StoryFacilityItemBuffEffectParamData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityItemBuffEffectParamData>) null;
    }

    [Token(Token = "0x6006753")]
    [Address(RVA = "0x4D2E474", Offset = "0x4D2E474", VA = "0x4D2E474", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006754")]
    [Address(RVA = "0x4D2E538", Offset = "0x4D2E538", VA = "0x4D2E538", Slot = "5")]
    protected override StoryFacilityItemBuffEffectParamData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityItemBuffEffectParamData) null;
    }

    [Token(Token = "0x6006755")]
    [Address(RVA = "0x4D2E4DC", Offset = "0x4D2E4DC", VA = "0x4D2E4DC")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006756")]
    [Address(RVA = "0x4D2E5A8", Offset = "0x4D2E5A8", VA = "0x4D2E5A8")]
    private void OnLoadEntity(StoryFacilityItemBuffEffectParamData entity)
    {
    }

    [Token(Token = "0x6006757")]
    [Address(RVA = "0x4D2E5AC", Offset = "0x4D2E5AC", VA = "0x4D2E5AC")]
    private void Groupinｇ(StoryFacilityItemBuffEffectParamData entity)
    {
    }

    [Token(Token = "0x6006758")]
    [Address(RVA = "0x4D2E728", Offset = "0x4D2E728", VA = "0x4D2E728")]
    public IReadOnlyCollection<StoryFacilityItemBuffEffectParamData> GetBuffItemEffectsByLabel(
      int facilityItemBuffEffectLabel)
    {
      return (IReadOnlyCollection<StoryFacilityItemBuffEffectParamData>) null;
    }

    [Token(Token = "0x6006759")]
    [Address(RVA = "0x4D2E7E4", Offset = "0x4D2E7E4", VA = "0x4D2E7E4")]
    public StoryFacilityItemBuffEffectParamMaster()
    {
    }
  }
}
