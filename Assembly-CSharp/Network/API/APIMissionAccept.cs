// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionAccept
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D69")]
  public class APIMissionAccept
  {
    [Token(Token = "0x4007DA6")]
    public const string DefaultAPIPath = "api/v1/mission/accept";
    [Token(Token = "0x4007DAA")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DAB")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMissionAcceptResponse> onSuccess;
    [Token(Token = "0x4007DAC")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002201")]
    public APIMissionAcceptRequest Request
    {
      [Token(Token = "0x600AD8B"), Address(RVA = "0x1A49FE4", Offset = "0x1A49FE4", VA = "0x1A49FE4")] private get
      {
        return (APIMissionAcceptRequest) null;
      }
      [Token(Token = "0x600AD8C"), Address(RVA = "0x1A49FEC", Offset = "0x1A49FEC", VA = "0x1A49FEC")] set
      {
      }
    }

    [Token(Token = "0x17002202")]
    public APIMissionAcceptResponse Response
    {
      [Token(Token = "0x600AD8D"), Address(RVA = "0x1A49FF4", Offset = "0x1A49FF4", VA = "0x1A49FF4")] get
      {
        return (APIMissionAcceptResponse) null;
      }
      [Token(Token = "0x600AD8E"), Address(RVA = "0x1A49FFC", Offset = "0x1A49FFC", VA = "0x1A49FFC")] private set
      {
      }
    }

    [Token(Token = "0x17002203")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD8F"), Address(RVA = "0x1A4A004", Offset = "0x1A4A004", VA = "0x1A4A004")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD90"), Address(RVA = "0x1A4A00C", Offset = "0x1A4A00C", VA = "0x1A4A00C")] private set
      {
      }
    }

    [Token(Token = "0x17002204")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD91"), Address(RVA = "0x1A4A014", Offset = "0x1A4A014", VA = "0x1A4A014")] set
      {
      }
      [Token(Token = "0x600AD92"), Address(RVA = "0x1A4A030", Offset = "0x1A4A030", VA = "0x1A4A030")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD93")]
    [Address(RVA = "0x1A4A04C", Offset = "0x1A4A04C", VA = "0x1A4A04C")]
    public APIMissionAccept(string apiPath = "api/v1/mission/accept")
    {
    }

    [Token(Token = "0x600AD94")]
    [Address(RVA = "0x1A4A0E4", Offset = "0x1A4A0E4", VA = "0x1A4A0E4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD95")]
    [Address(RVA = "0x1A4A174", Offset = "0x1A4A174", VA = "0x1A4A174")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD96")]
    [Address(RVA = "0x1A4A180", Offset = "0x1A4A180", VA = "0x1A4A180")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD97")]
    [Address(RVA = "0x1A4A254", Offset = "0x1A4A254", VA = "0x1A4A254")]
    private void OnSuccess(string json)
    {
    }
  }
}
