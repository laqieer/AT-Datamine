// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListNoTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EC8")]
  public class BookListNoTab
  {
    [Token(Token = "0x400C89F")]
    [FieldOffset(Offset = "0x18")]
    private BookList booklist;
    [Token(Token = "0x400C8A0")]
    private const string ASSETBUNDLE_LABEL = "ui_page_areaui_book";
    [Token(Token = "0x400C8A1")]
    private const string ASSET_NAME = "Book_Popup_Read";

    [Token(Token = "0x17003DFF")]
    public BookListView ListView
    {
      [Token(Token = "0x6012457"), Address(RVA = "0x22F28AC", Offset = "0x22F28AC", VA = "0x22F28AC")] get
      {
        return (BookListView) null;
      }
    }

    [Token(Token = "0x14000185")]
    public event Action OnClose
    {
      [Token(Token = "0x6012458"), Address(RVA = "0x22F28B4", Offset = "0x22F28B4", VA = "0x22F28B4")] add
      {
      }
      [Token(Token = "0x6012459"), Address(RVA = "0x22F28D0", Offset = "0x22F28D0", VA = "0x22F28D0")] remove
      {
      }
    }

    [Token(Token = "0x14000186")]
    public event Action<Story.Adv.LuaObjects.Book> OnSelect
    {
      [Token(Token = "0x601245A"), Address(RVA = "0x22F28EC", Offset = "0x22F28EC", VA = "0x22F28EC")] add
      {
      }
      [Token(Token = "0x601245B"), Address(RVA = "0x22F29AC", Offset = "0x22F29AC", VA = "0x22F29AC")] remove
      {
      }
    }

    [Token(Token = "0x601245C")]
    [Address(RVA = "0x22F2A6C", Offset = "0x22F2A6C", VA = "0x22F2A6C")]
    public BookListNoTab(BookList booklist)
    {
    }

    [Token(Token = "0x601245D")]
    [Address(RVA = "0x22F2B48", Offset = "0x22F2B48", VA = "0x22F2B48")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x601245E")]
    [Address(RVA = "0x22F2BD8", Offset = "0x22F2BD8", VA = "0x22F2BD8")]
    public void Set(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x601245F")]
    [Address(RVA = "0x22F2BF4", Offset = "0x22F2BF4", VA = "0x22F2BF4")]
    public void NewFlagOff(int bookItemID)
    {
    }

    [Token(Token = "0x6012460")]
    [Address(RVA = "0x22F2CB4", Offset = "0x22F2CB4", VA = "0x22F2CB4")]
    public void Open()
    {
    }

    [Token(Token = "0x6012461")]
    [Address(RVA = "0x22F2DA8", Offset = "0x22F2DA8", VA = "0x22F2DA8")]
    public void Close()
    {
    }

    [Token(Token = "0x6012462")]
    [Address(RVA = "0x22F2E58", Offset = "0x22F2E58", VA = "0x22F2E58")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6012463")]
    [Address(RVA = "0x22F2ED8", Offset = "0x22F2ED8", VA = "0x22F2ED8")]
    public static void Spawn(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<BookList> callback)
    {
    }

    [Token(Token = "0x6012464")]
    [Address(RVA = "0x22F2FEC", Offset = "0x22F2FEC", VA = "0x22F2FEC")]
    private static BookList Instantiate(GameObject loaded, Transform parent) => (BookList) null;
  }
}
