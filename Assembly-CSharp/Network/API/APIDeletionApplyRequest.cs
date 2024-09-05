// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeletionApplyRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C07")]
  [Serializable]
  public class APIDeletionApplyRequest
  {
    [Token(Token = "0x40077FA")]
    [FieldOffset(Offset = "0x10")]
    public string flow_token;
    [Token(Token = "0x40077FB")]
    [FieldOffset(Offset = "0x18")]
    public int last_confirm_time;

    [Token(Token = "0x600A4C9")]
    [Address(RVA = "0x46D3960", Offset = "0x46D3960", VA = "0x46D3960")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A4CA")]
    [Address(RVA = "0x46D39A8", Offset = "0x46D39A8", VA = "0x46D39A8")]
    public APIDeletionApplyRequest()
    {
    }
  }
}
