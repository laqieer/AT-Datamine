// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_trustFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EED")]
  public class APIUnit_trustFavorite
  {
    [Token(Token = "0x40084C8")]
    public const string DefaultAPIPath = "api/v1/unit_trust/favorite";
    [Token(Token = "0x40084CC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084CD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnit_trustFavoriteResponse> onSuccess;
    [Token(Token = "0x40084CE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002616")]
    public APIUnit_trustFavoriteRequest Request
    {
      [Token(Token = "0x600B7B0"), Address(RVA = "0x21319A0", Offset = "0x21319A0", VA = "0x21319A0")] private get
      {
        return (APIUnit_trustFavoriteRequest) null;
      }
      [Token(Token = "0x600B7B1"), Address(RVA = "0x21319A8", Offset = "0x21319A8", VA = "0x21319A8")] set
      {
      }
    }

    [Token(Token = "0x17002617")]
    public APIUnit_trustFavoriteResponse Response
    {
      [Token(Token = "0x600B7B2"), Address(RVA = "0x21319B0", Offset = "0x21319B0", VA = "0x21319B0")] get
      {
        return (APIUnit_trustFavoriteResponse) null;
      }
      [Token(Token = "0x600B7B3"), Address(RVA = "0x21319B8", Offset = "0x21319B8", VA = "0x21319B8")] private set
      {
      }
    }

    [Token(Token = "0x17002618")]
    public int ResponseCode
    {
      [Token(Token = "0x600B7B4"), Address(RVA = "0x21319C0", Offset = "0x21319C0", VA = "0x21319C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B7B5"), Address(RVA = "0x21319C8", Offset = "0x21319C8", VA = "0x21319C8")] private set
      {
      }
    }

    [Token(Token = "0x17002619")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B7B6"), Address(RVA = "0x21319D0", Offset = "0x21319D0", VA = "0x21319D0")] set
      {
      }
      [Token(Token = "0x600B7B7"), Address(RVA = "0x21319EC", Offset = "0x21319EC", VA = "0x21319EC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B7B8")]
    [Address(RVA = "0x2131A08", Offset = "0x2131A08", VA = "0x2131A08")]
    public APIUnit_trustFavorite(string apiPath = "api/v1/unit_trust/favorite")
    {
    }

    [Token(Token = "0x600B7B9")]
    [Address(RVA = "0x2131AA0", Offset = "0x2131AA0", VA = "0x2131AA0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B7BA")]
    [Address(RVA = "0x2131B30", Offset = "0x2131B30", VA = "0x2131B30")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B7BB")]
    [Address(RVA = "0x2131B3C", Offset = "0x2131B3C", VA = "0x2131B3C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B7BC")]
    [Address(RVA = "0x2131C10", Offset = "0x2131C10", VA = "0x2131C10")]
    private void OnSuccess(string json)
    {
    }
  }
}
