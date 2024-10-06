// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskTextMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E5")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskTextMaster : BaseMaster<StoryAreaEventQuestTaskTextData>
  {
    [Token(Token = "0x40055E2")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006648")]
    [Address(RVA = "0x4D24264", Offset = "0x4D24264", VA = "0x4D24264")]
    public IReadOnlyDictionary<int, StoryAreaEventQuestTaskTextData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaEventQuestTaskTextData>) null;
    }

    [Token(Token = "0x6006649")]
    [Address(RVA = "0x4D2426C", Offset = "0x4D2426C", VA = "0x4D2426C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600664A")]
    [Address(RVA = "0x4D242CC", Offset = "0x4D242CC", VA = "0x4D242CC", Slot = "5")]
    protected override StoryAreaEventQuestTaskTextData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaEventQuestTaskTextData) null;
    }

    [Token(Token = "0x600664B")]
    [Address(RVA = "0x4D24324", Offset = "0x4D24324", VA = "0x4D24324")]
    public StoryAreaEventQuestTaskTextMaster()
    {
    }
  }
}
