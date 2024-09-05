// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapChestBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001921")]
  public class FreeMapChestBuilder : FreeMapRewardInstanceBuilder<FreeMapChestInstance>
  {
    [Token(Token = "0x4006C66")]
    [FieldOffset(Offset = "0x5C")]
    private int chestID;

    [Token(Token = "0x6008ED5")]
    [Address(RVA = "0x4B03FC0", Offset = "0x4B03FC0", VA = "0x4B03FC0")]
    public FreeMapChestBuilder(
      int rewardLayoutID,
      int chestID,
      int propID,
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY)
    {
    }

    [Token(Token = "0x6008ED6")]
    [Address(RVA = "0x4B0406C", Offset = "0x4B0406C", VA = "0x4B0406C", Slot = "16")]
    protected override void BuildInternal()
    {
    }

    [Token(Token = "0x6008ED7")]
    [Address(RVA = "0x4B04148", Offset = "0x4B04148", VA = "0x4B04148")]
    public static FreeMapChestBuilder Create(StoryFreeActionRewardObjectLayoutData layoutData)
    {
      return (FreeMapChestBuilder) null;
    }
  }
}
