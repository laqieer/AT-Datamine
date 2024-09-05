// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E37")]
  [Serializable]
  public sealed class BattleDropSetData : IMasterDataEntity
  {
    [Token(Token = "0x40043DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043DF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int drop;
    [Token(Token = "0x40043E0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int setDescription;
    [Token(Token = "0x40043E1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int weight;
    [Token(Token = "0x40043E2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool isRare;

    [Token(Token = "0x17000C75")]
    public int Key
    {
      [Token(Token = "0x600568E"), Address(RVA = "0x3E37A00", Offset = "0x3E37A00", VA = "0x3E37A00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600568F")]
    [Address(RVA = "0x3E37A08", Offset = "0x3E37A08", VA = "0x3E37A08", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005690")]
    [Address(RVA = "0x3E37C38", Offset = "0x3E37C38", VA = "0x3E37C38", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005691")]
    [Address(RVA = "0x3E37CEC", Offset = "0x3E37CEC", VA = "0x3E37CEC")]
    public BattleDropSetData()
    {
    }
  }
}
