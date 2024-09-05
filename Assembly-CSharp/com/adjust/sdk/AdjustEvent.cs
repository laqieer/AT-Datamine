// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FEF")]
  public class AdjustEvent
  {
    [Token(Token = "0x4011855")]
    [FieldOffset(Offset = "0x10")]
    internal string currency;
    [Token(Token = "0x4011856")]
    [FieldOffset(Offset = "0x18")]
    internal string eventToken;
    [Token(Token = "0x4011857")]
    [FieldOffset(Offset = "0x20")]
    internal string callbackId;
    [Token(Token = "0x4011858")]
    [FieldOffset(Offset = "0x28")]
    internal string transactionId;
    [Token(Token = "0x4011859")]
    [FieldOffset(Offset = "0x30")]
    internal string productId;
    [Token(Token = "0x401185A")]
    [FieldOffset(Offset = "0x38")]
    internal double? revenue;
    [Token(Token = "0x401185B")]
    [FieldOffset(Offset = "0x48")]
    internal List<string> partnerList;
    [Token(Token = "0x401185C")]
    [FieldOffset(Offset = "0x50")]
    internal List<string> callbackList;
    [Token(Token = "0x401185D")]
    [FieldOffset(Offset = "0x58")]
    internal string receipt;
    [Token(Token = "0x401185E")]
    [FieldOffset(Offset = "0x60")]
    internal string receiptBase64;
    [Token(Token = "0x401185F")]
    [FieldOffset(Offset = "0x68")]
    internal bool isReceiptSet;
    [Token(Token = "0x4011860")]
    [FieldOffset(Offset = "0x70")]
    internal string purchaseToken;

    [Token(Token = "0x6019BF4")]
    [Address(RVA = "0x379BCB0", Offset = "0x379BCB0", VA = "0x379BCB0")]
    public AdjustEvent(string eventToken)
    {
    }

    [Token(Token = "0x6019BF5")]
    [Address(RVA = "0x379BCDC", Offset = "0x379BCDC", VA = "0x379BCDC")]
    public void setRevenue(double amount, string currency)
    {
    }

    [Token(Token = "0x6019BF6")]
    [Address(RVA = "0x379BD5C", Offset = "0x379BD5C", VA = "0x379BD5C")]
    public void addCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019BF7")]
    [Address(RVA = "0x379BEB8", Offset = "0x379BEB8", VA = "0x379BEB8")]
    public void addPartnerParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019BF8")]
    [Address(RVA = "0x379C014", Offset = "0x379C014", VA = "0x379C014")]
    public void setCallbackId(string callbackId)
    {
    }

    [Token(Token = "0x6019BF9")]
    [Address(RVA = "0x379C01C", Offset = "0x379C01C", VA = "0x379C01C")]
    public void setTransactionId(string transactionId)
    {
    }

    [Token(Token = "0x6019BFA")]
    [Address(RVA = "0x379C024", Offset = "0x379C024", VA = "0x379C024")]
    public void setProductId(string productId)
    {
    }

    [Token(Token = "0x6019BFB")]
    [Address(RVA = "0x379C02C", Offset = "0x379C02C", VA = "0x379C02C")]
    [Obsolete("This is an obsolete method. Please use separate setter methods for purchase verification parameters.")]
    public void setReceipt(string receipt, string transactionId)
    {
    }

    [Token(Token = "0x6019BFC")]
    [Address(RVA = "0x379C030", Offset = "0x379C030", VA = "0x379C030")]
    public void setReceipt(string receipt)
    {
    }

    [Token(Token = "0x6019BFD")]
    [Address(RVA = "0x379C038", Offset = "0x379C038", VA = "0x379C038")]
    public void setReceiptBase64(string receiptBase64)
    {
    }

    [Token(Token = "0x6019BFE")]
    [Address(RVA = "0x379C040", Offset = "0x379C040", VA = "0x379C040")]
    public void setPurchaseToken(string purchaseToken)
    {
    }
  }
}
