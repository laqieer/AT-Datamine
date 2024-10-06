// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponLimitBreakDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F76")]
  [Serializable]
  public sealed class WeaponLimitBreakDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004DE5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DE6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int weaponLimitBreak;
    [Token(Token = "0x4004DE7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004DE8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004DE9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int pieceNum;

    [Token(Token = "0x17000D77")]
    public int Key
    {
      [Token(Token = "0x6005AF7"), Address(RVA = "0x277C2E0", Offset = "0x277C2E0", VA = "0x277C2E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AF8")]
    [Address(RVA = "0x277C2E8", Offset = "0x277C2E8", VA = "0x277C2E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AF9")]
    [Address(RVA = "0x277C514", Offset = "0x277C514", VA = "0x277C514", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005AFA")]
    [Address(RVA = "0x277C5C8", Offset = "0x277C5C8", VA = "0x277C5C8")]
    public WeaponLimitBreakDescriptionData()
    {
    }
  }
}
