// Decompiled with JetBrains decompiler
// Type: Network.APIGooglePlayFulfill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A2A")]
  public class APIGooglePlayFulfill
  {
    [Token(Token = "0x1700184F")]
    public APIGooglePlayFulfillRequest Request
    {
      [Token(Token = "0x600954B"), Address(RVA = "0x48ED430", Offset = "0x48ED430", VA = "0x48ED430")] private get
      {
        return (APIGooglePlayFulfillRequest) null;
      }
      [Token(Token = "0x600954C"), Address(RVA = "0x48ED438", Offset = "0x48ED438", VA = "0x48ED438")] set
      {
      }
    }

    [Token(Token = "0x17001850")]
    public APIFulfillResponse Response
    {
      [Token(Token = "0x600954D"), Address(RVA = "0x48ED440", Offset = "0x48ED440", VA = "0x48ED440")] get
      {
        return (APIFulfillResponse) null;
      }
      [Token(Token = "0x600954E"), Address(RVA = "0x48ED448", Offset = "0x48ED448", VA = "0x48ED448")] private set
      {
      }
    }

    [Token(Token = "0x600954F")]
    [Address(RVA = "0x48ED450", Offset = "0x48ED450", VA = "0x48ED450")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009550")]
    [Address(RVA = "0x48ED4E0", Offset = "0x48ED4E0", VA = "0x48ED4E0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009551")]
    [Address(RVA = "0x48ED4EC", Offset = "0x48ED4EC", VA = "0x48ED4EC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009552")]
    [Address(RVA = "0x48ED5C0", Offset = "0x48ED5C0", VA = "0x48ED5C0")]
    public APIGooglePlayFulfill()
    {
    }
  }
}
