// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleInitialPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E54")]
  [Serializable]
  public sealed class BattleInitialPlacementData : IMasterDataEntity
  {
    [Token(Token = "0x4004515")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004516")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000CCA")]
    public int Key
    {
      [Token(Token = "0x6005748"), Address(RVA = "0x3E3CE30", Offset = "0x3E3CE30", VA = "0x3E3CE30", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005749")]
    [Address(RVA = "0x3E3CE38", Offset = "0x3E3CE38", VA = "0x3E3CE38", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600574A")]
    [Address(RVA = "0x3E3CF44", Offset = "0x3E3CF44", VA = "0x3E3CF44", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600574B")]
    [Address(RVA = "0x3E3CFCC", Offset = "0x3E3CFCC", VA = "0x3E3CFCC")]
    public BattleInitialPlacementData()
    {
    }
  }
}
