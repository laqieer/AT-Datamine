// Decompiled with JetBrains decompiler
// Type: Network.API.APIMind_equipmentFavoriteResponse
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
  [Token(Token = "0x2001D5C")]
  [Serializable]
  public class APIMind_equipmentFavoriteResponse
  {
    [Token(Token = "0x4007D6B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerGearMindEquipmentType> player_mind_equipments;

    [Token(Token = "0x170021DA")]
    public List<PlayerGearMindEquipmentType> PlayerMindEquipments
    {
      [Token(Token = "0x600AD33"), Address(RVA = "0x1A48F50", Offset = "0x1A48F50", VA = "0x1A48F50")] get
      {
        return (List<PlayerGearMindEquipmentType>) null;
      }
    }

    [Token(Token = "0x600AD34")]
    [Address(RVA = "0x1A48F58", Offset = "0x1A48F58", VA = "0x1A48F58")]
    public APIMind_equipmentFavoriteResponse()
    {
    }
  }
}
