// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartySlotRelease
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C25")]
  public class APIExpeditionPartySlotRelease
  {
    [Token(Token = "0x4007878")]
    public const string DefaultAPIPath = "api/v1/expedition/party/slot/release";
    [Token(Token = "0x400787C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400787D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionPartySlotReleaseResponse> onSuccess;
    [Token(Token = "0x400787E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F14")]
    public APIExpeditionPartySlotReleaseRequest Request
    {
      [Token(Token = "0x600A58E"), Address(RVA = "0x1908020", Offset = "0x1908020", VA = "0x1908020")] private get
      {
        return (APIExpeditionPartySlotReleaseRequest) null;
      }
      [Token(Token = "0x600A58F"), Address(RVA = "0x1908028", Offset = "0x1908028", VA = "0x1908028")] set
      {
      }
    }

    [Token(Token = "0x17001F15")]
    public APIExpeditionPartySlotReleaseResponse Response
    {
      [Token(Token = "0x600A590"), Address(RVA = "0x1908030", Offset = "0x1908030", VA = "0x1908030")] get
      {
        return (APIExpeditionPartySlotReleaseResponse) null;
      }
      [Token(Token = "0x600A591"), Address(RVA = "0x1908038", Offset = "0x1908038", VA = "0x1908038")] private set
      {
      }
    }

    [Token(Token = "0x17001F16")]
    public int ResponseCode
    {
      [Token(Token = "0x600A592"), Address(RVA = "0x1908040", Offset = "0x1908040", VA = "0x1908040")] get
      {
        return new int();
      }
      [Token(Token = "0x600A593"), Address(RVA = "0x1908048", Offset = "0x1908048", VA = "0x1908048")] private set
      {
      }
    }

    [Token(Token = "0x17001F17")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A594"), Address(RVA = "0x1908050", Offset = "0x1908050", VA = "0x1908050")] set
      {
      }
      [Token(Token = "0x600A595"), Address(RVA = "0x190806C", Offset = "0x190806C", VA = "0x190806C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A596")]
    [Address(RVA = "0x1908088", Offset = "0x1908088", VA = "0x1908088")]
    public APIExpeditionPartySlotRelease(string apiPath = "api/v1/expedition/party/slot/release")
    {
    }

    [Token(Token = "0x600A597")]
    [Address(RVA = "0x1908120", Offset = "0x1908120", VA = "0x1908120")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A598")]
    [Address(RVA = "0x19081B0", Offset = "0x19081B0", VA = "0x19081B0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A599")]
    [Address(RVA = "0x19081BC", Offset = "0x19081BC", VA = "0x19081BC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A59A")]
    [Address(RVA = "0x1908290", Offset = "0x1908290", VA = "0x1908290")]
    private void OnSuccess(string json)
    {
    }
  }
}
