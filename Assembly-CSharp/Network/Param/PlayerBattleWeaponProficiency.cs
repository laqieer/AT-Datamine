// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleWeaponProficiency
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A94")]
  [Serializable]
  public class PlayerBattleWeaponProficiency
  {
    [Token(Token = "0x40071F6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x40071F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int weapon_type;
    [Token(Token = "0x40071F8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001A3A")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009991"), Address(RVA = "0x48F0A88", Offset = "0x48F0A88", VA = "0x48F0A88")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009992"), Address(RVA = "0x48F0A90", Offset = "0x48F0A90", VA = "0x48F0A90")] set
      {
      }
    }

    [Token(Token = "0x17001A3B")]
    public int WeaponType
    {
      [Token(Token = "0x6009993"), Address(RVA = "0x48F0A98", Offset = "0x48F0A98", VA = "0x48F0A98")] get
      {
        return new int();
      }
      [Token(Token = "0x6009994"), Address(RVA = "0x48F0AA0", Offset = "0x48F0AA0", VA = "0x48F0AA0")] set
      {
      }
    }

    [Token(Token = "0x17001A3C")]
    public int Experience
    {
      [Token(Token = "0x6009995"), Address(RVA = "0x48F0AA8", Offset = "0x48F0AA8", VA = "0x48F0AA8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009996"), Address(RVA = "0x48F0AB0", Offset = "0x48F0AB0", VA = "0x48F0AB0")] set
      {
      }
    }

    [Token(Token = "0x6009997")]
    [Address(RVA = "0x48F0AB8", Offset = "0x48F0AB8", VA = "0x48F0AB8")]
    public PlayerBattleWeaponProficiency()
    {
    }
  }
}
