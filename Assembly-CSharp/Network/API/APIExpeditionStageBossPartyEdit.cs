// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossPartyEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C3D")]
  public class APIExpeditionStageBossPartyEdit
  {
    [Token(Token = "0x40078EE")]
    public const string DefaultAPIPath = "api/v1/expedition/stage/boss/party/edit";
    [Token(Token = "0x40078F2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40078F3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionStageBossPartyEditResponse> onSuccess;
    [Token(Token = "0x40078F4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F61")]
    public APIExpeditionStageBossPartyEditRequest Request
    {
      [Token(Token = "0x600A63B"), Address(RVA = "0x190A130", Offset = "0x190A130", VA = "0x190A130")] private get
      {
        return (APIExpeditionStageBossPartyEditRequest) null;
      }
      [Token(Token = "0x600A63C"), Address(RVA = "0x190A138", Offset = "0x190A138", VA = "0x190A138")] set
      {
      }
    }

    [Token(Token = "0x17001F62")]
    public APIExpeditionStageBossPartyEditResponse Response
    {
      [Token(Token = "0x600A63D"), Address(RVA = "0x190A140", Offset = "0x190A140", VA = "0x190A140")] get
      {
        return (APIExpeditionStageBossPartyEditResponse) null;
      }
      [Token(Token = "0x600A63E"), Address(RVA = "0x190A148", Offset = "0x190A148", VA = "0x190A148")] private set
      {
      }
    }

    [Token(Token = "0x17001F63")]
    public int ResponseCode
    {
      [Token(Token = "0x600A63F"), Address(RVA = "0x190A150", Offset = "0x190A150", VA = "0x190A150")] get
      {
        return new int();
      }
      [Token(Token = "0x600A640"), Address(RVA = "0x190A158", Offset = "0x190A158", VA = "0x190A158")] private set
      {
      }
    }

    [Token(Token = "0x17001F64")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A641"), Address(RVA = "0x190A160", Offset = "0x190A160", VA = "0x190A160")] set
      {
      }
      [Token(Token = "0x600A642"), Address(RVA = "0x190A17C", Offset = "0x190A17C", VA = "0x190A17C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A643")]
    [Address(RVA = "0x190A198", Offset = "0x190A198", VA = "0x190A198")]
    public APIExpeditionStageBossPartyEdit(string apiPath = "api/v1/expedition/stage/boss/party/edit")
    {
    }

    [Token(Token = "0x600A644")]
    [Address(RVA = "0x190A230", Offset = "0x190A230", VA = "0x190A230")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A645")]
    [Address(RVA = "0x190A2C0", Offset = "0x190A2C0", VA = "0x190A2C0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A646")]
    [Address(RVA = "0x190A2CC", Offset = "0x190A2CC", VA = "0x190A2CC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A647")]
    [Address(RVA = "0x190A3A0", Offset = "0x190A3A0", VA = "0x190A3A0")]
    private void OnSuccess(string json)
    {
    }
  }
}
