// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDTokenRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019CC")]
  [Serializable]
  public class APIDascFgGIDTokenRequest
  {
    [Token(Token = "0x4006EB2")]
    [FieldOffset(Offset = "0x10")]
    public string code;
    [Token(Token = "0x4006EB3")]
    [FieldOffset(Offset = "0x18")]
    public string state;

    [Token(Token = "0x6009363")]
    [Address(RVA = "0x4D115C4", Offset = "0x4D115C4", VA = "0x4D115C4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009364")]
    [Address(RVA = "0x4D1160C", Offset = "0x4D1160C", VA = "0x4D1160C")]
    public APIDascFgGIDTokenRequest()
    {
    }
  }
}
