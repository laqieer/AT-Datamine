// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityConditionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200121A")]
  [Serializable]
  public sealed class StoryFacilityConditionsData : IMasterDataEntity
  {
    [Token(Token = "0x40056A8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056A9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int label;
    [Token(Token = "0x40056AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionTypeEnum conditionType;
    [Token(Token = "0x40056AB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int conditionD;
    [Token(Token = "0x40056AC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000F8D")]
    public int Key
    {
      [Token(Token = "0x600672D"), Address(RVA = "0x4D2D0D4", Offset = "0x4D2D0D4", VA = "0x4D2D0D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600672E")]
    [Address(RVA = "0x4D2D0DC", Offset = "0x4D2D0DC", VA = "0x4D2D0DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600672F")]
    [Address(RVA = "0x4D2D308", Offset = "0x4D2D308", VA = "0x4D2D308", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006730")]
    [Address(RVA = "0x4D2D3BC", Offset = "0x4D2D3BC", VA = "0x4D2D3BC")]
    public StoryFacilityConditionsData()
    {
    }
  }
}
