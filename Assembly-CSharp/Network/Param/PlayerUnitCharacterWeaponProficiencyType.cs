// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitCharacterWeaponProficiencyType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF6")]
  [Serializable]
  public class PlayerUnitCharacterWeaponProficiencyType
  {
    [Token(Token = "0x40073BD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int weapon_type;
    [Token(Token = "0x40073BE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001C1F")]
    public int WeaponType
    {
      [Token(Token = "0x6009D9F"), Address(RVA = "0x48F2DA8", Offset = "0x48F2DA8", VA = "0x48F2DA8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DA0"), Address(RVA = "0x48F2DB0", Offset = "0x48F2DB0", VA = "0x48F2DB0")] set
      {
      }
    }

    [Token(Token = "0x17001C20")]
    public int Experience
    {
      [Token(Token = "0x6009DA1"), Address(RVA = "0x48F2DB8", Offset = "0x48F2DB8", VA = "0x48F2DB8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DA2"), Address(RVA = "0x48F2DC0", Offset = "0x48F2DC0", VA = "0x48F2DC0")] set
      {
      }
    }

    [Token(Token = "0x6009DA3")]
    [Address(RVA = "0x48F2DC8", Offset = "0x48F2DC8", VA = "0x48F2DC8")]
    public PlayerUnitCharacterWeaponProficiencyType()
    {
    }
  }
}
