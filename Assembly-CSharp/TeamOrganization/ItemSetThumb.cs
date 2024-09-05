// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemSetThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000785")]
  public class ItemSetThumb : MonoBehaviour
  {
    [Token(Token = "0x4002288")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002289")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject selectEquip;
    [Token(Token = "0x400228A")]
    [FieldOffset(Offset = "0x28")]
    public bool use;
    [Token(Token = "0x400228B")]
    [FieldOffset(Offset = "0x30")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x400228C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400228D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400228E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400228F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x4002290")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image newBadgeImage;
    [Token(Token = "0x4002291")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Image EquipIconImage;
    [Token(Token = "0x4002292")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x4002293")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text ItemPossessionNum;
    [Token(Token = "0x4002294")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button ItemChangeButton;
    [Token(Token = "0x4002295")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button ItemRemoveButton;
    [Token(Token = "0x4002296")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image AcquiredImage;
    [Token(Token = "0x4002297")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image OrdinalNumImage;
    [Token(Token = "0x4002298")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject elementIcon;
    [Token(Token = "0x4002299")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject nameBase;
    [Token(Token = "0x400229A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject rarityLayout;
    [Token(Token = "0x400229B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject rarityIcon;
    [Token(Token = "0x400229C")]
    [FieldOffset(Offset = "0xB8")]
    private Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onSelectAction;
    [Token(Token = "0x400229D")]
    [FieldOffset(Offset = "0xC0")]
    private Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onChangeAction;
    [Token(Token = "0x400229E")]
    [FieldOffset(Offset = "0xC8")]
    private Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onRemoveAction;
    [Token(Token = "0x400229F")]
    [FieldOffset(Offset = "0xD0")]
    private Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onDetailAction;
    [Token(Token = "0x40022A0")]
    [FieldOffset(Offset = "0xD8")]
    private int itemIndex;
    [Token(Token = "0x40022A1")]
    [FieldOffset(Offset = "0xE0")]
    private ItemSetListPopup itemSetListPopup;
    [Token(Token = "0x40022A2")]
    [FieldOffset(Offset = "0xE8")]
    private PartyListBelowScreen partyListBelowScreen;
    [Token(Token = "0x40022A3")]
    [FieldOffset(Offset = "0xF0")]
    private ItemSetEditView setEditView;
    [Token(Token = "0x40022A4")]
    [FieldOffset(Offset = "0xF8")]
    private ItemSetEditItemListPopup itemSetEditItemListPopup;
    [Token(Token = "0x40022A5")]
    [FieldOffset(Offset = "0x100")]
    private ItemSetEditItemListPopup.eItemListKind eItemListKind;
    [Token(Token = "0x40022A6")]
    [FieldOffset(Offset = "0x104")]
    private bool isShowBattleMobileCnt;
    [Token(Token = "0x40022A7")]
    [FieldOffset(Offset = "0x108")]
    public ItemSetThumb.ThumbnailState thumbnailState;
    [Token(Token = "0x40022A8")]
    [FieldOffset(Offset = "0x110")]
    private string thumbAssetBundleName;
    [Token(Token = "0x40022A9")]
    [FieldOffset(Offset = "0x118")]
    private Sprite thumbSprite;
    [Token(Token = "0x40022AA")]
    [FieldOffset(Offset = "0x120")]
    public bool onDisp;

    [Token(Token = "0x1700064F")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x6002A0F"), Address(RVA = "0x34FEAFC", Offset = "0x34FEAFC", VA = "0x34FEAFC")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17000650")]
    public Expendable expendable
    {
      [Token(Token = "0x6002A10"), Address(RVA = "0x34FEB04", Offset = "0x34FEB04", VA = "0x34FEB04")] get
      {
        return (Expendable) null;
      }
      [Token(Token = "0x6002A11"), Address(RVA = "0x34FEB0C", Offset = "0x34FEB0C", VA = "0x34FEB0C")] private set
      {
      }
    }

    [Token(Token = "0x6002A12")]
    [Address(RVA = "0x34FEB14", Offset = "0x34FEB14", VA = "0x34FEB14")]
    public void Initialize(ItemSetListPopup itemSetListPopup)
    {
    }

    [Token(Token = "0x6002A13")]
    [Address(RVA = "0x34FEEDC", Offset = "0x34FEEDC", VA = "0x34FEEDC")]
    public void Initialize(PartyListBelowScreen partyListBelowScreen, Expendable expendable)
    {
    }

    [Token(Token = "0x6002A14")]
    [Address(RVA = "0x34FEF14", Offset = "0x34FEF14", VA = "0x34FEF14")]
    public void Initialize(
      int index,
      ItemSetEditView itemSetEditView,
      Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onSelectAction)
    {
    }

    [Token(Token = "0x6002A15")]
    [Address(RVA = "0x34F7D60", Offset = "0x34F7D60", VA = "0x34F7D60")]
    public void Initialize(
      int idx,
      ItemSetEditItemListPopup itemSetEditItemListPopup,
      ItemSetEditItemListPopup.eItemListKind kind,
      Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onChangeAction,
      Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onDetailAction,
      Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onSelectAction,
      Action<int, ItemSetEditItemListPopup.eItemListKind, ItemSetThumb> onRemoveAction)
    {
    }

    [Token(Token = "0x6002A16")]
    [Address(RVA = "0x34F7E60", Offset = "0x34F7E60", VA = "0x34F7E60")]
    public void UpdateThumb(Expendable expendable)
    {
    }

    [Token(Token = "0x6002A17")]
    [Address(RVA = "0x34FEBD8", Offset = "0x34FEBD8", VA = "0x34FEBD8")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6002A18")]
    [Address(RVA = "0x34FF524", Offset = "0x34FF524", VA = "0x34FF524")]
    public void OnClickThumb(int index)
    {
    }

    [Token(Token = "0x6002A19")]
    [Address(RVA = "0x34F98D0", Offset = "0x34F98D0", VA = "0x34F98D0")]
    public void ChangeSelectButton(bool isRemove)
    {
    }

    [Token(Token = "0x6002A1A")]
    [Address(RVA = "0x34F9590", Offset = "0x34F9590", VA = "0x34F9590")]
    public void SelectOn(bool isRemove)
    {
    }

    [Token(Token = "0x6002A1B")]
    [Address(RVA = "0x34F9464", Offset = "0x34F9464", VA = "0x34F9464")]
    public void SelectOff()
    {
    }

    [Token(Token = "0x6002A1C")]
    [Address(RVA = "0x34FF54C", Offset = "0x34FF54C", VA = "0x34FF54C")]
    public void OnChangeButton()
    {
    }

    [Token(Token = "0x6002A1D")]
    [Address(RVA = "0x34FF574", Offset = "0x34FF574", VA = "0x34FF574")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002A1E")]
    [Address(RVA = "0x34FF59C", Offset = "0x34FF59C", VA = "0x34FF59C")]
    public void OnDetailAction()
    {
    }

    [Token(Token = "0x6002A1F")]
    [Address(RVA = "0x34FF5C4", Offset = "0x34FF5C4", VA = "0x34FF5C4")]
    private void SetThumbnailImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002A20")]
    [Address(RVA = "0x34FF6E0", Offset = "0x34FF6E0", VA = "0x34FF6E0")]
    private void Update()
    {
    }

    [Token(Token = "0x6002A21")]
    [Address(RVA = "0x34FFA8C", Offset = "0x34FFA8C", VA = "0x34FFA8C")]
    private void DestroyThumbSprite()
    {
    }

    [Token(Token = "0x6002A22")]
    [Address(RVA = "0x34FEFF0", Offset = "0x34FEFF0", VA = "0x34FEFF0")]
    private Sprite GetRarityBaseImage() => (Sprite) null;

    [Token(Token = "0x6002A23")]
    [Address(RVA = "0x34FF2A0", Offset = "0x34FF2A0", VA = "0x34FF2A0")]
    private void AddThumbAssetBundle()
    {
    }

    [Token(Token = "0x6002A24")]
    [Address(RVA = "0x34FF3D4", Offset = "0x34FF3D4", VA = "0x34FF3D4")]
    private string GetAseetBundleName() => (string) null;

    [Token(Token = "0x6002A25")]
    [Address(RVA = "0x34FF93C", Offset = "0x34FF93C", VA = "0x34FF93C")]
    private string GetAseetName() => (string) null;

    [Token(Token = "0x6002A26")]
    [Address(RVA = "0x34FFBA4", Offset = "0x34FFBA4", VA = "0x34FFBA4")]
    public ItemSetThumb()
    {
    }

    [Token(Token = "0x2000786")]
    private enum eIconTween
    {
      [Token(Token = "0x40022B1")] In = 0,
      [Token(Token = "0x40022AD")] NewBadge = 0,
      [Token(Token = "0x40022AE")] Equipped = 1,
      [Token(Token = "0x40022B2")] Out = 1,
      [Token(Token = "0x40022AF")] Favorite = 2,
      [Token(Token = "0x40022B3")] Flick = 2,
      [Token(Token = "0x40022B0")] Lost = 3,
    }

    [Token(Token = "0x2000787")]
    public enum ThumbnailState
    {
      [Token(Token = "0x40022B5")] Nothing,
      [Token(Token = "0x40022B6")] LoadWait,
      [Token(Token = "0x40022B7")] Loading,
      [Token(Token = "0x40022B8")] Enable,
    }
  }
}
