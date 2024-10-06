// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD9")]
  public class APIScenarioEventFreeQuestBattleSkip
  {
    [Token(Token = "0x4007F8C")]
    public const string DefaultAPIPath = "api/v1/scenario_event/free_quest_battle_skip";
    [Token(Token = "0x4007F90")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F91")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventFreeQuestBattleSkipResponse> onSuccess;
    [Token(Token = "0x4007F92")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002329")]
    public APIScenarioEventFreeQuestBattleSkipRequest Request
    {
      [Token(Token = "0x600B073"), Address(RVA = "0x1A53814", Offset = "0x1A53814", VA = "0x1A53814")] private get
      {
        return (APIScenarioEventFreeQuestBattleSkipRequest) null;
      }
      [Token(Token = "0x600B074"), Address(RVA = "0x1A5381C", Offset = "0x1A5381C", VA = "0x1A5381C")] set
      {
      }
    }

    [Token(Token = "0x1700232A")]
    public APIScenarioEventFreeQuestBattleSkipResponse Response
    {
      [Token(Token = "0x600B075"), Address(RVA = "0x1A53824", Offset = "0x1A53824", VA = "0x1A53824")] get
      {
        return (APIScenarioEventFreeQuestBattleSkipResponse) null;
      }
      [Token(Token = "0x600B076"), Address(RVA = "0x1A5382C", Offset = "0x1A5382C", VA = "0x1A5382C")] private set
      {
      }
    }

    [Token(Token = "0x1700232B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B077"), Address(RVA = "0x1A53834", Offset = "0x1A53834", VA = "0x1A53834")] get
      {
        return new int();
      }
      [Token(Token = "0x600B078"), Address(RVA = "0x1A5383C", Offset = "0x1A5383C", VA = "0x1A5383C")] private set
      {
      }
    }

    [Token(Token = "0x1700232C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B079"), Address(RVA = "0x1A53844", Offset = "0x1A53844", VA = "0x1A53844")] set
      {
      }
      [Token(Token = "0x600B07A"), Address(RVA = "0x1A53860", Offset = "0x1A53860", VA = "0x1A53860")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B07B")]
    [Address(RVA = "0x1A5387C", Offset = "0x1A5387C", VA = "0x1A5387C")]
    public APIScenarioEventFreeQuestBattleSkip(string apiPath = "api/v1/scenario_event/free_quest_battle_skip")
    {
    }

    [Token(Token = "0x600B07C")]
    [Address(RVA = "0x1A53914", Offset = "0x1A53914", VA = "0x1A53914")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B07D")]
    [Address(RVA = "0x1A539A4", Offset = "0x1A539A4", VA = "0x1A539A4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B07E")]
    [Address(RVA = "0x1A539B0", Offset = "0x1A539B0", VA = "0x1A539B0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B07F")]
    [Address(RVA = "0x1A53A84", Offset = "0x1A53A84", VA = "0x1A53A84")]
    private void OnSuccess(string json)
    {
    }
  }
}
