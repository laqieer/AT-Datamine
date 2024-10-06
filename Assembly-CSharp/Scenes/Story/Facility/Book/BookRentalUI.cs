// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookRentalUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EDD")]
  public class BookRentalUI : MonoBehaviour, IRentalEvent
  {
    [Token(Token = "0x400C8DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400C8E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor flavour;

    [Token(Token = "0x17003E1A")]
    public string Title
    {
      [Token(Token = "0x60124E6"), Address(RVA = "0x22F5A04", Offset = "0x22F5A04", VA = "0x22F5A04")] set
      {
      }
    }

    [Token(Token = "0x17003E1B")]
    public string Flavour
    {
      [Token(Token = "0x60124E7"), Address(RVA = "0x22F5A44", Offset = "0x22F5A44", VA = "0x22F5A44")] set
      {
      }
    }

    [Token(Token = "0x17003E1C")]
    public Action OnPositive
    {
      [Token(Token = "0x60124E8"), Address(RVA = "0x22F5E3C", Offset = "0x22F5E3C", VA = "0x22F5E3C")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x60124E9"), Address(RVA = "0x22F5E44", Offset = "0x22F5E44", VA = "0x22F5E44", Slot = "4")] set
      {
      }
    }

    [Token(Token = "0x17003E1D")]
    public Action OnNegative
    {
      [Token(Token = "0x60124EA"), Address(RVA = "0x22F5E4C", Offset = "0x22F5E4C", VA = "0x22F5E4C")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x60124EB"), Address(RVA = "0x22F5E54", Offset = "0x22F5E54", VA = "0x22F5E54", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x60124EC")]
    [Address(RVA = "0x22F5E5C", Offset = "0x22F5E5C", VA = "0x22F5E5C")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x60124ED")]
    [Address(RVA = "0x22F5E78", Offset = "0x22F5E78", VA = "0x22F5E78")]
    public void OnClickNegative()
    {
    }

    [Token(Token = "0x60124EE")]
    [Address(RVA = "0x22F5E94", Offset = "0x22F5E94", VA = "0x22F5E94")]
    public BookRentalUI()
    {
    }
  }
}
