// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugGoogleplayFulfill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BF1")]
  public class APIDebugGoogleplayFulfill
  {
    [Token(Token = "0x40077A6")]
    public const string DefaultAPIPath = "api/v1/debug/googleplay/fulfill";
    [Token(Token = "0x40077AA")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077AB")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDebugGoogleplayFulfillResponse> onSuccess;
    [Token(Token = "0x40077AC")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E98")]
    public APIDebugGoogleplayFulfillRequest Request
    {
      [Token(Token = "0x600A442"), Address(RVA = "0x46D19C0", Offset = "0x46D19C0", VA = "0x46D19C0")] private get
      {
        return (APIDebugGoogleplayFulfillRequest) null;
      }
      [Token(Token = "0x600A443"), Address(RVA = "0x46D19C8", Offset = "0x46D19C8", VA = "0x46D19C8")] set
      {
      }
    }

    [Token(Token = "0x17001E99")]
    public APIDebugGoogleplayFulfillResponse Response
    {
      [Token(Token = "0x600A444"), Address(RVA = "0x46D19D0", Offset = "0x46D19D0", VA = "0x46D19D0")] get
      {
        return (APIDebugGoogleplayFulfillResponse) null;
      }
      [Token(Token = "0x600A445"), Address(RVA = "0x46D19D8", Offset = "0x46D19D8", VA = "0x46D19D8")] private set
      {
      }
    }

    [Token(Token = "0x17001E9A")]
    public int ResponseCode
    {
      [Token(Token = "0x600A446"), Address(RVA = "0x46D19E0", Offset = "0x46D19E0", VA = "0x46D19E0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A447"), Address(RVA = "0x46D19E8", Offset = "0x46D19E8", VA = "0x46D19E8")] private set
      {
      }
    }

    [Token(Token = "0x17001E9B")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A448"), Address(RVA = "0x46D19F0", Offset = "0x46D19F0", VA = "0x46D19F0")] set
      {
      }
      [Token(Token = "0x600A449"), Address(RVA = "0x46D1A0C", Offset = "0x46D1A0C", VA = "0x46D1A0C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A44A")]
    [Address(RVA = "0x46D1A28", Offset = "0x46D1A28", VA = "0x46D1A28")]
    public APIDebugGoogleplayFulfill(string apiPath = "api/v1/debug/googleplay/fulfill")
    {
    }

    [Token(Token = "0x600A44B")]
    [Address(RVA = "0x46D1AC0", Offset = "0x46D1AC0", VA = "0x46D1AC0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A44C")]
    [Address(RVA = "0x46D1B50", Offset = "0x46D1B50", VA = "0x46D1B50")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A44D")]
    [Address(RVA = "0x46D1B5C", Offset = "0x46D1B5C", VA = "0x46D1B5C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A44E")]
    [Address(RVA = "0x46D1C30", Offset = "0x46D1C30", VA = "0x46D1C30")]
    private void OnSuccess(string json)
    {
    }
  }
}
