// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleAdvTriggerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DFC")]
  [Serializable]
  public sealed class BattleAdvTriggerData : IMasterDataEntity
  {
    [Token(Token = "0x40042C8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042C9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupId;
    [Token(Token = "0x40042CA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int playerIdx;
    [Token(Token = "0x40042CB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int IdMode;
    [Token(Token = "0x40042CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int targetId;
    [Token(Token = "0x40042CD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public BattleEventTriggerTypeEnum conditions;
    [Token(Token = "0x40042CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int arg1;
    [Token(Token = "0x40042CF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int arg2;
    [Token(Token = "0x40042D0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int arg3;
    [Token(Token = "0x40042D1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int arg4;

    [Token(Token = "0x17000C3C")]
    public int Key
    {
      [Token(Token = "0x600554C"), Address(RVA = "0x3AAEF20", Offset = "0x3AAEF20", VA = "0x3AAEF20", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600554D")]
    [Address(RVA = "0x3AAEF28", Offset = "0x3AAEF28", VA = "0x3AAEF28", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600554E")]
    [Address(RVA = "0x3AAF334", Offset = "0x3AAF334", VA = "0x3AAF334", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600554F")]
    [Address(RVA = "0x3AAEAA8", Offset = "0x3AAEAA8", VA = "0x3AAEAA8")]
    public bool IsMatchState(UnitParameterData unitParam) => new bool();

    [Token(Token = "0x6005550")]
    [Address(RVA = "0x3AAEBA8", Offset = "0x3AAEBA8", VA = "0x3AAEBA8")]
    public bool IsMatchGrid(UnitParameterData unitParam) => new bool();

    [Token(Token = "0x6005551")]
    [Address(RVA = "0x3AAF438", Offset = "0x3AAF438", VA = "0x3AAF438")]
    public BattleAdvTriggerData()
    {
    }
  }
}
