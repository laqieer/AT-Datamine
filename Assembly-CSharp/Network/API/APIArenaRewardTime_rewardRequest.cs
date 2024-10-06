// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaRewardTime_rewardRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B9B")]
  [Serializable]
  public class APIArenaRewardTime_rewardRequest
  {
    [Token(Token = "0x4007662")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;

    [Token(Token = "0x600A23D")]
    [Address(RVA = "0x46CA88C", Offset = "0x46CA88C", VA = "0x46CA88C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A23E")]
    [Address(RVA = "0x46CA8D4", Offset = "0x46CA8D4", VA = "0x46CA8D4")]
    public APIArenaRewardTime_rewardRequest()
    {
    }
  }
}
