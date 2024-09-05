// Decompiled with JetBrains decompiler
// Type: Network.API.APIConfirmExpiration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BE5")]
  public class APIConfirmExpiration
  {
    [Token(Token = "0x4007771")]
    public const string DefaultAPIPath = "api/v1/present/confirm_expiration";
    [Token(Token = "0x4007775")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007776")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIConfirmExpirationResponse> onSuccess;
    [Token(Token = "0x4007777")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E76")]
    public APIConfirmExpirationRequest Request
    {
      [Token(Token = "0x600A3F0"), Address(RVA = "0x46D095C", Offset = "0x46D095C", VA = "0x46D095C")] private get
      {
        return (APIConfirmExpirationRequest) null;
      }
      [Token(Token = "0x600A3F1"), Address(RVA = "0x46D0964", Offset = "0x46D0964", VA = "0x46D0964")] set
      {
      }
    }

    [Token(Token = "0x17001E77")]
    public APIConfirmExpirationResponse Response
    {
      [Token(Token = "0x600A3F2"), Address(RVA = "0x46D096C", Offset = "0x46D096C", VA = "0x46D096C")] get
      {
        return (APIConfirmExpirationResponse) null;
      }
      [Token(Token = "0x600A3F3"), Address(RVA = "0x46D0974", Offset = "0x46D0974", VA = "0x46D0974")] private set
      {
      }
    }

    [Token(Token = "0x17001E78")]
    public int ResponseCode
    {
      [Token(Token = "0x600A3F4"), Address(RVA = "0x46D097C", Offset = "0x46D097C", VA = "0x46D097C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3F5"), Address(RVA = "0x46D0984", Offset = "0x46D0984", VA = "0x46D0984")] private set
      {
      }
    }

    [Token(Token = "0x17001E79")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A3F6"), Address(RVA = "0x46D098C", Offset = "0x46D098C", VA = "0x46D098C")] set
      {
      }
      [Token(Token = "0x600A3F7"), Address(RVA = "0x46D09A8", Offset = "0x46D09A8", VA = "0x46D09A8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A3F8")]
    [Address(RVA = "0x46D09C4", Offset = "0x46D09C4", VA = "0x46D09C4")]
    public APIConfirmExpiration(string apiPath = "api/v1/present/confirm_expiration")
    {
    }

    [Token(Token = "0x600A3F9")]
    [Address(RVA = "0x46D0A5C", Offset = "0x46D0A5C", VA = "0x46D0A5C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A3FA")]
    [Address(RVA = "0x46D0AEC", Offset = "0x46D0AEC", VA = "0x46D0AEC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A3FB")]
    [Address(RVA = "0x46D0AF8", Offset = "0x46D0AF8", VA = "0x46D0AF8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A3FC")]
    [Address(RVA = "0x46D0BCC", Offset = "0x46D0BCC", VA = "0x46D0BCC")]
    private void OnSuccess(string json)
    {
    }
  }
}
