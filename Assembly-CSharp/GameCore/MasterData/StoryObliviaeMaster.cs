// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012CB")]
  [Serializable]
  public sealed class StoryObliviaeMaster : BaseMaster<StoryObliviaeData>
  {
    [Token(Token = "0x6006A80")]
    [Address(RVA = "0x48D9618", Offset = "0x48D9618", VA = "0x48D9618")]
    public IReadOnlyDictionary<int, StoryObliviaeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryObliviaeData>) null;
    }

    [Token(Token = "0x6006A81")]
    [Address(RVA = "0x48D9620", Offset = "0x48D9620", VA = "0x48D9620", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A82")]
    [Address(RVA = "0x48D9680", Offset = "0x48D9680", VA = "0x48D9680", Slot = "5")]
    protected override StoryObliviaeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryObliviaeData) null;
    }

    [Token(Token = "0x6006A83")]
    [Address(RVA = "0x48D96D8", Offset = "0x48D96D8", VA = "0x48D96D8")]
    public StoryObliviaeData GetDataByChapterID(int chapterId) => (StoryObliviaeData) null;

    [Token(Token = "0x6006A84")]
    [Address(RVA = "0x48D97E0", Offset = "0x48D97E0", VA = "0x48D97E0")]
    public StoryObliviaeMaster()
    {
    }
  }
}
