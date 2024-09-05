// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.LocationDataExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x2001947")]
  public static class LocationDataExtension
  {
    [Token(Token = "0x6008FE2")]
    [Address(RVA = "0x4B0E138", Offset = "0x4B0E138", VA = "0x4B0E138")]
    public static void SetConnection(
      this LocationData self,
      IReadOnlyList<StoryFreeActionAreaGroupData> groupDataList,
      IReadOnlyList<StoryFreeActionAreaSettingData> areaSettingDataList)
    {
    }

    [Token(Token = "0x6008FE3")]
    [Address(RVA = "0x4B0E458", Offset = "0x4B0E458", VA = "0x4B0E458")]
    public static void SetInstanceDirection(
      this LocationData self,
      StoryFreeActionSettingData settingData,
      int sequenceID)
    {
    }

    [Token(Token = "0x6008FE4")]
    [Address(RVA = "0x4B0E848", Offset = "0x4B0E848", VA = "0x4B0E848")]
    public static void SetInstanceDirection(
      this LocationData self,
      StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6008FE5")]
    [Address(RVA = "0x4B0E7AC", Offset = "0x4B0E7AC", VA = "0x4B0E7AC")]
    public static IFreeMapInstanceBuilder SetInstanceDirection(
      this LocationData self,
      StoryFreeActionLayoutData layout)
    {
      return (IFreeMapInstanceBuilder) null;
    }

    [Token(Token = "0x6008FE6")]
    [Address(RVA = "0x4B0EB9C", Offset = "0x4B0EB9C", VA = "0x4B0EB9C")]
    public static void SetSoundObjectInstance(
      this LocationData self,
      StoryFreeActionSettingData settingData)
    {
    }

    [Token(Token = "0x6008FE7")]
    [Address(RVA = "0x4B0EFBC", Offset = "0x4B0EFBC", VA = "0x4B0EFBC")]
    public static void SetRewardInstance(
      this LocationData self,
      StoryFreeActionSettingData settingData)
    {
    }
  }
}
