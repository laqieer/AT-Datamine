// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatLogRequest
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
  [Token(Token = "0x2001BCF")]
  [Serializable]
  public class APIChatLogRequest
  {
    [Token(Token = "0x4007725")]
    [FieldOffset(Offset = "0x10")]
    public List<ChatLogRequestType> requests;

    [Token(Token = "0x600A375")]
    [Address(RVA = "0x46CEE38", Offset = "0x46CEE38", VA = "0x46CEE38")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A376")]
    [Address(RVA = "0x46CEE80", Offset = "0x46CEE80", VA = "0x46CEE80")]
    public APIChatLogRequest()
    {
    }
  }
}
