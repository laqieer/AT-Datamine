// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.SpeciesTypeInfo
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
  [Token(Token = "0x20004D7")]
  [Serializable]
  public class SpeciesTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001955")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SpeciesTypeEnum speciesTypeEnum;

    [Token(Token = "0x1700036A")]
    public SpeciesTypeEnum SpeciesTypeEnum
    {
      [Token(Token = "0x6001B94"), Address(RVA = "0x2C2CC40", Offset = "0x2C2CC40", VA = "0x2C2CC40")] get
      {
        return new SpeciesTypeEnum();
      }
    }

    [Token(Token = "0x1700036B")]
    public override int Key
    {
      [Token(Token = "0x6001B95"), Address(RVA = "0x2C2CC48", Offset = "0x2C2CC48", VA = "0x2C2CC48", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B96")]
    [Address(RVA = "0x2C2CC50", Offset = "0x2C2CC50", VA = "0x2C2CC50")]
    public SpeciesTypeInfo()
    {
    }
  }
}
