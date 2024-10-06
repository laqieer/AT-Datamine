// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewFootSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F5C")]
  internal class DebugAreaMapUIViewFootSound : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x400CAF3")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 scrollViewPosition;
    [Token(Token = "0x400CAF4")]
    [FieldOffset(Offset = "0x30")]
    private Texture2D colorTexture;

    [Token(Token = "0x1400019B")]
    public event EventHandler OnShowGizmos
    {
      [Token(Token = "0x6012830"), Address(RVA = "0x211A84C", Offset = "0x211A84C", VA = "0x211A84C")] add
      {
      }
      [Token(Token = "0x6012831"), Address(RVA = "0x2122934", Offset = "0x2122934", VA = "0x2122934")] remove
      {
      }
    }

    [Token(Token = "0x1400019C")]
    public event DebugAreaMapUIViewFootSound.GetHitFloors GetHitFloorsEvent
    {
      [Token(Token = "0x6012832"), Address(RVA = "0x211A9A4", Offset = "0x211A9A4", VA = "0x211A9A4")] add
      {
      }
      [Token(Token = "0x6012833"), Address(RVA = "0x21229D0", Offset = "0x21229D0", VA = "0x21229D0")] remove
      {
      }
    }

    [Token(Token = "0x6012834")]
    [Address(RVA = "0x211A7DC", Offset = "0x211A7DC", VA = "0x211A7DC")]
    public DebugAreaMapUIViewFootSound()
    {
    }

    [Token(Token = "0x6012835")]
    [Address(RVA = "0x2122A6C", Offset = "0x2122A6C", VA = "0x2122A6C", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012836")]
    [Address(RVA = "0x2122F00", Offset = "0x2122F00", VA = "0x2122F00")]
    private void DrawFloorData(FootMoveSoundFloor floorData)
    {
    }

    [Token(Token = "0x2002F5D")]
    public delegate IEnumerable<FootMoveSoundFloor> GetHitFloors();
  }
}
