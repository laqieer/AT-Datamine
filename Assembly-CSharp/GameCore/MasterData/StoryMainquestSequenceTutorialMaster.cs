// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainquestSequenceTutorialMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012AC")]
  [Serializable]
  public sealed class StoryMainquestSequenceTutorialMaster : 
    BaseMaster<StoryMainquestSequenceTutorialData>
  {
    [Token(Token = "0x40058F9")]
    [FieldOffset(Offset = "0x18")]
    private readonly IReadOnlyList<StoryMainquestSequenceTutorialData> constEmptylist;
    [Token(Token = "0x40058FA")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<StoryMainquestSequenceTutorialData>> groupDict;

    [Token(Token = "0x6006A07")]
    [Address(RVA = "0x48D5984", Offset = "0x48D5984", VA = "0x48D5984")]
    public IReadOnlyDictionary<int, StoryMainquestSequenceTutorialData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainquestSequenceTutorialData>) null;
    }

    [Token(Token = "0x6006A08")]
    [Address(RVA = "0x48D598C", Offset = "0x48D598C", VA = "0x48D598C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A09")]
    [Address(RVA = "0x48D5A44", Offset = "0x48D5A44", VA = "0x48D5A44", Slot = "5")]
    protected override StoryMainquestSequenceTutorialData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainquestSequenceTutorialData) null;
    }

    [Token(Token = "0x6006A0A")]
    [Address(RVA = "0x48D59F4", Offset = "0x48D59F4", VA = "0x48D59F4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006A0B")]
    [Address(RVA = "0x48D5AB4", Offset = "0x48D5AB4", VA = "0x48D5AB4")]
    private void OnLoadEntity(StoryMainquestSequenceTutorialData entity)
    {
    }

    [Token(Token = "0x6006A0C")]
    [Address(RVA = "0x48D5C8C", Offset = "0x48D5C8C", VA = "0x48D5C8C")]
    private IReadOnlyList<StoryMainquestSequenceTutorialData> GetGroupList(int chapterId)
    {
      return (IReadOnlyList<StoryMainquestSequenceTutorialData>) null;
    }

    [Token(Token = "0x6006A0D")]
    [Address(RVA = "0x48D5D20", Offset = "0x48D5D20", VA = "0x48D5D20")]
    public int GetTutorialId(int chapterId, int sequenceId) => new int();

    [Token(Token = "0x6006A0E")]
    [Address(RVA = "0x48D6088", Offset = "0x48D6088", VA = "0x48D6088")]
    public StoryMainquestSequenceTutorialMaster()
    {
    }
  }
}
