// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012AE")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedGroupMaster : 
    BaseMaster<StoryMainQuestTimeZoneElapsedGroupData>
  {
    [Token(Token = "0x40058FF")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryMainQuestTimeZoneElapsedGroupData> groupTable;

    [Token(Token = "0x6006A13")]
    [Address(RVA = "0x48D63DC", Offset = "0x48D63DC", VA = "0x48D63DC")]
    public IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedGroupData>) null;
    }

    [Token(Token = "0x6006A14")]
    [Address(RVA = "0x48D63E4", Offset = "0x48D63E4", VA = "0x48D63E4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A15")]
    [Address(RVA = "0x48D6550", Offset = "0x48D6550", VA = "0x48D6550", Slot = "5")]
    protected override StoryMainQuestTimeZoneElapsedGroupData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestTimeZoneElapsedGroupData) null;
    }

    [Token(Token = "0x6006A16")]
    [Address(RVA = "0x48D644C", Offset = "0x48D644C", VA = "0x48D644C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006A17")]
    [Address(RVA = "0x48D65C0", Offset = "0x48D65C0", VA = "0x48D65C0")]
    private void OnLoadEntity(StoryMainQuestTimeZoneElapsedGroupData entity)
    {
    }

    [Token(Token = "0x6006A18")]
    [Address(RVA = "0x48D6618", Offset = "0x48D6618", VA = "0x48D6618")]
    public List<StoryMainQuestTimeZoneElapsedGroupData> GetGroupList(int groupID)
    {
      return (List<StoryMainQuestTimeZoneElapsedGroupData>) null;
    }

    [Token(Token = "0x6006A19")]
    [Address(RVA = "0x48D6670", Offset = "0x48D6670", VA = "0x48D6670")]
    public StoryMainQuestTimeZoneElapsedGroupMaster()
    {
    }
  }
}
