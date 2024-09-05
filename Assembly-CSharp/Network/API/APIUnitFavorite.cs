// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitFavorite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EC1")]
  public class APIUnitFavorite
  {
    [Token(Token = "0x4008416")]
    public const string DefaultAPIPath = "api/v1/unit/favorite";
    [Token(Token = "0x400841A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400841B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitFavoriteResponse> onSuccess;
    [Token(Token = "0x400841C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025B2")]
    public APIUnitFavoriteRequest Request
    {
      [Token(Token = "0x600B69C"), Address(RVA = "0x22ED308", Offset = "0x22ED308", VA = "0x22ED308")] private get
      {
        return (APIUnitFavoriteRequest) null;
      }
      [Token(Token = "0x600B69D"), Address(RVA = "0x22ED310", Offset = "0x22ED310", VA = "0x22ED310")] set
      {
      }
    }

    [Token(Token = "0x170025B3")]
    public APIUnitFavoriteResponse Response
    {
      [Token(Token = "0x600B69E"), Address(RVA = "0x22ED318", Offset = "0x22ED318", VA = "0x22ED318")] get
      {
        return (APIUnitFavoriteResponse) null;
      }
      [Token(Token = "0x600B69F"), Address(RVA = "0x22ED320", Offset = "0x22ED320", VA = "0x22ED320")] private set
      {
      }
    }

    [Token(Token = "0x170025B4")]
    public int ResponseCode
    {
      [Token(Token = "0x600B6A0"), Address(RVA = "0x22ED328", Offset = "0x22ED328", VA = "0x22ED328")] get
      {
        return new int();
      }
      [Token(Token = "0x600B6A1"), Address(RVA = "0x22ED330", Offset = "0x22ED330", VA = "0x22ED330")] private set
      {
      }
    }

    [Token(Token = "0x170025B5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B6A2"), Address(RVA = "0x22ED338", Offset = "0x22ED338", VA = "0x22ED338")] set
      {
      }
      [Token(Token = "0x600B6A3"), Address(RVA = "0x22ED354", Offset = "0x22ED354", VA = "0x22ED354")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B6A4")]
    [Address(RVA = "0x22ED370", Offset = "0x22ED370", VA = "0x22ED370")]
    public APIUnitFavorite(string apiPath = "api/v1/unit/favorite")
    {
    }

    [Token(Token = "0x600B6A5")]
    [Address(RVA = "0x22ED408", Offset = "0x22ED408", VA = "0x22ED408")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B6A6")]
    [Address(RVA = "0x22ED498", Offset = "0x22ED498", VA = "0x22ED498")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B6A7")]
    [Address(RVA = "0x22ED4A4", Offset = "0x22ED4A4", VA = "0x22ED4A4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B6A8")]
    [Address(RVA = "0x22ED578", Offset = "0x22ED578", VA = "0x22ED578")]
    private void OnSuccess(string json)
    {
    }
  }
}
