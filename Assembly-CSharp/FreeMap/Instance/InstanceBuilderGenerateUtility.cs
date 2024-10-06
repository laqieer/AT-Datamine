// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.InstanceBuilderGenerateUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018B2")]
  public static class InstanceBuilderGenerateUtility
  {
    [Token(Token = "0x6008C2A")]
    [Address(RVA = "0x452B408", Offset = "0x452B408", VA = "0x452B408")]
    public static IFreeMapInstanceBuilder CreateByStoryLayoutData(
      StoryFreeActionLayoutData layout,
      FreeMapAreaSituationData? areaParam)
    {
      return (IFreeMapInstanceBuilder) null;
    }

    [Token(Token = "0x6008C2B")]
    [Address(RVA = "0x452B7BC", Offset = "0x452B7BC", VA = "0x452B7BC")]
    public static IFreeMapInstanceBuilder CreateByLobbyLayoutData(
      LobbyFreeActionLayoutData layout,
      FreeMapAreaSituationData? areaParam)
    {
      return (IFreeMapInstanceBuilder) null;
    }

    [Token(Token = "0x6008C2C")]
    [Address(RVA = "0x452B510", Offset = "0x452B510", VA = "0x452B510")]
    private static IFreeMapInstanceBuilder CreateByLayoutData(
      IFreeActionLayoutData layout,
      FreeMapAreaSituationData? areaParam,
      InstanceType instanceType,
      StoryCharacterLookWeatherTypeEnum lookWeatherType)
    {
      return (IFreeMapInstanceBuilder) null;
    }

    [Token(Token = "0x6008C2D")]
    [Address(RVA = "0x452B7CC", Offset = "0x452B7CC", VA = "0x452B7CC")]
    public static IFreeMapInstanceBuilder CreateChest(StoryFreeActionRewardObjectLayoutData layout)
    {
      return (IFreeMapInstanceBuilder) null;
    }

    [Token(Token = "0x6008C2E")]
    [Address(RVA = "0x452B7D4", Offset = "0x452B7D4", VA = "0x452B7D4")]
    public static IFreeMapInstanceBuilder CreateBreakableObject(
      StoryFreeActionRewardObjectLayoutData layout)
    {
      return (IFreeMapInstanceBuilder) null;
    }
  }
}
