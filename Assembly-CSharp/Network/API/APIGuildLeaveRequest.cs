// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildLeaveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CFF")]
  [Serializable]
  public class APIGuildLeaveRequest
  {
    [Token(Token = "0x4007BDE")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AAE5")]
    [Address(RVA = "0x1A412BC", Offset = "0x1A412BC", VA = "0x1A412BC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AAE6")]
    [Address(RVA = "0x1A41304", Offset = "0x1A41304", VA = "0x1A41304")]
    public APIGuildLeaveRequest()
    {
    }
  }
}
