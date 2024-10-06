// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DE5")]
  public class APIScenarioEventMainQuestBattleStart
  {
    [Token(Token = "0x4007FE2")]
    public const string DefaultAPIPath = "api/v1/scenario_event/main_quest_battle_start";
    [Token(Token = "0x4007FE6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007FE7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventMainQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x4007FE8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002352")]
    public APIScenarioEventMainQuestBattleStartRequest Request
    {
      [Token(Token = "0x600B0CC"), Address(RVA = "0x1A548B0", Offset = "0x1A548B0", VA = "0x1A548B0")] private get
      {
        return (APIScenarioEventMainQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600B0CD"), Address(RVA = "0x1A548B8", Offset = "0x1A548B8", VA = "0x1A548B8")] set
      {
      }
    }

    [Token(Token = "0x17002353")]
    public APIScenarioEventMainQuestBattleStartResponse Response
    {
      [Token(Token = "0x600B0CE"), Address(RVA = "0x1A548C0", Offset = "0x1A548C0", VA = "0x1A548C0")] get
      {
        return (APIScenarioEventMainQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600B0CF"), Address(RVA = "0x1A548C8", Offset = "0x1A548C8", VA = "0x1A548C8")] private set
      {
      }
    }

    [Token(Token = "0x17002354")]
    public int ResponseCode
    {
      [Token(Token = "0x600B0D0"), Address(RVA = "0x1A548D0", Offset = "0x1A548D0", VA = "0x1A548D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B0D1"), Address(RVA = "0x1A548D8", Offset = "0x1A548D8", VA = "0x1A548D8")] private set
      {
      }
    }

    [Token(Token = "0x17002355")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B0D2"), Address(RVA = "0x1A548E0", Offset = "0x1A548E0", VA = "0x1A548E0")] set
      {
      }
      [Token(Token = "0x600B0D3"), Address(RVA = "0x1A548FC", Offset = "0x1A548FC", VA = "0x1A548FC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B0D4")]
    [Address(RVA = "0x1A54918", Offset = "0x1A54918", VA = "0x1A54918")]
    public APIScenarioEventMainQuestBattleStart(string apiPath = "api/v1/scenario_event/main_quest_battle_start")
    {
    }

    [Token(Token = "0x600B0D5")]
    [Address(RVA = "0x1A549B0", Offset = "0x1A549B0", VA = "0x1A549B0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B0D6")]
    [Address(RVA = "0x1A54A18", Offset = "0x1A54A18", VA = "0x1A54A18")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B0D7")]
    [Address(RVA = "0x1A54A24", Offset = "0x1A54A24", VA = "0x1A54A24")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B0D8")]
    [Address(RVA = "0x1A54AF8", Offset = "0x1A54AF8", VA = "0x1A54AF8")]
    private void OnSuccess(string json)
    {
    }
  }
}
