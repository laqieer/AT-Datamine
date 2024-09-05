// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryItemRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D83")]
  [Serializable]
  public class APIPlayerApRecoveryItemRequest
  {
    [Token(Token = "0x4007E0A")]
    [FieldOffset(Offset = "0x10")]
    public int now_ap;
    [Token(Token = "0x4007E0B")]
    [FieldOffset(Offset = "0x18")]
    public List<RequestPaymentType> payments;

    [Token(Token = "0x600AE33")]
    [Address(RVA = "0x1A4C518", Offset = "0x1A4C518", VA = "0x1A4C518")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE34")]
    [Address(RVA = "0x1A4C560", Offset = "0x1A4C560", VA = "0x1A4C560")]
    public APIPlayerApRecoveryItemRequest()
    {
    }
  }
}
