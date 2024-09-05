// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.RideTypeInfo
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
  [Token(Token = "0x20004DA")]
  [Serializable]
  public class RideTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001958")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RideTypeEnum rideTypeEnum;

    [Token(Token = "0x17000370")]
    public RideTypeEnum RideTypeEnum
    {
      [Token(Token = "0x6001B9D"), Address(RVA = "0x2C2CC88", Offset = "0x2C2CC88", VA = "0x2C2CC88")] get
      {
        return new RideTypeEnum();
      }
    }

    [Token(Token = "0x17000371")]
    public override int Key
    {
      [Token(Token = "0x6001B9E"), Address(RVA = "0x2C2CC90", Offset = "0x2C2CC90", VA = "0x2C2CC90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B9F")]
    [Address(RVA = "0x2C2CC98", Offset = "0x2C2CC98", VA = "0x2C2CC98")]
    public RideTypeInfo()
    {
    }
  }
}
