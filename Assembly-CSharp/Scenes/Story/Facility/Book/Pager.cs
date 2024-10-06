// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.Pager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EE8")]
  public class Pager
  {
    [Token(Token = "0x400C8FA")]
    [FieldOffset(Offset = "0x10")]
    public int MAX;
    [Token(Token = "0x400C8FB")]
    [FieldOffset(Offset = "0x14")]
    private int currentIdx;
    [Token(Token = "0x400C8FC")]
    [FieldOffset(Offset = "0x18")]
    private BookListPageJump[] pageJumps;
    [Token(Token = "0x400C8FD")]
    [FieldOffset(Offset = "0x20")]
    private BookListItem[] instances;
    [Token(Token = "0x400C8FE")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, BookListItem> showItems;
    [Token(Token = "0x400C8FF")]
    [FieldOffset(Offset = "0x30")]
    public Action<int> OnJumpPage;
    [Token(Token = "0x400C900")]
    [FieldOffset(Offset = "0x38")]
    public Action<Story.Adv.LuaObjects.Book> OnSelect;

    [Token(Token = "0x17003E28")]
    public bool ArrowFirst
    {
      [Token(Token = "0x6012523"), Address(RVA = "0x22F3DF4", Offset = "0x22F3DF4", VA = "0x22F3DF4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003E29")]
    public bool ArrowPrev
    {
      [Token(Token = "0x6012524"), Address(RVA = "0x22F6838", Offset = "0x22F6838", VA = "0x22F6838")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012525"), Address(RVA = "0x22F6840", Offset = "0x22F6840", VA = "0x22F6840")] private set
      {
      }
    }

    [Token(Token = "0x17003E2A")]
    public bool ArrowNext
    {
      [Token(Token = "0x6012526"), Address(RVA = "0x22F684C", Offset = "0x22F684C", VA = "0x22F684C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6012527"), Address(RVA = "0x22F6854", Offset = "0x22F6854", VA = "0x22F6854")] private set
      {
      }
    }

    [Token(Token = "0x17003E2B")]
    public bool ArrowEnd
    {
      [Token(Token = "0x6012528"), Address(RVA = "0x22F3DFC", Offset = "0x22F3DFC", VA = "0x22F3DFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6012529")]
    [Address(RVA = "0x22F3E04", Offset = "0x22F3E04", VA = "0x22F3E04")]
    public Pager()
    {
    }

    [Token(Token = "0x601252A")]
    [Address(RVA = "0x22F366C", Offset = "0x22F366C", VA = "0x22F366C")]
    public void Initialize(BookList booklist)
    {
    }

    [Token(Token = "0x601252B")]
    [Address(RVA = "0x22F39A8", Offset = "0x22F39A8", VA = "0x22F39A8")]
    public void NewFlagOff(int bookItemID)
    {
    }

    [Token(Token = "0x601252C")]
    [Address(RVA = "0x22F6860", Offset = "0x22F6860", VA = "0x22F6860")]
    public int GetMaxPage(Story.Adv.LuaObjects.Book[] books) => new int();

    [Token(Token = "0x601252D")]
    [Address(RVA = "0x22F4644", Offset = "0x22F4644", VA = "0x22F4644")]
    public void JumpPage(int index, Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x601252E")]
    [Address(RVA = "0x22F3954", Offset = "0x22F3954", VA = "0x22F3954")]
    public void FirstPage(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x601252F")]
    [Address(RVA = "0x22F4034", Offset = "0x22F4034", VA = "0x22F4034")]
    public void EndPage(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012530")]
    [Address(RVA = "0x22F4484", Offset = "0x22F4484", VA = "0x22F4484")]
    public void PrevPage(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012531")]
    [Address(RVA = "0x22F430C", Offset = "0x22F430C", VA = "0x22F430C")]
    public void NextPage(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012532")]
    [Address(RVA = "0x22F68E4", Offset = "0x22F68E4", VA = "0x22F68E4")]
    private void Change(int pageIndex, Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012533")]
    [Address(RVA = "0x22F6944", Offset = "0x22F6944", VA = "0x22F6944")]
    private void ChangeArrows(int pageIndex, Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012534")]
    [Address(RVA = "0x22F6B98", Offset = "0x22F6B98", VA = "0x22F6B98")]
    private void ChangeListItems(int pageIndex, Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x6012535")]
    [Address(RVA = "0x22F6984", Offset = "0x22F6984", VA = "0x22F6984")]
    private void ChangeJumpNumbers(int pageIndex, Story.Adv.LuaObjects.Book[] books)
    {
    }
  }
}
