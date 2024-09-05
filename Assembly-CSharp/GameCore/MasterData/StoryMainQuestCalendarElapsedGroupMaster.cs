// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001291")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedGroupMaster : 
    BaseMaster<StoryMainQuestCalendarElapsedGroupData>
  {
    [Token(Token = "0x40058A9")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryMainQuestCalendarElapsedGroupData> groupTable;

    [Token(Token = "0x6006980")]
    [Address(RVA = "0x48D0DFC", Offset = "0x48D0DFC", VA = "0x48D0DFC")]
    public IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedGroupData>) null;
    }

    [Token(Token = "0x6006981")]
    [Address(RVA = "0x48D0E04", Offset = "0x48D0E04", VA = "0x48D0E04", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006982")]
    [Address(RVA = "0x48D0F70", Offset = "0x48D0F70", VA = "0x48D0F70", Slot = "5")]
    protected override StoryMainQuestCalendarElapsedGroupData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestCalendarElapsedGroupData) null;
    }

    [Token(Token = "0x6006983")]
    [Address(RVA = "0x48D0E6C", Offset = "0x48D0E6C", VA = "0x48D0E6C")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006984")]
    [Address(RVA = "0x48D0FE0", Offset = "0x48D0FE0", VA = "0x48D0FE0")]
    private void OnLoadEntity(StoryMainQuestCalendarElapsedGroupData entity)
    {
    }

    [Token(Token = "0x6006985")]
    [Address(RVA = "0x48D1038", Offset = "0x48D1038", VA = "0x48D1038")]
    public List<StoryMainQuestCalendarElapsedGroupData> GetGroupList(int groupID)
    {
      return (List<StoryMainQuestCalendarElapsedGroupData>) null;
    }

    [Token(Token = "0x6006986")]
    [Address(RVA = "0x48D1090", Offset = "0x48D1090", VA = "0x48D1090")]
    public StoryMainQuestCalendarElapsedGroupMaster()
    {
    }
  }
}
