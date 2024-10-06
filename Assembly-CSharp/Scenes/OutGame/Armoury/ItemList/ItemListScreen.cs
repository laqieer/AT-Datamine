// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.ItemListScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x200386C")]
  internal class ItemListScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400F65C")]
    [FieldOffset(Offset = "0x90")]
    [Header("画面上部")]
    [SerializeField]
    private Text zenyButtonText;
    [Token(Token = "0x400F65D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private SortFilterHeaderButton sortFilterHeaderButton;
    [Token(Token = "0x400F65E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    [Header("スクロールビュー")]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400F65F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private float scrollSnapDuration;
    [Token(Token = "0x400F660")]
    [FieldOffset(Offset = "0xB0")]
    [Header("サブメニュー")]
    [SerializeField]
    private Transform subMenuParent;
    [Token(Token = "0x400F661")]
    [FieldOffset(Offset = "0xB8")]
    [Space(10f)]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F662")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CanvasGroup topCanvasGroup;
    [Token(Token = "0x400F663")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton fullScreenButton;
    [Token(Token = "0x400F664")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x400F665")]
    [FieldOffset(Offset = "0xD8")]
    private ItemListScreen.Param itemListParam;
    [Token(Token = "0x400F666")]
    [FieldOffset(Offset = "0xE0")]
    private readonly NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400F667")]
    [FieldOffset(Offset = "0xE8")]
    private readonly List<Item> items;
    [Token(Token = "0x400F668")]
    [FieldOffset(Offset = "0xF0")]
    private List<Item> displayItems;
    [Token(Token = "0x400F669")]
    [FieldOffset(Offset = "0xF8")]
    private readonly List<IArmouryItemThumbResource> itemResources;
    [Token(Token = "0x400F66A")]
    [FieldOffset(Offset = "0x100")]
    private ItemListAssetLoader assetLoader;
    [Token(Token = "0x400F66B")]
    [FieldOffset(Offset = "0x108")]
    private ItemListSubMenu subMenu;
    [Token(Token = "0x400F66C")]
    [FieldOffset(Offset = "0x110")]
    private SaleAfterPopup saleAfterPopup;
    [Token(Token = "0x400F66D")]
    [FieldOffset(Offset = "0x118")]
    private SaleCheckContainer saleCheckContainer;
    [Token(Token = "0x400F66E")]
    [FieldOffset(Offset = "0x120")]
    private int prevZeny;
    [Token(Token = "0x400F66F")]
    [FieldOffset(Offset = "0x124")]
    private int thumbSelectIndex;

    [Token(Token = "0x60162D9")]
    [Address(RVA = "0x1DEFC14", Offset = "0x1DEFC14", VA = "0x1DEFC14", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60162DA")]
    [Address(RVA = "0x1DF3414", Offset = "0x1DF3414", VA = "0x1DF3414", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60162DB")]
    [Address(RVA = "0x1DF34A4", Offset = "0x1DF34A4", VA = "0x1DF34A4", Slot = "8")]
    public override void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x60162DC")]
    [Address(RVA = "0x1DF3504", Offset = "0x1DF3504", VA = "0x1DF3504", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x60162DD")]
    [Address(RVA = "0x1DF3698", Offset = "0x1DF3698", VA = "0x1DF3698", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60162DE")]
    [Address(RVA = "0x1DF36B4", Offset = "0x1DF36B4", VA = "0x1DF36B4")]
    private void RefreshView(bool immediateSnap, int newThumbSelectIndex)
    {
    }

    [Token(Token = "0x60162DF")]
    [Address(RVA = "0x1DF3368", Offset = "0x1DF3368", VA = "0x1DF3368")]
    private void UpdateZeny()
    {
    }

    [Token(Token = "0x60162E0")]
    [Address(RVA = "0x1DEFF60", Offset = "0x1DEFF60", VA = "0x1DEFF60")]
    private void CreateItemList()
    {
    }

    [Token(Token = "0x60162E1")]
    [Address(RVA = "0x1DF2DF4", Offset = "0x1DF2DF4", VA = "0x1DF2DF4")]
    private void CreateResources(int dataCount)
    {
    }

    [Token(Token = "0x60162E2")]
    [Address(RVA = "0x1DF3060", Offset = "0x1DF3060", VA = "0x1DF3060")]
    private void SetupScrollView()
    {
    }

    [Token(Token = "0x60162E3")]
    [Address(RVA = "0x1DF3CB0", Offset = "0x1DF3CB0", VA = "0x1DF3CB0")]
    private (int, string) GetPrevSelectedInfo() => ();

    [Token(Token = "0x60162E4")]
    [Address(RVA = "0x1DF37D0", Offset = "0x1DF37D0", VA = "0x1DF37D0")]
    private void ChangeSelectThumb(int index)
    {
    }

    [Token(Token = "0x60162E5")]
    [Address(RVA = "0x1DF3548", Offset = "0x1DF3548", VA = "0x1DF3548")]
    private void ChangeSelectThumbNone()
    {
    }

    [Token(Token = "0x60162E6")]
    [Address(RVA = "0x1DF34C0", Offset = "0x1DF34C0", VA = "0x1DF34C0")]
    private void SetInteractable(bool flg)
    {
    }

    [Token(Token = "0x60162E7")]
    [Address(RVA = "0x1DF3D94", Offset = "0x1DF3D94", VA = "0x1DF3D94")]
    private void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x60162E8")]
    [Address(RVA = "0x1DF3624", Offset = "0x1DF3624", VA = "0x1DF3624")]
    private void OnCloseSubMenuAndHeaderPopup()
    {
    }

    [Token(Token = "0x60162E9")]
    [Address(RVA = "0x1DF40A0", Offset = "0x1DF40A0", VA = "0x1DF40A0")]
    private IEnumerator OnClickFilterButton() => (IEnumerator) null;

    [Token(Token = "0x60162EA")]
    [Address(RVA = "0x1DF4130", Offset = "0x1DF4130", VA = "0x1DF4130")]
    private void UpdateSortFilterAction(List<Item> sortFilterList)
    {
    }

    [Token(Token = "0x60162EB")]
    [Address(RVA = "0x1DEFF44", Offset = "0x1DEFF44", VA = "0x1DEFF44")]
    private void UpdateSortFilterButton()
    {
    }

    [Token(Token = "0x60162EC")]
    [Address(RVA = "0x1DF4448", Offset = "0x1DF4448", VA = "0x1DF4448")]
    private void OnClickSubMenuSaleButton()
    {
    }

    [Token(Token = "0x60162ED")]
    [Address(RVA = "0x1DF4468", Offset = "0x1DF4468", VA = "0x1DF4468")]
    private IEnumerator OpenSaleDialog() => (IEnumerator) null;

    [Token(Token = "0x60162EE")]
    [Address(RVA = "0x1DF44F8", Offset = "0x1DF44F8", VA = "0x1DF44F8")]
    private IEnumerator OnClickPopupSale() => (IEnumerator) null;

    [Token(Token = "0x60162EF")]
    [Address(RVA = "0x1DF4588", Offset = "0x1DF4588", VA = "0x1DF4588")]
    private IEnumerator OnClickSubMenuUseButton() => (IEnumerator) null;

    [Token(Token = "0x60162F0")]
    [Address(RVA = "0x1DF4618", Offset = "0x1DF4618", VA = "0x1DF4618")]
    private IEnumerator CreateBoxItemPopup(Item item, Action<BoxItemUsePopup> finished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60162F1")]
    [Address(RVA = "0x1DF46BC", Offset = "0x1DF46BC", VA = "0x1DF46BC")]
    private void Update()
    {
    }

    [Token(Token = "0x60162F2")]
    [Address(RVA = "0x1DF46D8", Offset = "0x1DF46D8", VA = "0x1DF46D8")]
    public ItemListScreen()
    {
    }

    [Token(Token = "0x200386D")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x1700492C")]
      public int FilterSelect
      {
        [Token(Token = "0x60162FD"), Address(RVA = "0x1DF4E24", Offset = "0x1DF4E24", VA = "0x1DF4E24")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60162FE")]
      [Address(RVA = "0x1DEFF3C", Offset = "0x1DEFF3C", VA = "0x1DEFF3C")]
      public Param()
      {
      }
    }
  }
}
