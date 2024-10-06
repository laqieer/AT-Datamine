// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_confirmResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F00")]
  [Serializable]
  public class APIWeaponOption_change_confirmResponse
  {
    [Token(Token = "0x4008513")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerGearWeaponType player_weapon;

    [Token(Token = "0x17002640")]
    public PlayerGearWeaponType PlayerWeapon
    {
      [Token(Token = "0x600B829"), Address(RVA = "0x2133474", Offset = "0x2133474", VA = "0x2133474")] get
      {
        return (PlayerGearWeaponType) null;
      }
    }

    [Token(Token = "0x600B82A")]
    [Address(RVA = "0x213347C", Offset = "0x213347C", VA = "0x213347C")]
    public APIWeaponOption_change_confirmResponse()
    {
    }
  }
}
