// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopPopupItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using PurchaseModule.Product;
using System.Collections.Generic;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x20028A9")]
  public class PaidCoinShopPopupItemInfo
  {
    [Token(Token = "0x400AD95")]
    [FieldOffset(Offset = "0x10")]
    public string imageBanner;
    [Token(Token = "0x400AD96")]
    [FieldOffset(Offset = "0x18")]
    public ProductInfo productInfo;
    [Token(Token = "0x400AD97")]
    [FieldOffset(Offset = "0x20")]
    public int purchaseLimit;
    [Token(Token = "0x400AD98")]
    [FieldOffset(Offset = "0x24")]
    public int purchaseCount;
    [Token(Token = "0x400AD99")]
    [FieldOffset(Offset = "0x28")]
    public int paidGetCount;
    [Token(Token = "0x400AD9A")]
    [FieldOffset(Offset = "0x2C")]
    public int freeCommonGetCount;
    [Token(Token = "0x400AD9B")]
    [FieldOffset(Offset = "0x30")]
    public int passId;
    [Token(Token = "0x400AD9C")]
    [FieldOffset(Offset = "0x38")]
    public List<Reward> articleRewards;
    [Token(Token = "0x400AD9D")]
    [FieldOffset(Offset = "0x40")]
    public string name;
    [Token(Token = "0x400AD9E")]
    [FieldOffset(Offset = "0x48")]
    public string endAt;
    [Token(Token = "0x400AD9F")]
    [FieldOffset(Offset = "0x50")]
    public PaidCoinShopPopup.ItemType itemType;

    [Token(Token = "0x17003839")]
    public bool IsJpy
    {
      [Token(Token = "0x6010013"), Address(RVA = "0x41658A0", Offset = "0x41658A0", VA = "0x41658A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6010014")]
    [Address(RVA = "0x41658F8", Offset = "0x41658F8", VA = "0x41658F8")]
    public PaidCoinShopPopupItemInfo()
    {
    }
  }
}
