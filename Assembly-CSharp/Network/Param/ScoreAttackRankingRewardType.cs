// Decompiled with JetBrains decompiler
// Type: Network.Param.ScoreAttackRankingRewardType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0E")]
  [Serializable]
  public class ScoreAttackRankingRewardType
  {
    [Token(Token = "0x4007439")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x400743A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int high_score;

    [Token(Token = "0x17001C9B")]
    public int Id
    {
      [Token(Token = "0x6009EAF"), Address(RVA = "0x48F3658", Offset = "0x48F3658", VA = "0x48F3658")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EB0"), Address(RVA = "0x48F3660", Offset = "0x48F3660", VA = "0x48F3660")] set
      {
      }
    }

    [Token(Token = "0x17001C9C")]
    public int HighScore
    {
      [Token(Token = "0x6009EB1"), Address(RVA = "0x48F3668", Offset = "0x48F3668", VA = "0x48F3668")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EB2"), Address(RVA = "0x48F3670", Offset = "0x48F3670", VA = "0x48F3670")] set
      {
      }
    }

    [Token(Token = "0x6009EB3")]
    [Address(RVA = "0x48F3678", Offset = "0x48F3678", VA = "0x48F3678")]
    public ScoreAttackRankingRewardType()
    {
    }
  }
}
