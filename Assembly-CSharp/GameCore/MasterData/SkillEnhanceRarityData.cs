// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SkillEnhanceRarityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6B")]
  [Serializable]
  public sealed class SkillEnhanceRarityData : IMasterDataEntity
  {
    [Token(Token = "0x4004D8A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D8B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum equipmentRarity;
    [Token(Token = "0x4004D8C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RarityTypeEnum itemRarity;

    [Token(Token = "0x17000D71")]
    public int Key
    {
      [Token(Token = "0x6005AB6"), Address(RVA = "0x3C42928", Offset = "0x3C42928", VA = "0x3C42928", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005AB7")]
    [Address(RVA = "0x3C42930", Offset = "0x3C42930", VA = "0x3C42930", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005AB8")]
    [Address(RVA = "0x3C42A9C", Offset = "0x3C42A9C", VA = "0x3C42A9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005AB9")]
    [Address(RVA = "0x3C42B30", Offset = "0x3C42B30", VA = "0x3C42B30")]
    public SkillEnhanceRarityData()
    {
    }
  }
}
