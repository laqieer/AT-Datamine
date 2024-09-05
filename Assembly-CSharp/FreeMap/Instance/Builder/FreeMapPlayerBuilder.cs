// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapPlayerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001928")]
  public class FreeMapPlayerBuilder : FreeMapPlayerBuilderBase<FreeMapPlayerInstance>
  {
    [Token(Token = "0x6008F04")]
    [Address(RVA = "0x4B05914", Offset = "0x4B05914", VA = "0x4B05914")]
    public FreeMapPlayerBuilder(
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData,
      PropSettingData[] propData,
      bool isPlayerRegister)
    {
    }

    [Token(Token = "0x6008F05")]
    [Address(RVA = "0x4B059F4", Offset = "0x4B059F4", VA = "0x4B059F4")]
    public static FreeMapPlayerBuilder Create(
      int characterSwitchPatternID,
      string startAnchorName,
      Vector3 startOffset,
      float startRotateY,
      FreeMapAreaSituationData? areaParam,
      StoryCharacterLookWeatherTypeEnum lookWeatherType)
    {
      return (FreeMapPlayerBuilder) null;
    }
  }
}
