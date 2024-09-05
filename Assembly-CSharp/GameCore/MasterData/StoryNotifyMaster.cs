// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryNotifyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E9")]
  [Serializable]
  public sealed class StoryNotifyMaster : BaseMaster<StoryNotifyData>
  {
    [Token(Token = "0x40059A5")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006B0A")]
    [Address(RVA = "0x48DE9DC", Offset = "0x48DE9DC", VA = "0x48DE9DC")]
    public IReadOnlyDictionary<int, StoryNotifyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryNotifyData>) null;
    }

    [Token(Token = "0x6006B0B")]
    [Address(RVA = "0x48DE9E4", Offset = "0x48DE9E4", VA = "0x48DE9E4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B0C")]
    [Address(RVA = "0x48DEA44", Offset = "0x48DEA44", VA = "0x48DEA44", Slot = "5")]
    protected override StoryNotifyData LoadEntity(IMasterDataReader reader)
    {
      return (StoryNotifyData) null;
    }

    [Token(Token = "0x6006B0D")]
    [Address(RVA = "0x48DEA9C", Offset = "0x48DEA9C", VA = "0x48DEA9C")]
    public StoryNotifyMaster()
    {
    }
  }
}
