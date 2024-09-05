// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFailedConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E15")]
  [Serializable]
  public sealed class BattleFailedConditionData : IMasterDataEntity
  {
    [Token(Token = "0x400431A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400431B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x400431C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum op;
    [Token(Token = "0x400431D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleFailConditionTypeEnum conditionType;
    [Token(Token = "0x400431E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value;
    [Token(Token = "0x400431F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int subValue;

    [Token(Token = "0x17000C51")]
    public int Key
    {
      [Token(Token = "0x60055D2"), Address(RVA = "0x3E2EA08", Offset = "0x3E2EA08", VA = "0x3E2EA08", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055D3")]
    [Address(RVA = "0x3E2EA10", Offset = "0x3E2EA10", VA = "0x3E2EA10", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055D4")]
    [Address(RVA = "0x3E2EC9C", Offset = "0x3E2EC9C", VA = "0x3E2EC9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055D5")]
    [Address(RVA = "0x3E2ED60", Offset = "0x3E2ED60", VA = "0x3E2ED60")]
    public BattleFailedConditionData()
    {
    }
  }
}
