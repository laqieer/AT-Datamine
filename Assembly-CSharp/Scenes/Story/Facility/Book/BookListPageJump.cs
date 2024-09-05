// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListPageJump
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002ECB")]
  public class BookListPageJump : MonoBehaviour
  {
    [Token(Token = "0x400C8A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor number;
    [Token(Token = "0x400C8A8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button btn;
    [Token(Token = "0x400C8A9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400C8AA")]
    [FieldOffset(Offset = "0x30")]
    public Action OnClick;

    [Token(Token = "0x17003E02")]
    public int Number
    {
      [Token(Token = "0x601246D"), Address(RVA = "0x22F33AC", Offset = "0x22F33AC", VA = "0x22F33AC")] set
      {
      }
    }

    [Token(Token = "0x601246E")]
    [Address(RVA = "0x22F33EC", Offset = "0x22F33EC", VA = "0x22F33EC")]
    public void OnOff(bool value)
    {
    }

    [Token(Token = "0x601246F")]
    [Address(RVA = "0x22F3464", Offset = "0x22F3464", VA = "0x22F3464")]
    private void Start()
    {
    }

    [Token(Token = "0x6012470")]
    [Address(RVA = "0x22F34F8", Offset = "0x22F34F8", VA = "0x22F34F8")]
    private void Click()
    {
    }

    [Token(Token = "0x6012471")]
    [Address(RVA = "0x22F3514", Offset = "0x22F3514", VA = "0x22F3514")]
    public BookListPageJump()
    {
    }
  }
}
