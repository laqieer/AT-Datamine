// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DE1")]
  public class APIScenarioEventMainQuestBattleEnd
  {
    [Token(Token = "0x4007FC8")]
    public const string DefaultAPIPath = "api/v1/scenario_event/main_quest_battle_end";
    [Token(Token = "0x4007FCC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007FCD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventMainQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x4007FCE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002345")]
    public APIScenarioEventMainQuestBattleEndRequest Request
    {
      [Token(Token = "0x600B0AF"), Address(RVA = "0x1A5432C", Offset = "0x1A5432C", VA = "0x1A5432C")] private get
      {
        return (APIScenarioEventMainQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600B0B0"), Address(RVA = "0x1A54334", Offset = "0x1A54334", VA = "0x1A54334")] set
      {
      }
    }

    [Token(Token = "0x17002346")]
    public APIScenarioEventMainQuestBattleEndResponse Response
    {
      [Token(Token = "0x600B0B1"), Address(RVA = "0x1A5433C", Offset = "0x1A5433C", VA = "0x1A5433C")] get
      {
        return (APIScenarioEventMainQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600B0B2"), Address(RVA = "0x1A54344", Offset = "0x1A54344", VA = "0x1A54344")] private set
      {
      }
    }

    [Token(Token = "0x17002347")]
    public int ResponseCode
    {
      [Token(Token = "0x600B0B3"), Address(RVA = "0x1A5434C", Offset = "0x1A5434C", VA = "0x1A5434C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B0B4"), Address(RVA = "0x1A54354", Offset = "0x1A54354", VA = "0x1A54354")] private set
      {
      }
    }

    [Token(Token = "0x17002348")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B0B5"), Address(RVA = "0x1A5435C", Offset = "0x1A5435C", VA = "0x1A5435C")] set
      {
      }
      [Token(Token = "0x600B0B6"), Address(RVA = "0x1A54378", Offset = "0x1A54378", VA = "0x1A54378")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B0B7")]
    [Address(RVA = "0x1A54394", Offset = "0x1A54394", VA = "0x1A54394")]
    public APIScenarioEventMainQuestBattleEnd(string apiPath = "api/v1/scenario_event/main_quest_battle_end")
    {
    }

    [Token(Token = "0x600B0B8")]
    [Address(RVA = "0x1A5442C", Offset = "0x1A5442C", VA = "0x1A5442C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B0B9")]
    [Address(RVA = "0x1A544BC", Offset = "0x1A544BC", VA = "0x1A544BC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B0BA")]
    [Address(RVA = "0x1A544C8", Offset = "0x1A544C8", VA = "0x1A544C8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B0BB")]
    [Address(RVA = "0x1A5459C", Offset = "0x1A5459C", VA = "0x1A5459C")]
    private void OnSuccess(string json)
    {
    }
  }
}
