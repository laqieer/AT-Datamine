// Decompiled with JetBrains decompiler
// Type: Network.API.APIBlockRemoveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB7")]
  [Serializable]
  public class APIBlockRemoveRequest
  {
    [Token(Token = "0x40076CF")]
    [FieldOffset(Offset = "0x10")]
    public string target_player_id;

    [Token(Token = "0x600A2E6")]
    [Address(RVA = "0x46CCE18", Offset = "0x46CCE18", VA = "0x46CCE18")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A2E7")]
    [Address(RVA = "0x46CCE60", Offset = "0x46CCE60", VA = "0x46CCE60")]
    public APIBlockRemoveRequest()
    {
    }
  }
}
