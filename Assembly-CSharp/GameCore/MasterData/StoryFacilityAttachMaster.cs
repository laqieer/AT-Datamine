// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityAttachMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001214")]
  [Serializable]
  public sealed class StoryFacilityAttachMaster : BaseMaster<StoryFacilityAttachData>
  {
    [Token(Token = "0x400567E")]
    public const string TEXT_AB = "text_masterdata_story";
    [Token(Token = "0x400567F")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFacilityAttachData>> groupingTable;

    [Token(Token = "0x6006707")]
    [Address(RVA = "0x4D2B22C", Offset = "0x4D2B22C", VA = "0x4D2B22C")]
    public IReadOnlyDictionary<int, StoryFacilityAttachData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityAttachData>) null;
    }

    [Token(Token = "0x6006708")]
    [Address(RVA = "0x4D2B234", Offset = "0x4D2B234", VA = "0x4D2B234", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006709")]
    [Address(RVA = "0x4D2B33C", Offset = "0x4D2B33C", VA = "0x4D2B33C", Slot = "5")]
    protected override StoryFacilityAttachData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityAttachData) null;
    }

    [Token(Token = "0x600670A")]
    [Address(RVA = "0x4D2B29C", Offset = "0x4D2B29C", VA = "0x4D2B29C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600670B")]
    [Address(RVA = "0x4D2B3AC", Offset = "0x4D2B3AC", VA = "0x4D2B3AC")]
    private void OnLoadEntity(StoryFacilityAttachData entity)
    {
    }

    [Token(Token = "0x600670C")]
    [Address(RVA = "0x4D2B590", Offset = "0x4D2B590", VA = "0x4D2B590")]
    public IReadOnlyList<StoryFacilityAttachData> GetCollection(int facilityLabel)
    {
      return (IReadOnlyList<StoryFacilityAttachData>) null;
    }

    [Token(Token = "0x600670D")]
    [Address(RVA = "0x4D2B64C", Offset = "0x4D2B64C", VA = "0x4D2B64C")]
    public IEnumerable<StoryFacilityAttachData> GetList()
    {
      return (IEnumerable<StoryFacilityAttachData>) null;
    }

    [Token(Token = "0x600670E")]
    [Address(RVA = "0x4D2B69C", Offset = "0x4D2B69C", VA = "0x4D2B69C")]
    public StoryFacilityAttachMaster()
    {
    }
  }
}
