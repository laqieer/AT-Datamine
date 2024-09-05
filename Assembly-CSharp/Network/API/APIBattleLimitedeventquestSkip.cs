// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleLimitedeventquestSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BA5")]
  public class APIBattleLimitedeventquestSkip
  {
    [Token(Token = "0x400768F")]
    public const string DefaultAPIPath = "api/v1/battle/limitedeventquest/skip";
    [Token(Token = "0x4007693")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007694")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBattleLimitedeventquestSkipResponse> onSuccess;
    [Token(Token = "0x4007695")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DFC")]
    public APIBattleLimitedeventquestSkipRequest Request
    {
      [Token(Token = "0x600A276"), Address(RVA = "0x46CB3CC", Offset = "0x46CB3CC", VA = "0x46CB3CC")] private get
      {
        return (APIBattleLimitedeventquestSkipRequest) null;
      }
      [Token(Token = "0x600A277"), Address(RVA = "0x46CB3D4", Offset = "0x46CB3D4", VA = "0x46CB3D4")] set
      {
      }
    }

    [Token(Token = "0x17001DFD")]
    public APIBattleLimitedeventquestSkipResponse Response
    {
      [Token(Token = "0x600A278"), Address(RVA = "0x46CB3DC", Offset = "0x46CB3DC", VA = "0x46CB3DC")] get
      {
        return (APIBattleLimitedeventquestSkipResponse) null;
      }
      [Token(Token = "0x600A279"), Address(RVA = "0x46CB3E4", Offset = "0x46CB3E4", VA = "0x46CB3E4")] private set
      {
      }
    }

    [Token(Token = "0x17001DFE")]
    public int ResponseCode
    {
      [Token(Token = "0x600A27A"), Address(RVA = "0x46CB3EC", Offset = "0x46CB3EC", VA = "0x46CB3EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A27B"), Address(RVA = "0x46CB3F4", Offset = "0x46CB3F4", VA = "0x46CB3F4")] private set
      {
      }
    }

    [Token(Token = "0x17001DFF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A27C"), Address(RVA = "0x46CB3FC", Offset = "0x46CB3FC", VA = "0x46CB3FC")] set
      {
      }
      [Token(Token = "0x600A27D"), Address(RVA = "0x46CB418", Offset = "0x46CB418", VA = "0x46CB418")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A27E")]
    [Address(RVA = "0x46CB434", Offset = "0x46CB434", VA = "0x46CB434")]
    public APIBattleLimitedeventquestSkip(string apiPath = "api/v1/battle/limitedeventquest/skip")
    {
    }

    [Token(Token = "0x600A27F")]
    [Address(RVA = "0x46CB4CC", Offset = "0x46CB4CC", VA = "0x46CB4CC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A280")]
    [Address(RVA = "0x46CB55C", Offset = "0x46CB55C", VA = "0x46CB55C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A281")]
    [Address(RVA = "0x46CB568", Offset = "0x46CB568", VA = "0x46CB568")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A282")]
    [Address(RVA = "0x46CB63C", Offset = "0x46CB63C", VA = "0x46CB63C")]
    private void OnSuccess(string json)
    {
    }
  }
}
