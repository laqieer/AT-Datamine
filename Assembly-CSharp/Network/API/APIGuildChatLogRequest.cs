// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatLogRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CAF")]
  [Serializable]
  public class APIGuildChatLogRequest
  {
    [Token(Token = "0x4007AA8")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007AA9")]
    [FieldOffset(Offset = "0x18")]
    public string latest_message_id;

    [Token(Token = "0x600A8FD")]
    [Address(RVA = "0x1913CAC", Offset = "0x1913CAC", VA = "0x1913CAC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A8FE")]
    [Address(RVA = "0x1913CF4", Offset = "0x1913CF4", VA = "0x1913CF4")]
    public APIGuildChatLogRequest()
    {
    }
  }
}
