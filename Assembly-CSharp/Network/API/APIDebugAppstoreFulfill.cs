// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugAppstoreFulfill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BED")]
  public class APIDebugAppstoreFulfill
  {
    [Token(Token = "0x4007795")]
    public const string DefaultAPIPath = "api/v1/debug/appstore/fulfill";
    [Token(Token = "0x4007799")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400779A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDebugAppstoreFulfillResponse> onSuccess;
    [Token(Token = "0x400779B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E8D")]
    public APIDebugAppstoreFulfillRequest Request
    {
      [Token(Token = "0x600A427"), Address(RVA = "0x46D144C", Offset = "0x46D144C", VA = "0x46D144C")] private get
      {
        return (APIDebugAppstoreFulfillRequest) null;
      }
      [Token(Token = "0x600A428"), Address(RVA = "0x46D1454", Offset = "0x46D1454", VA = "0x46D1454")] set
      {
      }
    }

    [Token(Token = "0x17001E8E")]
    public APIDebugAppstoreFulfillResponse Response
    {
      [Token(Token = "0x600A429"), Address(RVA = "0x46D145C", Offset = "0x46D145C", VA = "0x46D145C")] get
      {
        return (APIDebugAppstoreFulfillResponse) null;
      }
      [Token(Token = "0x600A42A"), Address(RVA = "0x46D1464", Offset = "0x46D1464", VA = "0x46D1464")] private set
      {
      }
    }

    [Token(Token = "0x17001E8F")]
    public int ResponseCode
    {
      [Token(Token = "0x600A42B"), Address(RVA = "0x46D146C", Offset = "0x46D146C", VA = "0x46D146C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A42C"), Address(RVA = "0x46D1474", Offset = "0x46D1474", VA = "0x46D1474")] private set
      {
      }
    }

    [Token(Token = "0x17001E90")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A42D"), Address(RVA = "0x46D147C", Offset = "0x46D147C", VA = "0x46D147C")] set
      {
      }
      [Token(Token = "0x600A42E"), Address(RVA = "0x46D1498", Offset = "0x46D1498", VA = "0x46D1498")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A42F")]
    [Address(RVA = "0x46D14B4", Offset = "0x46D14B4", VA = "0x46D14B4")]
    public APIDebugAppstoreFulfill(string apiPath = "api/v1/debug/appstore/fulfill")
    {
    }

    [Token(Token = "0x600A430")]
    [Address(RVA = "0x46D154C", Offset = "0x46D154C", VA = "0x46D154C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A431")]
    [Address(RVA = "0x46D15DC", Offset = "0x46D15DC", VA = "0x46D15DC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A432")]
    [Address(RVA = "0x46D15E8", Offset = "0x46D15E8", VA = "0x46D15E8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A433")]
    [Address(RVA = "0x46D16BC", Offset = "0x46D16BC", VA = "0x46D16BC")]
    private void OnSuccess(string json)
    {
    }
  }
}
