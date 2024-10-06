// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleFreequestSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BA1")]
  public class APIBattleFreequestSkip
  {
    [Token(Token = "0x400767A")]
    public const string DefaultAPIPath = "api/v1/battle/freequest/skip";
    [Token(Token = "0x400767E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400767F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBattleFreequestSkipResponse> onSuccess;
    [Token(Token = "0x4007680")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DF2")]
    public APIBattleFreequestSkipRequest Request
    {
      [Token(Token = "0x600A25C"), Address(RVA = "0x46CAE60", Offset = "0x46CAE60", VA = "0x46CAE60")] private get
      {
        return (APIBattleFreequestSkipRequest) null;
      }
      [Token(Token = "0x600A25D"), Address(RVA = "0x46CAE68", Offset = "0x46CAE68", VA = "0x46CAE68")] set
      {
      }
    }

    [Token(Token = "0x17001DF3")]
    public APIBattleFreequestSkipResponse Response
    {
      [Token(Token = "0x600A25E"), Address(RVA = "0x46CAE70", Offset = "0x46CAE70", VA = "0x46CAE70")] get
      {
        return (APIBattleFreequestSkipResponse) null;
      }
      [Token(Token = "0x600A25F"), Address(RVA = "0x46CAE78", Offset = "0x46CAE78", VA = "0x46CAE78")] private set
      {
      }
    }

    [Token(Token = "0x17001DF4")]
    public int ResponseCode
    {
      [Token(Token = "0x600A260"), Address(RVA = "0x46CAE80", Offset = "0x46CAE80", VA = "0x46CAE80")] get
      {
        return new int();
      }
      [Token(Token = "0x600A261"), Address(RVA = "0x46CAE88", Offset = "0x46CAE88", VA = "0x46CAE88")] private set
      {
      }
    }

    [Token(Token = "0x17001DF5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A262"), Address(RVA = "0x46CAE90", Offset = "0x46CAE90", VA = "0x46CAE90")] set
      {
      }
      [Token(Token = "0x600A263"), Address(RVA = "0x46CAEAC", Offset = "0x46CAEAC", VA = "0x46CAEAC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A264")]
    [Address(RVA = "0x46CAEC8", Offset = "0x46CAEC8", VA = "0x46CAEC8")]
    public APIBattleFreequestSkip(string apiPath = "api/v1/battle/freequest/skip")
    {
    }

    [Token(Token = "0x600A265")]
    [Address(RVA = "0x46CAF60", Offset = "0x46CAF60", VA = "0x46CAF60")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A266")]
    [Address(RVA = "0x46CAFF0", Offset = "0x46CAFF0", VA = "0x46CAFF0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A267")]
    [Address(RVA = "0x46CAFFC", Offset = "0x46CAFFC", VA = "0x46CAFFC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A268")]
    [Address(RVA = "0x46CB0D0", Offset = "0x46CB0D0", VA = "0x46CB0D0")]
    private void OnSuccess(string json)
    {
    }
  }
}
