// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E4D")]
  public class APIStoryMainquestBattleStart
  {
    [Token(Token = "0x40081F4")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/battle/start";
    [Token(Token = "0x40081F8")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40081F9")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestBattleStartResponse> onSuccess;
    [Token(Token = "0x40081FA")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002476")]
    public APIStoryMainquestBattleStartRequest Request
    {
      [Token(Token = "0x600B390"), Address(RVA = "0x22E34FC", Offset = "0x22E34FC", VA = "0x22E34FC")] private get
      {
        return (APIStoryMainquestBattleStartRequest) null;
      }
      [Token(Token = "0x600B391"), Address(RVA = "0x22E3504", Offset = "0x22E3504", VA = "0x22E3504")] set
      {
      }
    }

    [Token(Token = "0x17002477")]
    public APIStoryMainquestBattleStartResponse Response
    {
      [Token(Token = "0x600B392"), Address(RVA = "0x22E350C", Offset = "0x22E350C", VA = "0x22E350C")] get
      {
        return (APIStoryMainquestBattleStartResponse) null;
      }
      [Token(Token = "0x600B393"), Address(RVA = "0x22E3514", Offset = "0x22E3514", VA = "0x22E3514")] private set
      {
      }
    }

    [Token(Token = "0x17002478")]
    public int ResponseCode
    {
      [Token(Token = "0x600B394"), Address(RVA = "0x22E351C", Offset = "0x22E351C", VA = "0x22E351C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B395"), Address(RVA = "0x22E3524", Offset = "0x22E3524", VA = "0x22E3524")] private set
      {
      }
    }

    [Token(Token = "0x17002479")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B396"), Address(RVA = "0x22E352C", Offset = "0x22E352C", VA = "0x22E352C")] set
      {
      }
      [Token(Token = "0x600B397"), Address(RVA = "0x22E3548", Offset = "0x22E3548", VA = "0x22E3548")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B398")]
    [Address(RVA = "0x22E3564", Offset = "0x22E3564", VA = "0x22E3564")]
    public APIStoryMainquestBattleStart(string apiPath = "api/v1/story/mainquest/battle/start")
    {
    }

    [Token(Token = "0x600B399")]
    [Address(RVA = "0x22E35FC", Offset = "0x22E35FC", VA = "0x22E35FC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B39A")]
    [Address(RVA = "0x22E368C", Offset = "0x22E368C", VA = "0x22E368C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B39B")]
    [Address(RVA = "0x22E3698", Offset = "0x22E3698", VA = "0x22E3698")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B39C")]
    [Address(RVA = "0x22E376C", Offset = "0x22E376C", VA = "0x22E376C")]
    private void OnSuccess(string json)
    {
    }
  }
}
