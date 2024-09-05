// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkADVEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001283")]
  [Serializable]
  public sealed class StoryFreeActionTalkADVEventMaster : BaseMaster<StoryFreeActionTalkADVEventData>
  {
    [Token(Token = "0x400587A")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionTalkADVEventData>> groupingTable;

    [Token(Token = "0x6006939")]
    [Address(RVA = "0x48CE178", Offset = "0x48CE178", VA = "0x48CE178")]
    public IReadOnlyDictionary<int, StoryFreeActionTalkADVEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionTalkADVEventData>) null;
    }

    [Token(Token = "0x600693A")]
    [Address(RVA = "0x48CE180", Offset = "0x48CE180", VA = "0x48CE180", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600693B")]
    [Address(RVA = "0x48CE244", Offset = "0x48CE244", VA = "0x48CE244", Slot = "5")]
    protected override StoryFreeActionTalkADVEventData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionTalkADVEventData) null;
    }

    [Token(Token = "0x600693C")]
    [Address(RVA = "0x48CE1E8", Offset = "0x48CE1E8", VA = "0x48CE1E8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600693D")]
    [Address(RVA = "0x48CE2B4", Offset = "0x48CE2B4", VA = "0x48CE2B4")]
    private void OnLoadEntity(StoryFreeActionTalkADVEventData entity)
    {
    }

    [Token(Token = "0x600693E")]
    [Address(RVA = "0x48CE430", Offset = "0x48CE430", VA = "0x48CE430")]
    public IReadOnlyList<StoryFreeActionTalkADVEventData> GetADVEventDataListByLabel(int label)
    {
      return (IReadOnlyList<StoryFreeActionTalkADVEventData>) null;
    }

    [Token(Token = "0x600693F")]
    [Address(RVA = "0x48CE4EC", Offset = "0x48CE4EC", VA = "0x48CE4EC")]
    public IEnumerable<StoryFreeActionTalkADVEventData> GetList()
    {
      return (IEnumerable<StoryFreeActionTalkADVEventData>) null;
    }

    [Token(Token = "0x6006940")]
    [Address(RVA = "0x48CE53C", Offset = "0x48CE53C", VA = "0x48CE53C")]
    public StoryFreeActionTalkADVEventMaster()
    {
    }
  }
}
