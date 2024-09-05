// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0001Pay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C85")]
  public class APIG0001Pay
  {
    [Token(Token = "0x4007A06")]
    public const string DefaultAPIPath = "api/gacha/G0001/pay";
    [Token(Token = "0x4007A0A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A0B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0001PayResponse> onSuccess;
    [Token(Token = "0x4007A0C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FFE")]
    public APIG0001PayRequest Request
    {
      [Token(Token = "0x600A7F8"), Address(RVA = "0x1910210", Offset = "0x1910210", VA = "0x1910210")] private get
      {
        return (APIG0001PayRequest) null;
      }
      [Token(Token = "0x600A7F9"), Address(RVA = "0x1910218", Offset = "0x1910218", VA = "0x1910218")] set
      {
      }
    }

    [Token(Token = "0x17001FFF")]
    public APIG0001PayResponse Response
    {
      [Token(Token = "0x600A7FA"), Address(RVA = "0x1910220", Offset = "0x1910220", VA = "0x1910220")] get
      {
        return (APIG0001PayResponse) null;
      }
      [Token(Token = "0x600A7FB"), Address(RVA = "0x1910228", Offset = "0x1910228", VA = "0x1910228")] private set
      {
      }
    }

    [Token(Token = "0x17002000")]
    public int ResponseCode
    {
      [Token(Token = "0x600A7FC"), Address(RVA = "0x1910230", Offset = "0x1910230", VA = "0x1910230")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7FD"), Address(RVA = "0x1910238", Offset = "0x1910238", VA = "0x1910238")] private set
      {
      }
    }

    [Token(Token = "0x17002001")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A7FE"), Address(RVA = "0x1910240", Offset = "0x1910240", VA = "0x1910240")] set
      {
      }
      [Token(Token = "0x600A7FF"), Address(RVA = "0x191025C", Offset = "0x191025C", VA = "0x191025C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A800")]
    [Address(RVA = "0x1910278", Offset = "0x1910278", VA = "0x1910278")]
    public APIG0001Pay(string apiPath = "api/gacha/G0001/pay")
    {
    }

    [Token(Token = "0x600A801")]
    [Address(RVA = "0x1910310", Offset = "0x1910310", VA = "0x1910310")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A802")]
    [Address(RVA = "0x19103A0", Offset = "0x19103A0", VA = "0x19103A0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A803")]
    [Address(RVA = "0x19103AC", Offset = "0x19103AC", VA = "0x19103AC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A804")]
    [Address(RVA = "0x1910480", Offset = "0x1910480", VA = "0x1910480")]
    private void OnSuccess(string json)
    {
    }
  }
}
