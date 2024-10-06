// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugTreeDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F56")]
  internal class DebugTreeDrawer
  {
    [Token(Token = "0x4008636")]
    private const float TITLE_LABEL_HEIGHT = 25f;
    [Token(Token = "0x4008637")]
    private const float BACK_BUTTON_WIDTH = 25f;
    [Token(Token = "0x4008638")]
    private const float NODE_LABEL_HEIGHT = 22f;
    [Token(Token = "0x4008639")]
    private const float VSCROLLBAR_WIDTH = 20f;
    [Token(Token = "0x400863A")]
    [FieldOffset(Offset = "0x10")]
    private Vector2 horizontalScrollPos;
    [Token(Token = "0x400863B")]
    [FieldOffset(Offset = "0x18")]
    private Vector2 scrollAnimationEndPos;
    [Token(Token = "0x400863C")]
    [FieldOffset(Offset = "0x20")]
    private Vector2 size;
    [Token(Token = "0x400863D")]
    [FieldOffset(Offset = "0x28")]
    private DateTime prevUpdateTime;
    [Token(Token = "0x400863E")]
    [FieldOffset(Offset = "0x30")]
    private float animationTime;
    [Token(Token = "0x400863F")]
    [FieldOffset(Offset = "0x34")]
    private float currentAnimationTime;
    [Token(Token = "0x4008640")]
    [FieldOffset(Offset = "0x38")]
    private List<int> selected;
    [Token(Token = "0x4008641")]
    [FieldOffset(Offset = "0x40")]
    private List<Rect> lastViewRects;
    [Token(Token = "0x4008642")]
    [FieldOffset(Offset = "0x48")]
    private int currentIndex;

    [Token(Token = "0x600BA08")]
    [Address(RVA = "0x213F180", Offset = "0x213F180", VA = "0x213F180")]
    private void UpdateAnimation(DebugTreeNode<DebugTreeExtraData> root)
    {
    }

    [Token(Token = "0x600BA09")]
    [Address(RVA = "0x213F3D8", Offset = "0x213F3D8", VA = "0x213F3D8")]
    private void PlayAnimation()
    {
    }

    [Token(Token = "0x600BA0A")]
    [Address(RVA = "0x213F3E0", Offset = "0x213F3E0", VA = "0x213F3E0")]
    public void Draw(
      DebugTreeNode<DebugTreeExtraData> root,
      Rect clipRect,
      DebugTreeNode<DebugTreeExtraData>.OnSelectEvent onSelect)
    {
    }

    [Token(Token = "0x600BA0B")]
    [Address(RVA = "0x213F960", Offset = "0x213F960", VA = "0x213F960")]
    private bool DrawItem(
      DebugTreeNode<DebugTreeExtraData> node,
      Rect rect,
      DebugTreeNode<DebugTreeExtraData>.OnSelectEvent onSelect)
    {
      return new bool();
    }

    [Token(Token = "0x600BA0C")]
    [Address(RVA = "0x213F2DC", Offset = "0x213F2DC", VA = "0x213F2DC")]
    private DebugTreeNode<DebugTreeExtraData> GetSelectedNode(DebugTreeNode<DebugTreeExtraData> root)
    {
      return (DebugTreeNode<DebugTreeExtraData>) null;
    }

    [Token(Token = "0x600BA0D")]
    [Address(RVA = "0x2140644", Offset = "0x2140644", VA = "0x2140644")]
    public void ClearSelected()
    {
    }

    [Token(Token = "0x600BA0E")]
    [Address(RVA = "0x21406B8", Offset = "0x21406B8", VA = "0x21406B8")]
    public DebugTreeDrawer()
    {
    }
  }
}
