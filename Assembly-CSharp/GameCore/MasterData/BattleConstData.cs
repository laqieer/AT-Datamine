// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2F")]
  [Serializable]
  public sealed class BattleConstData : IMasterDataEntity
  {
    [Token(Token = "0x40043AA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043AB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int BattleRollbackSaveTurnCount;
    [Token(Token = "0x40043AC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int BattleRollbackFreeCount;
    [Token(Token = "0x40043AD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int BattleRollbackPaymentAmount;
    [Token(Token = "0x40043AE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float FastModeSpeed;
    [Token(Token = "0x40043AF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int IncreaseSupportValueBySkill;
    [Token(Token = "0x40043B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int IncreaseSupportValueByClear;
    [Token(Token = "0x40043B1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int DecreaseSupportValueByDead;

    [Token(Token = "0x17000C6F")]
    public int Key
    {
      [Token(Token = "0x6005663"), Address(RVA = "0x3E3571C", Offset = "0x3E3571C", VA = "0x3E3571C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005664")]
    [Address(RVA = "0x3E35724", Offset = "0x3E35724", VA = "0x3E35724", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005665")]
    [Address(RVA = "0x3E35A70", Offset = "0x3E35A70", VA = "0x3E35A70", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005666")]
    [Address(RVA = "0x3E35B54", Offset = "0x3E35B54", VA = "0x3E35B54")]
    public BattleConstData()
    {
    }
  }
}
