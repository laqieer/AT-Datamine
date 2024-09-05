// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattlePowerConstantData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E23")]
  [Serializable]
  public sealed class BattlePowerConstantData : IMasterDataEntity
  {
    [Token(Token = "0x4004353")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004354")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int CoefficientA;
    [Token(Token = "0x4004355")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int CoefficientB;
    [Token(Token = "0x4004356")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int CoefficientC;
    [Token(Token = "0x4004357")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float CoefficientD;
    [Token(Token = "0x4004358")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int CoefficientE;
    [Token(Token = "0x4004359")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float CoefficientF;
    [Token(Token = "0x400435A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float MaxSpRate;
    [Token(Token = "0x400435B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float MinSpRate;
    [Token(Token = "0x400435C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int Adjust;
    [Token(Token = "0x400435D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int HpLevel1;
    [Token(Token = "0x400435E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int HpLevel2;
    [Token(Token = "0x400435F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public float HpRate1;
    [Token(Token = "0x4004360")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public float HpRate2;
    [Token(Token = "0x4004361")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int AdjustA;
    [Token(Token = "0x4004362")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int AdjustB;
    [Token(Token = "0x4004363")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int AdjustC;
    [Token(Token = "0x4004364")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int AdjustD;

    [Token(Token = "0x17000C64")]
    public int Key
    {
      [Token(Token = "0x6005629"), Address(RVA = "0x3E31F44", Offset = "0x3E31F44", VA = "0x3E31F44", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600562A")]
    [Address(RVA = "0x3E31F4C", Offset = "0x3E31F4C", VA = "0x3E31F4C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600562B")]
    [Address(RVA = "0x3E32658", Offset = "0x3E32658", VA = "0x3E32658", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C65")]
    public float[] CoefficientAtoF
    {
      [Token(Token = "0x600562C"), Address(RVA = "0x3E31DC4", Offset = "0x3E31DC4", VA = "0x3E31DC4")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x600562D")]
    [Address(RVA = "0x3E327DC", Offset = "0x3E327DC", VA = "0x3E327DC")]
    public BattlePowerConstantData()
    {
    }
  }
}
