// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustPlayStoreSubscription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF5")]
  public class AdjustPlayStoreSubscription
  {
    [Token(Token = "0x4011878")]
    [FieldOffset(Offset = "0x10")]
    internal string price;
    [Token(Token = "0x4011879")]
    [FieldOffset(Offset = "0x18")]
    internal string currency;
    [Token(Token = "0x401187A")]
    [FieldOffset(Offset = "0x20")]
    internal string sku;
    [Token(Token = "0x401187B")]
    [FieldOffset(Offset = "0x28")]
    internal string orderId;
    [Token(Token = "0x401187C")]
    [FieldOffset(Offset = "0x30")]
    internal string signature;
    [Token(Token = "0x401187D")]
    [FieldOffset(Offset = "0x38")]
    internal string purchaseToken;
    [Token(Token = "0x401187E")]
    [FieldOffset(Offset = "0x40")]
    internal string billingStore;
    [Token(Token = "0x401187F")]
    [FieldOffset(Offset = "0x48")]
    internal string purchaseTime;
    [Token(Token = "0x4011880")]
    [FieldOffset(Offset = "0x50")]
    internal List<string> partnerList;
    [Token(Token = "0x4011881")]
    [FieldOffset(Offset = "0x58")]
    internal List<string> callbackList;

    [Token(Token = "0x6019C26")]
    [Address(RVA = "0x3B3A50C", Offset = "0x3B3A50C", VA = "0x3B3A50C")]
    public AdjustPlayStoreSubscription(
      string price,
      string currency,
      string sku,
      string orderId,
      string signature,
      string purchaseToken)
    {
    }

    [Token(Token = "0x6019C27")]
    [Address(RVA = "0x3B3A560", Offset = "0x3B3A560", VA = "0x3B3A560")]
    public void setPurchaseTime(string purchaseTime)
    {
    }

    [Token(Token = "0x6019C28")]
    [Address(RVA = "0x3B3A568", Offset = "0x3B3A568", VA = "0x3B3A568")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019C29")]
    [Address(RVA = "0x3B3A6C4", Offset = "0x3B3A6C4", VA = "0x3B3A6C4")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
