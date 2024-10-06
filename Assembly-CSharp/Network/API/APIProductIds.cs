// Decompiled with JetBrains decompiler
// Type: Network.API.APIProductIds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DCD")]
  public class APIProductIds
  {
    [Token(Token = "0x4007F4F")]
    public const string DefaultAPIPath = "api/v1/shop/product_ids";
    [Token(Token = "0x4007F53")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F54")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIProductIdsResponse> onSuccess;
    [Token(Token = "0x4007F55")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700230E")]
    public APIProductIdsRequest Request
    {
      [Token(Token = "0x600B028"), Address(RVA = "0x1A527E8", Offset = "0x1A527E8", VA = "0x1A527E8")] private get
      {
        return (APIProductIdsRequest) null;
      }
      [Token(Token = "0x600B029"), Address(RVA = "0x1A527F0", Offset = "0x1A527F0", VA = "0x1A527F0")] set
      {
      }
    }

    [Token(Token = "0x1700230F")]
    public APIProductIdsResponse Response
    {
      [Token(Token = "0x600B02A"), Address(RVA = "0x1A527F8", Offset = "0x1A527F8", VA = "0x1A527F8")] get
      {
        return (APIProductIdsResponse) null;
      }
      [Token(Token = "0x600B02B"), Address(RVA = "0x1A52800", Offset = "0x1A52800", VA = "0x1A52800")] private set
      {
      }
    }

    [Token(Token = "0x17002310")]
    public int ResponseCode
    {
      [Token(Token = "0x600B02C"), Address(RVA = "0x1A52808", Offset = "0x1A52808", VA = "0x1A52808")] get
      {
        return new int();
      }
      [Token(Token = "0x600B02D"), Address(RVA = "0x1A52810", Offset = "0x1A52810", VA = "0x1A52810")] private set
      {
      }
    }

    [Token(Token = "0x17002311")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B02E"), Address(RVA = "0x1A52818", Offset = "0x1A52818", VA = "0x1A52818")] set
      {
      }
      [Token(Token = "0x600B02F"), Address(RVA = "0x1A52834", Offset = "0x1A52834", VA = "0x1A52834")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B030")]
    [Address(RVA = "0x1A52850", Offset = "0x1A52850", VA = "0x1A52850")]
    public APIProductIds(string apiPath = "api/v1/shop/product_ids")
    {
    }

    [Token(Token = "0x600B031")]
    [Address(RVA = "0x1A528E8", Offset = "0x1A528E8", VA = "0x1A528E8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B032")]
    [Address(RVA = "0x1A52978", Offset = "0x1A52978", VA = "0x1A52978")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B033")]
    [Address(RVA = "0x1A52984", Offset = "0x1A52984", VA = "0x1A52984")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B034")]
    [Address(RVA = "0x1A52A58", Offset = "0x1A52A58", VA = "0x1A52A58")]
    private void OnSuccess(string json)
    {
    }
  }
}
