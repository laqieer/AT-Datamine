// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnit_rankingPower_rankingRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EE3")]
  [Serializable]
  public class APIUnit_rankingPower_rankingRequest
  {
    [Token(Token = "0x40084A7")]
    [FieldOffset(Offset = "0x10")]
    public int style_id;
    [Token(Token = "0x40084A8")]
    [FieldOffset(Offset = "0x14")]
    public int offset;

    [Token(Token = "0x600B77A")]
    [Address(RVA = "0x2130E78", Offset = "0x2130E78", VA = "0x2130E78")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B77B")]
    [Address(RVA = "0x2130EC0", Offset = "0x2130EC0", VA = "0x2130EC0")]
    public APIUnit_rankingPower_rankingRequest()
    {
    }
  }
}
