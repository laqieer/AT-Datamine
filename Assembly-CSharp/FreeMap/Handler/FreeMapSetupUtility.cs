// Decompiled with JetBrains decompiler
// Type: FreeMap.Handler.FreeMapSetupUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob;
using FreeMap.Data;
using FreeMap.Instance;
using FreeMap.Parameter;
using FreeMap.State;
using FreeMap.UI;
using FreeMap.UI.Element;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace FreeMap.Handler
{
  [Token(Token = "0x2001930")]
  public static class FreeMapSetupUtility
  {
    [Token(Token = "0x6008F3B")]
    [Address(RVA = "0x4B064D8", Offset = "0x4B064D8", VA = "0x4B064D8")]
    public static void SetupPlayer(
      FreeMapCommonElement commonElement,
      FreeMapLocationHolder locationHolder,
      int characterSwitchPatternID,
      int startAreaID,
      string startAnchorName,
      Vector3 startOffset,
      float startRotateY,
      Action<FreeMapPlayerInstance> onCreate,
      Canvas swipeCanvas)
    {
    }

    [Token(Token = "0x6008F3C")]
    [Address(RVA = "0x4B068D8", Offset = "0x4B068D8", VA = "0x4B068D8")]
    public static void SetupActionCircleEvent(
      FreeMapStateManager stateHandler,
      FreeMapIconEventHandler iconEventHandler,
      FreeMapPlayerInstance playerInstance)
    {
    }

    [Token(Token = "0x6008F3D")]
    [Address(RVA = "0x4B069D4", Offset = "0x4B069D4", VA = "0x4B069D4")]
    public static void SetupContent(
      FreeMapCommonElement commonElement,
      FreeMapLocationHolder locationHolder,
      FreeMapIconEventControlElement iconEventElement,
      MovableMobManager mobManager,
      int startAreaID,
      bool createTransitionIcon,
      List<string> activeTransAreaAnchorsRef)
    {
    }

    [Token(Token = "0x6008F3E")]
    [Address(RVA = "0x4B07088", Offset = "0x4B07088", VA = "0x4B07088")]
    public static void SetupBackgroundScenes(Scene scene, FreeMapScenesParam scenesParam)
    {
    }

    [Token(Token = "0x6008F3F")]
    [Address(RVA = "0x4B070A4", Offset = "0x4B070A4", VA = "0x4B070A4")]
    private static void SetupBackgroundUniqueObject(Scene scene, int label)
    {
    }
  }
}
