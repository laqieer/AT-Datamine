// Decompiled with JetBrains decompiler
// Type: Network.API.APIArena
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B81")]
  public class APIArena
  {
    [Token(Token = "0x40075EC")]
    public const string DefaultAPIPath = "api/v1/arena";
    [Token(Token = "0x40075F0")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40075F1")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaResponse> onSuccess;
    [Token(Token = "0x40075F2")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D9F")]
    public APIArenaRequest Request
    {
      [Token(Token = "0x600A189"), Address(RVA = "0x46C82E8", Offset = "0x46C82E8", VA = "0x46C82E8")] private get
      {
        return (APIArenaRequest) null;
      }
      [Token(Token = "0x600A18A"), Address(RVA = "0x46C82F0", Offset = "0x46C82F0", VA = "0x46C82F0")] set
      {
      }
    }

    [Token(Token = "0x17001DA0")]
    public APIArenaResponse Response
    {
      [Token(Token = "0x600A18B"), Address(RVA = "0x46C82F8", Offset = "0x46C82F8", VA = "0x46C82F8")] get
      {
        return (APIArenaResponse) null;
      }
      [Token(Token = "0x600A18C"), Address(RVA = "0x46C8300", Offset = "0x46C8300", VA = "0x46C8300")] private set
      {
      }
    }

    [Token(Token = "0x17001DA1")]
    public int ResponseCode
    {
      [Token(Token = "0x600A18D"), Address(RVA = "0x46C8308", Offset = "0x46C8308", VA = "0x46C8308")] get
      {
        return new int();
      }
      [Token(Token = "0x600A18E"), Address(RVA = "0x46C8310", Offset = "0x46C8310", VA = "0x46C8310")] private set
      {
      }
    }

    [Token(Token = "0x17001DA2")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A18F"), Address(RVA = "0x46C8318", Offset = "0x46C8318", VA = "0x46C8318")] set
      {
      }
      [Token(Token = "0x600A190"), Address(RVA = "0x46C8334", Offset = "0x46C8334", VA = "0x46C8334")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A191")]
    [Address(RVA = "0x46C8350", Offset = "0x46C8350", VA = "0x46C8350")]
    public APIArena(string apiPath = "api/v1/arena")
    {
    }

    [Token(Token = "0x600A192")]
    [Address(RVA = "0x46C83E8", Offset = "0x46C83E8", VA = "0x46C83E8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A193")]
    [Address(RVA = "0x46C8478", Offset = "0x46C8478", VA = "0x46C8478")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A194")]
    [Address(RVA = "0x46C8484", Offset = "0x46C8484", VA = "0x46C8484")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A195")]
    [Address(RVA = "0x46C8558", Offset = "0x46C8558", VA = "0x46C8558")]
    private void OnSuccess(string json)
    {
    }
  }
}
