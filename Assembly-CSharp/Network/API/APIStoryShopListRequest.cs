// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E67")]
  [Serializable]
  public class APIStoryShopListRequest
  {
    [Token(Token = "0x4008291")]
    [FieldOffset(Offset = "0x10")]
    public int shop_type_id;

    [Token(Token = "0x600B459")]
    [Address(RVA = "0x22E5B48", Offset = "0x22E5B48", VA = "0x22E5B48")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B45A")]
    [Address(RVA = "0x22E5B90", Offset = "0x22E5B90", VA = "0x22E5B90")]
    public APIStoryShopListRequest()
    {
    }
  }
}
