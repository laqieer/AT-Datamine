// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000Provide_ratio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C7D")]
  public class APIG0000Provide_ratio
  {
    [Token(Token = "0x40079E7")]
    public const string DefaultAPIPath = "api/gacha/G0000/provide_ratio";
    [Token(Token = "0x40079EB")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079EC")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0000Provide_ratioResponse> onSuccess;
    [Token(Token = "0x40079ED")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FEB")]
    public APIG0000Provide_ratioRequest Request
    {
      [Token(Token = "0x600A7C5"), Address(RVA = "0x190F740", Offset = "0x190F740", VA = "0x190F740")] private get
      {
        return (APIG0000Provide_ratioRequest) null;
      }
      [Token(Token = "0x600A7C6"), Address(RVA = "0x190F748", Offset = "0x190F748", VA = "0x190F748")] set
      {
      }
    }

    [Token(Token = "0x17001FEC")]
    public APIG0000Provide_ratioResponse Response
    {
      [Token(Token = "0x600A7C7"), Address(RVA = "0x190F750", Offset = "0x190F750", VA = "0x190F750")] get
      {
        return (APIG0000Provide_ratioResponse) null;
      }
      [Token(Token = "0x600A7C8"), Address(RVA = "0x190F758", Offset = "0x190F758", VA = "0x190F758")] private set
      {
      }
    }

    [Token(Token = "0x17001FED")]
    public int ResponseCode
    {
      [Token(Token = "0x600A7C9"), Address(RVA = "0x190F760", Offset = "0x190F760", VA = "0x190F760")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7CA"), Address(RVA = "0x190F768", Offset = "0x190F768", VA = "0x190F768")] private set
      {
      }
    }

    [Token(Token = "0x17001FEE")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A7CB"), Address(RVA = "0x190F770", Offset = "0x190F770", VA = "0x190F770")] set
      {
      }
      [Token(Token = "0x600A7CC"), Address(RVA = "0x190F78C", Offset = "0x190F78C", VA = "0x190F78C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A7CD")]
    [Address(RVA = "0x190F7A8", Offset = "0x190F7A8", VA = "0x190F7A8")]
    public APIG0000Provide_ratio(string apiPath = "api/gacha/G0000/provide_ratio")
    {
    }

    [Token(Token = "0x600A7CE")]
    [Address(RVA = "0x190F840", Offset = "0x190F840", VA = "0x190F840")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A7CF")]
    [Address(RVA = "0x190F8D0", Offset = "0x190F8D0", VA = "0x190F8D0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A7D0")]
    [Address(RVA = "0x190F8DC", Offset = "0x190F8DC", VA = "0x190F8DC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A7D1")]
    [Address(RVA = "0x190F9B0", Offset = "0x190F9B0", VA = "0x190F9B0")]
    private void OnSuccess(string json)
    {
    }
  }
}
