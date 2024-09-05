// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B79")]
  public class APIAreaQuestBattleStart
  {
    [Token(Token = "0x40075D1")]
    public const string DefaultAPIPath = "api/v1/area_quest/battle/start";
    [Token(Token = "0x40075D5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40075D6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaQuestBattleStartResponse> onSuccess;
    [Token(Token = "0x40075D7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D91")]
    public APIAreaQuestBattleStartRequest Request
    {
      [Token(Token = "0x600A15B"), Address(RVA = "0x46C7840", Offset = "0x46C7840", VA = "0x46C7840")] private get
      {
        return (APIAreaQuestBattleStartRequest) null;
      }
      [Token(Token = "0x600A15C"), Address(RVA = "0x46C7848", Offset = "0x46C7848", VA = "0x46C7848")] set
      {
      }
    }

    [Token(Token = "0x17001D92")]
    public APIAreaQuestBattleStartResponse Response
    {
      [Token(Token = "0x600A15D"), Address(RVA = "0x46C7850", Offset = "0x46C7850", VA = "0x46C7850")] get
      {
        return (APIAreaQuestBattleStartResponse) null;
      }
      [Token(Token = "0x600A15E"), Address(RVA = "0x46C7858", Offset = "0x46C7858", VA = "0x46C7858")] private set
      {
      }
    }

    [Token(Token = "0x17001D93")]
    public int ResponseCode
    {
      [Token(Token = "0x600A15F"), Address(RVA = "0x46C7860", Offset = "0x46C7860", VA = "0x46C7860")] get
      {
        return new int();
      }
      [Token(Token = "0x600A160"), Address(RVA = "0x46C7868", Offset = "0x46C7868", VA = "0x46C7868")] private set
      {
      }
    }

    [Token(Token = "0x17001D94")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A161"), Address(RVA = "0x46C7870", Offset = "0x46C7870", VA = "0x46C7870")] set
      {
      }
      [Token(Token = "0x600A162"), Address(RVA = "0x46C788C", Offset = "0x46C788C", VA = "0x46C788C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A163")]
    [Address(RVA = "0x46C78A8", Offset = "0x46C78A8", VA = "0x46C78A8")]
    public APIAreaQuestBattleStart(string apiPath = "api/v1/area_quest/battle/start")
    {
    }

    [Token(Token = "0x600A164")]
    [Address(RVA = "0x46C7940", Offset = "0x46C7940", VA = "0x46C7940")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A165")]
    [Address(RVA = "0x46C79D0", Offset = "0x46C79D0", VA = "0x46C79D0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A166")]
    [Address(RVA = "0x46C79DC", Offset = "0x46C79DC", VA = "0x46C79DC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A167")]
    [Address(RVA = "0x46C7AB0", Offset = "0x46C7AB0", VA = "0x46C7AB0")]
    private void OnSuccess(string json)
    {
    }
  }
}
