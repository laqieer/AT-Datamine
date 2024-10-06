// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using PurchaseModule.Product;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B64")]
  public class PassShopItem : MonoBehaviour
  {
    [Token(Token = "0x4010671")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x4010672")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x4010673")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text dailyNum;
    [Token(Token = "0x4010674")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text untilAvailableDay;
    [Token(Token = "0x4010675")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image shopBanner;
    [Token(Token = "0x4010676")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text priceNum;
    [Token(Token = "0x4010677")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject soldOutObj;
    [Token(Token = "0x4010678")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4010679")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup badgeIcon;
    [Token(Token = "0x401067A")]
    [FieldOffset(Offset = "0x60")]
    private PlayerShopArticleType articleType;
    [Token(Token = "0x401067B")]
    [FieldOffset(Offset = "0x68")]
    private Action<PlayerShopArticleType, bool> onClickItemAction;
    [Token(Token = "0x401067C")]
    [FieldOffset(Offset = "0x70")]
    private bool isBuy;
    [Token(Token = "0x401067D")]
    [FieldOffset(Offset = "0x78")]
    private Coroutine rawImageCoroutine;
    [Token(Token = "0x401067E")]
    [FieldOffset(Offset = "0x80")]
    private bool isDestroy;

    [Token(Token = "0x17004C1B")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x60175DC"), Address(RVA = "0x28FD230", Offset = "0x28FD230", VA = "0x28FD230")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x60175DD")]
    [Address(RVA = "0x28FD238", Offset = "0x28FD238", VA = "0x28FD238")]
    public IEnumerator GetSetItemBanner(int setItemId, Action<Texture2D> loadedAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60175DE")]
    [Address(RVA = "0x28FD2E0", Offset = "0x28FD2E0", VA = "0x28FD2E0")]
    private void ResetCoroutine()
    {
    }

    [Token(Token = "0x60175DF")]
    [Address(RVA = "0x28FD304", Offset = "0x28FD304", VA = "0x28FD304")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60175E0")]
    [Address(RVA = "0x28FD330", Offset = "0x28FD330", VA = "0x28FD330")]
    public void Initialize(
      PlayerShopArticleType articleType,
      ProductInfo productInfo,
      Action<PlayerShopArticleType, bool> onClickItemAction)
    {
    }

    [Token(Token = "0x60175E1")]
    [Address(RVA = "0x28FD94C", Offset = "0x28FD94C", VA = "0x28FD94C")]
    private void BadgeActive(bool isActive)
    {
    }

    [Token(Token = "0x60175E2")]
    [Address(RVA = "0x28FD9C4", Offset = "0x28FD9C4", VA = "0x28FD9C4")]
    public void OnClickToButton()
    {
    }

    [Token(Token = "0x60175E3")]
    [Address(RVA = "0x28FD9E8", Offset = "0x28FD9E8", VA = "0x28FD9E8")]
    public PassShopItem()
    {
    }
  }
}
