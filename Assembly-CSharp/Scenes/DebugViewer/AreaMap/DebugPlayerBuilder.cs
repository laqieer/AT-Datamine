// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.DebugPlayerBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.Builder;
using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap
{
  [Token(Token = "0x2002F32")]
  public class DebugPlayerBuilder : FreeMapPlayerBuilderBase<DebugAreaMapPlayer>
  {
    [Token(Token = "0x6012724")]
    [Address(RVA = "0x2117AD0", Offset = "0x2117AD0", VA = "0x2117AD0")]
    public DebugPlayerBuilder(
      string anchorName,
      Vector3 positionOffset,
      float rotationOffsetY,
      StoryCharacterLookWeatherTypeEnum lookWeatherType,
      StoryCharacterUtility.LoadResouceData resourceData)
    {
    }

    [Token(Token = "0x6012725")]
    [Address(RVA = "0x2114D04", Offset = "0x2114D04", VA = "0x2114D04")]
    public static DebugPlayerBuilder Create(
      int characterSwitchPatternID,
      string startAnchorName,
      Vector3 startOffset,
      float startRotateY,
      FreeMapAreaSituationData? areaParam)
    {
      return (DebugPlayerBuilder) null;
    }
  }
}
