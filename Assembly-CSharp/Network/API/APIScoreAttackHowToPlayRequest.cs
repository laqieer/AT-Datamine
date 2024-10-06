// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackHowToPlayRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DFB")]
  [Serializable]
  public class APIScoreAttackHowToPlayRequest
  {
    [Token(Token = "0x4008067")]
    [FieldOffset(Offset = "0x10")]
    public int score_attack_event_id;

    [Token(Token = "0x600B16B")]
    [Address(RVA = "0x22DC764", Offset = "0x22DC764", VA = "0x22DC764")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B16C")]
    [Address(RVA = "0x22DC7AC", Offset = "0x22DC7AC", VA = "0x22DC7AC")]
    public APIScoreAttackHowToPlayRequest()
    {
    }
  }
}
