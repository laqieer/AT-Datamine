// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapBreakableBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x200191C")]
  public class FreeMapBreakableBuilder : FreeMapRewardInstanceBuilder<FreeMapBreakableInstance>
  {
    [Token(Token = "0x6008EBE")]
    [Address(RVA = "0x4B03CCC", Offset = "0x4B03CCC", VA = "0x4B03CCC")]
    public FreeMapBreakableBuilder(
      int rewardLayoutID,
      int propID,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008EBF")]
    [Address(RVA = "0x4B03D6C", Offset = "0x4B03D6C", VA = "0x4B03D6C", Slot = "16")]
    protected override void BuildInternal()
    {
    }

    [Token(Token = "0x6008EC0")]
    [Address(RVA = "0x4B03DC8", Offset = "0x4B03DC8", VA = "0x4B03DC8")]
    public static FreeMapBreakableBuilder Create(StoryFreeActionRewardObjectLayoutData layout)
    {
      return (FreeMapBreakableBuilder) null;
    }
  }
}
