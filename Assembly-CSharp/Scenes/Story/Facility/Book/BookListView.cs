// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002ECD")]
  public class BookListView
  {
    [Token(Token = "0x400C8AF")]
    [FieldOffset(Offset = "0x10")]
    private BookList booklist;
    [Token(Token = "0x400C8B0")]
    [FieldOffset(Offset = "0x18")]
    private Pager pager;

    [Token(Token = "0x17003E07")]
    public IEnumerable<Story.Adv.LuaObjects.Book> ShowBooks
    {
      [Token(Token = "0x6012478"), Address(RVA = "0x22F365C", Offset = "0x22F365C", VA = "0x22F365C")] private get
      {
        return (IEnumerable<Story.Adv.LuaObjects.Book>) null;
      }
      [Token(Token = "0x6012479"), Address(RVA = "0x22F3664", Offset = "0x22F3664", VA = "0x22F3664")] set
      {
      }
    }

    [Token(Token = "0x14000187")]
    public event Action<Story.Adv.LuaObjects.Book> OnSelect
    {
      [Token(Token = "0x601247A"), Address(RVA = "0x22F2904", Offset = "0x22F2904", VA = "0x22F2904")] add
      {
      }
      [Token(Token = "0x601247B"), Address(RVA = "0x22F29C4", Offset = "0x22F29C4", VA = "0x22F29C4")] remove
      {
      }
    }

    [Token(Token = "0x601247C")]
    [Address(RVA = "0x22F313C", Offset = "0x22F313C", VA = "0x22F313C")]
    public void Initialize(BookList booklist)
    {
    }

    [Token(Token = "0x601247D")]
    [Address(RVA = "0x22F2CCC", Offset = "0x22F2CCC", VA = "0x22F2CCC")]
    public void Open()
    {
    }

    [Token(Token = "0x601247E")]
    [Address(RVA = "0x22F2DC0", Offset = "0x22F2DC0", VA = "0x22F2DC0")]
    public void Close()
    {
    }

    [Token(Token = "0x601247F")]
    [Address(RVA = "0x22F2C0C", Offset = "0x22F2C0C", VA = "0x22F2C0C")]
    public void NewFlagOff(int bookItemID)
    {
    }

    [Token(Token = "0x6012480")]
    [Address(RVA = "0x22F3A28", Offset = "0x22F3A28", VA = "0x22F3A28")]
    public void JumpPage(int index)
    {
    }

    [Token(Token = "0x6012481")]
    [Address(RVA = "0x22F3B34", Offset = "0x22F3B34", VA = "0x22F3B34")]
    public void FirstPage()
    {
    }

    [Token(Token = "0x6012482")]
    [Address(RVA = "0x22F3BE4", Offset = "0x22F3BE4", VA = "0x22F3BE4")]
    public void EndPage()
    {
    }

    [Token(Token = "0x6012483")]
    [Address(RVA = "0x22F3C94", Offset = "0x22F3C94", VA = "0x22F3C94")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x6012484")]
    [Address(RVA = "0x22F3D44", Offset = "0x22F3D44", VA = "0x22F3D44")]
    public void NextPage()
    {
    }

    [Token(Token = "0x6012485")]
    [Address(RVA = "0x22F3964", Offset = "0x22F3964", VA = "0x22F3964")]
    private void ChangeArrow()
    {
    }

    [Token(Token = "0x6012486")]
    [Address(RVA = "0x22F2AE4", Offset = "0x22F2AE4", VA = "0x22F2AE4")]
    public BookListView()
    {
    }
  }
}
