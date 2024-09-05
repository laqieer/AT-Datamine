// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeLimitRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC3")]
  [Serializable]
  public class APIChargeLimitRequest
  {
    [Token(Token = "0x40076FD")]
    [FieldOffset(Offset = "0x10")]
    public string currency;

    [Token(Token = "0x600A330")]
    [Address(RVA = "0x46CDE3C", Offset = "0x46CDE3C", VA = "0x46CDE3C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A331")]
    [Address(RVA = "0x46CDE84", Offset = "0x46CDE84", VA = "0x46CDE84")]
    public APIChargeLimitRequest()
    {
    }
  }
}
