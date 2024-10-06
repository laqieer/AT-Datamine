// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryCoinRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D7F")]
  [Serializable]
  public class APIPlayerApRecoveryCoinRequest
  {
    [Token(Token = "0x4007DF9")]
    [FieldOffset(Offset = "0x10")]
    public int recovery_count;
    [Token(Token = "0x4007DFA")]
    [FieldOffset(Offset = "0x14")]
    public int now_ap;

    [Token(Token = "0x600AE19")]
    [Address(RVA = "0x1A4BFAC", Offset = "0x1A4BFAC", VA = "0x1A4BFAC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE1A")]
    [Address(RVA = "0x1A4BFF4", Offset = "0x1A4BFF4", VA = "0x1A4BFF4")]
    public APIPlayerApRecoveryCoinRequest()
    {
    }
  }
}
