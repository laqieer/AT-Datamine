// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildTransferMasterRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D23")]
  [Serializable]
  public class APIGuildTransferMasterRequest
  {
    [Token(Token = "0x4007C7D")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007C7E")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600ABC7")]
    [Address(RVA = "0x1A44348", Offset = "0x1A44348", VA = "0x1A44348")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ABC8")]
    [Address(RVA = "0x1A44390", Offset = "0x1A44390", VA = "0x1A44390")]
    public APIGuildTransferMasterRequest()
    {
    }
  }
}
