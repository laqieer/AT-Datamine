// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.DebugViewerGUIUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F1D")]
  internal static class DebugViewerGUIUtility
  {
    [Token(Token = "0x400CA1F")]
    public const int ScreenWidth = 1024;
    [Token(Token = "0x400CA20")]
    public const int ScreenHeight = 576;
    [Token(Token = "0x400CA21")]
    public const int GUIHeight = 30;

    [Token(Token = "0x6012685")]
    [Address(RVA = "0x2304A54", Offset = "0x2304A54", VA = "0x2304A54")]
    public static DebugViewerGUIUtility.GUIAdjustResolution AdjustResolution()
    {
      return new DebugViewerGUIUtility.GUIAdjustResolution();
    }

    [Token(Token = "0x6012686")]
    [Address(RVA = "0x2304A98", Offset = "0x2304A98", VA = "0x2304A98")]
    public static bool DrawFloatField(
      string title,
      ref float param,
      float minValue,
      float maxValue)
    {
      return new bool();
    }

    [Token(Token = "0x6012687")]
    [Address(RVA = "0x2304DAC", Offset = "0x2304DAC", VA = "0x2304DAC")]
    public static Rect CreateMainWindowRect() => new Rect();

    [Token(Token = "0x6012688")]
    [Address(RVA = "0x2304960", Offset = "0x2304960", VA = "0x2304960")]
    public static bool Button(string text, params GUILayoutOption[] options) => new bool();

    [Token(Token = "0x6012689")]
    [Address(RVA = "0x2304DF4", Offset = "0x2304DF4", VA = "0x2304DF4")]
    public static bool RepeatButton(string text, params GUILayoutOption[] options) => new bool();

    [Token(Token = "0x601268A")]
    [Address(RVA = "0x230486C", Offset = "0x230486C", VA = "0x230486C")]
    public static void Label(string text, params GUILayoutOption[] options)
    {
    }

    [Token(Token = "0x601268B")]
    [Address(RVA = "0x2304EE8", Offset = "0x2304EE8", VA = "0x2304EE8")]
    public static string TextField(string text, params GUILayoutOption[] options) => (string) null;

    [Token(Token = "0x601268C")]
    [Address(RVA = "0x2304FDC", Offset = "0x2304FDC", VA = "0x2304FDC")]
    public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
    {
      return new Vector2();
    }

    [Token(Token = "0x601268D")]
    [Address(RVA = "0x2304C34", Offset = "0x2304C34", VA = "0x2304C34")]
    public static float HorizontalSlider(
      float value,
      float leftValue,
      float rightValue,
      params GUILayoutOption[] options)
    {
      return new float();
    }

    [Token(Token = "0x2002F1E")]
    public struct GUIAdjustResolution : IDisposable
    {
      [Token(Token = "0x601268E")]
      [Address(RVA = "0x2304A74", Offset = "0x2304A74", VA = "0x2304A74")]
      public DebugViewerGUIUtility.GUIAdjustResolution Resize(int screenWidth, int screenHeight)
      {
        return new DebugViewerGUIUtility.GUIAdjustResolution();
      }

      [Token(Token = "0x601268F")]
      [Address(RVA = "0x230514C", Offset = "0x230514C", VA = "0x230514C", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
