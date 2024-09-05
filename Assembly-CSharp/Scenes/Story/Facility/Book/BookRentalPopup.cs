// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Facility.Book.BookRentalPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Facility.Book
{
  [Token(Token = "0x2002ED9")]
  public class BookRentalPopup : MonoBehaviour
  {
    [Token(Token = "0x400C8D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C8D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BookThumbUI thumbUI;
    [Token(Token = "0x400C8D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BookRentalUI rentalUI;
    [Token(Token = "0x400C8D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextAccessor positiveTxt;
    [Token(Token = "0x400C8D8")]
    private const string ASSETBUNDLE_LABEL = "ui_page_areaui_book";
    [Token(Token = "0x400C8D9")]
    private const string ASSET_NAME = "Com_Popup_Base_S_Book_Rental";

    [Token(Token = "0x17003E15")]
    public IRentalEvent Event
    {
      [Token(Token = "0x60124CF"), Address(RVA = "0x22F57A0", Offset = "0x22F57A0", VA = "0x22F57A0")] get
      {
        return (IRentalEvent) null;
      }
    }

    [Token(Token = "0x60124D0")]
    [Address(RVA = "0x22F57A8", Offset = "0x22F57A8", VA = "0x22F57A8")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60124D1")]
    [Address(RVA = "0x22F5828", Offset = "0x22F5828", VA = "0x22F5828")]
    public static void Spawn(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<BookRentalPopup> callback)
    {
    }

    [Token(Token = "0x60124D2")]
    [Address(RVA = "0x22F593C", Offset = "0x22F593C", VA = "0x22F593C")]
    private static BookRentalPopup Instantiate(Transform parent, GameObject loaded)
    {
      return (BookRentalPopup) null;
    }

    [Token(Token = "0x60124D3")]
    [Address(RVA = "0x22F59E0", Offset = "0x22F59E0", VA = "0x22F59E0")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x60124D4")]
    [Address(RVA = "0x22F5A20", Offset = "0x22F5A20", VA = "0x22F5A20")]
    public void SetFlavour(string flavour)
    {
    }

    [Token(Token = "0x60124D5")]
    [Address(RVA = "0x22F5A60", Offset = "0x22F5A60", VA = "0x22F5A60")]
    public void SetPositive(string text)
    {
    }

    [Token(Token = "0x60124D6")]
    [Address(RVA = "0x22F5A7C", Offset = "0x22F5A7C", VA = "0x22F5A7C")]
    public void SetCount(int num, int max)
    {
    }

    [Token(Token = "0x60124D7")]
    [Address(RVA = "0x22F5B58", Offset = "0x22F5B58", VA = "0x22F5B58")]
    public void Open()
    {
    }

    [Token(Token = "0x60124D8")]
    [Address(RVA = "0x22F5B98", Offset = "0x22F5B98", VA = "0x22F5B98")]
    private IEnumerator OpenInternal() => (IEnumerator) null;

    [Token(Token = "0x60124D9")]
    [Address(RVA = "0x22F5C28", Offset = "0x22F5C28", VA = "0x22F5C28")]
    public void Close()
    {
    }

    [Token(Token = "0x60124DA")]
    [Address(RVA = "0x22F5CC0", Offset = "0x22F5CC0", VA = "0x22F5CC0")]
    public BookRentalPopup()
    {
    }
  }
}
