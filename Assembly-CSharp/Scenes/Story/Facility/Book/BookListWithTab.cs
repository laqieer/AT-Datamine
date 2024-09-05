// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookListWithTab
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
  [Token(Token = "0x2002ED4")]
  public class BookListWithTab
  {
    [Token(Token = "0x400C8C4")]
    [FieldOffset(Offset = "0x18")]
    private BookList booklist;
    [Token(Token = "0x400C8C5")]
    [FieldOffset(Offset = "0x20")]
    private BookListTab bookListTab;
    [Token(Token = "0x400C8C6")]
    [FieldOffset(Offset = "0x28")]
    private Story.Adv.LuaObjects.Book[] books;
    [Token(Token = "0x400C8C7")]
    private const string ASSETBUNDLE_LABEL = "ui_page_areaui_book";
    [Token(Token = "0x400C8C8")]
    private const string ASSET_NAME = "Book_Popup_Rental";

    [Token(Token = "0x17003E12")]
    public BookListView ListView
    {
      [Token(Token = "0x60124AB"), Address(RVA = "0x22F46AC", Offset = "0x22F46AC", VA = "0x22F46AC")] get
      {
        return (BookListView) null;
      }
    }

    [Token(Token = "0x14000188")]
    public event Action OnClose
    {
      [Token(Token = "0x60124AC"), Address(RVA = "0x22F46B4", Offset = "0x22F46B4", VA = "0x22F46B4")] add
      {
      }
      [Token(Token = "0x60124AD"), Address(RVA = "0x22F46D0", Offset = "0x22F46D0", VA = "0x22F46D0")] remove
      {
      }
    }

    [Token(Token = "0x14000189")]
    public event Action<Story.Adv.LuaObjects.Book> OnSelect
    {
      [Token(Token = "0x60124AE"), Address(RVA = "0x22F46EC", Offset = "0x22F46EC", VA = "0x22F46EC")] add
      {
      }
      [Token(Token = "0x60124AF"), Address(RVA = "0x22F4704", Offset = "0x22F4704", VA = "0x22F4704")] remove
      {
      }
    }

    [Token(Token = "0x60124B0")]
    [Address(RVA = "0x22F471C", Offset = "0x22F471C", VA = "0x22F471C")]
    public BookListWithTab(BookList booklist)
    {
    }

    [Token(Token = "0x60124B1")]
    [Address(RVA = "0x22F47BC", Offset = "0x22F47BC", VA = "0x22F47BC")]
    public IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x60124B2")]
    [Address(RVA = "0x22F484C", Offset = "0x22F484C", VA = "0x22F484C")]
    public void Set(Story.Adv.LuaObjects.Book[] books)
    {
    }

    [Token(Token = "0x60124B3")]
    [Address(RVA = "0x22F486C", Offset = "0x22F486C", VA = "0x22F486C")]
    public void NewFlagOff(int bookItemID)
    {
    }

    [Token(Token = "0x60124B4")]
    [Address(RVA = "0x22F4884", Offset = "0x22F4884", VA = "0x22F4884")]
    public void Open()
    {
    }

    [Token(Token = "0x60124B5")]
    [Address(RVA = "0x22F489C", Offset = "0x22F489C", VA = "0x22F489C")]
    public void Close()
    {
    }

    [Token(Token = "0x60124B6")]
    [Address(RVA = "0x22F48B4", Offset = "0x22F48B4", VA = "0x22F48B4")]
    private void TabInitialize()
    {
    }

    [Token(Token = "0x60124B7")]
    [Address(RVA = "0x22F4AC4", Offset = "0x22F4AC4", VA = "0x22F4AC4")]
    private void TabInitializeCommon(BookTab tab)
    {
    }

    [Token(Token = "0x60124B8")]
    [Address(RVA = "0x22F4CBC", Offset = "0x22F4CBC", VA = "0x22F4CBC")]
    private void TabActivateToggle(BookTab activate)
    {
    }

    [Token(Token = "0x60124B9")]
    [Address(RVA = "0x22F4FEC", Offset = "0x22F4FEC", VA = "0x22F4FEC")]
    public void FilteringAll()
    {
    }

    [Token(Token = "0x60124BA")]
    [Address(RVA = "0x22F5010", Offset = "0x22F5010", VA = "0x22F5010")]
    public void FilteringRental()
    {
    }

    [Token(Token = "0x60124BB")]
    [Address(RVA = "0x22F512C", Offset = "0x22F512C", VA = "0x22F512C")]
    public void FilteringRead()
    {
    }

    [Token(Token = "0x60124BC")]
    [Address(RVA = "0x22F5248", Offset = "0x22F5248", VA = "0x22F5248")]
    public void FilteringLocked()
    {
    }

    [Token(Token = "0x60124BD")]
    [Address(RVA = "0x22F5364", Offset = "0x22F5364", VA = "0x22F5364")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60124BE")]
    [Address(RVA = "0x22F53E4", Offset = "0x22F53E4", VA = "0x22F53E4")]
    public static void Spawn(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<BookList> callback)
    {
    }

    [Token(Token = "0x60124BF")]
    [Address(RVA = "0x22F54F8", Offset = "0x22F54F8", VA = "0x22F54F8")]
    private static BookList Instantiate(GameObject loaded, Transform parent) => (BookList) null;
  }
}
