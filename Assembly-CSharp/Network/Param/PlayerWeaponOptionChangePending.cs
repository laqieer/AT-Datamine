// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerWeaponOptionChangePending
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
  [Token(Token = "0x2001B05")]
  [Serializable]
  public class PlayerWeaponOptionChangePending
  {
    [Token(Token = "0x400741B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_weapon_id;
    [Token(Token = "0x400741C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerGearOptionCandidateType> candidates;

    [Token(Token = "0x17001C7D")]
    public string PlayerWeaponId
    {
      [Token(Token = "0x6009E6A"), Address(RVA = "0x48F342C", Offset = "0x48F342C", VA = "0x48F342C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E6B"), Address(RVA = "0x48F3434", Offset = "0x48F3434", VA = "0x48F3434")] set
      {
      }
    }

    [Token(Token = "0x17001C7E")]
    public List<PlayerGearOptionCandidateType> Candidates
    {
      [Token(Token = "0x6009E6C"), Address(RVA = "0x48F343C", Offset = "0x48F343C", VA = "0x48F343C")] get
      {
        return (List<PlayerGearOptionCandidateType>) null;
      }
      [Token(Token = "0x6009E6D"), Address(RVA = "0x48F3444", Offset = "0x48F3444", VA = "0x48F3444")] set
      {
      }
    }

    [Token(Token = "0x6009E6E")]
    [Address(RVA = "0x48F344C", Offset = "0x48F344C", VA = "0x48F344C")]
    public PlayerWeaponOptionChangePending()
    {
    }
  }
}
