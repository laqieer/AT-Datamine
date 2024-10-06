// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityReleaseSequenceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001228")]
  [Serializable]
  public sealed class StoryFacilityReleaseSequenceMaster : 
    BaseMaster<StoryFacilityReleaseSequenceData>
  {
    [Token(Token = "0x40056D7")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryFacilityReleaseSequenceData> groupTable;

    [Token(Token = "0x6006770")]
    [Address(RVA = "0x4D2FAF8", Offset = "0x4D2FAF8", VA = "0x4D2FAF8")]
    public IReadOnlyDictionary<int, StoryFacilityReleaseSequenceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityReleaseSequenceData>) null;
    }

    [Token(Token = "0x6006771")]
    [Address(RVA = "0x4D2FB00", Offset = "0x4D2FB00", VA = "0x4D2FB00", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006772")]
    [Address(RVA = "0x4D2FC6C", Offset = "0x4D2FC6C", VA = "0x4D2FC6C", Slot = "5")]
    protected override StoryFacilityReleaseSequenceData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityReleaseSequenceData) null;
    }

    [Token(Token = "0x6006773")]
    [Address(RVA = "0x4D2FB68", Offset = "0x4D2FB68", VA = "0x4D2FB68")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006774")]
    [Address(RVA = "0x4D2FCDC", Offset = "0x4D2FCDC", VA = "0x4D2FCDC")]
    private void OnLoadEntity(StoryFacilityReleaseSequenceData entity)
    {
    }

    [Token(Token = "0x6006775")]
    [Address(RVA = "0x4D2FD34", Offset = "0x4D2FD34", VA = "0x4D2FD34")]
    public List<StoryFacilityReleaseSequenceData> GetList(int facilityAttachID)
    {
      return (List<StoryFacilityReleaseSequenceData>) null;
    }

    [Token(Token = "0x6006776")]
    [Address(RVA = "0x4D2FD8C", Offset = "0x4D2FD8C", VA = "0x4D2FD8C")]
    public StoryFacilityReleaseSequenceMaster()
    {
    }
  }
}
