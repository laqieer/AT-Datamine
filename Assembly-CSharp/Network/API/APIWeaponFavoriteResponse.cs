// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponFavoriteResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF4")]
  [Serializable]
  public class APIWeaponFavoriteResponse
  {
    [Token(Token = "0x40084E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerGearWeaponType> weapons;

    [Token(Token = "0x17002628")]
    public List<PlayerGearWeaponType> Weapons
    {
      [Token(Token = "0x600B7E1"), Address(RVA = "0x2132460", Offset = "0x2132460", VA = "0x2132460")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
    }

    [Token(Token = "0x600B7E2")]
    [Address(RVA = "0x2132468", Offset = "0x2132468", VA = "0x2132468")]
    public APIWeaponFavoriteResponse()
    {
    }
  }
}
