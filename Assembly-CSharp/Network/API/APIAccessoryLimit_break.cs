// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryLimit_break
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B3D")]
  public class APIAccessoryLimit_break
  {
    [Token(Token = "0x40074D9")]
    public const string DefaultAPIPath = "api/v1/accessory/limit_break";
    [Token(Token = "0x40074DD")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40074DE")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryLimit_breakResponse> onSuccess;
    [Token(Token = "0x40074DF")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D0F")]
    public APIAccessoryLimit_breakRequest Request
    {
      [Token(Token = "0x6009FE9"), Address(RVA = "0x46C278C", Offset = "0x46C278C", VA = "0x46C278C")] private get
      {
        return (APIAccessoryLimit_breakRequest) null;
      }
      [Token(Token = "0x6009FEA"), Address(RVA = "0x46C2794", Offset = "0x46C2794", VA = "0x46C2794")] set
      {
      }
    }

    [Token(Token = "0x17001D10")]
    public APIAccessoryLimit_breakResponse Response
    {
      [Token(Token = "0x6009FEB"), Address(RVA = "0x46C279C", Offset = "0x46C279C", VA = "0x46C279C")] get
      {
        return (APIAccessoryLimit_breakResponse) null;
      }
      [Token(Token = "0x6009FEC"), Address(RVA = "0x46C27A4", Offset = "0x46C27A4", VA = "0x46C27A4")] private set
      {
      }
    }

    [Token(Token = "0x17001D11")]
    public int ResponseCode
    {
      [Token(Token = "0x6009FED"), Address(RVA = "0x46C27AC", Offset = "0x46C27AC", VA = "0x46C27AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009FEE"), Address(RVA = "0x46C27B4", Offset = "0x46C27B4", VA = "0x46C27B4")] private set
      {
      }
    }

    [Token(Token = "0x17001D12")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x6009FEF"), Address(RVA = "0x46C27BC", Offset = "0x46C27BC", VA = "0x46C27BC")] set
      {
      }
      [Token(Token = "0x6009FF0"), Address(RVA = "0x46C27D8", Offset = "0x46C27D8", VA = "0x46C27D8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x6009FF1")]
    [Address(RVA = "0x46C27F4", Offset = "0x46C27F4", VA = "0x46C27F4")]
    public APIAccessoryLimit_break(string apiPath = "api/v1/accessory/limit_break")
    {
    }

    [Token(Token = "0x6009FF2")]
    [Address(RVA = "0x46C288C", Offset = "0x46C288C", VA = "0x46C288C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009FF3")]
    [Address(RVA = "0x46C291C", Offset = "0x46C291C", VA = "0x46C291C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009FF4")]
    [Address(RVA = "0x46C2928", Offset = "0x46C2928", VA = "0x46C2928")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009FF5")]
    [Address(RVA = "0x46C29FC", Offset = "0x46C29FC", VA = "0x46C29FC")]
    private void OnSuccess(string json)
    {
    }
  }
}
