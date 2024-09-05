// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeAmountByMonthRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BBF")]
  [Serializable]
  public class APIChargeAmountByMonthRequest
  {
    [Token(Token = "0x40076EE")]
    [FieldOffset(Offset = "0x10")]
    public string currency;

    [Token(Token = "0x600A317")]
    [Address(RVA = "0x46CD8D8", Offset = "0x46CD8D8", VA = "0x46CD8D8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A318")]
    [Address(RVA = "0x46CD920", Offset = "0x46CD920", VA = "0x46CD920")]
    public APIChargeAmountByMonthRequest()
    {
    }
  }
}
