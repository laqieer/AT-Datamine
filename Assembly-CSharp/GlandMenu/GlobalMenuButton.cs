// Decompiled with JetBrains decompiler
// Type: GlandMenu.GlobalMenuButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x200095B")]
  public class GlobalMenuButton : MonoBehaviour
  {
    [Token(Token = "0x4002B56")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button buttonGlobalMenu;

    [Token(Token = "0x140000E7")]
    public event Action ClickGlobalMenuAction
    {
      [Token(Token = "0x60034C8"), Address(RVA = "0x3635588", Offset = "0x3635588", VA = "0x3635588")] add
      {
      }
      [Token(Token = "0x60034C9"), Address(RVA = "0x3635624", Offset = "0x3635624", VA = "0x3635624")] remove
      {
      }
    }

    [Token(Token = "0x60034CA")]
    [Address(RVA = "0x36356C0", Offset = "0x36356C0", VA = "0x36356C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60034CB")]
    [Address(RVA = "0x3635754", Offset = "0x3635754", VA = "0x3635754")]
    private void OnClickGlobalMenu()
    {
    }

    [Token(Token = "0x60034CC")]
    [Address(RVA = "0x36359B8", Offset = "0x36359B8", VA = "0x36359B8")]
    public GlobalMenuButton()
    {
    }
  }
}
