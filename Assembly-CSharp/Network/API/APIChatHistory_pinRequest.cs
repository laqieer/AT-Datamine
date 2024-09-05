// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatHistory_pinRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BCB")]
  [Serializable]
  public class APIChatHistory_pinRequest
  {
    [Token(Token = "0x4007717")]
    [FieldOffset(Offset = "0x10")]
    public List<ChatHistoryPinAddRequest> add_requests;
    [Token(Token = "0x4007718")]
    [FieldOffset(Offset = "0x18")]
    public List<string> delete_requests;

    [Token(Token = "0x600A35E")]
    [Address(RVA = "0x46CE8E4", Offset = "0x46CE8E4", VA = "0x46CE8E4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A35F")]
    [Address(RVA = "0x46CE92C", Offset = "0x46CE92C", VA = "0x46CE92C")]
    public APIChatHistory_pinRequest()
    {
    }
  }
}
