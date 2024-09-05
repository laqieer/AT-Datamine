// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.ArmorTypeInfo
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
  [Token(Token = "0x20004D8")]
  [Serializable]
  public class ArmorTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001956")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArmorTypeEnum armorTypeEnum;

    [Token(Token = "0x1700036C")]
    public ArmorTypeEnum ArmorTypeEnum
    {
      [Token(Token = "0x6001B97"), Address(RVA = "0x2C2CC58", Offset = "0x2C2CC58", VA = "0x2C2CC58")] get
      {
        return new ArmorTypeEnum();
      }
    }

    [Token(Token = "0x1700036D")]
    public override int Key
    {
      [Token(Token = "0x6001B98"), Address(RVA = "0x2C2CC60", Offset = "0x2C2CC60", VA = "0x2C2CC60", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B99")]
    [Address(RVA = "0x2C2CC68", Offset = "0x2C2CC68", VA = "0x2C2CC68")]
    public ArmorTypeInfo()
    {
    }
  }
}
