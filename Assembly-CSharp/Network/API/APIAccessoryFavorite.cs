// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B39")]
  public class APIAccessoryFavorite
  {
    [Token(Token = "0x40074C7")]
    public const string DefaultAPIPath = "api/v1/accessory/favorite";
    [Token(Token = "0x40074CB")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40074CC")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryFavoriteResponse> onSuccess;
    [Token(Token = "0x40074CD")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D04")]
    public APIAccessoryFavoriteRequest Request
    {
      [Token(Token = "0x6009FCE"), Address(RVA = "0x46C2218", Offset = "0x46C2218", VA = "0x46C2218")] private get
      {
        return (APIAccessoryFavoriteRequest) null;
      }
      [Token(Token = "0x6009FCF"), Address(RVA = "0x46C2220", Offset = "0x46C2220", VA = "0x46C2220")] set
      {
      }
    }

    [Token(Token = "0x17001D05")]
    public APIAccessoryFavoriteResponse Response
    {
      [Token(Token = "0x6009FD0"), Address(RVA = "0x46C2228", Offset = "0x46C2228", VA = "0x46C2228")] get
      {
        return (APIAccessoryFavoriteResponse) null;
      }
      [Token(Token = "0x6009FD1"), Address(RVA = "0x46C2230", Offset = "0x46C2230", VA = "0x46C2230")] private set
      {
      }
    }

    [Token(Token = "0x17001D06")]
    public int ResponseCode
    {
      [Token(Token = "0x6009FD2"), Address(RVA = "0x46C2238", Offset = "0x46C2238", VA = "0x46C2238")] get
      {
        return new int();
      }
      [Token(Token = "0x6009FD3"), Address(RVA = "0x46C2240", Offset = "0x46C2240", VA = "0x46C2240")] private set
      {
      }
    }

    [Token(Token = "0x17001D07")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x6009FD4"), Address(RVA = "0x46C2248", Offset = "0x46C2248", VA = "0x46C2248")] set
      {
      }
      [Token(Token = "0x6009FD5"), Address(RVA = "0x46C2264", Offset = "0x46C2264", VA = "0x46C2264")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x6009FD6")]
    [Address(RVA = "0x46C2280", Offset = "0x46C2280", VA = "0x46C2280")]
    public APIAccessoryFavorite(string apiPath = "api/v1/accessory/favorite")
    {
    }

    [Token(Token = "0x6009FD7")]
    [Address(RVA = "0x46C2318", Offset = "0x46C2318", VA = "0x46C2318")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009FD8")]
    [Address(RVA = "0x46C23A8", Offset = "0x46C23A8", VA = "0x46C23A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009FD9")]
    [Address(RVA = "0x46C23B4", Offset = "0x46C23B4", VA = "0x46C23B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009FDA")]
    [Address(RVA = "0x46C2488", Offset = "0x46C2488", VA = "0x46C2488")]
    private void OnSuccess(string json)
    {
    }
  }
}
