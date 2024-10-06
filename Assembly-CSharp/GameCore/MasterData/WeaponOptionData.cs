// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F86")]
  [Serializable]
  public sealed class WeaponOptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004E59")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E5A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string referenceName;
    [Token(Token = "0x4004E5B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int optionGrade;
    [Token(Token = "0x4004E5C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public OptionEffectTypeEnum effectType;
    [Token(Token = "0x4004E5D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float randomValueMinimum;
    [Token(Token = "0x4004E5E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float randomValueMaximum;

    [Token(Token = "0x17000D81")]
    public int Key
    {
      [Token(Token = "0x6005B49"), Address(RVA = "0x2780F78", Offset = "0x2780F78", VA = "0x2780F78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B4A")]
    [Address(RVA = "0x2780F80", Offset = "0x2780F80", VA = "0x2780F80", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B4B")]
    [Address(RVA = "0x278120C", Offset = "0x278120C", VA = "0x278120C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D82")]
    public string Name
    {
      [Token(Token = "0x6005B4C"), Address(RVA = "0x27812D4", Offset = "0x27812D4", VA = "0x27812D4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005B4D")]
    [Address(RVA = "0x2781344", Offset = "0x2781344", VA = "0x2781344")]
    public WeaponOptionData()
    {
    }
  }
}
