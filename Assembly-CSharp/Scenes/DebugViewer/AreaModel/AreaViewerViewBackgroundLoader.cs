// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerViewBackgroundLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F94")]
  internal class AreaViewerViewBackgroundLoader : AreaViewerViewBase
  {
    [Token(Token = "0x400CB99")]
    [FieldOffset(Offset = "0x28")]
    private GUIDropdown backgroundList;
    [Token(Token = "0x400CB9A")]
    [FieldOffset(Offset = "0x30")]
    public EventHandler<int> OnLoadBackground;

    [Token(Token = "0x60129AF")]
    [Address(RVA = "0x4292398", Offset = "0x4292398", VA = "0x4292398", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x60129B0")]
    [Address(RVA = "0x4292424", Offset = "0x4292424", VA = "0x4292424", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x60129B1")]
    [Address(RVA = "0x4292528", Offset = "0x4292528", VA = "0x4292528")]
    public void SetBackgroundList(List<string> list)
    {
    }

    [Token(Token = "0x60129B2")]
    [Address(RVA = "0x42925BC", Offset = "0x42925BC", VA = "0x42925BC")]
    public AreaViewerViewBackgroundLoader()
    {
    }
  }
}
