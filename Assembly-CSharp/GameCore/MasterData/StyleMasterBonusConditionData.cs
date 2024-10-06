// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010C9")]
  [Serializable]
  public sealed class StyleMasterBonusConditionData : IMasterDataEntity
  {
    [Token(Token = "0x400525F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005260")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005261")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int element;
    [Token(Token = "0x4005262")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int move;
    [Token(Token = "0x4005263")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int armor;
    [Token(Token = "0x4005264")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int ride;

    [Token(Token = "0x17000E79")]
    public int Key
    {
      [Token(Token = "0x6006107"), Address(RVA = "0x28DC494", Offset = "0x28DC494", VA = "0x28DC494", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006108")]
    [Address(RVA = "0x28DC49C", Offset = "0x28DC49C", VA = "0x28DC49C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006109")]
    [Address(RVA = "0x28DC728", Offset = "0x28DC728", VA = "0x28DC728", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600610A")]
    [Address(RVA = "0x28DC7F0", Offset = "0x28DC7F0", VA = "0x28DC7F0")]
    public StyleMasterBonusConditionData()
    {
    }
  }
}
