// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityWorkAbilityEffectMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200122F")]
  [Serializable]
  public sealed class StoryFacilityWorkAbilityEffectMaster : 
    BaseMaster<StoryFacilityWorkAbilityEffectData>
  {
    [Token(Token = "0x600678C")]
    [Address(RVA = "0x4D307B8", Offset = "0x4D307B8", VA = "0x4D307B8")]
    public IReadOnlyDictionary<int, StoryFacilityWorkAbilityEffectData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityWorkAbilityEffectData>) null;
    }

    [Token(Token = "0x600678D")]
    [Address(RVA = "0x4D307C0", Offset = "0x4D307C0", VA = "0x4D307C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600678E")]
    [Address(RVA = "0x4D30820", Offset = "0x4D30820", VA = "0x4D30820", Slot = "5")]
    protected override StoryFacilityWorkAbilityEffectData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityWorkAbilityEffectData) null;
    }

    [Token(Token = "0x600678F")]
    [Address(RVA = "0x4D30878", Offset = "0x4D30878", VA = "0x4D30878")]
    public IEnumerable<StoryFacilityWorkAbilityEffectData> GetList(int facilityAttachID)
    {
      return (IEnumerable<StoryFacilityWorkAbilityEffectData>) null;
    }

    [Token(Token = "0x6006790")]
    [Address(RVA = "0x4D30980", Offset = "0x4D30980", VA = "0x4D30980")]
    public StoryFacilityWorkAbilityEffectMaster()
    {
    }
  }
}
