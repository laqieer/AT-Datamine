// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCustom_skillFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB9")]
  public class APIUnitCustom_skillFavorite
  {
    [Token(Token = "0x40083FB")]
    public const string DefaultAPIPath = "api/v1/unit/custom_skill/favorite";
    [Token(Token = "0x40083FF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008400")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitCustom_skillFavoriteResponse> onSuccess;
    [Token(Token = "0x4008401")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025A4")]
    public APIUnitCustom_skillFavoriteRequest Request
    {
      [Token(Token = "0x600B66E"), Address(RVA = "0x22EC860", Offset = "0x22EC860", VA = "0x22EC860")] private get
      {
        return (APIUnitCustom_skillFavoriteRequest) null;
      }
      [Token(Token = "0x600B66F"), Address(RVA = "0x22EC868", Offset = "0x22EC868", VA = "0x22EC868")] set
      {
      }
    }

    [Token(Token = "0x170025A5")]
    public APIUnitCustom_skillFavoriteResponse Response
    {
      [Token(Token = "0x600B670"), Address(RVA = "0x22EC870", Offset = "0x22EC870", VA = "0x22EC870")] get
      {
        return (APIUnitCustom_skillFavoriteResponse) null;
      }
      [Token(Token = "0x600B671"), Address(RVA = "0x22EC878", Offset = "0x22EC878", VA = "0x22EC878")] private set
      {
      }
    }

    [Token(Token = "0x170025A6")]
    public int ResponseCode
    {
      [Token(Token = "0x600B672"), Address(RVA = "0x22EC880", Offset = "0x22EC880", VA = "0x22EC880")] get
      {
        return new int();
      }
      [Token(Token = "0x600B673"), Address(RVA = "0x22EC888", Offset = "0x22EC888", VA = "0x22EC888")] private set
      {
      }
    }

    [Token(Token = "0x170025A7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B674"), Address(RVA = "0x22EC890", Offset = "0x22EC890", VA = "0x22EC890")] set
      {
      }
      [Token(Token = "0x600B675"), Address(RVA = "0x22EC8AC", Offset = "0x22EC8AC", VA = "0x22EC8AC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B676")]
    [Address(RVA = "0x22EC8C8", Offset = "0x22EC8C8", VA = "0x22EC8C8")]
    public APIUnitCustom_skillFavorite(string apiPath = "api/v1/unit/custom_skill/favorite")
    {
    }

    [Token(Token = "0x600B677")]
    [Address(RVA = "0x22EC960", Offset = "0x22EC960", VA = "0x22EC960")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B678")]
    [Address(RVA = "0x22EC9F0", Offset = "0x22EC9F0", VA = "0x22EC9F0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B679")]
    [Address(RVA = "0x22EC9FC", Offset = "0x22EC9FC", VA = "0x22EC9FC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B67A")]
    [Address(RVA = "0x22ECAD0", Offset = "0x22ECAD0", VA = "0x22ECAD0")]
    private void OnSuccess(string json)
    {
    }
  }
}
