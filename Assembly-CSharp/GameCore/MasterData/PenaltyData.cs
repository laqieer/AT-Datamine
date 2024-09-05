// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PenaltyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E9A")]
  [Serializable]
  public sealed class PenaltyData : IMasterDataEntity
  {
    [Token(Token = "0x40046A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40046A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string message;
    [Token(Token = "0x40046A4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public bool showEndAt;

    [Token(Token = "0x17000D38")]
    public int Key
    {
      [Token(Token = "0x60058D7"), Address(RVA = "0x3C2E134", Offset = "0x3C2E134", VA = "0x3C2E134", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058D8")]
    [Address(RVA = "0x3C2E13C", Offset = "0x3C2E13C", VA = "0x3C2E13C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058D9")]
    [Address(RVA = "0x3C2E30C", Offset = "0x3C2E30C", VA = "0x3C2E30C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058DA")]
    [Address(RVA = "0x3C2E3B8", Offset = "0x3C2E3B8", VA = "0x3C2E3B8")]
    public PenaltyData()
    {
    }
  }
}
