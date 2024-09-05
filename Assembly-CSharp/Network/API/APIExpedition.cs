// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpedition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C15")]
  public class APIExpedition
  {
    [Token(Token = "0x400782E")]
    public const string DefaultAPIPath = "api/v1/expedition";
    [Token(Token = "0x4007832")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007833")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionResponse> onSuccess;
    [Token(Token = "0x4007834")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EE0")]
    public APIExpeditionRequest Request
    {
      [Token(Token = "0x600A51A"), Address(RVA = "0x1906A10", Offset = "0x1906A10", VA = "0x1906A10")] private get
      {
        return (APIExpeditionRequest) null;
      }
      [Token(Token = "0x600A51B"), Address(RVA = "0x1906A18", Offset = "0x1906A18", VA = "0x1906A18")] set
      {
      }
    }

    [Token(Token = "0x17001EE1")]
    public APIExpeditionResponse Response
    {
      [Token(Token = "0x600A51C"), Address(RVA = "0x1906A20", Offset = "0x1906A20", VA = "0x1906A20")] get
      {
        return (APIExpeditionResponse) null;
      }
      [Token(Token = "0x600A51D"), Address(RVA = "0x1906A28", Offset = "0x1906A28", VA = "0x1906A28")] private set
      {
      }
    }

    [Token(Token = "0x17001EE2")]
    public int ResponseCode
    {
      [Token(Token = "0x600A51E"), Address(RVA = "0x1906A30", Offset = "0x1906A30", VA = "0x1906A30")] get
      {
        return new int();
      }
      [Token(Token = "0x600A51F"), Address(RVA = "0x1906A38", Offset = "0x1906A38", VA = "0x1906A38")] private set
      {
      }
    }

    [Token(Token = "0x17001EE3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A520"), Address(RVA = "0x1906A40", Offset = "0x1906A40", VA = "0x1906A40")] set
      {
      }
      [Token(Token = "0x600A521"), Address(RVA = "0x1906A5C", Offset = "0x1906A5C", VA = "0x1906A5C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A522")]
    [Address(RVA = "0x1906A78", Offset = "0x1906A78", VA = "0x1906A78")]
    public APIExpedition(string apiPath = "api/v1/expedition")
    {
    }

    [Token(Token = "0x600A523")]
    [Address(RVA = "0x1906B10", Offset = "0x1906B10", VA = "0x1906B10")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A524")]
    [Address(RVA = "0x1906BA0", Offset = "0x1906BA0", VA = "0x1906BA0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A525")]
    [Address(RVA = "0x1906BAC", Offset = "0x1906BAC", VA = "0x1906BAC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A526")]
    [Address(RVA = "0x1906C80", Offset = "0x1906C80", VA = "0x1906C80")]
    private void OnSuccess(string json)
    {
    }
  }
}
