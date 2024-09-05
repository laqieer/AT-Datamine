// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftWishSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD5")]
  public class APIGuildGiftWishSet
  {
    [Token(Token = "0x4007B37")]
    public const string DefaultAPIPath = "api/v1/guild/gift/wish_set";
    [Token(Token = "0x4007B3B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B3C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildGiftWishSetResponse> onSuccess;
    [Token(Token = "0x4007B3D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020A6")]
    public APIGuildGiftWishSetRequest Request
    {
      [Token(Token = "0x600A9E0"), Address(RVA = "0x1916D70", Offset = "0x1916D70", VA = "0x1916D70")] private get
      {
        return (APIGuildGiftWishSetRequest) null;
      }
      [Token(Token = "0x600A9E1"), Address(RVA = "0x1916D78", Offset = "0x1916D78", VA = "0x1916D78")] set
      {
      }
    }

    [Token(Token = "0x170020A7")]
    public APIGuildGiftWishSetResponse Response
    {
      [Token(Token = "0x600A9E2"), Address(RVA = "0x1916D80", Offset = "0x1916D80", VA = "0x1916D80")] get
      {
        return (APIGuildGiftWishSetResponse) null;
      }
      [Token(Token = "0x600A9E3"), Address(RVA = "0x1916D88", Offset = "0x1916D88", VA = "0x1916D88")] private set
      {
      }
    }

    [Token(Token = "0x170020A8")]
    public int ResponseCode
    {
      [Token(Token = "0x600A9E4"), Address(RVA = "0x1916D90", Offset = "0x1916D90", VA = "0x1916D90")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9E5"), Address(RVA = "0x1916D98", Offset = "0x1916D98", VA = "0x1916D98")] private set
      {
      }
    }

    [Token(Token = "0x170020A9")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A9E6"), Address(RVA = "0x1916DA0", Offset = "0x1916DA0", VA = "0x1916DA0")] set
      {
      }
      [Token(Token = "0x600A9E7"), Address(RVA = "0x1916DBC", Offset = "0x1916DBC", VA = "0x1916DBC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A9E8")]
    [Address(RVA = "0x1916DD8", Offset = "0x1916DD8", VA = "0x1916DD8")]
    public APIGuildGiftWishSet(string apiPath = "api/v1/guild/gift/wish_set")
    {
    }

    [Token(Token = "0x600A9E9")]
    [Address(RVA = "0x1916E70", Offset = "0x1916E70", VA = "0x1916E70")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A9EA")]
    [Address(RVA = "0x1916F00", Offset = "0x1916F00", VA = "0x1916F00")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A9EB")]
    [Address(RVA = "0x1916F0C", Offset = "0x1916F0C", VA = "0x1916F0C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A9EC")]
    [Address(RVA = "0x1916FE0", Offset = "0x1916FE0", VA = "0x1916FE0")]
    private void OnSuccess(string json)
    {
    }
  }
}
