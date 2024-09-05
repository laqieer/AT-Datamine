// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Model.PaymentRequestModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace DMM.Games.Client.Sdk.Model
{
  [Token(Token = "0x2003FC8")]
  [Serializable]
  public class PaymentRequestModel : RequestModel
  {
    [Token(Token = "0x4011771")]
    [FieldOffset(Offset = "0x38")]
    public string itemId;
    [Token(Token = "0x4011772")]
    [FieldOffset(Offset = "0x40")]
    public string itemName;
    [Token(Token = "0x4011773")]
    [FieldOffset(Offset = "0x48")]
    public int unitPrice;
    [Token(Token = "0x4011774")]
    [FieldOffset(Offset = "0x4C")]
    public int quantity;
    [Token(Token = "0x4011775")]
    [FieldOffset(Offset = "0x50")]
    public string callbackurl;
    [Token(Token = "0x4011776")]
    [FieldOffset(Offset = "0x58")]
    public string finishurl;

    [Token(Token = "0x6019A6D")]
    [Address(RVA = "0x3788704", Offset = "0x3788704", VA = "0x3788704")]
    public PaymentRequestModel()
    {
    }
  }
}
