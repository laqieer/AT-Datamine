// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterComebackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EAB")]
  [Serializable]
  public class APIUnitCharacterComebackRequest
  {
    [Token(Token = "0x40083CA")]
    [FieldOffset(Offset = "0x10")]
    public int character_id;
    [Token(Token = "0x40083CB")]
    [FieldOffset(Offset = "0x14")]
    public int coin_amount;

    [Token(Token = "0x600B620")]
    [Address(RVA = "0x22EB7DC", Offset = "0x22EB7DC", VA = "0x22EB7DC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B621")]
    [Address(RVA = "0x22EB824", Offset = "0x22EB824", VA = "0x22EB824")]
    public APIUnitCharacterComebackRequest()
    {
    }
  }
}
