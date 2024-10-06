// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSortieConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E27")]
  [Serializable]
  public sealed class BattleSortieConditionData : IMasterDataEntity
  {
    [Token(Token = "0x400436D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400436E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x400436F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum op;
    [Token(Token = "0x4004370")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleSortieConditionTypeEnum conditionType;
    [Token(Token = "0x4004371")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int value1;
    [Token(Token = "0x4004372")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int value2;
    [Token(Token = "0x4004373")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int value3;
    [Token(Token = "0x4004374")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int value4;
    [Token(Token = "0x4004375")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int value5;

    [Token(Token = "0x17000C67")]
    public int Key
    {
      [Token(Token = "0x600563D"), Address(RVA = "0x3E33110", Offset = "0x3E33110", VA = "0x3E33110", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600563E")]
    [Address(RVA = "0x3E33118", Offset = "0x3E33118", VA = "0x3E33118", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600563F")]
    [Address(RVA = "0x3E334C4", Offset = "0x3E334C4", VA = "0x3E334C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C68")]
    public string Name
    {
      [Token(Token = "0x6005640"), Address(RVA = "0x3E335B8", Offset = "0x3E335B8", VA = "0x3E335B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005641")]
    [Address(RVA = "0x3E33694", Offset = "0x3E33694", VA = "0x3E33694")]
    public bool Check(
      BattleSortieConditionTypeEnum trigger,
      int param1 = 0,
      int param2 = 0,
      int param3 = 0,
      int param4 = 0,
      int param5 = 0)
    {
      return new bool();
    }

    [Token(Token = "0x6005642")]
    [Address(RVA = "0x3E337A8", Offset = "0x3E337A8", VA = "0x3E337A8")]
    public BattleSortieConditionData()
    {
    }
  }
}
