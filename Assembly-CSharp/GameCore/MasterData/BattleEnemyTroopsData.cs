// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyTroopsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E3D")]
  [Serializable]
  public sealed class BattleEnemyTroopsData : IMasterDataEntity, ITroopsData
  {
    [Token(Token = "0x4004400")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004401")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004402")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4004403")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool initial;
    [Token(Token = "0x4004404")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    public bool quick;

    [Token(Token = "0x17000C89")]
    public int Key
    {
      [Token(Token = "0x60056BE"), Address(RVA = "0x3E392CC", Offset = "0x3E392CC", VA = "0x3E392CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056BF")]
    [Address(RVA = "0x3E392D4", Offset = "0x3E392D4", VA = "0x3E392D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60056C0")]
    [Address(RVA = "0x3E39508", Offset = "0x3E39508", VA = "0x3E39508", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C8A")]
    public int Troops
    {
      [Token(Token = "0x60056C1"), Address(RVA = "0x3E395BC", Offset = "0x3E395BC", VA = "0x3E395BC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C8B")]
    public bool IsInitial
    {
      [Token(Token = "0x60056C2"), Address(RVA = "0x3E395C4", Offset = "0x3E395C4", VA = "0x3E395C4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000C8C")]
    public bool IsQuick
    {
      [Token(Token = "0x60056C3"), Address(RVA = "0x3E395CC", Offset = "0x3E395CC", VA = "0x3E395CC", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60056C4")]
    [Address(RVA = "0x3E395D4", Offset = "0x3E395D4", VA = "0x3E395D4")]
    public BattleEnemyTroopsData()
    {
    }
  }
}
