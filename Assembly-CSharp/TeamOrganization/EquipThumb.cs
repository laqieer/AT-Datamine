// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007D9")]
  public class EquipThumb : MonoBehaviour
  {
    [Token(Token = "0x400249F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40024A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject selectEquip;
    [Token(Token = "0x40024A1")]
    [FieldOffset(Offset = "0x28")]
    private readonly string[][] iconTweenName;
    [Token(Token = "0x40024A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x40024A3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x40024A4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x40024A5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x40024A6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x40024A7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image elementImage;
    [Token(Token = "0x40024A8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x40024A9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image FavoriteIconImage;
    [Token(Token = "0x40024AA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image LostIconImage;
    [Token(Token = "0x40024AB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Button ItemChangeButton;
    [Token(Token = "0x40024AC")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Button ItemRemoveButton;
    [Token(Token = "0x40024AD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image AcquiredImage;
    [Token(Token = "0x40024AE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image OrdinalNumImage;
    [Token(Token = "0x40024AF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject ItemRarityStar;
    [Token(Token = "0x40024B0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject ItemPossessionNum;
    [Token(Token = "0x40024B1")]
    [FieldOffset(Offset = "0xA8")]
    private Action<int> onSelectAction;
    [Token(Token = "0x40024B2")]
    [FieldOffset(Offset = "0xB0")]
    private Action<int> onChangeAction;
    [Token(Token = "0x40024B3")]
    [FieldOffset(Offset = "0xB8")]
    private Action<int> onDetailAction;
    [Token(Token = "0x40024B4")]
    [FieldOffset(Offset = "0xC0")]
    private int itemIndex;
    [Token(Token = "0x40024B5")]
    [FieldOffset(Offset = "0xC8")]
    private EquipEditPopup.ThumbData thumbData;
    [Token(Token = "0x40024B6")]
    [FieldOffset(Offset = "0xD0")]
    private EquipEditPopup equipEditPopup;
    [Token(Token = "0x40024B7")]
    [FieldOffset(Offset = "0xD8")]
    public EquipThumb.ThumbnailState thumbnailState;
    [Token(Token = "0x40024B8")]
    [FieldOffset(Offset = "0xE0")]
    private string thumbAssetBundleName;
    [Token(Token = "0x40024B9")]
    [FieldOffset(Offset = "0xE8")]
    private Sprite thumbSprite;

    [Token(Token = "0x17000690")]
    public int ItemIndex
    {
      [Token(Token = "0x6002C5F"), Address(RVA = "0x387C998", Offset = "0x387C998", VA = "0x387C998")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000691")]
    public int EquipId
    {
      [Token(Token = "0x6002C60"), Address(RVA = "0x387186C", Offset = "0x387186C", VA = "0x387186C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6002C61")]
    [Address(RVA = "0x387C9A0", Offset = "0x387C9A0", VA = "0x387C9A0")]
    public void Initialize(
      EquipEditPopup equipEditPopup,
      EquipEditPopup.ThumbData equipThumbData,
      int idx,
      Action<int> onChangeAction,
      Action<int> onDetailAction,
      Action<int> onSelectAction)
    {
    }

    [Token(Token = "0x6002C62")]
    [Address(RVA = "0x386F6B8", Offset = "0x386F6B8", VA = "0x386F6B8")]
    public void UpdateNew()
    {
    }

    [Token(Token = "0x6002C63")]
    [Address(RVA = "0x387CA94", Offset = "0x387CA94", VA = "0x387CA94")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6002C64")]
    [Address(RVA = "0x387D138", Offset = "0x387D138", VA = "0x387D138")]
    private void EquipmentTypeUIUpdate()
    {
    }

    [Token(Token = "0x6002C65")]
    [Address(RVA = "0x387D200", Offset = "0x387D200", VA = "0x387D200")]
    public void OnClickStyleThumb(int index)
    {
    }

    [Token(Token = "0x6002C66")]
    [Address(RVA = "0x386F728", Offset = "0x386F728", VA = "0x386F728")]
    public void SelectOn(bool isRemove)
    {
    }

    [Token(Token = "0x6002C67")]
    [Address(RVA = "0x386D8CC", Offset = "0x386D8CC", VA = "0x386D8CC")]
    public void SelectOff()
    {
    }

    [Token(Token = "0x6002C68")]
    [Address(RVA = "0x387D27C", Offset = "0x387D27C", VA = "0x387D27C")]
    public void OnChangeButton()
    {
    }

    [Token(Token = "0x6002C69")]
    [Address(RVA = "0x387D29C", Offset = "0x387D29C", VA = "0x387D29C")]
    public void OnDetailAction()
    {
    }

    [Token(Token = "0x6002C6A")]
    [Address(RVA = "0x387D2BC", Offset = "0x387D2BC", VA = "0x387D2BC")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002C6B")]
    [Address(RVA = "0x387D2D4", Offset = "0x387D2D4", VA = "0x387D2D4")]
    private void SetThumbnailImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6002C6C")]
    [Address(RVA = "0x387D3F0", Offset = "0x387D3F0", VA = "0x387D3F0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6002C6D")]
    [Address(RVA = "0x387D494", Offset = "0x387D494", VA = "0x387D494")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6002C6E")]
    [Address(RVA = "0x387D498", Offset = "0x387D498", VA = "0x387D498")]
    private void Update()
    {
    }

    [Token(Token = "0x6002C6F")]
    [Address(RVA = "0x387D3F4", Offset = "0x387D3F4", VA = "0x387D3F4")]
    private void DestroyThumbSprite()
    {
    }

    [Token(Token = "0x6002C70")]
    [Address(RVA = "0x387D688", Offset = "0x387D688", VA = "0x387D688")]
    public EquipThumb()
    {
    }

    [Token(Token = "0x20007DA")]
    private enum eIconTween
    {
      [Token(Token = "0x40024C0")] In = 0,
      [Token(Token = "0x40024BB")] NewBadge = 0,
      [Token(Token = "0x40024BC")] Equipped = 1,
      [Token(Token = "0x40024C1")] Out = 1,
      [Token(Token = "0x40024BD")] Favorite = 2,
      [Token(Token = "0x40024C2")] Flick = 2,
      [Token(Token = "0x40024BE")] Lost = 3,
      [Token(Token = "0x40024BF")] Shortage = 4,
    }

    [Token(Token = "0x20007DB")]
    public enum ThumbnailState
    {
      [Token(Token = "0x40024C4")] Nothing,
      [Token(Token = "0x40024C5")] LoadWait,
      [Token(Token = "0x40024C6")] Loading,
      [Token(Token = "0x40024C7")] Enable,
    }
  }
}
