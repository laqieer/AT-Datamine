// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelFootSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F45")]
  internal class DebugAreaMapUIModelFootSound
  {
    [Token(Token = "0x400CAA6")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;
    [Token(Token = "0x400CAA7")]
    [FieldOffset(Offset = "0x18")]
    private readonly Color[] GizmosColorTable;
    [Token(Token = "0x400CAA8")]
    [FieldOffset(Offset = "0x20")]
    private bool isShowGizmos;
    [Token(Token = "0x400CAA9")]
    [FieldOffset(Offset = "0x28")]
    private FootMoveSoundFloor[] allFloor;

    [Token(Token = "0x60127A2")]
    [Address(RVA = "0x211DCC8", Offset = "0x211DCC8", VA = "0x211DCC8")]
    public DebugAreaMapUIModelFootSound(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x60127A3")]
    [Address(RVA = "0x211E624", Offset = "0x211E624", VA = "0x211E624")]
    private void BufferFloorComponent()
    {
    }

    [Token(Token = "0x60127A4")]
    [Address(RVA = "0x211AEF8", Offset = "0x211AEF8", VA = "0x211AEF8")]
    public void ShowGizmos()
    {
    }

    [Token(Token = "0x60127A5")]
    [Address(RVA = "0x211E698", Offset = "0x211E698", VA = "0x211E698")]
    public IEnumerable<FootMoveSoundFloor> GetHitFloorList()
    {
      return (IEnumerable<FootMoveSoundFloor>) null;
    }
  }
}
