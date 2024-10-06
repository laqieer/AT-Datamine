// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewPlayerSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F6F")]
  internal class DebugAreaMapUIViewPlayerSetting : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x140001AF")]
    public event DebugAreaMapUIViewPlayerSetting.ChangePlayer OnChangePlayer
    {
      [Token(Token = "0x60128BA"), Address(RVA = "0x2119B1C", Offset = "0x2119B1C", VA = "0x2119B1C")] add
      {
      }
      [Token(Token = "0x60128BB"), Address(RVA = "0x2126D38", Offset = "0x2126D38", VA = "0x2126D38")] remove
      {
      }
    }

    [Token(Token = "0x140001B0")]
    public event DebugAreaMapUIViewPlayerSetting.ChangeAnchor OnChangeAnchor
    {
      [Token(Token = "0x60128BC"), Address(RVA = "0x2119C8C", Offset = "0x2119C8C", VA = "0x2119C8C")] add
      {
      }
      [Token(Token = "0x60128BD"), Address(RVA = "0x2126DD4", Offset = "0x2126DD4", VA = "0x2126DD4")] remove
      {
      }
    }

    [Token(Token = "0x17003EB7")]
    private GUIDropdown playerModel
    {
      [Token(Token = "0x60128BE"), Address(RVA = "0x2126E70", Offset = "0x2126E70", VA = "0x2126E70")] set
      {
      }
      [Token(Token = "0x60128BF"), Address(RVA = "0x2126E78", Offset = "0x2126E78", VA = "0x2126E78")] get
      {
        return (GUIDropdown) null;
      }
    }

    [Token(Token = "0x17003EB8")]
    private GUIDropdown anchor
    {
      [Token(Token = "0x60128C0"), Address(RVA = "0x2126E80", Offset = "0x2126E80", VA = "0x2126E80")] set
      {
      }
      [Token(Token = "0x60128C1"), Address(RVA = "0x2126E88", Offset = "0x2126E88", VA = "0x2126E88")] get
      {
        return (GUIDropdown) null;
      }
    }

    [Token(Token = "0x60128C2")]
    [Address(RVA = "0x2119A54", Offset = "0x2119A54", VA = "0x2119A54")]
    public DebugAreaMapUIViewPlayerSetting()
    {
    }

    [Token(Token = "0x60128C3")]
    [Address(RVA = "0x2126E90", Offset = "0x2126E90", VA = "0x2126E90", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x60128C4")]
    [Address(RVA = "0x2126F64", Offset = "0x2126F64", VA = "0x2126F64", Slot = "13")]
    protected override void DoMainWindow(int windowID)
    {
    }

    [Token(Token = "0x60128C5")]
    [Address(RVA = "0x211C178", Offset = "0x211C178", VA = "0x211C178")]
    public void SetAnchor(List<string> list)
    {
    }

    [Token(Token = "0x60128C6")]
    [Address(RVA = "0x211C0C8", Offset = "0x211C0C8", VA = "0x211C0C8")]
    public void SetCharaModel(List<string> list)
    {
    }

    [Token(Token = "0x2002F70")]
    public delegate void ChangePlayer(int index, string anchorName);

    [Token(Token = "0x2002F71")]
    public delegate void ChangeAnchor(string anchorName);
  }
}
