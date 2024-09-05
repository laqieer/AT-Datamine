// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryChapterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D9")]
  [Serializable]
  public sealed class StoryChapterMaster : BaseMaster<StoryChapterData>
  {
    [Token(Token = "0x400597D")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006ABE")]
    [Address(RVA = "0x48DC060", Offset = "0x48DC060", VA = "0x48DC060")]
    public IReadOnlyDictionary<int, StoryChapterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryChapterData>) null;
    }

    [Token(Token = "0x6006ABF")]
    [Address(RVA = "0x48DC068", Offset = "0x48DC068", VA = "0x48DC068", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006AC0")]
    [Address(RVA = "0x48DC0C8", Offset = "0x48DC0C8", VA = "0x48DC0C8", Slot = "5")]
    protected override StoryChapterData LoadEntity(IMasterDataReader reader)
    {
      return (StoryChapterData) null;
    }

    [Token(Token = "0x6006AC1")]
    [Address(RVA = "0x48DC120", Offset = "0x48DC120", VA = "0x48DC120")]
    public IEnumerable<StoryChapterData> GetList() => (IEnumerable<StoryChapterData>) null;

    [Token(Token = "0x6006AC2")]
    [Address(RVA = "0x48DC248", Offset = "0x48DC248", VA = "0x48DC248")]
    public StoryChapterData GetDefaultChapter() => (StoryChapterData) null;

    [Token(Token = "0x6006AC3")]
    [Address(RVA = "0x48DC3B8", Offset = "0x48DC3B8", VA = "0x48DC3B8")]
    public StoryChapterMaster()
    {
    }
  }
}
