// Decompiled with JetBrains decompiler
// Type: Network.ErrorMessageJson
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A01")]
  [Serializable]
  public class ErrorMessageJson
  {
    [Token(Token = "0x4006F55")]
    [FieldOffset(Offset = "0x10")]
    public ErrorMessageJson_debug __debug__;
    [Token(Token = "0x4006F56")]
    [FieldOffset(Offset = "0x18")]
    public string error_code;
    [Token(Token = "0x4006F57")]
    [FieldOffset(Offset = "0x20")]
    public ExtraInfoJson extra_info;
    [Token(Token = "0x4006F58")]
    [FieldOffset(Offset = "0x28")]
    public ExtraStatusCodeJson extra;

    [Token(Token = "0x6009465")]
    [Address(RVA = "0x4D15EB0", Offset = "0x4D15EB0", VA = "0x4D15EB0")]
    public ErrorMessageJson()
    {
    }
  }
}
