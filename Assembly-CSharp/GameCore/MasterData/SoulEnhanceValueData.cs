// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SoulEnhanceValueData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E9F")]
  [Serializable]
  public sealed class SoulEnhanceValueData : IMasterDataEntity
  {
    [Token(Token = "0x40046AE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046AF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleEnhance;
    [Token(Token = "0x40046B0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int mindEquipmentEnhance;
    [Token(Token = "0x40046B1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int weaponEnhance;
    [Token(Token = "0x40046B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int accessoryEnhance;

    [Token(Token = "0x17000D3A")]
    public int Key
    {
      [Token(Token = "0x60058EF"), Address(RVA = "0x3C2EC48", Offset = "0x3C2EC48", VA = "0x3C2EC48", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058F0")]
    [Address(RVA = "0x3C2EC50", Offset = "0x3C2EC50", VA = "0x3C2EC50", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058F1")]
    [Address(RVA = "0x3C2EE7C", Offset = "0x3C2EE7C", VA = "0x3C2EE7C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058F2")]
    [Address(RVA = "0x3C2EF30", Offset = "0x3C2EF30", VA = "0x3C2EF30")]
    public SoulEnhanceValueData()
    {
    }
  }
}
