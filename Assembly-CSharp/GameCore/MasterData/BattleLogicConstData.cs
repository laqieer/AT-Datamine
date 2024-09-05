// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleLogicConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E31")]
  [Serializable]
  public sealed class BattleLogicConstData : IMasterDataEntity
  {
    [Token(Token = "0x40043B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043B4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int MinDamage;
    [Token(Token = "0x40043B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int MaxDamage;
    [Token(Token = "0x40043B6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int BasicHealCoefficientX;
    [Token(Token = "0x40043B7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int BasicHealCoefficientY;
    [Token(Token = "0x40043B8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int BasicHealCoefficientZ;
    [Token(Token = "0x40043B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int DamageOffsetAdjustValueA;
    [Token(Token = "0x40043BA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int DamageOffsetAdjustValueB;
    [Token(Token = "0x40043BB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int DamageOffsetAdjustValueC;
    [Token(Token = "0x40043BC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int DamageOffsetAdjustValueD;
    [Token(Token = "0x40043BD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int SupportAdjustValueA;
    [Token(Token = "0x40043BE")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int SupportAdjustValueB;
    [Token(Token = "0x40043BF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int SupportAdjustValueC;
    [Token(Token = "0x40043C0")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int SupportAdjustValueD;
    [Token(Token = "0x40043C1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int EnhanceRateAdjustValueA;
    [Token(Token = "0x40043C2")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int EnhanceRateAdjustValueB;
    [Token(Token = "0x40043C3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int EnhanceRateAdjustValueC;
    [Token(Token = "0x40043C4")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int EnhanceRateAdjustValueD;
    [Token(Token = "0x40043C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int EnhanceRateAdjustValueE;
    [Token(Token = "0x40043C6")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int EnhanceRateAdjustValueF;
    [Token(Token = "0x40043C7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int EnhanceRateAdjustValueG;
    [Token(Token = "0x40043C8")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int EnhanceRateAdjustValueH;
    [Token(Token = "0x40043C9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int ChanceOffsetAdjustValueA;
    [Token(Token = "0x40043CA")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int ChanceOffsetAdjustValueB;
    [Token(Token = "0x40043CB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int ChanceOffsetAdjustValueC;
    [Token(Token = "0x40043CC")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int ChanceOffsetAdjustValueD;
    [Token(Token = "0x40043CD")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int DoubleStatusAdjustValue;
    [Token(Token = "0x40043CE")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int LoadWeightCoefficient;
    [Token(Token = "0x40043CF")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int ElementAdvantageRate;
    [Token(Token = "0x40043D0")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int ElementDisadvantageRate;
    [Token(Token = "0x40043D1")]
    [FieldOffset(Offset = "0x88")]
    private int[] chanceOffsetAdjustTable;
    [Token(Token = "0x40043D2")]
    [FieldOffset(Offset = "0x90")]
    private int[] damageOffsetAdjustTable;

    [Token(Token = "0x17000C70")]
    public int Key
    {
      [Token(Token = "0x600566D"), Address(RVA = "0x3E35DCC", Offset = "0x3E35DCC", VA = "0x3E35DCC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600566E")]
    [Address(RVA = "0x3E35DD4", Offset = "0x3E35DD4", VA = "0x3E35DD4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600566F")]
    [Address(RVA = "0x3E36960", Offset = "0x3E36960", VA = "0x3E36960", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005670")]
    [Address(RVA = "0x3E35C48", Offset = "0x3E35C48", VA = "0x3E35C48")]
    public void Setup()
    {
    }

    [Token(Token = "0x17000C71")]
    public int[] ChanceOffsetAdjustTable
    {
      [Token(Token = "0x6005671"), Address(RVA = "0x3E36BA4", Offset = "0x3E36BA4", VA = "0x3E36BA4")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x17000C72")]
    public int[] DamageOffsetAdjustTable
    {
      [Token(Token = "0x6005672"), Address(RVA = "0x3E36BAC", Offset = "0x3E36BAC", VA = "0x3E36BAC")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x6005673")]
    [Address(RVA = "0x3E36BB4", Offset = "0x3E36BB4", VA = "0x3E36BB4")]
    public BattleLogicConstData()
    {
    }
  }
}
