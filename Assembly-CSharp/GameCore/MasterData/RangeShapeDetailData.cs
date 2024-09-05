// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RangeShapeDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011B2")]
  [Serializable]
  public sealed class RangeShapeDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4005534")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4005535")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int numCols;
    [Token(Token = "0x4005536")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int[] Cells;

    [Token(Token = "0x17000F4E")]
    public int Key
    {
      [Token(Token = "0x600655E"), Address(RVA = "0x4D1A614", Offset = "0x4D1A614", VA = "0x4D1A614", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600655F")]
    [Address(RVA = "0x4D1A61C", Offset = "0x4D1A61C", VA = "0x4D1A61C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006560")]
    [Address(RVA = "0x4D1A818", Offset = "0x4D1A818", VA = "0x4D1A818")]
    public RangeShapeDetailData()
    {
    }
  }
}
