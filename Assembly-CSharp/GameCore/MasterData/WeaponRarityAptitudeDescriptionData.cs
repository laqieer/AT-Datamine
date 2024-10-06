// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponRarityAptitudeDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7C")]
  [Serializable]
  public sealed class WeaponRarityAptitudeDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004DF2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DF3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int difference;
    [Token(Token = "0x4004DF4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public float power;
    [Token(Token = "0x4004DF5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float hit;
    [Token(Token = "0x4004DF6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float avoid;
    [Token(Token = "0x4004DF7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float sp;
    [Token(Token = "0x4004DF8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float weight;

    [Token(Token = "0x17000D7A")]
    public int Key
    {
      [Token(Token = "0x6005B0F"), Address(RVA = "0x277CDEC", Offset = "0x277CDEC", VA = "0x277CDEC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B10")]
    [Address(RVA = "0x277CDF4", Offset = "0x277CDF4", VA = "0x277CDF4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B11")]
    [Address(RVA = "0x277D0E0", Offset = "0x277D0E0", VA = "0x277D0E0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B12")]
    [Address(RVA = "0x277D1B4", Offset = "0x277D1B4", VA = "0x277D1B4")]
    public WeaponRarityAptitudeDescriptionData()
    {
    }
  }
}
