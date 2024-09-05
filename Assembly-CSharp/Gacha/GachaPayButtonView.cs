// Decompiled with JetBrains decompiler
// Type: Gacha.GachaPayButtonView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001510")]
  public class GachaPayButtonView : MonoBehaviour
  {
    [Token(Token = "0x40060E3")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Color notEnoughColor;
    [Token(Token = "0x40060E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image imageIcon;
    [Token(Token = "0x40060E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image miniIcon;
    [Token(Token = "0x40060E6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextAccessor textPrice;
    [Token(Token = "0x40060E7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextAccessor textCount;
    [Token(Token = "0x40060E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GachaPayButtonView.PaymentInfo paidCoinPaymentInfo;
    [Token(Token = "0x40060E9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GachaPayButtonView.PaymentInfo freeCoinPaymentInfo;
    [Token(Token = "0x40060EA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GachaPayButtonView.PaymentInfo itemPaymentInfo;
    [Token(Token = "0x40060EB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GachaPayButtonView.AdvertisementInfo advertisementInfo;
    [Token(Token = "0x40060EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button buttonPay;
    [Token(Token = "0x40060ED")]
    [FieldOffset(Offset = "0x60")]
    public Action<int> OnClickButton;
    [Token(Token = "0x40060EE")]
    [FieldOffset(Offset = "0x68")]
    private int index;

    [Token(Token = "0x6007746")]
    [Address(RVA = "0x44F0CFC", Offset = "0x44F0CFC", VA = "0x44F0CFC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007747")]
    [Address(RVA = "0x44F0D90", Offset = "0x44F0D90", VA = "0x44F0D90")]
    public void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x6007748")]
    [Address(RVA = "0x44F0DB0", Offset = "0x44F0DB0", VA = "0x44F0DB0")]
    public void SetIconActive(bool isActive)
    {
    }

    [Token(Token = "0x6007749")]
    [Address(RVA = "0x44F0E54", Offset = "0x44F0E54", VA = "0x44F0E54")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x600774A")]
    [Address(RVA = "0x44F0F0C", Offset = "0x44F0F0C", VA = "0x44F0F0C")]
    public void SetMiniIconActive(bool isActive)
    {
    }

    [Token(Token = "0x600774B")]
    [Address(RVA = "0x44F0FB0", Offset = "0x44F0FB0", VA = "0x44F0FB0")]
    public void SetMiniIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x600774C")]
    [Address(RVA = "0x44F1068", Offset = "0x44F1068", VA = "0x44F1068")]
    public void SetPrice(int price, bool hasEnoughPaymentAmount)
    {
    }

    [Token(Token = "0x600774D")]
    [Address(RVA = "0x44F1178", Offset = "0x44F1178", VA = "0x44F1178")]
    public void SetRollCount(int count)
    {
    }

    [Token(Token = "0x600774E")]
    [Address(RVA = "0x44F1220", Offset = "0x44F1220", VA = "0x44F1220")]
    public void SetAdRemainCount(int remainCount, bool isResult)
    {
    }

    [Token(Token = "0x600774F")]
    [Address(RVA = "0x44F1330", Offset = "0x44F1330", VA = "0x44F1330")]
    public void SetGachaResultDisplay(
      PaymentTypeEnum paymentType,
      int price,
      string name,
      int adRemainCount)
    {
    }

    [Token(Token = "0x6007750")]
    [Address(RVA = "0x44F16CC", Offset = "0x44F16CC", VA = "0x44F16CC")]
    public GachaPayButtonView()
    {
    }

    [Token(Token = "0x6007751")]
    [Address(RVA = "0x44F16D4", Offset = "0x44F16D4", VA = "0x44F16D4")]
    static GachaPayButtonView()
    {
    }

    [Token(Token = "0x2001511")]
    [Serializable]
    private class PaymentInfo
    {
      [Token(Token = "0x40060EF")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x40060F0")]
      [FieldOffset(Offset = "0x18")]
      public TextAccessor overwriteCurrencyName;
      [Token(Token = "0x40060F1")]
      [FieldOffset(Offset = "0x20")]
      public TextAccessor price;

      [Token(Token = "0x6007753")]
      [Address(RVA = "0x44F145C", Offset = "0x44F145C", VA = "0x44F145C")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x6007754")]
      [Address(RVA = "0x44F1634", Offset = "0x44F1634", VA = "0x44F1634")]
      public void SetCurrencyName(string name)
      {
      }

      [Token(Token = "0x6007755")]
      [Address(RVA = "0x44F158C", Offset = "0x44F158C", VA = "0x44F158C")]
      public void SetPrice(int price)
      {
      }

      [Token(Token = "0x6007756")]
      [Address(RVA = "0x44F1744", Offset = "0x44F1744", VA = "0x44F1744")]
      public PaymentInfo()
      {
      }
    }

    [Token(Token = "0x2001512")]
    [Serializable]
    private class AdvertisementInfo
    {
      [Token(Token = "0x40060F2")]
      [FieldOffset(Offset = "0x10")]
      public GameObject root;
      [Token(Token = "0x40060F3")]
      [FieldOffset(Offset = "0x18")]
      public GameObject badgeIcon;
      [Token(Token = "0x40060F4")]
      [FieldOffset(Offset = "0x20")]
      public TextAccessor remainCount;

      [Token(Token = "0x6007757")]
      [Address(RVA = "0x44F14F4", Offset = "0x44F14F4", VA = "0x44F14F4")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x6007758")]
      [Address(RVA = "0x44F123C", Offset = "0x44F123C", VA = "0x44F123C")]
      public void SetRemainCount(int remainCount, bool isResult)
      {
      }

      [Token(Token = "0x6007759")]
      [Address(RVA = "0x44F193C", Offset = "0x44F193C", VA = "0x44F193C")]
      public AdvertisementInfo()
      {
      }
    }
  }
}
