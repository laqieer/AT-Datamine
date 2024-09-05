// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryObliviaeDetailMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C8")]
  [Serializable]
  public sealed class StoryObliviaeDetailMaster : BaseMaster<StoryObliviaeDetailData>
  {
    [Token(Token = "0x6006A75")]
    [Address(RVA = "0x48D90D4", Offset = "0x48D90D4", VA = "0x48D90D4")]
    public IReadOnlyDictionary<int, StoryObliviaeDetailData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryObliviaeDetailData>) null;
    }

    [Token(Token = "0x6006A76")]
    [Address(RVA = "0x48D90DC", Offset = "0x48D90DC", VA = "0x48D90DC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A77")]
    [Address(RVA = "0x48D913C", Offset = "0x48D913C", VA = "0x48D913C", Slot = "5")]
    protected override StoryObliviaeDetailData LoadEntity(IMasterDataReader reader)
    {
      return (StoryObliviaeDetailData) null;
    }

    [Token(Token = "0x6006A78")]
    [Address(RVA = "0x48D9194", Offset = "0x48D9194", VA = "0x48D9194")]
    public StoryObliviaeDetailData[] GetDataByObliviaeID(int obliviaeId)
    {
      return (StoryObliviaeDetailData[]) null;
    }

    [Token(Token = "0x6006A79")]
    [Address(RVA = "0x48D92B8", Offset = "0x48D92B8", VA = "0x48D92B8")]
    public StoryObliviaeDetailMaster()
    {
    }
  }
}
