// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryEndingMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012DE")]
  [Serializable]
  public sealed class StoryEndingMaster : BaseMaster<StoryEndingData>
  {
    [Token(Token = "0x6006AD8")]
    [Address(RVA = "0x48DCFE8", Offset = "0x48DCFE8", VA = "0x48DCFE8")]
    public IReadOnlyDictionary<int, StoryEndingData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryEndingData>) null;
    }

    [Token(Token = "0x6006AD9")]
    [Address(RVA = "0x48DCFF0", Offset = "0x48DCFF0", VA = "0x48DCFF0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006ADA")]
    [Address(RVA = "0x48DD050", Offset = "0x48DD050", VA = "0x48DD050", Slot = "5")]
    protected override StoryEndingData LoadEntity(IMasterDataReader reader)
    {
      return (StoryEndingData) null;
    }

    [Token(Token = "0x6006ADB")]
    [Address(RVA = "0x48DD0A8", Offset = "0x48DD0A8", VA = "0x48DD0A8")]
    public StoryEndingMaster()
    {
    }
  }
}
