// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkBalloonEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001288")]
  [Serializable]
  public sealed class StoryFreeActionTalkBalloonEventMaster : 
    BaseMaster<StoryFreeActionTalkBalloonEventData>
  {
    [Token(Token = "0x400588B")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionTalkBalloonEventData>> groupingTable;

    [Token(Token = "0x6006955")]
    [Address(RVA = "0x48CF434", Offset = "0x48CF434", VA = "0x48CF434")]
    public IReadOnlyDictionary<int, StoryFreeActionTalkBalloonEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionTalkBalloonEventData>) null;
    }

    [Token(Token = "0x6006956")]
    [Address(RVA = "0x48CF43C", Offset = "0x48CF43C", VA = "0x48CF43C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006957")]
    [Address(RVA = "0x48CF500", Offset = "0x48CF500", VA = "0x48CF500", Slot = "5")]
    protected override StoryFreeActionTalkBalloonEventData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionTalkBalloonEventData) null;
    }

    [Token(Token = "0x6006958")]
    [Address(RVA = "0x48CF4A4", Offset = "0x48CF4A4", VA = "0x48CF4A4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006959")]
    [Address(RVA = "0x48CF570", Offset = "0x48CF570", VA = "0x48CF570")]
    private void OnLoadEntity(StoryFreeActionTalkBalloonEventData entity)
    {
    }

    [Token(Token = "0x600695A")]
    [Address(RVA = "0x48CF6EC", Offset = "0x48CF6EC", VA = "0x48CF6EC")]
    public IReadOnlyList<StoryFreeActionTalkBalloonEventData> GetEventDataListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionTalkBalloonEventData>) null;
    }

    [Token(Token = "0x600695B")]
    [Address(RVA = "0x48CF7A8", Offset = "0x48CF7A8", VA = "0x48CF7A8")]
    public StoryFreeActionTalkBalloonEventMaster()
    {
    }
  }
}
