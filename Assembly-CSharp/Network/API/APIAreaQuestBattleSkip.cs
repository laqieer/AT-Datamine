// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B75")]
  public class APIAreaQuestBattleSkip
  {
    [Token(Token = "0x40075B8")]
    public const string DefaultAPIPath = "api/v1/area_quest/battle/skip";
    [Token(Token = "0x40075BC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40075BD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaQuestBattleSkipResponse> onSuccess;
    [Token(Token = "0x40075BE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D84")]
    public APIAreaQuestBattleSkipRequest Request
    {
      [Token(Token = "0x600A13E"), Address(RVA = "0x46C72BC", Offset = "0x46C72BC", VA = "0x46C72BC")] private get
      {
        return (APIAreaQuestBattleSkipRequest) null;
      }
      [Token(Token = "0x600A13F"), Address(RVA = "0x46C72C4", Offset = "0x46C72C4", VA = "0x46C72C4")] set
      {
      }
    }

    [Token(Token = "0x17001D85")]
    public APIAreaQuestBattleSkipResponse Response
    {
      [Token(Token = "0x600A140"), Address(RVA = "0x46C72CC", Offset = "0x46C72CC", VA = "0x46C72CC")] get
      {
        return (APIAreaQuestBattleSkipResponse) null;
      }
      [Token(Token = "0x600A141"), Address(RVA = "0x46C72D4", Offset = "0x46C72D4", VA = "0x46C72D4")] private set
      {
      }
    }

    [Token(Token = "0x17001D86")]
    public int ResponseCode
    {
      [Token(Token = "0x600A142"), Address(RVA = "0x46C72DC", Offset = "0x46C72DC", VA = "0x46C72DC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A143"), Address(RVA = "0x46C72E4", Offset = "0x46C72E4", VA = "0x46C72E4")] private set
      {
      }
    }

    [Token(Token = "0x17001D87")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A144"), Address(RVA = "0x46C72EC", Offset = "0x46C72EC", VA = "0x46C72EC")] set
      {
      }
      [Token(Token = "0x600A145"), Address(RVA = "0x46C7308", Offset = "0x46C7308", VA = "0x46C7308")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A146")]
    [Address(RVA = "0x46C7324", Offset = "0x46C7324", VA = "0x46C7324")]
    public APIAreaQuestBattleSkip(string apiPath = "api/v1/area_quest/battle/skip")
    {
    }

    [Token(Token = "0x600A147")]
    [Address(RVA = "0x46C73BC", Offset = "0x46C73BC", VA = "0x46C73BC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A148")]
    [Address(RVA = "0x46C744C", Offset = "0x46C744C", VA = "0x46C744C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A149")]
    [Address(RVA = "0x46C7458", Offset = "0x46C7458", VA = "0x46C7458")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A14A")]
    [Address(RVA = "0x46C752C", Offset = "0x46C752C", VA = "0x46C752C")]
    private void OnSuccess(string json)
    {
    }
  }
}
