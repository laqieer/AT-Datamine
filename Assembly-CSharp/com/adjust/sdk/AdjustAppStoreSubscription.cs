// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAppStoreSubscription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FEA")]
  public class AdjustAppStoreSubscription
  {
    [Token(Token = "0x4011800")]
    [FieldOffset(Offset = "0x10")]
    internal string price;
    [Token(Token = "0x4011801")]
    [FieldOffset(Offset = "0x18")]
    internal string currency;
    [Token(Token = "0x4011802")]
    [FieldOffset(Offset = "0x20")]
    internal string transactionId;
    [Token(Token = "0x4011803")]
    [FieldOffset(Offset = "0x28")]
    internal string receipt;
    [Token(Token = "0x4011804")]
    [FieldOffset(Offset = "0x30")]
    internal string billingStore;
    [Token(Token = "0x4011805")]
    [FieldOffset(Offset = "0x38")]
    internal string transactionDate;
    [Token(Token = "0x4011806")]
    [FieldOffset(Offset = "0x40")]
    internal string salesRegion;
    [Token(Token = "0x4011807")]
    [FieldOffset(Offset = "0x48")]
    internal List<string> partnerList;
    [Token(Token = "0x4011808")]
    [FieldOffset(Offset = "0x50")]
    internal List<string> callbackList;

    [Token(Token = "0x6019BA5")]
    [Address(RVA = "0x379AFB4", Offset = "0x379AFB4", VA = "0x379AFB4")]
    public AdjustAppStoreSubscription(
      string price,
      string currency,
      string transactionId,
      string receipt)
    {
    }

    [Token(Token = "0x6019BA6")]
    [Address(RVA = "0x379AFF4", Offset = "0x379AFF4", VA = "0x379AFF4")]
    public void setTransactionDate(string transactionDate)
    {
    }

    [Token(Token = "0x6019BA7")]
    [Address(RVA = "0x379AFFC", Offset = "0x379AFFC", VA = "0x379AFFC")]
    public void setSalesRegion(string salesRegion)
    {
    }

    [Token(Token = "0x6019BA8")]
    [Address(RVA = "0x379B004", Offset = "0x379B004", VA = "0x379B004")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019BA9")]
    [Address(RVA = "0x379B160", Offset = "0x379B160", VA = "0x379B160")]
    public void addPartnerParameter(string key, string value)
    {
    }
  }
}
