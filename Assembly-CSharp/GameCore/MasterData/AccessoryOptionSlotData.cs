// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionSlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F42")]
  [Serializable]
  public sealed class AccessoryOptionSlotData : IMasterDataEntity
  {
    [Token(Token = "0x4004CE2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CE3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004CE4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int slot;

    [Token(Token = "0x17000D5A")]
    public int Key
    {
      [Token(Token = "0x60059F1"), Address(RVA = "0x3C3A320", Offset = "0x3C3A320", VA = "0x3C3A320", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059F2")]
    [Address(RVA = "0x3C3A328", Offset = "0x3C3A328", VA = "0x3C3A328", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059F3")]
    [Address(RVA = "0x3C3A494", Offset = "0x3C3A494", VA = "0x3C3A494", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60059F4")]
    [Address(RVA = "0x3C3A528", Offset = "0x3C3A528", VA = "0x3C3A528")]
    public AccessoryOptionSlotData()
    {
    }
  }
}
