// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleHistoryRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B87")]
  [Serializable]
  public class APIArenaBattleHistoryRequest
  {
    [Token(Token = "0x400760F")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;

    [Token(Token = "0x600A1BA")]
    [Address(RVA = "0x46C8D68", Offset = "0x46C8D68", VA = "0x46C8D68")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A1BB")]
    [Address(RVA = "0x46C8DB0", Offset = "0x46C8DB0", VA = "0x46C8DB0")]
    public APIArenaBattleHistoryRequest()
    {
    }
  }
}
