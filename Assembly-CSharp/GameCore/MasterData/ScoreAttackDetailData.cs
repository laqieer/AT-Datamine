// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001133")]
  [Serializable]
  public sealed class ScoreAttackDetailData : IMasterDataEntity
  {
    [Token(Token = "0x40053B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053B3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int difficultyScoreGroupId;
    [Token(Token = "0x40053B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int retreatScoreMax;
    [Token(Token = "0x40053B5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int retreatSubtraction;
    [Token(Token = "0x40053B6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int clearTurnGroupId;
    [Token(Token = "0x40053B7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int maxDamageCoeficientPercentage;
    [Token(Token = "0x40053B8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int takeDamageCoeficient;
    [Token(Token = "0x40053B9")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int dealDamageCoeficientPermillage;
    [Token(Token = "0x40053BA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int useItemGroupId;
    [Token(Token = "0x40053BB")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int breakBarrierCoeficient;
    [Token(Token = "0x40053BC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int breakBarrierScoreMax;
    [Token(Token = "0x40053BD")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int armorBreakBonus;

    [Token(Token = "0x17000ED8")]
    public int Key
    {
      [Token(Token = "0x60062FD"), Address(RVA = "0x4AE43D8", Offset = "0x4AE43D8", VA = "0x4AE43D8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062FE")]
    [Address(RVA = "0x4AE43E0", Offset = "0x4AE43E0", VA = "0x4AE43E0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062FF")]
    [Address(RVA = "0x4AE48AC", Offset = "0x4AE48AC", VA = "0x4AE48AC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006300")]
    [Address(RVA = "0x4AE49D0", Offset = "0x4AE49D0", VA = "0x4AE49D0")]
    public ScoreAttackDetailData()
    {
    }
  }
}
