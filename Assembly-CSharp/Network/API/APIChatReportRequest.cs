// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatReportRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BD7")]
  [Serializable]
  public class APIChatReportRequest
  {
    [Token(Token = "0x4007742")]
    [FieldOffset(Offset = "0x10")]
    public string player_id;
    [Token(Token = "0x4007743")]
    [FieldOffset(Offset = "0x18")]
    public int reason_type_id;
    [Token(Token = "0x4007744")]
    [FieldOffset(Offset = "0x20")]
    public string reason_content;

    [Token(Token = "0x600A3A3")]
    [Address(RVA = "0x46CF8E0", Offset = "0x46CF8E0", VA = "0x46CF8E0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A3A4")]
    [Address(RVA = "0x46CF928", Offset = "0x46CF928", VA = "0x46CF928")]
    public APIChatReportRequest()
    {
    }
  }
}
