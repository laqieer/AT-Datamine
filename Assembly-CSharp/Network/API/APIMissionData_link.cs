// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionData_link
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D71")]
  public class APIMissionData_link
  {
    [Token(Token = "0x4007DC8")]
    public const string DefaultAPIPath = "api/v1/mission/data_link";
    [Token(Token = "0x4007DCC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DCD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMissionData_linkResponse> onSuccess;
    [Token(Token = "0x4007DCE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002217")]
    public APIMissionData_linkRequest Request
    {
      [Token(Token = "0x600ADC1"), Address(RVA = "0x1A4AACC", Offset = "0x1A4AACC", VA = "0x1A4AACC")] private get
      {
        return (APIMissionData_linkRequest) null;
      }
      [Token(Token = "0x600ADC2"), Address(RVA = "0x1A4AAD4", Offset = "0x1A4AAD4", VA = "0x1A4AAD4")] set
      {
      }
    }

    [Token(Token = "0x17002218")]
    public APIMissionData_linkResponse Response
    {
      [Token(Token = "0x600ADC3"), Address(RVA = "0x1A4AADC", Offset = "0x1A4AADC", VA = "0x1A4AADC")] get
      {
        return (APIMissionData_linkResponse) null;
      }
      [Token(Token = "0x600ADC4"), Address(RVA = "0x1A4AAE4", Offset = "0x1A4AAE4", VA = "0x1A4AAE4")] private set
      {
      }
    }

    [Token(Token = "0x17002219")]
    public int ResponseCode
    {
      [Token(Token = "0x600ADC5"), Address(RVA = "0x1A4AAEC", Offset = "0x1A4AAEC", VA = "0x1A4AAEC")] get
      {
        return new int();
      }
      [Token(Token = "0x600ADC6"), Address(RVA = "0x1A4AAF4", Offset = "0x1A4AAF4", VA = "0x1A4AAF4")] private set
      {
      }
    }

    [Token(Token = "0x1700221A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ADC7"), Address(RVA = "0x1A4AAFC", Offset = "0x1A4AAFC", VA = "0x1A4AAFC")] set
      {
      }
      [Token(Token = "0x600ADC8"), Address(RVA = "0x1A4AB18", Offset = "0x1A4AB18", VA = "0x1A4AB18")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ADC9")]
    [Address(RVA = "0x1A4AB34", Offset = "0x1A4AB34", VA = "0x1A4AB34")]
    public APIMissionData_link(string apiPath = "api/v1/mission/data_link")
    {
    }

    [Token(Token = "0x600ADCA")]
    [Address(RVA = "0x1A4ABCC", Offset = "0x1A4ABCC", VA = "0x1A4ABCC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ADCB")]
    [Address(RVA = "0x1A4AC5C", Offset = "0x1A4AC5C", VA = "0x1A4AC5C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ADCC")]
    [Address(RVA = "0x1A4AC68", Offset = "0x1A4AC68", VA = "0x1A4AC68")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ADCD")]
    [Address(RVA = "0x1A4AD3C", Offset = "0x1A4AD3C", VA = "0x1A4AD3C")]
    private void OnSuccess(string json)
    {
    }
  }
}
