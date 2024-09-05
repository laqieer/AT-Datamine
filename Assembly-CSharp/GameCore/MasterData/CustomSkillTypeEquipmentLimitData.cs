// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillTypeEquipmentLimitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011AC")]
  [Serializable]
  public sealed class CustomSkillTypeEquipmentLimitData : IMasterDataEntity
  {
    [Token(Token = "0x4005502")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005503")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int maxCount;

    [Token(Token = "0x17000F4A")]
    public int Key
    {
      [Token(Token = "0x600653F"), Address(RVA = "0x4AF6DA4", Offset = "0x4AF6DA4", VA = "0x4AF6DA4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006540")]
    [Address(RVA = "0x4AF6DAC", Offset = "0x4AF6DAC", VA = "0x4AF6DAC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006541")]
    [Address(RVA = "0x4AF6EB8", Offset = "0x4AF6EB8", VA = "0x4AF6EB8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006542")]
    [Address(RVA = "0x4AF6F3C", Offset = "0x4AF6F3C", VA = "0x4AF6F3C")]
    public CustomSkillTypeEquipmentLimitData()
    {
    }
  }
}
