// Decompiled with JetBrains decompiler
// Type: Network.API.APIIntroductionFinish
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D39")]
  public class APIIntroductionFinish
  {
    [Token(Token = "0x4007CCC")]
    public const string DefaultAPIPath = "api/v1/introduction/finish";
    [Token(Token = "0x4007CD0")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CD1")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIIntroductionFinishResponse> onSuccess;
    [Token(Token = "0x4007CD2")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002184")]
    public APIIntroductionFinishRequest Request
    {
      [Token(Token = "0x600AC4E"), Address(RVA = "0x1A45EBC", Offset = "0x1A45EBC", VA = "0x1A45EBC")] private get
      {
        return (APIIntroductionFinishRequest) null;
      }
      [Token(Token = "0x600AC4F"), Address(RVA = "0x1A45EC4", Offset = "0x1A45EC4", VA = "0x1A45EC4")] set
      {
      }
    }

    [Token(Token = "0x17002185")]
    public APIIntroductionFinishResponse Response
    {
      [Token(Token = "0x600AC50"), Address(RVA = "0x1A45ECC", Offset = "0x1A45ECC", VA = "0x1A45ECC")] get
      {
        return (APIIntroductionFinishResponse) null;
      }
      [Token(Token = "0x600AC51"), Address(RVA = "0x1A45ED4", Offset = "0x1A45ED4", VA = "0x1A45ED4")] private set
      {
      }
    }

    [Token(Token = "0x17002186")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC52"), Address(RVA = "0x1A45EDC", Offset = "0x1A45EDC", VA = "0x1A45EDC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC53"), Address(RVA = "0x1A45EE4", Offset = "0x1A45EE4", VA = "0x1A45EE4")] private set
      {
      }
    }

    [Token(Token = "0x17002187")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC54"), Address(RVA = "0x1A45EEC", Offset = "0x1A45EEC", VA = "0x1A45EEC")] set
      {
      }
      [Token(Token = "0x600AC55"), Address(RVA = "0x1A45F08", Offset = "0x1A45F08", VA = "0x1A45F08")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC56")]
    [Address(RVA = "0x1A45F24", Offset = "0x1A45F24", VA = "0x1A45F24")]
    public APIIntroductionFinish(string apiPath = "api/v1/introduction/finish")
    {
    }

    [Token(Token = "0x600AC57")]
    [Address(RVA = "0x1A45FBC", Offset = "0x1A45FBC", VA = "0x1A45FBC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC58")]
    [Address(RVA = "0x1A4604C", Offset = "0x1A4604C", VA = "0x1A4604C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC59")]
    [Address(RVA = "0x1A46058", Offset = "0x1A46058", VA = "0x1A46058")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC5A")]
    [Address(RVA = "0x1A4612C", Offset = "0x1A4612C", VA = "0x1A4612C")]
    private void OnSuccess(string json)
    {
    }
  }
}
