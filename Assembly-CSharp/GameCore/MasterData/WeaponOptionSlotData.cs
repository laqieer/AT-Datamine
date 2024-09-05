// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionSlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F84")]
  [Serializable]
  public sealed class WeaponOptionSlotData : IMasterDataEntity
  {
    [Token(Token = "0x4004E56")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E57")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004E58")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int slot;

    [Token(Token = "0x17000D80")]
    public int Key
    {
      [Token(Token = "0x6005B40"), Address(RVA = "0x2780B80", Offset = "0x2780B80", VA = "0x2780B80", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B41")]
    [Address(RVA = "0x2780B88", Offset = "0x2780B88", VA = "0x2780B88", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B42")]
    [Address(RVA = "0x2780CF4", Offset = "0x2780CF4", VA = "0x2780CF4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B43")]
    [Address(RVA = "0x2780D88", Offset = "0x2780D88", VA = "0x2780D88")]
    public WeaponOptionSlotData()
    {
    }
  }
}
