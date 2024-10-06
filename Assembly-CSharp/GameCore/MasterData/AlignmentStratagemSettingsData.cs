// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AlignmentStratagemSettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A4")]
  [Serializable]
  public sealed class AlignmentStratagemSettingsData : IMasterDataEntity
  {
    [Token(Token = "0x40054F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054F1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int alignmentNumber;
    [Token(Token = "0x40054F2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int increaseDamageRate;
    [Token(Token = "0x40054F3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int selectGridBarrierBonus;
    [Token(Token = "0x40054F4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rangeGridBarrierBonus;

    [Token(Token = "0x17000F46")]
    public int Key
    {
      [Token(Token = "0x600651D"), Address(RVA = "0x4AF5D58", Offset = "0x4AF5D58", VA = "0x4AF5D58", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600651E")]
    [Address(RVA = "0x4AF5D60", Offset = "0x4AF5D60", VA = "0x4AF5D60", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600651F")]
    [Address(RVA = "0x4AF5F8C", Offset = "0x4AF5F8C", VA = "0x4AF5F8C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006520")]
    [Address(RVA = "0x4AF6040", Offset = "0x4AF6040", VA = "0x4AF6040")]
    public AlignmentStratagemSettingsData()
    {
    }
  }
}
