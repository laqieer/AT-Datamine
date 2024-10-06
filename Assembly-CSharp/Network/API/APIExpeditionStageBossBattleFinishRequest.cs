// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossBattleFinishRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C37")]
  [Serializable]
  public class APIExpeditionStageBossBattleFinishRequest
  {
    [Token(Token = "0x40078D0")]
    [FieldOffset(Offset = "0x10")]
    public int stage_id;
    [Token(Token = "0x40078D1")]
    [FieldOffset(Offset = "0x14")]
    public int boss_level;
    [Token(Token = "0x40078D2")]
    [FieldOffset(Offset = "0x18")]
    public int boss_challenge_type_id;

    [Token(Token = "0x600A613")]
    [Address(RVA = "0x1909B14", Offset = "0x1909B14", VA = "0x1909B14")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A614")]
    [Address(RVA = "0x1909B5C", Offset = "0x1909B5C", VA = "0x1909B5C")]
    public APIExpeditionStageBossBattleFinishRequest()
    {
    }
  }
}
