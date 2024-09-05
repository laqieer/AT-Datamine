// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSlayEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E25")]
  [Serializable]
  public sealed class BattleSlayEffectRatioData : IMasterDataEntity
  {
    [Token(Token = "0x4004365")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004366")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004367")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4004368")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int displayValue;
    [Token(Token = "0x4004369")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C66")]
    public int Key
    {
      [Token(Token = "0x6005633"), Address(RVA = "0x3E32A7C", Offset = "0x3E32A7C", VA = "0x3E32A7C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005634")]
    [Address(RVA = "0x3E32A84", Offset = "0x3E32A84", VA = "0x3E32A84", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005635")]
    [Address(RVA = "0x3E32CB0", Offset = "0x3E32CB0", VA = "0x3E32CB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005636")]
    [Address(RVA = "0x3E32D64", Offset = "0x3E32D64", VA = "0x3E32D64")]
    public BattleSlayEffectRatioData()
    {
    }
  }
}
