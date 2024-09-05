// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterLp_recovery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB5")]
  public class APIUnitCharacterLp_recovery
  {
    [Token(Token = "0x40083ED")]
    public const string DefaultAPIPath = "api/v1/unit/character/lp_recovery";
    [Token(Token = "0x40083F1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083F2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitCharacterLp_recoveryResponse> onSuccess;
    [Token(Token = "0x40083F3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700259D")]
    public APIUnitCharacterLp_recoveryRequest Request
    {
      [Token(Token = "0x600B657"), Address(RVA = "0x22EC30C", Offset = "0x22EC30C", VA = "0x22EC30C")] private get
      {
        return (APIUnitCharacterLp_recoveryRequest) null;
      }
      [Token(Token = "0x600B658"), Address(RVA = "0x22EC314", Offset = "0x22EC314", VA = "0x22EC314")] set
      {
      }
    }

    [Token(Token = "0x1700259E")]
    public APIUnitCharacterLp_recoveryResponse Response
    {
      [Token(Token = "0x600B659"), Address(RVA = "0x22EC31C", Offset = "0x22EC31C", VA = "0x22EC31C")] get
      {
        return (APIUnitCharacterLp_recoveryResponse) null;
      }
      [Token(Token = "0x600B65A"), Address(RVA = "0x22EC324", Offset = "0x22EC324", VA = "0x22EC324")] private set
      {
      }
    }

    [Token(Token = "0x1700259F")]
    public int ResponseCode
    {
      [Token(Token = "0x600B65B"), Address(RVA = "0x22EC32C", Offset = "0x22EC32C", VA = "0x22EC32C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B65C"), Address(RVA = "0x22EC334", Offset = "0x22EC334", VA = "0x22EC334")] private set
      {
      }
    }

    [Token(Token = "0x170025A0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B65D"), Address(RVA = "0x22EC33C", Offset = "0x22EC33C", VA = "0x22EC33C")] set
      {
      }
      [Token(Token = "0x600B65E"), Address(RVA = "0x22EC358", Offset = "0x22EC358", VA = "0x22EC358")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B65F")]
    [Address(RVA = "0x22EC374", Offset = "0x22EC374", VA = "0x22EC374")]
    public APIUnitCharacterLp_recovery(string apiPath = "api/v1/unit/character/lp_recovery")
    {
    }

    [Token(Token = "0x600B660")]
    [Address(RVA = "0x22EC40C", Offset = "0x22EC40C", VA = "0x22EC40C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B661")]
    [Address(RVA = "0x22EC49C", Offset = "0x22EC49C", VA = "0x22EC49C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B662")]
    [Address(RVA = "0x22EC4A8", Offset = "0x22EC4A8", VA = "0x22EC4A8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B663")]
    [Address(RVA = "0x22EC57C", Offset = "0x22EC57C", VA = "0x22EC57C")]
    private void OnSuccess(string json)
    {
    }
  }
}
