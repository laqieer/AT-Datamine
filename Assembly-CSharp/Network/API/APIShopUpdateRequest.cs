// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopUpdateRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E17")]
  [Serializable]
  public class APIShopUpdateRequest
  {
    [Token(Token = "0x40080CA")]
    [FieldOffset(Offset = "0x10")]
    public int shop_id;

    [Token(Token = "0x600B214")]
    [Address(RVA = "0x22DECF0", Offset = "0x22DECF0", VA = "0x22DECF0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B215")]
    [Address(RVA = "0x22DED38", Offset = "0x22DED38", VA = "0x22DED38")]
    public APIShopUpdateRequest()
    {
    }
  }
}
