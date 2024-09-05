// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.WeaponTypeInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004D6")]
  [Serializable]
  public class WeaponTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001954")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private WeaponTypeEnum weaponType;

    [Token(Token = "0x17000368")]
    public WeaponTypeEnum EquipmentType
    {
      [Token(Token = "0x6001B91"), Address(RVA = "0x2C2CC28", Offset = "0x2C2CC28", VA = "0x2C2CC28")] get
      {
        return new WeaponTypeEnum();
      }
    }

    [Token(Token = "0x17000369")]
    public override int Key
    {
      [Token(Token = "0x6001B92"), Address(RVA = "0x2C2CC30", Offset = "0x2C2CC30", VA = "0x2C2CC30", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B93")]
    [Address(RVA = "0x2C2CC38", Offset = "0x2C2CC38", VA = "0x2C2CC38")]
    public WeaponTypeInfo()
    {
    }
  }
}
