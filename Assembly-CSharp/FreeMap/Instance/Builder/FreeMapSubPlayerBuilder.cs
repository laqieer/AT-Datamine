// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapSubPlayerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Prop;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001927")]
  public class FreeMapSubPlayerBuilder : FreeMapPlayerBuilderBase<FreeMapPlayerInstance>
  {
    [Token(Token = "0x6008F02")]
    [Address(RVA = "0x4B0568C", Offset = "0x4B0568C", VA = "0x4B0568C")]
    public FreeMapSubPlayerBuilder(
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData,
      PropSettingData[] propData,
      bool isPlayerRegister)
    {
    }

    [Token(Token = "0x6008F03")]
    [Address(RVA = "0x4B0576C", Offset = "0x4B0576C", VA = "0x4B0576C")]
    public static FreeMapSubPlayerBuilder Create(
      int playerLabel,
      string startAnchorName,
      Vector3 startOffset,
      float startRotateY)
    {
      return (FreeMapSubPlayerBuilder) null;
    }
  }
}
