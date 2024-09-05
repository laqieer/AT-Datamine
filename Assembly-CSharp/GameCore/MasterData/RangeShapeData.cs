// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RangeShapeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B4")]
  [Serializable]
  public sealed class RangeShapeData : IMasterDataEntity
  {
    [Token(Token = "0x4005537")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005538")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005539")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RangeTypeEnum RangeType;

    [Token(Token = "0x17000F4F")]
    public int Key
    {
      [Token(Token = "0x6006565"), Address(RVA = "0x4D1A928", Offset = "0x4D1A928", VA = "0x4D1A928", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006566")]
    [Address(RVA = "0x4D1A930", Offset = "0x4D1A930", VA = "0x4D1A930", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006567")]
    [Address(RVA = "0x4D1AA9C", Offset = "0x4D1AA9C", VA = "0x4D1AA9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006568")]
    [Address(RVA = "0x4D1AB34", Offset = "0x4D1AB34", VA = "0x4D1AB34")]
    public RangeShapeData()
    {
    }
  }
}
