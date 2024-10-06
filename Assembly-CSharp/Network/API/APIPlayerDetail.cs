// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D91")]
  public class APIPlayerDetail
  {
    [Token(Token = "0x4007E3B")]
    public const string DefaultAPIPath = "api/v1/player/detail";
    [Token(Token = "0x4007E3F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E40")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerDetailResponse> onSuccess;
    [Token(Token = "0x4007E41")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002259")]
    public APIPlayerDetailRequest Request
    {
      [Token(Token = "0x600AE83"), Address(RVA = "0x1A4D5AC", Offset = "0x1A4D5AC", VA = "0x1A4D5AC")] private get
      {
        return (APIPlayerDetailRequest) null;
      }
      [Token(Token = "0x600AE84"), Address(RVA = "0x1A4D5B4", Offset = "0x1A4D5B4", VA = "0x1A4D5B4")] set
      {
      }
    }

    [Token(Token = "0x1700225A")]
    public APIPlayerDetailResponse Response
    {
      [Token(Token = "0x600AE85"), Address(RVA = "0x1A4D5BC", Offset = "0x1A4D5BC", VA = "0x1A4D5BC")] get
      {
        return (APIPlayerDetailResponse) null;
      }
      [Token(Token = "0x600AE86"), Address(RVA = "0x1A4D5C4", Offset = "0x1A4D5C4", VA = "0x1A4D5C4")] private set
      {
      }
    }

    [Token(Token = "0x1700225B")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE87"), Address(RVA = "0x1A4D5CC", Offset = "0x1A4D5CC", VA = "0x1A4D5CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE88"), Address(RVA = "0x1A4D5D4", Offset = "0x1A4D5D4", VA = "0x1A4D5D4")] private set
      {
      }
    }

    [Token(Token = "0x1700225C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE89"), Address(RVA = "0x1A4D5DC", Offset = "0x1A4D5DC", VA = "0x1A4D5DC")] set
      {
      }
      [Token(Token = "0x600AE8A"), Address(RVA = "0x1A4D5F8", Offset = "0x1A4D5F8", VA = "0x1A4D5F8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE8B")]
    [Address(RVA = "0x1A4D614", Offset = "0x1A4D614", VA = "0x1A4D614")]
    public APIPlayerDetail(string apiPath = "api/v1/player/detail")
    {
    }

    [Token(Token = "0x600AE8C")]
    [Address(RVA = "0x1A4D6AC", Offset = "0x1A4D6AC", VA = "0x1A4D6AC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE8D")]
    [Address(RVA = "0x1A4D73C", Offset = "0x1A4D73C", VA = "0x1A4D73C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE8E")]
    [Address(RVA = "0x1A4D748", Offset = "0x1A4D748", VA = "0x1A4D748")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE8F")]
    [Address(RVA = "0x1A4D81C", Offset = "0x1A4D81C", VA = "0x1A4D81C")]
    private void OnSuccess(string json)
    {
    }
  }
}
