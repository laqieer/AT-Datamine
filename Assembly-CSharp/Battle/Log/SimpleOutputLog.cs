// Decompiled with JetBrains decompiler
// Type: Battle.Log.SimpleOutputLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Text;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002513")]
  public sealed class SimpleOutputLog : IOutputLog
  {
    [Token(Token = "0x4009F4B")]
    private const int OmittCount = 6;
    [Token(Token = "0x4009F4C")]
    [FieldOffset(Offset = "0x10")]
    private Func<string> OmittedToken;
    [Token(Token = "0x4009F4D")]
    [FieldOffset(Offset = "0x18")]
    private StringBuilder builder;

    [Token(Token = "0x600E4C4")]
    [Address(RVA = "0x4789378", Offset = "0x4789378", VA = "0x4789378")]
    public SimpleOutputLog(StringBuilder builder)
    {
    }

    [Token(Token = "0x600E4C5")]
    [Address(RVA = "0x478946C", Offset = "0x478946C", VA = "0x478946C", Slot = "4")]
    public string ToText(string text) => (string) null;
  }
}
