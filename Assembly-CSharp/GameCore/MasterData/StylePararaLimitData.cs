// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StylePararaLimitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C9")]
  [Serializable]
  public sealed class StylePararaLimitData : IMasterDataEntity
  {
    [Token(Token = "0x4005C7D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005C7E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int StyleID;
    [Token(Token = "0x4005C7F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ReincarnationCount;
    [Token(Token = "0x4005C80")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int PararaMaxLife;
    [Token(Token = "0x4005C81")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int PararaMaxStrength;
    [Token(Token = "0x4005C82")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int PararaMaxIntelligence;
    [Token(Token = "0x4005C83")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int PararaMaxVitality;
    [Token(Token = "0x4005C84")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int PararaMaxMind;
    [Token(Token = "0x4005C85")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int PararaMaxAgility;
    [Token(Token = "0x4005C86")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int PararaMaxDexterity;
    [Token(Token = "0x4005C87")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int PararaMaxLucky;

    [Token(Token = "0x170010B9")]
    public int Key
    {
      [Token(Token = "0x6006F2B"), Address(RVA = "0x4711928", Offset = "0x4711928", VA = "0x4711928", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006F2C")]
    [Address(RVA = "0x4711930", Offset = "0x4711930", VA = "0x4711930", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006F2D")]
    [Address(RVA = "0x4711D9C", Offset = "0x4711D9C", VA = "0x4711D9C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006F2E")]
    [Address(RVA = "0x4711EB0", Offset = "0x4711EB0", VA = "0x4711EB0")]
    public StylePararaLimitData()
    {
    }
  }
}
