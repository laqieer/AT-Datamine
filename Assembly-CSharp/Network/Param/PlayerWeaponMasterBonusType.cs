// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerWeaponMasterBonusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B04")]
  [Serializable]
  public class PlayerWeaponMasterBonusType
  {
    [Token(Token = "0x4007419")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int weapon_master_id;
    [Token(Token = "0x400741A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001C7B")]
    public int WeaponMasterId
    {
      [Token(Token = "0x6009E65"), Address(RVA = "0x48F3404", Offset = "0x48F3404", VA = "0x48F3404")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E66"), Address(RVA = "0x48F340C", Offset = "0x48F340C", VA = "0x48F340C")] set
      {
      }
    }

    [Token(Token = "0x17001C7C")]
    public int Experience
    {
      [Token(Token = "0x6009E67"), Address(RVA = "0x48F3414", Offset = "0x48F3414", VA = "0x48F3414")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E68"), Address(RVA = "0x48F341C", Offset = "0x48F341C", VA = "0x48F341C")] set
      {
      }
    }

    [Token(Token = "0x6009E69")]
    [Address(RVA = "0x48F3424", Offset = "0x48F3424", VA = "0x48F3424")]
    public PlayerWeaponMasterBonusType()
    {
    }
  }
}
