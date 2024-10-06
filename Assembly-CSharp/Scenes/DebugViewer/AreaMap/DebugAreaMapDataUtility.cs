// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.DebugAreaMapDataUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap
{
  [Token(Token = "0x2002F21")]
  internal static class DebugAreaMapDataUtility
  {
    [Token(Token = "0x400CA2E")]
    [FieldOffset(Offset = "0x0")]
    private static readonly DebugAreaMapDataUtility.DebugAreaData[] activeDebugArea;
    [Token(Token = "0x400CA30")]
    private const int ButtonRow = 10;

    [Token(Token = "0x17003E6E")]
    public static bool showGUI
    {
      [Token(Token = "0x60126A6"), Address(RVA = "0x2305CEC", Offset = "0x2305CEC", VA = "0x2305CEC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60126A7"), Address(RVA = "0x2305D44", Offset = "0x2305D44", VA = "0x2305D44")] private set
      {
      }
    }

    [Token(Token = "0x60126A8")]
    [Address(RVA = "0x2305DA0", Offset = "0x2305DA0", VA = "0x2305DA0")]
    public static void SetShowGUI(bool enabled)
    {
    }

    [Token(Token = "0x60126A9")]
    [Address(RVA = "0x2305E30", Offset = "0x2305E30", VA = "0x2305E30")]
    public static void OnGUI(Action<int, string> loadAction)
    {
    }

    [Token(Token = "0x60126AA")]
    [Address(RVA = "0x2305F18", Offset = "0x2305F18", VA = "0x2305F18")]
    private static void ShowButtonGUI()
    {
    }

    [Token(Token = "0x17003E6F")]
    private static int ButtonColum
    {
      [Token(Token = "0x60126AB"), Address(RVA = "0x230652C", Offset = "0x230652C", VA = "0x230652C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60126AC")]
    [Address(RVA = "0x2306078", Offset = "0x2306078", VA = "0x2306078")]
    private static void AreaSelectButtons(
      float currentY,
      float baseHeight,
      Action<int, string> loadAction,
      bool isActiveADV = false)
    {
    }

    [Token(Token = "0x60126AD")]
    [Address(RVA = "0x23063B8", Offset = "0x23063B8", VA = "0x23063B8")]
    private static bool DebugGUIButton(Rect rect, string buttonText) => new bool();

    [Token(Token = "0x60126AE")]
    [Address(RVA = "0x23065AC", Offset = "0x23065AC", VA = "0x23065AC")]
    static DebugAreaMapDataUtility()
    {
    }

    [Token(Token = "0x2002F22")]
    private struct DebugAreaData
    {
      [Token(Token = "0x400CA31")]
      [FieldOffset(Offset = "0x0")]
      private string menuAreaName;
      [Token(Token = "0x400CA32")]
      [FieldOffset(Offset = "0x8")]
      private string areaName;
      [Token(Token = "0x400CA33")]
      [FieldOffset(Offset = "0x10")]
      private int areaId;

      [Token(Token = "0x17003E70")]
      public string MenuAreaName
      {
        [Token(Token = "0x60126AF"), Address(RVA = "0x2113BCC", Offset = "0x2113BCC", VA = "0x2113BCC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17003E71")]
      public string AreaName
      {
        [Token(Token = "0x60126B0"), Address(RVA = "0x2113C1C", Offset = "0x2113C1C", VA = "0x2113C1C")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17003E72")]
      public int AreaId
      {
        [Token(Token = "0x60126B1"), Address(RVA = "0x2113C24", Offset = "0x2113C24", VA = "0x2113C24")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60126B2")]
      [Address(RVA = "0x2113C2C", Offset = "0x2113C2C", VA = "0x2113C2C")]
      public DebugAreaData(string menuName, string areaName, int areaId)
      {
      }
    }
  }
}
