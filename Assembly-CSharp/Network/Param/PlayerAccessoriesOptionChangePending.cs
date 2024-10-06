// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAccessoriesOptionChangePending
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
  [Token(Token = "0x2001A7C")]
  [Serializable]
  public class PlayerAccessoriesOptionChangePending
  {
    [Token(Token = "0x4007190")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_accessory_id;
    [Token(Token = "0x4007191")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerGearOptionCandidateType> candidates;

    [Token(Token = "0x170019D4")]
    public string PlayerAccessoryId
    {
      [Token(Token = "0x60098AD"), Address(RVA = "0x48F0358", Offset = "0x48F0358", VA = "0x48F0358")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098AE"), Address(RVA = "0x48F0360", Offset = "0x48F0360", VA = "0x48F0360")] set
      {
      }
    }

    [Token(Token = "0x170019D5")]
    public List<PlayerGearOptionCandidateType> Candidates
    {
      [Token(Token = "0x60098AF"), Address(RVA = "0x48F0368", Offset = "0x48F0368", VA = "0x48F0368")] get
      {
        return (List<PlayerGearOptionCandidateType>) null;
      }
      [Token(Token = "0x60098B0"), Address(RVA = "0x48F0370", Offset = "0x48F0370", VA = "0x48F0370")] set
      {
      }
    }

    [Token(Token = "0x60098B1")]
    [Address(RVA = "0x48F0378", Offset = "0x48F0378", VA = "0x48F0378")]
    public PlayerAccessoriesOptionChangePending()
    {
    }
  }
}
