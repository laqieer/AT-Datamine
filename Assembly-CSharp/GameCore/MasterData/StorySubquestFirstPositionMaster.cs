// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestFirstPositionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001305")]
  [Serializable]
  public sealed class StorySubquestFirstPositionMaster : BaseMaster<StorySubquestFirstPositionData>
  {
    [Token(Token = "0x6006B70")]
    [Address(RVA = "0x48E2668", Offset = "0x48E2668", VA = "0x48E2668")]
    public IReadOnlyDictionary<int, StorySubquestFirstPositionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestFirstPositionData>) null;
    }

    [Token(Token = "0x6006B71")]
    [Address(RVA = "0x48E2670", Offset = "0x48E2670", VA = "0x48E2670", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B72")]
    [Address(RVA = "0x48E26D0", Offset = "0x48E26D0", VA = "0x48E26D0", Slot = "5")]
    protected override StorySubquestFirstPositionData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestFirstPositionData) null;
    }

    [Token(Token = "0x6006B73")]
    [Address(RVA = "0x48E2728", Offset = "0x48E2728", VA = "0x48E2728")]
    public StorySubquestFirstPositionData GetDataBuChapter(int chapterId)
    {
      return (StorySubquestFirstPositionData) null;
    }

    [Token(Token = "0x6006B74")]
    [Address(RVA = "0x48E2830", Offset = "0x48E2830", VA = "0x48E2830")]
    public StorySubquestFirstPositionMaster()
    {
    }
  }
}
