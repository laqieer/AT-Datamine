// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionEventCircleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001254")]
  [Serializable]
  public sealed class StoryFreeActionEventCircleMaster : BaseMaster<StoryFreeActionEventCircleData>
  {
    [Token(Token = "0x600683A")]
    [Address(RVA = "0x4D370F8", Offset = "0x4D370F8", VA = "0x4D370F8")]
    public IReadOnlyDictionary<int, StoryFreeActionEventCircleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionEventCircleData>) null;
    }

    [Token(Token = "0x600683B")]
    [Address(RVA = "0x4D37100", Offset = "0x4D37100", VA = "0x4D37100", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600683C")]
    [Address(RVA = "0x4D37160", Offset = "0x4D37160", VA = "0x4D37160", Slot = "5")]
    protected override StoryFreeActionEventCircleData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionEventCircleData) null;
    }

    [Token(Token = "0x600683D")]
    [Address(RVA = "0x4D371B8", Offset = "0x4D371B8", VA = "0x4D371B8")]
    public StoryFreeActionEventCircleMaster()
    {
    }
  }
}
