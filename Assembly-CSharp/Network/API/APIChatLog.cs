// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BD1")]
  public class APIChatLog
  {
    [Token(Token = "0x4007727")]
    public const string DefaultAPIPath = "api/v1/chat/log";
    [Token(Token = "0x400772B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400772C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChatLogResponse> onSuccess;
    [Token(Token = "0x400772D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E4F")]
    public APIChatLogRequest Request
    {
      [Token(Token = "0x600A379"), Address(RVA = "0x46CEE98", Offset = "0x46CEE98", VA = "0x46CEE98")] private get
      {
        return (APIChatLogRequest) null;
      }
      [Token(Token = "0x600A37A"), Address(RVA = "0x46CEEA0", Offset = "0x46CEEA0", VA = "0x46CEEA0")] set
      {
      }
    }

    [Token(Token = "0x17001E50")]
    public APIChatLogResponse Response
    {
      [Token(Token = "0x600A37B"), Address(RVA = "0x46CEEA8", Offset = "0x46CEEA8", VA = "0x46CEEA8")] get
      {
        return (APIChatLogResponse) null;
      }
      [Token(Token = "0x600A37C"), Address(RVA = "0x46CEEB0", Offset = "0x46CEEB0", VA = "0x46CEEB0")] private set
      {
      }
    }

    [Token(Token = "0x17001E51")]
    public int ResponseCode
    {
      [Token(Token = "0x600A37D"), Address(RVA = "0x46CEEB8", Offset = "0x46CEEB8", VA = "0x46CEEB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A37E"), Address(RVA = "0x46CEEC0", Offset = "0x46CEEC0", VA = "0x46CEEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001E52")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A37F"), Address(RVA = "0x46CEEC8", Offset = "0x46CEEC8", VA = "0x46CEEC8")] set
      {
      }
      [Token(Token = "0x600A380"), Address(RVA = "0x46CEEE4", Offset = "0x46CEEE4", VA = "0x46CEEE4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A381")]
    [Address(RVA = "0x46CEF00", Offset = "0x46CEF00", VA = "0x46CEF00")]
    public APIChatLog(string apiPath = "api/v1/chat/log")
    {
    }

    [Token(Token = "0x600A382")]
    [Address(RVA = "0x46CEF98", Offset = "0x46CEF98", VA = "0x46CEF98")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A383")]
    [Address(RVA = "0x46CF028", Offset = "0x46CF028", VA = "0x46CF028")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A384")]
    [Address(RVA = "0x46CF034", Offset = "0x46CF034", VA = "0x46CF034")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A385")]
    [Address(RVA = "0x46CF108", Offset = "0x46CF108", VA = "0x46CF108")]
    private void OnSuccess(string json)
    {
    }
  }
}
