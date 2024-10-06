// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleClearConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E08")]
  [Serializable]
  public sealed class BattleClearConditionData : IMasterDataEntity
  {
    [Token(Token = "0x40042FE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042FF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4004300")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum op;
    [Token(Token = "0x4004301")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleClearConditionTypeEnum conditionType;
    [Token(Token = "0x4004302")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value;
    [Token(Token = "0x4004303")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int subValue;

    [Token(Token = "0x17000C49")]
    public int Key
    {
      [Token(Token = "0x6005594"), Address(RVA = "0x3AB2234", Offset = "0x3AB2234", VA = "0x3AB2234", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005595")]
    [Address(RVA = "0x3AB223C", Offset = "0x3AB223C", VA = "0x3AB223C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005596")]
    [Address(RVA = "0x3AB24C8", Offset = "0x3AB24C8", VA = "0x3AB24C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C4A")]
    public string Name
    {
      [Token(Token = "0x6005597"), Address(RVA = "0x3AB258C", Offset = "0x3AB258C", VA = "0x3AB258C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005598")]
    [Address(RVA = "0x3AB2668", Offset = "0x3AB2668", VA = "0x3AB2668")]
    public BattleClearConditionData()
    {
    }
  }
}
