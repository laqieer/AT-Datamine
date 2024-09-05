// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DDD")]
  public class APIScenarioEventFreeQuestBattleStart
  {
    [Token(Token = "0x4007FA5")]
    public const string DefaultAPIPath = "api/v1/scenario_event/free_quest_battle_start";
    [Token(Token = "0x4007FA9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007FAA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventFreeQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x4007FAB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002336")]
    public APIScenarioEventFreeQuestBattleStartRequest Request
    {
      [Token(Token = "0x600B090"), Address(RVA = "0x1A53D98", Offset = "0x1A53D98", VA = "0x1A53D98")] private get
      {
        return (APIScenarioEventFreeQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600B091"), Address(RVA = "0x1A53DA0", Offset = "0x1A53DA0", VA = "0x1A53DA0")] set
      {
      }
    }

    [Token(Token = "0x17002337")]
    public APIScenarioEventFreeQuestBattleStartResponse Response
    {
      [Token(Token = "0x600B092"), Address(RVA = "0x1A53DA8", Offset = "0x1A53DA8", VA = "0x1A53DA8")] get
      {
        return (APIScenarioEventFreeQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600B093"), Address(RVA = "0x1A53DB0", Offset = "0x1A53DB0", VA = "0x1A53DB0")] private set
      {
      }
    }

    [Token(Token = "0x17002338")]
    public int ResponseCode
    {
      [Token(Token = "0x600B094"), Address(RVA = "0x1A53DB8", Offset = "0x1A53DB8", VA = "0x1A53DB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B095"), Address(RVA = "0x1A53DC0", Offset = "0x1A53DC0", VA = "0x1A53DC0")] private set
      {
      }
    }

    [Token(Token = "0x17002339")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B096"), Address(RVA = "0x1A53DC8", Offset = "0x1A53DC8", VA = "0x1A53DC8")] set
      {
      }
      [Token(Token = "0x600B097"), Address(RVA = "0x1A53DE4", Offset = "0x1A53DE4", VA = "0x1A53DE4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B098")]
    [Address(RVA = "0x1A53E00", Offset = "0x1A53E00", VA = "0x1A53E00")]
    public APIScenarioEventFreeQuestBattleStart(string apiPath = "api/v1/scenario_event/free_quest_battle_start")
    {
    }

    [Token(Token = "0x600B099")]
    [Address(RVA = "0x1A53E98", Offset = "0x1A53E98", VA = "0x1A53E98")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B09A")]
    [Address(RVA = "0x1A53F28", Offset = "0x1A53F28", VA = "0x1A53F28")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B09B")]
    [Address(RVA = "0x1A53F34", Offset = "0x1A53F34", VA = "0x1A53F34")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B09C")]
    [Address(RVA = "0x1A54008", Offset = "0x1A54008", VA = "0x1A54008")]
    private void OnSuccess(string json)
    {
    }
  }
}
