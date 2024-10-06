// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DE9")]
  public class APIScenarioEventSubQuestBattleEnd
  {
    [Token(Token = "0x4008004")]
    public const string DefaultAPIPath = "api/v1/scenario_event/sub_quest_battle_end";
    [Token(Token = "0x4008008")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008009")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIScenarioEventSubQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x400800A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002362")]
    public APIScenarioEventSubQuestBattleEndRequest Request
    {
      [Token(Token = "0x600B0EC"), Address(RVA = "0x22DACA0", Offset = "0x22DACA0", VA = "0x22DACA0")] private get
      {
        return (APIScenarioEventSubQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600B0ED"), Address(RVA = "0x22DACA8", Offset = "0x22DACA8", VA = "0x22DACA8")] set
      {
      }
    }

    [Token(Token = "0x17002363")]
    public APIScenarioEventSubQuestBattleEndResponse Response
    {
      [Token(Token = "0x600B0EE"), Address(RVA = "0x22DACB0", Offset = "0x22DACB0", VA = "0x22DACB0")] get
      {
        return (APIScenarioEventSubQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600B0EF"), Address(RVA = "0x22DACB8", Offset = "0x22DACB8", VA = "0x22DACB8")] private set
      {
      }
    }

    [Token(Token = "0x17002364")]
    public int ResponseCode
    {
      [Token(Token = "0x600B0F0"), Address(RVA = "0x22DACC0", Offset = "0x22DACC0", VA = "0x22DACC0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B0F1"), Address(RVA = "0x22DACC8", Offset = "0x22DACC8", VA = "0x22DACC8")] private set
      {
      }
    }

    [Token(Token = "0x17002365")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B0F2"), Address(RVA = "0x22DACD0", Offset = "0x22DACD0", VA = "0x22DACD0")] set
      {
      }
      [Token(Token = "0x600B0F3"), Address(RVA = "0x22DACEC", Offset = "0x22DACEC", VA = "0x22DACEC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B0F4")]
    [Address(RVA = "0x22DAD08", Offset = "0x22DAD08", VA = "0x22DAD08")]
    public APIScenarioEventSubQuestBattleEnd(string apiPath = "api/v1/scenario_event/sub_quest_battle_end")
    {
    }

    [Token(Token = "0x600B0F5")]
    [Address(RVA = "0x22DADA0", Offset = "0x22DADA0", VA = "0x22DADA0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B0F6")]
    [Address(RVA = "0x22DAE30", Offset = "0x22DAE30", VA = "0x22DAE30")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B0F7")]
    [Address(RVA = "0x22DAE3C", Offset = "0x22DAE3C", VA = "0x22DAE3C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B0F8")]
    [Address(RVA = "0x22DAF10", Offset = "0x22DAF10", VA = "0x22DAF10")]
    private void OnSuccess(string json)
    {
    }
  }
}
