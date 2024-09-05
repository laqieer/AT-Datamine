// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRecommendSearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D19")]
  public class APIGuildRecommendSearch
  {
    [Token(Token = "0x4007C4D")]
    public const string DefaultAPIPath = "api/v1/guild/recommend/search";
    [Token(Token = "0x4007C51")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C52")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRecommendSearchResponse> onSuccess;
    [Token(Token = "0x4007C53")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700213B")]
    public APIGuildRecommendSearchRequest Request
    {
      [Token(Token = "0x600AB85"), Address(RVA = "0x1A433A4", Offset = "0x1A433A4", VA = "0x1A433A4")] private get
      {
        return (APIGuildRecommendSearchRequest) null;
      }
      [Token(Token = "0x600AB86"), Address(RVA = "0x1A433AC", Offset = "0x1A433AC", VA = "0x1A433AC")] set
      {
      }
    }

    [Token(Token = "0x1700213C")]
    public APIGuildRecommendSearchResponse Response
    {
      [Token(Token = "0x600AB87"), Address(RVA = "0x1A433B4", Offset = "0x1A433B4", VA = "0x1A433B4")] get
      {
        return (APIGuildRecommendSearchResponse) null;
      }
      [Token(Token = "0x600AB88"), Address(RVA = "0x1A433BC", Offset = "0x1A433BC", VA = "0x1A433BC")] private set
      {
      }
    }

    [Token(Token = "0x1700213D")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB89"), Address(RVA = "0x1A433C4", Offset = "0x1A433C4", VA = "0x1A433C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB8A"), Address(RVA = "0x1A433CC", Offset = "0x1A433CC", VA = "0x1A433CC")] private set
      {
      }
    }

    [Token(Token = "0x1700213E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB8B"), Address(RVA = "0x1A433D4", Offset = "0x1A433D4", VA = "0x1A433D4")] set
      {
      }
      [Token(Token = "0x600AB8C"), Address(RVA = "0x1A433F0", Offset = "0x1A433F0", VA = "0x1A433F0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB8D")]
    [Address(RVA = "0x1A4340C", Offset = "0x1A4340C", VA = "0x1A4340C")]
    public APIGuildRecommendSearch(string apiPath = "api/v1/guild/recommend/search")
    {
    }

    [Token(Token = "0x600AB8E")]
    [Address(RVA = "0x1A434A4", Offset = "0x1A434A4", VA = "0x1A434A4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB8F")]
    [Address(RVA = "0x1A43534", Offset = "0x1A43534", VA = "0x1A43534")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB90")]
    [Address(RVA = "0x1A43540", Offset = "0x1A43540", VA = "0x1A43540")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB91")]
    [Address(RVA = "0x1A43614", Offset = "0x1A43614", VA = "0x1A43614")]
    private void OnSuccess(string json)
    {
    }
  }
}
