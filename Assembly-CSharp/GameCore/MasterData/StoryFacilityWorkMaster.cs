// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityWorkMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001232")]
  [Serializable]
  public sealed class StoryFacilityWorkMaster : BaseMaster<StoryFacilityWorkData>
  {
    [Token(Token = "0x40056F5")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006797")]
    [Address(RVA = "0x4D30D50", Offset = "0x4D30D50", VA = "0x4D30D50")]
    public IReadOnlyDictionary<int, StoryFacilityWorkData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityWorkData>) null;
    }

    [Token(Token = "0x6006798")]
    [Address(RVA = "0x4D30D58", Offset = "0x4D30D58", VA = "0x4D30D58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006799")]
    [Address(RVA = "0x4D30DB8", Offset = "0x4D30DB8", VA = "0x4D30DB8", Slot = "5")]
    protected override StoryFacilityWorkData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityWorkData) null;
    }

    [Token(Token = "0x600679A")]
    [Address(RVA = "0x4D30E10", Offset = "0x4D30E10", VA = "0x4D30E10")]
    public IEnumerable<StoryFacilityWorkData> GetList(int facilityAttachID)
    {
      return (IEnumerable<StoryFacilityWorkData>) null;
    }

    [Token(Token = "0x600679B")]
    [Address(RVA = "0x4D30F18", Offset = "0x4D30F18", VA = "0x4D30F18")]
    public StoryFacilityWorkMaster()
    {
    }
  }
}
