// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestSendRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF7")]
  [Serializable]
  public class APIGuildJoinRequestSendRequest
  {
    [Token(Token = "0x4007BC3")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AAB7")]
    [Address(RVA = "0x1919D64", Offset = "0x1919D64", VA = "0x1919D64")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AAB8")]
    [Address(RVA = "0x1919DAC", Offset = "0x1919DAC", VA = "0x1919DAC")]
    public APIGuildJoinRequestSendRequest()
    {
    }
  }
}
