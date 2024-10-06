// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterLp_recoveryRequest
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
  [Token(Token = "0x2001EB3")]
  [Serializable]
  public class APIUnitCharacterLp_recoveryRequest
  {
    [Token(Token = "0x40083E6")]
    [FieldOffset(Offset = "0x10")]
    public int character_id;
    [Token(Token = "0x40083E7")]
    [FieldOffset(Offset = "0x18")]
    public List<RequestPaymentType> payments;

    [Token(Token = "0x600B64F")]
    [Address(RVA = "0x22EC28C", Offset = "0x22EC28C", VA = "0x22EC28C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B650")]
    [Address(RVA = "0x22EC2D4", Offset = "0x22EC2D4", VA = "0x22EC2D4")]
    public APIUnitCharacterLp_recoveryRequest()
    {
    }
  }
}
