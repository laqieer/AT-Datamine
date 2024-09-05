// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugAnimatedTreeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F57")]
  internal class DebugAnimatedTreeView
  {
    [Token(Token = "0x4008643")]
    [FieldOffset(Offset = "0x10")]
    private DebugTreeNode<DebugTreeExtraData> teeRoot;
    [Token(Token = "0x4008644")]
    [FieldOffset(Offset = "0x18")]
    private DebugTreeDrawer treeDrawer;

    [Token(Token = "0x600BA0F")]
    [Address(RVA = "0x2140780", Offset = "0x2140780", VA = "0x2140780")]
    private void OnSelected(DebugTreeNode<DebugTreeExtraData> node)
    {
    }

    [Token(Token = "0x600BA10")]
    [Address(RVA = "0x21407E4", Offset = "0x21407E4", VA = "0x21407E4")]
    public void OnGUI(Rect rect)
    {
    }

    [Token(Token = "0x600BA11")]
    [Address(RVA = "0x21408A8", Offset = "0x21408A8", VA = "0x21408A8")]
    public void AddItem(
      string label,
      char separator,
      object userData,
      DebugTreeNode<DebugTreeExtraData>.OnSelectEvent callback,
      string tooltip = "")
    {
    }

    [Token(Token = "0x600BA12")]
    [Address(RVA = "0x214099C", Offset = "0x214099C", VA = "0x214099C")]
    public void AddItem(
      string label,
      object userData,
      DebugTreeNode<DebugTreeExtraData>.OnSelectEvent callback,
      string tooltip = "")
    {
    }

    [Token(Token = "0x600BA13")]
    [Address(RVA = "0x2140A70", Offset = "0x2140A70", VA = "0x2140A70")]
    public DebugAnimatedTreeView()
    {
    }
  }
}
