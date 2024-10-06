// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B22")]
  public class APIAuthRegister
  {
    [Token(Token = "0x17001CF0")]
    public APIAuthRegisterRequest Request
    {
      [Token(Token = "0x6009F74"), Address(RVA = "0x46BFE44", Offset = "0x46BFE44", VA = "0x46BFE44")] private get
      {
        return (APIAuthRegisterRequest) null;
      }
      [Token(Token = "0x6009F75"), Address(RVA = "0x46BFE4C", Offset = "0x46BFE4C", VA = "0x46BFE4C")] set
      {
      }
    }

    [Token(Token = "0x17001CF1")]
    public APIAuthRegisterResponse Response
    {
      [Token(Token = "0x6009F76"), Address(RVA = "0x46BFE54", Offset = "0x46BFE54", VA = "0x46BFE54")] get
      {
        return (APIAuthRegisterResponse) null;
      }
      [Token(Token = "0x6009F77"), Address(RVA = "0x46BFE5C", Offset = "0x46BFE5C", VA = "0x46BFE5C")] private set
      {
      }
    }

    [Token(Token = "0x17001CF2")]
    public int ResponseCode
    {
      [Token(Token = "0x6009F78"), Address(RVA = "0x46BFE64", Offset = "0x46BFE64", VA = "0x46BFE64")] get
      {
        return new int();
      }
      [Token(Token = "0x6009F79"), Address(RVA = "0x46BFE6C", Offset = "0x46BFE6C", VA = "0x46BFE6C")] private set
      {
      }
    }

    [Token(Token = "0x6009F7A")]
    [Address(RVA = "0x46BFE74", Offset = "0x46BFE74", VA = "0x46BFE74")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009F7B")]
    [Address(RVA = "0x46BFF04", Offset = "0x46BFF04", VA = "0x46BFF04")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009F7C")]
    [Address(RVA = "0x46BFF10", Offset = "0x46BFF10", VA = "0x46BFF10")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009F7D")]
    [Address(RVA = "0x46BFFE4", Offset = "0x46BFFE4", VA = "0x46BFFE4")]
    public APIAuthRegister()
    {
    }
  }
}
