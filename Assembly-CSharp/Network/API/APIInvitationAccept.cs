// Decompiled with JetBrains decompiler
// Type: Network.API.APIInvitationAccept
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D3D")]
  public class APIInvitationAccept
  {
    [Token(Token = "0x4007CDA")]
    public const string DefaultAPIPath = "api/v1/invitation/accept";
    [Token(Token = "0x4007CDE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CDF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIInvitationAcceptResponse> onSuccess;
    [Token(Token = "0x4007CE0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700218C")]
    public APIInvitationAcceptRequest Request
    {
      [Token(Token = "0x600AC66"), Address(RVA = "0x1A46418", Offset = "0x1A46418", VA = "0x1A46418")] private get
      {
        return (APIInvitationAcceptRequest) null;
      }
      [Token(Token = "0x600AC67"), Address(RVA = "0x1A46420", Offset = "0x1A46420", VA = "0x1A46420")] set
      {
      }
    }

    [Token(Token = "0x1700218D")]
    public APIInvitationAcceptResponse Response
    {
      [Token(Token = "0x600AC68"), Address(RVA = "0x1A46428", Offset = "0x1A46428", VA = "0x1A46428")] get
      {
        return (APIInvitationAcceptResponse) null;
      }
      [Token(Token = "0x600AC69"), Address(RVA = "0x1A46430", Offset = "0x1A46430", VA = "0x1A46430")] private set
      {
      }
    }

    [Token(Token = "0x1700218E")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC6A"), Address(RVA = "0x1A46438", Offset = "0x1A46438", VA = "0x1A46438")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC6B"), Address(RVA = "0x1A46440", Offset = "0x1A46440", VA = "0x1A46440")] private set
      {
      }
    }

    [Token(Token = "0x1700218F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC6C"), Address(RVA = "0x1A46448", Offset = "0x1A46448", VA = "0x1A46448")] set
      {
      }
      [Token(Token = "0x600AC6D"), Address(RVA = "0x1A46464", Offset = "0x1A46464", VA = "0x1A46464")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC6E")]
    [Address(RVA = "0x1A46480", Offset = "0x1A46480", VA = "0x1A46480")]
    public APIInvitationAccept(string apiPath = "api/v1/invitation/accept")
    {
    }

    [Token(Token = "0x600AC6F")]
    [Address(RVA = "0x1A46518", Offset = "0x1A46518", VA = "0x1A46518")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC70")]
    [Address(RVA = "0x1A465A8", Offset = "0x1A465A8", VA = "0x1A465A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC71")]
    [Address(RVA = "0x1A465B4", Offset = "0x1A465B4", VA = "0x1A465B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC72")]
    [Address(RVA = "0x1A46688", Offset = "0x1A46688", VA = "0x1A46688")]
    private void OnSuccess(string json)
    {
    }
  }
}
