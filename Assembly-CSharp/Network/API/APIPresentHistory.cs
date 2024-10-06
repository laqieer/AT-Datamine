// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DC1")]
  public class APIPresentHistory
  {
    [Token(Token = "0x4007F19")]
    public const string DefaultAPIPath = "api/v1/present/history";
    [Token(Token = "0x4007F1D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F1E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPresentHistoryResponse> onSuccess;
    [Token(Token = "0x4007F1F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022ED")]
    public APIPresentHistoryRequest Request
    {
      [Token(Token = "0x600AFD7"), Address(RVA = "0x1A5178C", Offset = "0x1A5178C", VA = "0x1A5178C")] private get
      {
        return (APIPresentHistoryRequest) null;
      }
      [Token(Token = "0x600AFD8"), Address(RVA = "0x1A51794", Offset = "0x1A51794", VA = "0x1A51794")] set
      {
      }
    }

    [Token(Token = "0x170022EE")]
    public APIPresentHistoryResponse Response
    {
      [Token(Token = "0x600AFD9"), Address(RVA = "0x1A5179C", Offset = "0x1A5179C", VA = "0x1A5179C")] get
      {
        return (APIPresentHistoryResponse) null;
      }
      [Token(Token = "0x600AFDA"), Address(RVA = "0x1A517A4", Offset = "0x1A517A4", VA = "0x1A517A4")] private set
      {
      }
    }

    [Token(Token = "0x170022EF")]
    public int ResponseCode
    {
      [Token(Token = "0x600AFDB"), Address(RVA = "0x1A517AC", Offset = "0x1A517AC", VA = "0x1A517AC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AFDC"), Address(RVA = "0x1A517B4", Offset = "0x1A517B4", VA = "0x1A517B4")] private set
      {
      }
    }

    [Token(Token = "0x170022F0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AFDD"), Address(RVA = "0x1A517BC", Offset = "0x1A517BC", VA = "0x1A517BC")] set
      {
      }
      [Token(Token = "0x600AFDE"), Address(RVA = "0x1A517D8", Offset = "0x1A517D8", VA = "0x1A517D8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AFDF")]
    [Address(RVA = "0x1A517F4", Offset = "0x1A517F4", VA = "0x1A517F4")]
    public APIPresentHistory(string apiPath = "api/v1/present/history")
    {
    }

    [Token(Token = "0x600AFE0")]
    [Address(RVA = "0x1A5188C", Offset = "0x1A5188C", VA = "0x1A5188C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AFE1")]
    [Address(RVA = "0x1A5191C", Offset = "0x1A5191C", VA = "0x1A5191C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AFE2")]
    [Address(RVA = "0x1A51928", Offset = "0x1A51928", VA = "0x1A51928")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AFE3")]
    [Address(RVA = "0x1A519FC", Offset = "0x1A519FC", VA = "0x1A519FC")]
    private void OnSuccess(string json)
    {
    }
  }
}
