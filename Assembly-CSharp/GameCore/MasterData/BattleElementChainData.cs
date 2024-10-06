// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleElementChainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E11")]
  [Serializable]
  public sealed class BattleElementChainData : IMasterDataEntity
  {
    [Token(Token = "0x4004314")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004315")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int minChainCount;
    [Token(Token = "0x4004316")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int reduceResistRate;

    [Token(Token = "0x17000C4E")]
    public int Key
    {
      [Token(Token = "0x60055BF"), Address(RVA = "0x3E2E14C", Offset = "0x3E2E14C", VA = "0x3E2E14C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055C0")]
    [Address(RVA = "0x3E2E154", Offset = "0x3E2E154", VA = "0x3E2E154", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055C1")]
    [Address(RVA = "0x3E2E2C0", Offset = "0x3E2E2C0", VA = "0x3E2E2C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055C2")]
    [Address(RVA = "0x3E2E354", Offset = "0x3E2E354", VA = "0x3E2E354")]
    public BattleElementChainData()
    {
    }
  }
}
