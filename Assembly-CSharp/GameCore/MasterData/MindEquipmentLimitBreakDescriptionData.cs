// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentLimitBreakDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F61")]
  [Serializable]
  public sealed class MindEquipmentLimitBreakDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004D25")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D26")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int mindEquipmentLimitBreak;
    [Token(Token = "0x4004D27")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004D28")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004D29")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int materialNum;

    [Token(Token = "0x17000D69")]
    public int Key
    {
      [Token(Token = "0x6005A7C"), Address(RVA = "0x3C3E938", Offset = "0x3C3E938", VA = "0x3C3E938", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A7D")]
    [Address(RVA = "0x3C3E940", Offset = "0x3C3E940", VA = "0x3C3E940", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A7E")]
    [Address(RVA = "0x3C3EB6C", Offset = "0x3C3EB6C", VA = "0x3C3EB6C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A7F")]
    [Address(RVA = "0x3C3EC20", Offset = "0x3C3EC20", VA = "0x3C3EC20")]
    public MindEquipmentLimitBreakDescriptionData()
    {
    }
  }
}
