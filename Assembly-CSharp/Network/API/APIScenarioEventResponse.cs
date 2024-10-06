// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD0")]
  [Serializable]
  public class APIScenarioEventResponse
  {
    [Token(Token = "0x4007F5B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerScoreAttackRankingType> score_attack_rankings;

    [Token(Token = "0x17002314")]
    public List<PlayerScoreAttackRankingType> ScoreAttackRankings
    {
      [Token(Token = "0x600B03D"), Address(RVA = "0x1A52D2C", Offset = "0x1A52D2C", VA = "0x1A52D2C")] get
      {
        return (List<PlayerScoreAttackRankingType>) null;
      }
    }

    [Token(Token = "0x600B03E")]
    [Address(RVA = "0x1A52D34", Offset = "0x1A52D34", VA = "0x1A52D34")]
    public APIScenarioEventResponse()
    {
    }
  }
}
