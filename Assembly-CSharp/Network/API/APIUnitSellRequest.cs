// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitSellRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001ED7")]
  [Serializable]
  public class APIUnitSellRequest
  {
    [Token(Token = "0x4008477")]
    [FieldOffset(Offset = "0x10")]
    public List<string> player_unit_ids;

    [Token(Token = "0x600B72E")]
    [Address(RVA = "0x212FE44", Offset = "0x212FE44", VA = "0x212FE44")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B72F")]
    [Address(RVA = "0x212FE8C", Offset = "0x212FE8C", VA = "0x212FE8C")]
    public APIUnitSellRequest()
    {
    }
  }
}
