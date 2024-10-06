// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF5")]
  public class APIWeaponFavorite
  {
    [Token(Token = "0x40084E9")]
    public const string DefaultAPIPath = "api/v1/weapon/favorite";
    [Token(Token = "0x40084ED")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084EE")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponFavoriteResponse> onSuccess;
    [Token(Token = "0x40084EF")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002629")]
    public APIWeaponFavoriteRequest Request
    {
      [Token(Token = "0x600B7E3"), Address(RVA = "0x2132470", Offset = "0x2132470", VA = "0x2132470")] private get
      {
        return (APIWeaponFavoriteRequest) null;
      }
      [Token(Token = "0x600B7E4"), Address(RVA = "0x2132478", Offset = "0x2132478", VA = "0x2132478")] set
      {
      }
    }

    [Token(Token = "0x1700262A")]
    public APIWeaponFavoriteResponse Response
    {
      [Token(Token = "0x600B7E5"), Address(RVA = "0x2132480", Offset = "0x2132480", VA = "0x2132480")] get
      {
        return (APIWeaponFavoriteResponse) null;
      }
      [Token(Token = "0x600B7E6"), Address(RVA = "0x2132488", Offset = "0x2132488", VA = "0x2132488")] private set
      {
      }
    }

    [Token(Token = "0x1700262B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B7E7"), Address(RVA = "0x2132490", Offset = "0x2132490", VA = "0x2132490")] get
      {
        return new int();
      }
      [Token(Token = "0x600B7E8"), Address(RVA = "0x2132498", Offset = "0x2132498", VA = "0x2132498")] private set
      {
      }
    }

    [Token(Token = "0x1700262C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B7E9"), Address(RVA = "0x21324A0", Offset = "0x21324A0", VA = "0x21324A0")] set
      {
      }
      [Token(Token = "0x600B7EA"), Address(RVA = "0x21324BC", Offset = "0x21324BC", VA = "0x21324BC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B7EB")]
    [Address(RVA = "0x21324D8", Offset = "0x21324D8", VA = "0x21324D8")]
    public APIWeaponFavorite(string apiPath = "api/v1/weapon/favorite")
    {
    }

    [Token(Token = "0x600B7EC")]
    [Address(RVA = "0x2132570", Offset = "0x2132570", VA = "0x2132570")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B7ED")]
    [Address(RVA = "0x2132600", Offset = "0x2132600", VA = "0x2132600")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B7EE")]
    [Address(RVA = "0x213260C", Offset = "0x213260C", VA = "0x213260C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B7EF")]
    [Address(RVA = "0x21326E0", Offset = "0x21326E0", VA = "0x21326E0")]
    private void OnSuccess(string json)
    {
    }
  }
}
