// Decompiled with JetBrains decompiler
// Type: Network.APIAppStoreFulfill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A24")]
  public class APIAppStoreFulfill
  {
    [Token(Token = "0x1700184B")]
    public APIAppStoreFulfillRequest Request
    {
      [Token(Token = "0x6009538"), Address(RVA = "0x48ED08C", Offset = "0x48ED08C", VA = "0x48ED08C")] private get
      {
        return (APIAppStoreFulfillRequest) null;
      }
      [Token(Token = "0x6009539"), Address(RVA = "0x48ED094", Offset = "0x48ED094", VA = "0x48ED094")] set
      {
      }
    }

    [Token(Token = "0x1700184C")]
    public APIFulfillResponse Response
    {
      [Token(Token = "0x600953A"), Address(RVA = "0x48ED09C", Offset = "0x48ED09C", VA = "0x48ED09C")] get
      {
        return (APIFulfillResponse) null;
      }
      [Token(Token = "0x600953B"), Address(RVA = "0x48ED0A4", Offset = "0x48ED0A4", VA = "0x48ED0A4")] private set
      {
      }
    }

    [Token(Token = "0x600953C")]
    [Address(RVA = "0x48ED0AC", Offset = "0x48ED0AC", VA = "0x48ED0AC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600953D")]
    [Address(RVA = "0x48ED13C", Offset = "0x48ED13C", VA = "0x48ED13C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600953E")]
    [Address(RVA = "0x48ED148", Offset = "0x48ED148", VA = "0x48ED148")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600953F")]
    [Address(RVA = "0x48ED21C", Offset = "0x48ED21C", VA = "0x48ED21C")]
    public APIAppStoreFulfill()
    {
    }
  }
}
