// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E2")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskMaster : BaseMaster<StoryAreaEventQuestTaskData>
  {
    [Token(Token = "0x600663A")]
    [Address(RVA = "0x4D23584", Offset = "0x4D23584", VA = "0x4D23584")]
    public IReadOnlyDictionary<int, StoryAreaEventQuestTaskData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaEventQuestTaskData>) null;
    }

    [Token(Token = "0x600663B")]
    [Address(RVA = "0x4D2358C", Offset = "0x4D2358C", VA = "0x4D2358C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600663C")]
    [Address(RVA = "0x4D235EC", Offset = "0x4D235EC", VA = "0x4D235EC", Slot = "5")]
    protected override StoryAreaEventQuestTaskData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaEventQuestTaskData) null;
    }

    [Token(Token = "0x600663D")]
    [Address(RVA = "0x4D23644", Offset = "0x4D23644", VA = "0x4D23644")]
    public IEnumerable<StoryAreaEventQuestTaskData> GetListByQuestID(int questID)
    {
      return (IEnumerable<StoryAreaEventQuestTaskData>) null;
    }

    [Token(Token = "0x600663E")]
    [Address(RVA = "0x4D2374C", Offset = "0x4D2374C", VA = "0x4D2374C")]
    public IEnumerable<StoryAreaEventQuestTaskData> GetList()
    {
      return (IEnumerable<StoryAreaEventQuestTaskData>) null;
    }

    [Token(Token = "0x600663F")]
    [Address(RVA = "0x4D2379C", Offset = "0x4D2379C", VA = "0x4D2379C")]
    public StoryAreaEventQuestTaskMaster()
    {
    }
  }
}
