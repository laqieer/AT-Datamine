// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011DD")]
  [Serializable]
  public sealed class StoryAreaEventQuestMaster : BaseMaster<StoryAreaEventQuestData>
  {
    [Token(Token = "0x40055C5")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006624")]
    [Address(RVA = "0x4D22BA8", Offset = "0x4D22BA8", VA = "0x4D22BA8")]
    public IReadOnlyDictionary<int, StoryAreaEventQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaEventQuestData>) null;
    }

    [Token(Token = "0x6006625")]
    [Address(RVA = "0x4D22BB0", Offset = "0x4D22BB0", VA = "0x4D22BB0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006626")]
    [Address(RVA = "0x4D22C10", Offset = "0x4D22C10", VA = "0x4D22C10", Slot = "5")]
    protected override StoryAreaEventQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaEventQuestData) null;
    }

    [Token(Token = "0x6006627")]
    [Address(RVA = "0x4D22C68", Offset = "0x4D22C68", VA = "0x4D22C68")]
    public IEnumerable<StoryAreaEventQuestData> GetListBySequence(int sequenceID)
    {
      return (IEnumerable<StoryAreaEventQuestData>) null;
    }

    [Token(Token = "0x6006628")]
    [Address(RVA = "0x4D22D70", Offset = "0x4D22D70", VA = "0x4D22D70")]
    public IEnumerable<StoryAreaEventQuestData> GetList()
    {
      return (IEnumerable<StoryAreaEventQuestData>) null;
    }

    [Token(Token = "0x6006629")]
    [Address(RVA = "0x4D22DC0", Offset = "0x4D22DC0", VA = "0x4D22DC0")]
    public StoryAreaEventQuestMaster()
    {
    }
  }
}
