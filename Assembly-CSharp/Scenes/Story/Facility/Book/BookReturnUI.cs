// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookReturnUI
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
  [Token(Token = "0x2002EE2")]
  public class BookReturnUI : MonoBehaviour, IReturnEvent
  {
    [Token(Token = "0x400C8ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;

    [Token(Token = "0x17003E23")]
    public string Title
    {
      [Token(Token = "0x6012504"), Address(RVA = "0x22F6100", Offset = "0x22F6100", VA = "0x22F6100")] set
      {
      }
    }

    [Token(Token = "0x17003E24")]
    public Action OnPositive
    {
      [Token(Token = "0x6012505"), Address(RVA = "0x22F6418", Offset = "0x22F6418", VA = "0x22F6418")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x6012506"), Address(RVA = "0x22F6420", Offset = "0x22F6420", VA = "0x22F6420", Slot = "4")] set
      {
      }
    }

    [Token(Token = "0x17003E25")]
    public Action OnNegative
    {
      [Token(Token = "0x6012507"), Address(RVA = "0x22F6428", Offset = "0x22F6428", VA = "0x22F6428")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x6012508"), Address(RVA = "0x22F6430", Offset = "0x22F6430", VA = "0x22F6430", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x6012509")]
    [Address(RVA = "0x22F6438", Offset = "0x22F6438", VA = "0x22F6438")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x601250A")]
    [Address(RVA = "0x22F6454", Offset = "0x22F6454", VA = "0x22F6454")]
    public void OnClickNegative()
    {
    }

    [Token(Token = "0x601250B")]
    [Address(RVA = "0x22F6470", Offset = "0x22F6470", VA = "0x22F6470")]
    public BookReturnUI()
    {
    }
  }
}
