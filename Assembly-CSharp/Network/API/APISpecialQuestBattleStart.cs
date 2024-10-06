// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E21")]
  public class APISpecialQuestBattleStart
  {
    [Token(Token = "0x4008104")]
    public const string DefaultAPIPath = "api/v1/battle/specialquest/start";
    [Token(Token = "0x4008108")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008109")]
    [FieldOffset(Offset = "0x30")]
    public Action<APISpecialQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x400810A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023E9")]
    public APISpecialQuestBattleStartRequest Request
    {
      [Token(Token = "0x600B253"), Address(RVA = "0x22DF860", Offset = "0x22DF860", VA = "0x22DF860")] private get
      {
        return (APISpecialQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600B254"), Address(RVA = "0x22DF868", Offset = "0x22DF868", VA = "0x22DF868")] set
      {
      }
    }

    [Token(Token = "0x170023EA")]
    public APISpecialQuestBattleStartResponse Response
    {
      [Token(Token = "0x600B255"), Address(RVA = "0x22DF870", Offset = "0x22DF870", VA = "0x22DF870")] get
      {
        return (APISpecialQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600B256"), Address(RVA = "0x22DF878", Offset = "0x22DF878", VA = "0x22DF878")] private set
      {
      }
    }

    [Token(Token = "0x170023EB")]
    public int ResponseCode
    {
      [Token(Token = "0x600B257"), Address(RVA = "0x22DF880", Offset = "0x22DF880", VA = "0x22DF880")] get
      {
        return new int();
      }
      [Token(Token = "0x600B258"), Address(RVA = "0x22DF888", Offset = "0x22DF888", VA = "0x22DF888")] private set
      {
      }
    }

    [Token(Token = "0x170023EC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B259"), Address(RVA = "0x22DF890", Offset = "0x22DF890", VA = "0x22DF890")] set
      {
      }
      [Token(Token = "0x600B25A"), Address(RVA = "0x22DF8AC", Offset = "0x22DF8AC", VA = "0x22DF8AC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B25B")]
    [Address(RVA = "0x22DF8C8", Offset = "0x22DF8C8", VA = "0x22DF8C8")]
    public APISpecialQuestBattleStart(string apiPath = "api/v1/battle/specialquest/start")
    {
    }

    [Token(Token = "0x600B25C")]
    [Address(RVA = "0x22DF960", Offset = "0x22DF960", VA = "0x22DF960")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B25D")]
    [Address(RVA = "0x22DF9F0", Offset = "0x22DF9F0", VA = "0x22DF9F0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B25E")]
    [Address(RVA = "0x22DF9FC", Offset = "0x22DF9FC", VA = "0x22DF9FC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B25F")]
    [Address(RVA = "0x22DFAD0", Offset = "0x22DFAD0", VA = "0x22DFAD0")]
    private void OnSuccess(string json)
    {
    }
  }
}
