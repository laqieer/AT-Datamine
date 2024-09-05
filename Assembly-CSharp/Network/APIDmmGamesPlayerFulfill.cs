// Decompiled with JetBrains decompiler
// Type: Network.APIDmmGamesPlayerFulfill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A32")]
  public class APIDmmGamesPlayerFulfill
  {
    [Token(Token = "0x4007019")]
    private const string API_PATH = "pas/dmmgamesstore/v2/fulfill";

    [Token(Token = "0x17001855")]
    public APIDmmGamesPlayerFulfillRequest Request
    {
      [Token(Token = "0x6009565"), Address(RVA = "0x48ED9A0", Offset = "0x48ED9A0", VA = "0x48ED9A0")] private get
      {
        return (APIDmmGamesPlayerFulfillRequest) null;
      }
      [Token(Token = "0x6009566"), Address(RVA = "0x48ED9A8", Offset = "0x48ED9A8", VA = "0x48ED9A8")] set
      {
      }
    }

    [Token(Token = "0x17001856")]
    public APIDmmGamesPlayerFulfillResponse Response
    {
      [Token(Token = "0x6009567"), Address(RVA = "0x48ED9B0", Offset = "0x48ED9B0", VA = "0x48ED9B0")] get
      {
        return (APIDmmGamesPlayerFulfillResponse) null;
      }
      [Token(Token = "0x6009568"), Address(RVA = "0x48ED9B8", Offset = "0x48ED9B8", VA = "0x48ED9B8")] private set
      {
      }
    }

    [Token(Token = "0x6009569")]
    [Address(RVA = "0x48ED9C0", Offset = "0x48ED9C0", VA = "0x48ED9C0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600956A")]
    [Address(RVA = "0x48ED9CC", Offset = "0x48ED9CC", VA = "0x48ED9CC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600956B")]
    [Address(RVA = "0x48EDAA0", Offset = "0x48EDAA0", VA = "0x48EDAA0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600956C")]
    [Address(RVA = "0x48EDB30", Offset = "0x48EDB30", VA = "0x48EDB30")]
    public APIDmmGamesPlayerFulfill()
    {
    }
  }
}
