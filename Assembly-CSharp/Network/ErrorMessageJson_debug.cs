// Decompiled with JetBrains decompiler
// Type: Network.ErrorMessageJson_debug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A04")]
  [Serializable]
  public class ErrorMessageJson_debug
  {
    [Token(Token = "0x4006F5C")]
    [FieldOffset(Offset = "0x10")]
    public ErrorMessageJson_debug_info debug_info;
    [Token(Token = "0x4006F5D")]
    [FieldOffset(Offset = "0x18")]
    public string message;
    [Token(Token = "0x4006F5E")]
    [FieldOffset(Offset = "0x20")]
    public string stack;

    [Token(Token = "0x6009468")]
    [Address(RVA = "0x4D15F74", Offset = "0x4D15F74", VA = "0x4D15F74")]
    public ErrorMessageJson_debug()
    {
    }
  }
}
