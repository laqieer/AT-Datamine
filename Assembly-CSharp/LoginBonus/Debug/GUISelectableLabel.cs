// Decompiled with JetBrains decompiler
// Type: LoginBonus.Debug.GUISelectableLabel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace LoginBonus.Debug
{
  [Token(Token = "0x2000B17")]
  internal class GUISelectableLabel
  {
    [Token(Token = "0x4003298")]
    [FieldOffset(Offset = "0x10")]
    private readonly string title;
    [Token(Token = "0x4003299")]
    [FieldOffset(Offset = "0x18")]
    private string label;
    [Token(Token = "0x400329A")]
    [FieldOffset(Offset = "0x20")]
    private readonly Action onClickChangeButton;

    [Token(Token = "0x6003F23")]
    [Address(RVA = "0x2C195FC", Offset = "0x2C195FC", VA = "0x2C195FC")]
    public GUISelectableLabel(string title, string label, Action onClickChangeButton)
    {
    }

    [Token(Token = "0x6003F24")]
    [Address(RVA = "0x2C1AA50", Offset = "0x2C1AA50", VA = "0x2C1AA50")]
    public void SetLabel(string label)
    {
    }

    [Token(Token = "0x6003F25")]
    [Address(RVA = "0x2C19C28", Offset = "0x2C19C28", VA = "0x2C19C28")]
    public void OnGUI()
    {
    }
  }
}
