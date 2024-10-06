// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D9D")]
  public class APIPlayerInfo
  {
    [Token(Token = "0x4007E61")]
    public const string DefaultAPIPath = "api/v1/player/info";
    [Token(Token = "0x4007E65")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E66")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerInfoResponse> onSuccess;
    [Token(Token = "0x4007E67")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700226E")]
    public APIPlayerInfoRequest Request
    {
      [Token(Token = "0x600AEC8"), Address(RVA = "0x1A4E5A8", Offset = "0x1A4E5A8", VA = "0x1A4E5A8")] private get
      {
        return (APIPlayerInfoRequest) null;
      }
      [Token(Token = "0x600AEC9"), Address(RVA = "0x1A4E5B0", Offset = "0x1A4E5B0", VA = "0x1A4E5B0")] set
      {
      }
    }

    [Token(Token = "0x1700226F")]
    public APIPlayerInfoResponse Response
    {
      [Token(Token = "0x600AECA"), Address(RVA = "0x1A4E5B8", Offset = "0x1A4E5B8", VA = "0x1A4E5B8")] get
      {
        return (APIPlayerInfoResponse) null;
      }
      [Token(Token = "0x600AECB"), Address(RVA = "0x1A4E5C0", Offset = "0x1A4E5C0", VA = "0x1A4E5C0")] private set
      {
      }
    }

    [Token(Token = "0x17002270")]
    public int ResponseCode
    {
      [Token(Token = "0x600AECC"), Address(RVA = "0x1A4E5C8", Offset = "0x1A4E5C8", VA = "0x1A4E5C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600AECD"), Address(RVA = "0x1A4E5D0", Offset = "0x1A4E5D0", VA = "0x1A4E5D0")] private set
      {
      }
    }

    [Token(Token = "0x17002271")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AECE"), Address(RVA = "0x1A4E5D8", Offset = "0x1A4E5D8", VA = "0x1A4E5D8")] set
      {
      }
      [Token(Token = "0x600AECF"), Address(RVA = "0x1A4E5F4", Offset = "0x1A4E5F4", VA = "0x1A4E5F4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AED0")]
    [Address(RVA = "0x1A4E610", Offset = "0x1A4E610", VA = "0x1A4E610")]
    public APIPlayerInfo(string apiPath = "api/v1/player/info")
    {
    }

    [Token(Token = "0x600AED1")]
    [Address(RVA = "0x1A4E6A8", Offset = "0x1A4E6A8", VA = "0x1A4E6A8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AED2")]
    [Address(RVA = "0x1A4E738", Offset = "0x1A4E738", VA = "0x1A4E738")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AED3")]
    [Address(RVA = "0x1A4E744", Offset = "0x1A4E744", VA = "0x1A4E744")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AED4")]
    [Address(RVA = "0x1A4E818", Offset = "0x1A4E818", VA = "0x1A4E818")]
    private void OnSuccess(string json)
    {
    }
  }
}
