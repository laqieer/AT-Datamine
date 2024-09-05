// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E02")]
  [Serializable]
  public sealed class BattleBadStatusGroupData : IMasterDataEntity
  {
    [Token(Token = "0x40042E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042E7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x40042E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int detailID;

    [Token(Token = "0x17000C42")]
    public int Key
    {
      [Token(Token = "0x6005573"), Address(RVA = "0x3AB0B5C", Offset = "0x3AB0B5C", VA = "0x3AB0B5C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005574")]
    [Address(RVA = "0x3AB0B64", Offset = "0x3AB0B64", VA = "0x3AB0B64", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005575")]
    [Address(RVA = "0x3AB0CD0", Offset = "0x3AB0CD0", VA = "0x3AB0CD0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005576")]
    [Address(RVA = "0x3AB0D64", Offset = "0x3AB0D64", VA = "0x3AB0D64")]
    public BattleBadStatusGroupData()
    {
    }
  }
}
