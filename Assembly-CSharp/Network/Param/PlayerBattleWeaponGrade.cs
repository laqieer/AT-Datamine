// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleWeaponGrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A93")]
  [Serializable]
  public class PlayerBattleWeaponGrade
  {
    [Token(Token = "0x40071F4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_gear_weapon_id;
    [Token(Token = "0x40071F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001A38")]
    public string PlayerGearWeaponId
    {
      [Token(Token = "0x600998C"), Address(RVA = "0x48F0A60", Offset = "0x48F0A60", VA = "0x48F0A60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600998D"), Address(RVA = "0x48F0A68", Offset = "0x48F0A68", VA = "0x48F0A68")] set
      {
      }
    }

    [Token(Token = "0x17001A39")]
    public int Experience
    {
      [Token(Token = "0x600998E"), Address(RVA = "0x48F0A70", Offset = "0x48F0A70", VA = "0x48F0A70")] get
      {
        return new int();
      }
      [Token(Token = "0x600998F"), Address(RVA = "0x48F0A78", Offset = "0x48F0A78", VA = "0x48F0A78")] set
      {
      }
    }

    [Token(Token = "0x6009990")]
    [Address(RVA = "0x48F0A80", Offset = "0x48F0A80", VA = "0x48F0A80")]
    public PlayerBattleWeaponGrade()
    {
    }
  }
}
