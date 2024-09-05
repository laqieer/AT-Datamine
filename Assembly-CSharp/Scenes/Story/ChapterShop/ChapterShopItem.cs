// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ChapterShop.ChapterShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Story.ChapterShop
{
  [Token(Token = "0x2002EF5")]
  public class ChapterShopItem : MonoBehaviour
  {
    [Token(Token = "0x400C94C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform selfRectTransform;
    [Token(Token = "0x400C94D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x400C94E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400C94F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI totalLimitNumText;
    [Token(Token = "0x400C950")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI normalPriceTxt;
    [Token(Token = "0x400C951")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI salePriceTxt;
    [Token(Token = "0x400C952")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI prevSalePriceTxt;
    [Token(Token = "0x400C953")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject normalImageObj;
    [Token(Token = "0x400C954")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject saleImageObj;
    [Token(Token = "0x400C955")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject soldOutIconObj;
    [Token(Token = "0x400C956")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject limitItemObj;
    [Token(Token = "0x400C957")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI limitedNumText;
    [Token(Token = "0x400C958")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI addItemNum;
    [Token(Token = "0x400C959")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI limitTextTitle;
    [Token(Token = "0x400C95A")]
    [FieldOffset(Offset = "0x88")]
    private ChapterShopData chapterShopData;
    [Token(Token = "0x400C95B")]
    [FieldOffset(Offset = "0x90")]
    private bool isSoldOut;

    [Token(Token = "0x17003E41")]
    public RectTransform SelfRectTransform
    {
      [Token(Token = "0x6012593"), Address(RVA = "0x22FACF4", Offset = "0x22FACF4", VA = "0x22FACF4")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003E42")]
    public Action<ChapterShopItem.ShopItemType, ChapterShopData> OnShopItemAction
    {
      [Token(Token = "0x6012594"), Address(RVA = "0x22FACFC", Offset = "0x22FACFC", VA = "0x22FACFC")] get
      {
        return (Action<ChapterShopItem.ShopItemType, ChapterShopData>) null;
      }
      [Token(Token = "0x6012595"), Address(RVA = "0x22FAD04", Offset = "0x22FAD04", VA = "0x22FAD04")] set
      {
      }
    }

    [Token(Token = "0x17003E43")]
    public Action<ChapterShopData> OnDescruptionAction
    {
      [Token(Token = "0x6012596"), Address(RVA = "0x22FAD0C", Offset = "0x22FAD0C", VA = "0x22FAD0C")] get
      {
        return (Action<ChapterShopData>) null;
      }
      [Token(Token = "0x6012597"), Address(RVA = "0x22FAD14", Offset = "0x22FAD14", VA = "0x22FAD14")] set
      {
      }
    }

    [Token(Token = "0x17003E44")]
    public ChapterShopItem.ShopItemType NowShopItemType
    {
      [Token(Token = "0x6012598"), Address(RVA = "0x22FAD1C", Offset = "0x22FAD1C", VA = "0x22FAD1C")] get
      {
        return new ChapterShopItem.ShopItemType();
      }
      [Token(Token = "0x6012599"), Address(RVA = "0x22FAD24", Offset = "0x22FAD24", VA = "0x22FAD24")] private set
      {
      }
    }

    [Token(Token = "0x601259A")]
    [Address(RVA = "0x22FAD2C", Offset = "0x22FAD2C", VA = "0x22FAD2C")]
    public void InitializeBySingle(
      ChapterShopData chapterShopData,
      ChapterShopLoader loader,
      Action<ChapterShopItem.ShopItemType, ChapterShopData> onClickShopItem)
    {
    }

    [Token(Token = "0x601259B")]
    [Address(RVA = "0x22FAD30", Offset = "0x22FAD30", VA = "0x22FAD30")]
    private void Initialize(
      ChapterShopData chapterShopData,
      ChapterShopLoader loader,
      Action<ChapterShopItem.ShopItemType, ChapterShopData> onClickShopItem)
    {
    }

    [Token(Token = "0x601259C")]
    [Address(RVA = "0x22FB2EC", Offset = "0x22FB2EC", VA = "0x22FB2EC")]
    public void OnClickItem()
    {
    }

    [Token(Token = "0x601259D")]
    [Address(RVA = "0x22FB318", Offset = "0x22FB318", VA = "0x22FB318")]
    public void OnLongPressToDescription()
    {
    }

    [Token(Token = "0x601259E")]
    [Address(RVA = "0x22FB338", Offset = "0x22FB338", VA = "0x22FB338")]
    public ChapterShopItem()
    {
    }

    [Token(Token = "0x2002EF6")]
    public enum ShopItemType
    {
      [Token(Token = "0x400C960")] Single,
      [Token(Token = "0x400C961")] Set,
    }
  }
}
