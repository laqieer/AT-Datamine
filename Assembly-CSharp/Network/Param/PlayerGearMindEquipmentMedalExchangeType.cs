// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearMindEquipmentMedalExchangeType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABA")]
  [Serializable]
  public class PlayerGearMindEquipmentMedalExchangeType
  {
    [Token(Token = "0x400728D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_mind_equipment_id;
    [Token(Token = "0x400728E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int count;

    [Token(Token = "0x17001AE3")]
    public string PlayerMindEquipmentId
    {
      [Token(Token = "0x6009AF7"), Address(RVA = "0x48F17C0", Offset = "0x48F17C0", VA = "0x48F17C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AF8"), Address(RVA = "0x48F17C8", Offset = "0x48F17C8", VA = "0x48F17C8")] set
      {
      }
    }

    [Token(Token = "0x17001AE4")]
    public int Count
    {
      [Token(Token = "0x6009AF9"), Address(RVA = "0x48F17D0", Offset = "0x48F17D0", VA = "0x48F17D0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AFA"), Address(RVA = "0x48F17D8", Offset = "0x48F17D8", VA = "0x48F17D8")] set
      {
      }
    }

    [Token(Token = "0x6009AFB")]
    [Address(RVA = "0x48F17E0", Offset = "0x48F17E0", VA = "0x48F17E0")]
    public PlayerGearMindEquipmentMedalExchangeType()
    {
    }
  }
}
