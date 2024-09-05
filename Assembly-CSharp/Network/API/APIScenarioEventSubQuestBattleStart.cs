// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DED")]
  public class APIScenarioEventSubQuestBattleStart
  {
    [Token(Token = "0x400801E")]
    public const string DefaultAPIPath = "api/v1/scenario_event/sub_quest_battle_start";
    [Token(Token = "0x4008022")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008023")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventSubQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x4008024")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700236F")]
    public APIScenarioEventSubQuestBattleStartRequest Request
    {
      [Token(Token = "0x600B109"), Address(RVA = "0x22DB224", Offset = "0x22DB224", VA = "0x22DB224")] private get
      {
        return (APIScenarioEventSubQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600B10A"), Address(RVA = "0x22DB22C", Offset = "0x22DB22C", VA = "0x22DB22C")] set
      {
      }
    }

    [Token(Token = "0x17002370")]
    public APIScenarioEventSubQuestBattleStartResponse Response
    {
      [Token(Token = "0x600B10B"), Address(RVA = "0x22DB234", Offset = "0x22DB234", VA = "0x22DB234")] get
      {
        return (APIScenarioEventSubQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600B10C"), Address(RVA = "0x22DB23C", Offset = "0x22DB23C", VA = "0x22DB23C")] private set
      {
      }
    }

    [Token(Token = "0x17002371")]
    public int ResponseCode
    {
      [Token(Token = "0x600B10D"), Address(RVA = "0x22DB244", Offset = "0x22DB244", VA = "0x22DB244")] get
      {
        return new int();
      }
      [Token(Token = "0x600B10E"), Address(RVA = "0x22DB24C", Offset = "0x22DB24C", VA = "0x22DB24C")] private set
      {
      }
    }

    [Token(Token = "0x17002372")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B10F"), Address(RVA = "0x22DB254", Offset = "0x22DB254", VA = "0x22DB254")] set
      {
      }
      [Token(Token = "0x600B110"), Address(RVA = "0x22DB270", Offset = "0x22DB270", VA = "0x22DB270")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B111")]
    [Address(RVA = "0x22DB28C", Offset = "0x22DB28C", VA = "0x22DB28C")]
    public APIScenarioEventSubQuestBattleStart(string apiPath = "api/v1/scenario_event/sub_quest_battle_start")
    {
    }

    [Token(Token = "0x600B112")]
    [Address(RVA = "0x22DB324", Offset = "0x22DB324", VA = "0x22DB324")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B113")]
    [Address(RVA = "0x22DB3B4", Offset = "0x22DB3B4", VA = "0x22DB3B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B114")]
    [Address(RVA = "0x22DB3C0", Offset = "0x22DB3C0", VA = "0x22DB3C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B115")]
    [Address(RVA = "0x22DB494", Offset = "0x22DB494", VA = "0x22DB494")]
    private void OnSuccess(string json)
    {
    }
  }
}
