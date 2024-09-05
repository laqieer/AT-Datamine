// Decompiled with JetBrains decompiler
// Type: Network.ExtraInfoJson
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A02")]
  [Serializable]
  public class ExtraInfoJson
  {
    [Token(Token = "0x4006F59")]
    [FieldOffset(Offset = "0x10")]
    public string ban_expires_at;
    [Token(Token = "0x4006F5A")]
    [FieldOffset(Offset = "0x18")]
    public string reason_code;

    [Token(Token = "0x6009466")]
    [Address(RVA = "0x4D15FDC", Offset = "0x4D15FDC", VA = "0x4D15FDC")]
    public ExtraInfoJson()
    {
    }
  }
}
