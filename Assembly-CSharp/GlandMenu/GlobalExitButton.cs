// Decompiled with JetBrains decompiler
// Type: GlandMenu.GlobalExitButton
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
  [Token(Token = "0x200095A")]
  public class GlobalExitButton : MonoBehaviour
  {
    [Token(Token = "0x4002B54")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button target;

    [Token(Token = "0x140000E6")]
    public event Action ClickGlobalMenuAction
    {
      [Token(Token = "0x60034C3"), Address(RVA = "0x36352FC", Offset = "0x36352FC", VA = "0x36352FC")] add
      {
      }
      [Token(Token = "0x60034C4"), Address(RVA = "0x3635398", Offset = "0x3635398", VA = "0x3635398")] remove
      {
      }
    }

    [Token(Token = "0x60034C5")]
    [Address(RVA = "0x3635434", Offset = "0x3635434", VA = "0x3635434")]
    private void Awake()
    {
    }

    [Token(Token = "0x60034C6")]
    [Address(RVA = "0x36354C8", Offset = "0x36354C8", VA = "0x36354C8")]
    private void OnClickExit()
    {
    }

    [Token(Token = "0x60034C7")]
    [Address(RVA = "0x3635580", Offset = "0x3635580", VA = "0x3635580")]
    public GlobalExitButton()
    {
    }
  }
}
