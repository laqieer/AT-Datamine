// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DEF")]
  [Serializable]
  public class APIScoreAttackRequest
  {
    [Token(Token = "0x4008029")]
    [FieldOffset(Offset = "0x10")]
    public int score_attack_event_id;

    [Token(Token = "0x600B11C")]
    [Address(RVA = "0x22DB718", Offset = "0x22DB718", VA = "0x22DB718")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B11D")]
    [Address(RVA = "0x22DB760", Offset = "0x22DB760", VA = "0x22DB760")]
    public APIScoreAttackRequest()
    {
    }
  }
}
