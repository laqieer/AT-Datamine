// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookReturnPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002EDE")]
  public class BookReturnPopup : MonoBehaviour
  {
    [Token(Token = "0x400C8E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C8E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BookThumbUI thumbUI;
    [Token(Token = "0x400C8E5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BookReturnUI returnUI;
    [Token(Token = "0x400C8E6")]
    private const string ASSETBUNDLE_LABEL = "ui_page_areaui_book";
    [Token(Token = "0x400C8E7")]
    private const string ASSET_NAME = "Com_Popup_Base_S_Book_Return";

    [Token(Token = "0x17003E1E")]
    public IReturnEvent Event
    {
      [Token(Token = "0x60124EF"), Address(RVA = "0x22F5E9C", Offset = "0x22F5E9C", VA = "0x22F5E9C")] get
      {
        return (IReturnEvent) null;
      }
    }

    [Token(Token = "0x60124F0")]
    [Address(RVA = "0x22F5EA4", Offset = "0x22F5EA4", VA = "0x22F5EA4")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60124F1")]
    [Address(RVA = "0x22F5F24", Offset = "0x22F5F24", VA = "0x22F5F24")]
    public static void Spawn(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<BookReturnPopup> callback)
    {
    }

    [Token(Token = "0x60124F2")]
    [Address(RVA = "0x22F6038", Offset = "0x22F6038", VA = "0x22F6038")]
    private static BookReturnPopup Instantiate(Transform parent, GameObject loaded)
    {
      return (BookReturnPopup) null;
    }

    [Token(Token = "0x60124F3")]
    [Address(RVA = "0x22F60DC", Offset = "0x22F60DC", VA = "0x22F60DC")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60124F4")]
    [Address(RVA = "0x22F611C", Offset = "0x22F611C", VA = "0x22F611C")]
    public void SetCount(int num, int max)
    {
    }

    [Token(Token = "0x60124F5")]
    [Address(RVA = "0x22F6134", Offset = "0x22F6134", VA = "0x22F6134")]
    public void Open()
    {
    }

    [Token(Token = "0x60124F6")]
    [Address(RVA = "0x22F6174", Offset = "0x22F6174", VA = "0x22F6174")]
    private IEnumerator OpenInternal() => (IEnumerator) null;

    [Token(Token = "0x60124F7")]
    [Address(RVA = "0x22F6204", Offset = "0x22F6204", VA = "0x22F6204")]
    public void Close()
    {
    }

    [Token(Token = "0x60124F8")]
    [Address(RVA = "0x22F629C", Offset = "0x22F629C", VA = "0x22F629C")]
    public BookReturnPopup()
    {
    }
  }
}
