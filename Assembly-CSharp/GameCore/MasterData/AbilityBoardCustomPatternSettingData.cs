// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardCustomPatternSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001346")]
  [Serializable]
  public sealed class AbilityBoardCustomPatternSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005AC1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AC2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005AC3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int customA1;
    [Token(Token = "0x4005AC4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int customA2;
    [Token(Token = "0x4005AC5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int customA3;
    [Token(Token = "0x4005AC6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int customB1;
    [Token(Token = "0x4005AC7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int customB2;
    [Token(Token = "0x4005AC8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int customB3;

    [Token(Token = "0x17001066")]
    public int Key
    {
      [Token(Token = "0x6006CAF"), Address(RVA = "0x46F6044", Offset = "0x46F6044", VA = "0x46F6044", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CB0")]
    [Address(RVA = "0x46F604C", Offset = "0x46F604C", VA = "0x46F604C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CB1")]
    [Address(RVA = "0x46F6398", Offset = "0x46F6398", VA = "0x46F6398", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CB2")]
    [Address(RVA = "0x46F6480", Offset = "0x46F6480", VA = "0x46F6480")]
    public AbilityBoardCustomPatternSettingData()
    {
    }
  }
}
