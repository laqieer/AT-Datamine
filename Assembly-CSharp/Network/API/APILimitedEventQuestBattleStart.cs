// Decompiled with JetBrains decompiler
// Type: Network.API.APILimitedEventQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D49")]
  public class APILimitedEventQuestBattleStart
  {
    [Token(Token = "0x4007D1E")]
    public const string DefaultAPIPath = "api/v1/battle/limitedeventquest/start";
    [Token(Token = "0x4007D22")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D23")]
    [FieldOffset(Offset = "0x30")]
    public Action<APILimitedEventQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x4007D24")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021AD")]
    public APILimitedEventQuestBattleStartRequest Request
    {
      [Token(Token = "0x600ACB7"), Address(RVA = "0x1A47474", Offset = "0x1A47474", VA = "0x1A47474")] private get
      {
        return (APILimitedEventQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600ACB8"), Address(RVA = "0x1A4747C", Offset = "0x1A4747C", VA = "0x1A4747C")] set
      {
      }
    }

    [Token(Token = "0x170021AE")]
    public APILimitedEventQuestBattleStartResponse Response
    {
      [Token(Token = "0x600ACB9"), Address(RVA = "0x1A47484", Offset = "0x1A47484", VA = "0x1A47484")] get
      {
        return (APILimitedEventQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600ACBA"), Address(RVA = "0x1A4748C", Offset = "0x1A4748C", VA = "0x1A4748C")] private set
      {
      }
    }

    [Token(Token = "0x170021AF")]
    public int ResponseCode
    {
      [Token(Token = "0x600ACBB"), Address(RVA = "0x1A47494", Offset = "0x1A47494", VA = "0x1A47494")] get
      {
        return new int();
      }
      [Token(Token = "0x600ACBC"), Address(RVA = "0x1A4749C", Offset = "0x1A4749C", VA = "0x1A4749C")] private set
      {
      }
    }

    [Token(Token = "0x170021B0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ACBD"), Address(RVA = "0x1A474A4", Offset = "0x1A474A4", VA = "0x1A474A4")] set
      {
      }
      [Token(Token = "0x600ACBE"), Address(RVA = "0x1A474C0", Offset = "0x1A474C0", VA = "0x1A474C0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ACBF")]
    [Address(RVA = "0x1A474DC", Offset = "0x1A474DC", VA = "0x1A474DC")]
    public APILimitedEventQuestBattleStart(string apiPath = "api/v1/battle/limitedeventquest/start")
    {
    }

    [Token(Token = "0x600ACC0")]
    [Address(RVA = "0x1A47574", Offset = "0x1A47574", VA = "0x1A47574")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ACC1")]
    [Address(RVA = "0x1A47604", Offset = "0x1A47604", VA = "0x1A47604")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ACC2")]
    [Address(RVA = "0x1A47610", Offset = "0x1A47610", VA = "0x1A47610")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ACC3")]
    [Address(RVA = "0x1A476E4", Offset = "0x1A476E4", VA = "0x1A476E4")]
    private void OnSuccess(string json)
    {
    }
  }
}
