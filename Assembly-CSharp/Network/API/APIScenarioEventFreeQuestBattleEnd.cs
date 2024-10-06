// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD5")]
  public class APIScenarioEventFreeQuestBattleEnd
  {
    [Token(Token = "0x4007F77")]
    public const string DefaultAPIPath = "api/v1/scenario_event/free_quest_battle_end";
    [Token(Token = "0x4007F7B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F7C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventFreeQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x4007F7D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700231F")]
    public APIScenarioEventFreeQuestBattleEndRequest Request
    {
      [Token(Token = "0x600B059"), Address(RVA = "0x1A532A8", Offset = "0x1A532A8", VA = "0x1A532A8")] private get
      {
        return (APIScenarioEventFreeQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600B05A"), Address(RVA = "0x1A532B0", Offset = "0x1A532B0", VA = "0x1A532B0")] set
      {
      }
    }

    [Token(Token = "0x17002320")]
    public APIScenarioEventFreeQuestBattleEndResponse Response
    {
      [Token(Token = "0x600B05B"), Address(RVA = "0x1A532B8", Offset = "0x1A532B8", VA = "0x1A532B8")] get
      {
        return (APIScenarioEventFreeQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600B05C"), Address(RVA = "0x1A532C0", Offset = "0x1A532C0", VA = "0x1A532C0")] private set
      {
      }
    }

    [Token(Token = "0x17002321")]
    public int ResponseCode
    {
      [Token(Token = "0x600B05D"), Address(RVA = "0x1A532C8", Offset = "0x1A532C8", VA = "0x1A532C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B05E"), Address(RVA = "0x1A532D0", Offset = "0x1A532D0", VA = "0x1A532D0")] private set
      {
      }
    }

    [Token(Token = "0x17002322")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B05F"), Address(RVA = "0x1A532D8", Offset = "0x1A532D8", VA = "0x1A532D8")] set
      {
      }
      [Token(Token = "0x600B060"), Address(RVA = "0x1A532F4", Offset = "0x1A532F4", VA = "0x1A532F4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B061")]
    [Address(RVA = "0x1A53310", Offset = "0x1A53310", VA = "0x1A53310")]
    public APIScenarioEventFreeQuestBattleEnd(string apiPath = "api/v1/scenario_event/free_quest_battle_end")
    {
    }

    [Token(Token = "0x600B062")]
    [Address(RVA = "0x1A533A8", Offset = "0x1A533A8", VA = "0x1A533A8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B063")]
    [Address(RVA = "0x1A53438", Offset = "0x1A53438", VA = "0x1A53438")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B064")]
    [Address(RVA = "0x1A53444", Offset = "0x1A53444", VA = "0x1A53444")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B065")]
    [Address(RVA = "0x1A53518", Offset = "0x1A53518", VA = "0x1A53518")]
    private void OnSuccess(string json)
    {
    }
  }
}
