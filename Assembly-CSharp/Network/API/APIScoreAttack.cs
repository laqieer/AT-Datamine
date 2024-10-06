// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DF1")]
  public class APIScoreAttack
  {
    [Token(Token = "0x400802E")]
    public const string DefaultAPIPath = "api/v1/score_attack";
    [Token(Token = "0x4008032")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008033")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScoreAttackResponse> onSuccess;
    [Token(Token = "0x4008034")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002379")]
    public APIScoreAttackRequest Request
    {
      [Token(Token = "0x600B123"), Address(RVA = "0x22DB790", Offset = "0x22DB790", VA = "0x22DB790")] private get
      {
        return (APIScoreAttackRequest) null;
      }
      [Token(Token = "0x600B124"), Address(RVA = "0x22DB798", Offset = "0x22DB798", VA = "0x22DB798")] set
      {
      }
    }

    [Token(Token = "0x1700237A")]
    public APIScoreAttackResponse Response
    {
      [Token(Token = "0x600B125"), Address(RVA = "0x22DB7A0", Offset = "0x22DB7A0", VA = "0x22DB7A0")] get
      {
        return (APIScoreAttackResponse) null;
      }
      [Token(Token = "0x600B126"), Address(RVA = "0x22DB7A8", Offset = "0x22DB7A8", VA = "0x22DB7A8")] private set
      {
      }
    }

    [Token(Token = "0x1700237B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B127"), Address(RVA = "0x22DB7B0", Offset = "0x22DB7B0", VA = "0x22DB7B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B128"), Address(RVA = "0x22DB7B8", Offset = "0x22DB7B8", VA = "0x22DB7B8")] private set
      {
      }
    }

    [Token(Token = "0x1700237C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B129"), Address(RVA = "0x22DB7C0", Offset = "0x22DB7C0", VA = "0x22DB7C0")] set
      {
      }
      [Token(Token = "0x600B12A"), Address(RVA = "0x22DB7DC", Offset = "0x22DB7DC", VA = "0x22DB7DC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B12B")]
    [Address(RVA = "0x22DB7F8", Offset = "0x22DB7F8", VA = "0x22DB7F8")]
    public APIScoreAttack(string apiPath = "api/v1/score_attack")
    {
    }

    [Token(Token = "0x600B12C")]
    [Address(RVA = "0x22DB890", Offset = "0x22DB890", VA = "0x22DB890")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B12D")]
    [Address(RVA = "0x22DB920", Offset = "0x22DB920", VA = "0x22DB920")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B12E")]
    [Address(RVA = "0x22DB92C", Offset = "0x22DB92C", VA = "0x22DB92C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B12F")]
    [Address(RVA = "0x22DBA00", Offset = "0x22DBA00", VA = "0x22DBA00")]
    private void OnSuccess(string json)
    {
    }
  }
}
