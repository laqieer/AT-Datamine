// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B6D")]
  public class APIAreaQuest
  {
    [Token(Token = "0x4007587")]
    public const string DefaultAPIPath = "api/v1/area_quest";
    [Token(Token = "0x400758B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400758C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAreaQuestResponse> onSuccess;
    [Token(Token = "0x400758D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D6F")]
    public APIAreaQuestRequest Request
    {
      [Token(Token = "0x600A109"), Address(RVA = "0x46C67DC", Offset = "0x46C67DC", VA = "0x46C67DC")] private get
      {
        return (APIAreaQuestRequest) null;
      }
      [Token(Token = "0x600A10A"), Address(RVA = "0x46C67E4", Offset = "0x46C67E4", VA = "0x46C67E4")] set
      {
      }
    }

    [Token(Token = "0x17001D70")]
    public APIAreaQuestResponse Response
    {
      [Token(Token = "0x600A10B"), Address(RVA = "0x46C67EC", Offset = "0x46C67EC", VA = "0x46C67EC")] get
      {
        return (APIAreaQuestResponse) null;
      }
      [Token(Token = "0x600A10C"), Address(RVA = "0x46C67F4", Offset = "0x46C67F4", VA = "0x46C67F4")] private set
      {
      }
    }

    [Token(Token = "0x17001D71")]
    public int ResponseCode
    {
      [Token(Token = "0x600A10D"), Address(RVA = "0x46C67FC", Offset = "0x46C67FC", VA = "0x46C67FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A10E"), Address(RVA = "0x46C6804", Offset = "0x46C6804", VA = "0x46C6804")] private set
      {
      }
    }

    [Token(Token = "0x17001D72")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A10F"), Address(RVA = "0x46C680C", Offset = "0x46C680C", VA = "0x46C680C")] set
      {
      }
      [Token(Token = "0x600A110"), Address(RVA = "0x46C6828", Offset = "0x46C6828", VA = "0x46C6828")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A111")]
    [Address(RVA = "0x46C6844", Offset = "0x46C6844", VA = "0x46C6844")]
    public APIAreaQuest(string apiPath = "api/v1/area_quest")
    {
    }

    [Token(Token = "0x600A112")]
    [Address(RVA = "0x46C68DC", Offset = "0x46C68DC", VA = "0x46C68DC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A113")]
    [Address(RVA = "0x46C696C", Offset = "0x46C696C", VA = "0x46C696C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A114")]
    [Address(RVA = "0x46C6978", Offset = "0x46C6978", VA = "0x46C6978")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A115")]
    [Address(RVA = "0x46C6A4C", Offset = "0x46C6A4C", VA = "0x46C6A4C")]
    private void OnSuccess(string json)
    {
    }
  }
}
