// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BA9")]
  public class APIBattleResume
  {
    [Token(Token = "0x400769C")]
    public const string DefaultAPIPath = "api/v1/battle/resume";
    [Token(Token = "0x40076A0")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076A1")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBattleResumeResponse> onSuccess;
    [Token(Token = "0x40076A2")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E04")]
    public APIBattleResumeRequest Request
    {
      [Token(Token = "0x600A28E"), Address(RVA = "0x46CB928", Offset = "0x46CB928", VA = "0x46CB928")] private get
      {
        return (APIBattleResumeRequest) null;
      }
      [Token(Token = "0x600A28F"), Address(RVA = "0x46CB930", Offset = "0x46CB930", VA = "0x46CB930")] set
      {
      }
    }

    [Token(Token = "0x17001E05")]
    public APIBattleResumeResponse Response
    {
      [Token(Token = "0x600A290"), Address(RVA = "0x46CB938", Offset = "0x46CB938", VA = "0x46CB938")] get
      {
        return (APIBattleResumeResponse) null;
      }
      [Token(Token = "0x600A291"), Address(RVA = "0x46CB940", Offset = "0x46CB940", VA = "0x46CB940")] private set
      {
      }
    }

    [Token(Token = "0x17001E06")]
    public int ResponseCode
    {
      [Token(Token = "0x600A292"), Address(RVA = "0x46CB948", Offset = "0x46CB948", VA = "0x46CB948")] get
      {
        return new int();
      }
      [Token(Token = "0x600A293"), Address(RVA = "0x46CB950", Offset = "0x46CB950", VA = "0x46CB950")] private set
      {
      }
    }

    [Token(Token = "0x17001E07")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A294"), Address(RVA = "0x46CB958", Offset = "0x46CB958", VA = "0x46CB958")] set
      {
      }
      [Token(Token = "0x600A295"), Address(RVA = "0x46CB974", Offset = "0x46CB974", VA = "0x46CB974")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A296")]
    [Address(RVA = "0x46CB990", Offset = "0x46CB990", VA = "0x46CB990")]
    public APIBattleResume(string apiPath = "api/v1/battle/resume")
    {
    }

    [Token(Token = "0x600A297")]
    [Address(RVA = "0x46CBA28", Offset = "0x46CBA28", VA = "0x46CBA28")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A298")]
    [Address(RVA = "0x46CBAB8", Offset = "0x46CBAB8", VA = "0x46CBAB8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A299")]
    [Address(RVA = "0x46CBAC4", Offset = "0x46CBAC4", VA = "0x46CBAC4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A29A")]
    [Address(RVA = "0x46CBB98", Offset = "0x46CBB98", VA = "0x46CBB98")]
    private void OnSuccess(string json)
    {
    }
  }
}
