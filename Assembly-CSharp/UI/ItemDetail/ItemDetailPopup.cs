// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame;
using Scenes.OutGame.PersonalEmblem;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008C7")]
  public class ItemDetailPopup : PopupBase
  {
    [Token(Token = "0x4002922")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x4002923")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x4002924")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject possessionGroup;
    [Token(Token = "0x4002925")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI possessionNum;
    [Token(Token = "0x4002926")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject saleGroup;
    [Token(Token = "0x4002927")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text salePriceNum;
    [Token(Token = "0x4002928")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject canNotSale;
    [Token(Token = "0x4002929")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text description;
    [Token(Token = "0x400292A")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private RectTransform itemUseTagParent;
    [Token(Token = "0x400292B")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private ItemDetailRecommendPresenter recommendObject;
    [Token(Token = "0x400292C")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton[] commonButtons;
    [Token(Token = "0x400292D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject usuallyObject;
    [Token(Token = "0x400292E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject personalTitleObject;
    [Token(Token = "0x400292F")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x4002930")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4002931")]
    [FieldOffset(Offset = "0x100")]
    private ItemIcon itemIcon;
    [Token(Token = "0x4002932")]
    [FieldOffset(Offset = "0x108")]
    private ItemUseTag baseItemUseTag;
    [Token(Token = "0x4002933")]
    [FieldOffset(Offset = "0x110")]
    private List<ItemUseTag> createItemUseTagList;
    [Token(Token = "0x4002938")]
    [FieldOffset(Offset = "0x134")]
    private bool showPossession;
    [Token(Token = "0x4002939")]
    [FieldOffset(Offset = "0x135")]
    private bool showSale;
    [Token(Token = "0x400293A")]
    [FieldOffset(Offset = "0x136")]
    private bool useUsuallyContent;
    [Token(Token = "0x400293B")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private BoxItemDetailPopup boxItemDetailPopup;

    [Token(Token = "0x1700072F")]
    public Action OnClickToClose
    {
      [Token(Token = "0x60031BE"), Address(RVA = "0x3C1B0E4", Offset = "0x3C1B0E4", VA = "0x3C1B0E4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60031BF"), Address(RVA = "0x3C1B0EC", Offset = "0x3C1B0EC", VA = "0x3C1B0EC")] set
      {
      }
    }

    [Token(Token = "0x17000730")]
    public Action<ItemSupplierSearcher.ISearchResult, bool> OnClickSupplier
    {
      [Token(Token = "0x60031C0"), Address(RVA = "0x3C1B0F4", Offset = "0x3C1B0F4", VA = "0x3C1B0F4")] get
      {
        return (Action<ItemSupplierSearcher.ISearchResult, bool>) null;
      }
      [Token(Token = "0x60031C1"), Address(RVA = "0x3C1B0FC", Offset = "0x3C1B0FC", VA = "0x3C1B0FC")] set
      {
      }
    }

    [Token(Token = "0x17000731")]
    public AssetCachedSpawner AssetCachedSpawner
    {
      [Token(Token = "0x60031C2"), Address(RVA = "0x3C1B104", Offset = "0x3C1B104", VA = "0x3C1B104")] get
      {
        return (AssetCachedSpawner) null;
      }
      [Token(Token = "0x60031C3"), Address(RVA = "0x3C1B10C", Offset = "0x3C1B10C", VA = "0x3C1B10C")] set
      {
      }
    }

    [Token(Token = "0x17000732")]
    private ItemDetailPopup.PhaseType Phase
    {
      [Token(Token = "0x60031C4"), Address(RVA = "0x3C1B114", Offset = "0x3C1B114", VA = "0x3C1B114")] get
      {
        return new ItemDetailPopup.PhaseType();
      }
      [Token(Token = "0x60031C5"), Address(RVA = "0x3C1B11C", Offset = "0x3C1B11C", VA = "0x3C1B11C")] set
      {
      }
    }

    [Token(Token = "0x60031C6")]
    [Address(RVA = "0x3C1B124", Offset = "0x3C1B124", VA = "0x3C1B124")]
    private void Awake()
    {
    }

    [Token(Token = "0x60031C7")]
    [Address(RVA = "0x3C1B1B8", Offset = "0x3C1B1B8", VA = "0x3C1B1B8")]
    public void SetDefaultOutofRangeEvent()
    {
    }

    [Token(Token = "0x60031C8")]
    [Address(RVA = "0x3C1B284", Offset = "0x3C1B284", VA = "0x3C1B284")]
    public void SetDefaultClickToCloseEvent()
    {
    }

    [Token(Token = "0x60031C9")]
    [Address(RVA = "0x3C1B384", Offset = "0x3C1B384", VA = "0x3C1B384")]
    private void SetDefaultClickSupplierEvent()
    {
    }

    [Token(Token = "0x60031CA")]
    [Address(RVA = "0x3C1B4AC", Offset = "0x3C1B4AC", VA = "0x3C1B4AC")]
    private void DefaultClickToCloseCallBack()
    {
    }

    [Token(Token = "0x60031CB")]
    [Address(RVA = "0x3C1B5D4", Offset = "0x3C1B5D4", VA = "0x3C1B5D4")]
    private void DefaultClickOutOfRangeCallBack()
    {
    }

    [Token(Token = "0x60031CC")]
    [Address(RVA = "0x3C1B7C8", Offset = "0x3C1B7C8", VA = "0x3C1B7C8")]
    private void DefaultClickSupplierCallBack(
      ItemSupplierSearcher.ISearchResult target,
      bool isLock)
    {
    }

    [Token(Token = "0x60031CD")]
    [Address(RVA = "0x3C1B7DC", Offset = "0x3C1B7DC", VA = "0x3C1B7DC")]
    public void SetData(
      ItemTypeEnum itemTypeEnum,
      int itemId,
      ItemIcon itemIcon,
      ItemUseTag itemUseTag,
      bool disableSupplier = true)
    {
    }

    [Token(Token = "0x60031CE")]
    [Address(RVA = "0x3C1C40C", Offset = "0x3C1C40C", VA = "0x3C1C40C")]
    public void SetData(
      RewardTypeEnum rewardTypeEnum,
      int rewardId,
      ItemIcon itemIcon,
      ItemUseTag itemUseTag)
    {
    }

    [Token(Token = "0x60031CF")]
    [Address(RVA = "0x3C1C610", Offset = "0x3C1C610", VA = "0x3C1C610")]
    public void SetData(
      PaymentTypeEnum paymentTypeEnum,
      int paymentId,
      ItemIcon itemIcon,
      ItemUseTag itemUseTag)
    {
    }

    [Token(Token = "0x60031D0")]
    [Address(RVA = "0x3C1C790", Offset = "0x3C1C790", VA = "0x3C1C790")]
    public void RecommendSetActive(bool active)
    {
    }

    [Token(Token = "0x60031D1")]
    [Address(RVA = "0x3C1BEE8", Offset = "0x3C1BEE8", VA = "0x3C1BEE8")]
    private void DisableContentByItemType(ItemTypeEnum type)
    {
    }

    [Token(Token = "0x60031D2")]
    [Address(RVA = "0x3C1C5C4", Offset = "0x3C1C5C4", VA = "0x3C1C5C4")]
    private void DisableContentByItemType(RewardTypeEnum type)
    {
    }

    [Token(Token = "0x60031D3")]
    [Address(RVA = "0x3C1C784", Offset = "0x3C1C784", VA = "0x3C1C784")]
    private void DisableContentByItemType(PaymentTypeEnum type)
    {
    }

    [Token(Token = "0x60031D4")]
    [Address(RVA = "0x3C1BF20", Offset = "0x3C1BF20", VA = "0x3C1BF20")]
    private void SetData(
      ItemUtility.Parameter itemParam,
      int roundedAmountByShowLimit,
      int saleNum,
      ItemIcon itemIcon,
      bool disableSupplier = true)
    {
    }

    [Token(Token = "0x60031D5")]
    [Address(RVA = "0x3C1CA90", Offset = "0x3C1CA90", VA = "0x3C1CA90")]
    private void InitializeBoxItemDetail(ItemUtility.Parameter itemParam)
    {
    }

    [Token(Token = "0x60031D6")]
    [Address(RVA = "0x3C1C7DC", Offset = "0x3C1C7DC", VA = "0x3C1C7DC")]
    private void CreateItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x60031D7")]
    [Address(RVA = "0x3C1B988", Offset = "0x3C1B988", VA = "0x3C1B988")]
    private int GetSaleNum(ItemTypeEnum itemTypeEnum, int itemId, ItemUtility.Parameter param)
    {
      return new int();
    }

    [Token(Token = "0x60031D8")]
    [Address(RVA = "0x3C1BA70", Offset = "0x3C1BA70", VA = "0x3C1BA70")]
    private void SetUsageNames(int itemId, ItemTypeEnum itemType)
    {
    }

    [Token(Token = "0x60031D9")]
    [Address(RVA = "0x3C1CC30", Offset = "0x3C1CC30", VA = "0x3C1CC30")]
    public void OnPressedBackKey()
    {
    }

    [Token(Token = "0x60031DA")]
    [Address(RVA = "0x3C1CC4C", Offset = "0x3C1CC4C", VA = "0x3C1CC4C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60031DB")]
    [Address(RVA = "0x3C1CC88", Offset = "0x3C1CC88", VA = "0x3C1CC88")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60031DC")]
    [Address(RVA = "0x3C1CEC8", Offset = "0x3C1CEC8", VA = "0x3C1CEC8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60031DD")]
    [Address(RVA = "0x3C1B4B8", Offset = "0x3C1B4B8", VA = "0x3C1B4B8")]
    private void Close(bool destroyWhenFinished = true, Action onClosed = null)
    {
    }

    [Token(Token = "0x60031DE")]
    [Address(RVA = "0x3C1D01C", Offset = "0x3C1D01C", VA = "0x3C1D01C")]
    public ItemDetailPopup()
    {
    }

    [Token(Token = "0x20008C8")]
    public enum ButtonType
    {
      [Token(Token = "0x400293D")] RedButton,
      [Token(Token = "0x400293E")] BlackButton,
      [Token(Token = "0x400293F")] BlueButton,
    }

    [Token(Token = "0x20008C9")]
    private enum PhaseType
    {
      [Token(Token = "0x4002941")] Initialize,
      [Token(Token = "0x4002942")] Opening,
      [Token(Token = "0x4002943")] Operate,
      [Token(Token = "0x4002944")] Ending,
      [Token(Token = "0x4002945")] Finish,
    }
  }
}
