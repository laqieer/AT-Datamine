// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerMissionProgressType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ACB")]
  [Serializable]
  public class PlayerMissionProgressType
  {
    [Token(Token = "0x40072CB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int mission_id;
    [Token(Token = "0x40072CC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int progress_denominator;
    [Token(Token = "0x40072CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int progress_numerator;
    [Token(Token = "0x40072CE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool is_accepted;

    [Token(Token = "0x17001B21")]
    public int MissionId
    {
      [Token(Token = "0x6009B84"), Address(RVA = "0x48F1C34", Offset = "0x48F1C34", VA = "0x48F1C34")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B85"), Address(RVA = "0x48F1C3C", Offset = "0x48F1C3C", VA = "0x48F1C3C")] set
      {
      }
    }

    [Token(Token = "0x17001B22")]
    public int ProgressDenominator
    {
      [Token(Token = "0x6009B86"), Address(RVA = "0x48F1C44", Offset = "0x48F1C44", VA = "0x48F1C44")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B87"), Address(RVA = "0x48F1C4C", Offset = "0x48F1C4C", VA = "0x48F1C4C")] set
      {
      }
    }

    [Token(Token = "0x17001B23")]
    public int ProgressNumerator
    {
      [Token(Token = "0x6009B88"), Address(RVA = "0x48F1C54", Offset = "0x48F1C54", VA = "0x48F1C54")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B89"), Address(RVA = "0x48F1C5C", Offset = "0x48F1C5C", VA = "0x48F1C5C")] set
      {
      }
    }

    [Token(Token = "0x17001B24")]
    public bool IsAccepted
    {
      [Token(Token = "0x6009B8A"), Address(RVA = "0x48F1C64", Offset = "0x48F1C64", VA = "0x48F1C64")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009B8B"), Address(RVA = "0x48F1C6C", Offset = "0x48F1C6C", VA = "0x48F1C6C")] set
      {
      }
    }

    [Token(Token = "0x6009B8C")]
    [Address(RVA = "0x48F1C78", Offset = "0x48F1C78", VA = "0x48F1C78")]
    public PlayerMissionProgressType()
    {
    }
  }
}
