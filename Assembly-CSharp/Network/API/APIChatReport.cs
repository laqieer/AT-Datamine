// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BD9")]
  public class APIChatReport
  {
    [Token(Token = "0x4007745")]
    public const string DefaultAPIPath = "api/v1/chat/report";
    [Token(Token = "0x4007749")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400774A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChatReportResponse> onSuccess;
    [Token(Token = "0x400774B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E5C")]
    public APIChatReportRequest Request
    {
      [Token(Token = "0x600A3A6"), Address(RVA = "0x46CF938", Offset = "0x46CF938", VA = "0x46CF938")] private get
      {
        return (APIChatReportRequest) null;
      }
      [Token(Token = "0x600A3A7"), Address(RVA = "0x46CF940", Offset = "0x46CF940", VA = "0x46CF940")] set
      {
      }
    }

    [Token(Token = "0x17001E5D")]
    public APIChatReportResponse Response
    {
      [Token(Token = "0x600A3A8"), Address(RVA = "0x46CF948", Offset = "0x46CF948", VA = "0x46CF948")] get
      {
        return (APIChatReportResponse) null;
      }
      [Token(Token = "0x600A3A9"), Address(RVA = "0x46CF950", Offset = "0x46CF950", VA = "0x46CF950")] private set
      {
      }
    }

    [Token(Token = "0x17001E5E")]
    public int ResponseCode
    {
      [Token(Token = "0x600A3AA"), Address(RVA = "0x46CF958", Offset = "0x46CF958", VA = "0x46CF958")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3AB"), Address(RVA = "0x46CF960", Offset = "0x46CF960", VA = "0x46CF960")] private set
      {
      }
    }

    [Token(Token = "0x17001E5F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A3AC"), Address(RVA = "0x46CF968", Offset = "0x46CF968", VA = "0x46CF968")] set
      {
      }
      [Token(Token = "0x600A3AD"), Address(RVA = "0x46CF984", Offset = "0x46CF984", VA = "0x46CF984")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A3AE")]
    [Address(RVA = "0x46CF9A0", Offset = "0x46CF9A0", VA = "0x46CF9A0")]
    public APIChatReport(string apiPath = "api/v1/chat/report")
    {
    }

    [Token(Token = "0x600A3AF")]
    [Address(RVA = "0x46CFA38", Offset = "0x46CFA38", VA = "0x46CFA38")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A3B0")]
    [Address(RVA = "0x46CFAC8", Offset = "0x46CFAC8", VA = "0x46CFAC8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A3B1")]
    [Address(RVA = "0x46CFAD4", Offset = "0x46CFAD4", VA = "0x46CFAD4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A3B2")]
    [Address(RVA = "0x46CFBA8", Offset = "0x46CFBA8", VA = "0x46CFBA8")]
    private void OnSuccess(string json)
    {
    }
  }
}
