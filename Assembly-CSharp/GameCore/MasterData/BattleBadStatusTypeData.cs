// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EBB")]
  [Serializable]
  public sealed class BattleBadStatusTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40047C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40047C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40047C4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D41")]
    public int Key
    {
      [Token(Token = "0x600592D"), Address(RVA = "0x3C30A28", Offset = "0x3C30A28", VA = "0x3C30A28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600592E")]
    [Address(RVA = "0x3C30A30", Offset = "0x3C30A30", VA = "0x3C30A30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600592F")]
    [Address(RVA = "0x3C30B9C", Offset = "0x3C30B9C", VA = "0x3C30B9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005930")]
    [Address(RVA = "0x3C30C38", Offset = "0x3C30C38", VA = "0x3C30C38")]
    public BattleBadStatusTypeData()
    {
    }
  }
}
