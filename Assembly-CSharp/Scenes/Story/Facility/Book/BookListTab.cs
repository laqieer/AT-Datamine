// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002ECC")]
  public class BookListTab : MonoBehaviour
  {
    [Token(Token = "0x400C8AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BookTab tabAll;
    [Token(Token = "0x400C8AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BookTab tabRental;
    [Token(Token = "0x400C8AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BookTab tabRead;
    [Token(Token = "0x400C8AE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BookTab tabLocked;

    [Token(Token = "0x17003E03")]
    public BookTab TabAll
    {
      [Token(Token = "0x6012472"), Address(RVA = "0x22F351C", Offset = "0x22F351C", VA = "0x22F351C")] get
      {
        return (BookTab) null;
      }
    }

    [Token(Token = "0x17003E04")]
    public BookTab TabRental
    {
      [Token(Token = "0x6012473"), Address(RVA = "0x22F3524", Offset = "0x22F3524", VA = "0x22F3524")] get
      {
        return (BookTab) null;
      }
    }

    [Token(Token = "0x17003E05")]
    public BookTab TabRead
    {
      [Token(Token = "0x6012474"), Address(RVA = "0x22F352C", Offset = "0x22F352C", VA = "0x22F352C")] get
      {
        return (BookTab) null;
      }
    }

    [Token(Token = "0x17003E06")]
    public BookTab TabLocked
    {
      [Token(Token = "0x6012475"), Address(RVA = "0x22F3534", Offset = "0x22F3534", VA = "0x22F3534")] get
      {
        return (BookTab) null;
      }
    }

    [Token(Token = "0x6012476")]
    [Address(RVA = "0x22F353C", Offset = "0x22F353C", VA = "0x22F353C")]
    public IEnumerable<BookTab> Tabs() => (IEnumerable<BookTab>) null;

    [Token(Token = "0x6012477")]
    [Address(RVA = "0x22F3654", Offset = "0x22F3654", VA = "0x22F3654")]
    public BookListTab()
    {
    }
  }
}
