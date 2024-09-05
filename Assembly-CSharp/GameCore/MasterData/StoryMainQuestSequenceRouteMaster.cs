// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceRouteMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E6")]
  [Serializable]
  public sealed class StoryMainQuestSequenceRouteMaster : BaseMaster<StoryMainQuestSequenceRouteData>
  {
    [Token(Token = "0x400599E")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryMainQuestSequenceRouteData>> groupingTable;
    [Token(Token = "0x400599F")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<StoryMainQuestSequenceRouteData> defaultList;

    [Token(Token = "0x6006AF9")]
    [Address(RVA = "0x48DE110", Offset = "0x48DE110", VA = "0x48DE110")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceRouteData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceRouteData>) null;
    }

    [Token(Token = "0x6006AFA")]
    [Address(RVA = "0x48DE118", Offset = "0x48DE118", VA = "0x48DE118", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AFB")]
    [Address(RVA = "0x48DE1DC", Offset = "0x48DE1DC", VA = "0x48DE1DC", Slot = "5")]
    protected override StoryMainQuestSequenceRouteData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceRouteData) null;
    }

    [Token(Token = "0x6006AFC")]
    [Address(RVA = "0x48DE180", Offset = "0x48DE180", VA = "0x48DE180")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006AFD")]
    [Address(RVA = "0x48DE24C", Offset = "0x48DE24C", VA = "0x48DE24C")]
    private void OnLoadEntity(StoryMainQuestSequenceRouteData entity)
    {
    }

    [Token(Token = "0x6006AFE")]
    [Address(RVA = "0x48DE250", Offset = "0x48DE250", VA = "0x48DE250")]
    private void Grouping(StoryMainQuestSequenceRouteData entity)
    {
    }

    [Token(Token = "0x6006AFF")]
    [Address(RVA = "0x48DE3CC", Offset = "0x48DE3CC", VA = "0x48DE3CC")]
    public IEnumerable<StoryMainQuestSequenceRouteData> GetListBySequenceID(int sequenceID)
    {
      return (IEnumerable<StoryMainQuestSequenceRouteData>) null;
    }

    [Token(Token = "0x6006B00")]
    [Address(RVA = "0x48DE44C", Offset = "0x48DE44C", VA = "0x48DE44C")]
    public StoryRouteData GetFirstBySequenceID(int sequenceID) => (StoryRouteData) null;

    [Token(Token = "0x6006B01")]
    [Address(RVA = "0x48DE560", Offset = "0x48DE560", VA = "0x48DE560")]
    public IEnumerable<int> GetRouteIDsBySequenceID(int sequenceID) => (IEnumerable<int>) null;

    [Token(Token = "0x6006B02")]
    [Address(RVA = "0x48DE674", Offset = "0x48DE674", VA = "0x48DE674")]
    public StoryMainQuestSequenceRouteMaster()
    {
    }
  }
}
