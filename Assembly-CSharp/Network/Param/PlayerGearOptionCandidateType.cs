// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearOptionCandidateType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABC")]
  [Serializable]
  public class PlayerGearOptionCandidateType
  {
    [Token(Token = "0x4007296")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int id;
    [Token(Token = "0x4007297")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerGearOptionType> candidates;

    [Token(Token = "0x17001AEC")]
    public int Id
    {
      [Token(Token = "0x6009B0B"), Address(RVA = "0x48F1864", Offset = "0x48F1864", VA = "0x48F1864")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B0C"), Address(RVA = "0x48F186C", Offset = "0x48F186C", VA = "0x48F186C")] set
      {
      }
    }

    [Token(Token = "0x17001AED")]
    public List<PlayerGearOptionType> Candidates
    {
      [Token(Token = "0x6009B0D"), Address(RVA = "0x48F1874", Offset = "0x48F1874", VA = "0x48F1874")] get
      {
        return (List<PlayerGearOptionType>) null;
      }
      [Token(Token = "0x6009B0E"), Address(RVA = "0x48F187C", Offset = "0x48F187C", VA = "0x48F187C")] set
      {
      }
    }

    [Token(Token = "0x6009B0F")]
    [Address(RVA = "0x48F1884", Offset = "0x48F1884", VA = "0x48F1884")]
    public PlayerGearOptionCandidateType()
    {
    }
  }
}
