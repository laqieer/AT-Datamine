// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002FAC")]
  internal static class AdvViewerUtility
  {
    [Token(Token = "0x400CBDF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string[] ViewStateName;
    [Token(Token = "0x400CBE0")]
    [FieldOffset(Offset = "0x8")]
    private static bool isHideAdvInfo;

    [Token(Token = "0x6012A4D")]
    [Address(RVA = "0x4296A9C", Offset = "0x4296A9C", VA = "0x4296A9C")]
    public static bool ShowButtonGUI(ref bool isShow) => new bool();

    [Token(Token = "0x6012A4E")]
    [Address(RVA = "0x4296C84", Offset = "0x4296C84", VA = "0x4296C84")]
    public static void ToggleHideShowButtonGUI(ref bool isHide)
    {
    }

    [Token(Token = "0x6012A4F")]
    [Address(RVA = "0x4296D68", Offset = "0x4296D68", VA = "0x4296D68")]
    public static void ToggleAdvUIHideShowButtonGUI(ref bool isHide)
    {
    }

    [Token(Token = "0x6012A50")]
    [Address(RVA = "0x4296B68", Offset = "0x4296B68", VA = "0x4296B68")]
    public static void ShowForceEndButton(Action onButtonCallback)
    {
    }

    [Token(Token = "0x6012A51")]
    [Address(RVA = "0x4296E4C", Offset = "0x4296E4C", VA = "0x4296E4C")]
    public static void ShowReturnToDebugMenuButton()
    {
    }

    [Token(Token = "0x6012A52")]
    [Address(RVA = "0x429C254", Offset = "0x429C254", VA = "0x429C254")]
    public static void SetHideAdvInfo(bool hide)
    {
    }

    [Token(Token = "0x6012A53")]
    [Address(RVA = "0x429BDB0", Offset = "0x429BDB0", VA = "0x429BDB0")]
    public static void ShowAdvInfo()
    {
    }

    [Token(Token = "0x6012A54")]
    [Address(RVA = "0x429C2B0", Offset = "0x429C2B0", VA = "0x429C2B0")]
    public static IEnumerable<StoryFreeActionSettingData> GetSettingList()
    {
      return (IEnumerable<StoryFreeActionSettingData>) null;
    }

    [Token(Token = "0x6012A55")]
    [Address(RVA = "0x429C42C", Offset = "0x429C42C", VA = "0x429C42C")]
    public static IEnumerable<StoryFreeActionAreaData> GetAreaList()
    {
      return (IEnumerable<StoryFreeActionAreaData>) null;
    }

    [Token(Token = "0x6012A56")]
    [Address(RVA = "0x429C4AC", Offset = "0x429C4AC", VA = "0x429C4AC")]
    public static StoryFreeActionLayoutData GetLayoutByObjectID(int objectID)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x6012A57")]
    [Address(RVA = "0x429C9D0", Offset = "0x429C9D0", VA = "0x429C9D0")]
    static AdvViewerUtility()
    {
    }
  }
}
