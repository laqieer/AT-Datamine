// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionGradeGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F8B")]
  [Serializable]
  public sealed class WeaponOptionGradeGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004E84")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E85")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004E86")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004E87")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int optionGrade;
    [Token(Token = "0x4004E88")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D84")]
    public int Key
    {
      [Token(Token = "0x6005B5C"), Address(RVA = "0x278180C", Offset = "0x278180C", VA = "0x278180C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B5D")]
    [Address(RVA = "0x2781814", Offset = "0x2781814", VA = "0x2781814", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B5E")]
    [Address(RVA = "0x2781A40", Offset = "0x2781A40", VA = "0x2781A40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B5F")]
    [Address(RVA = "0x2781AF8", Offset = "0x2781AF8", VA = "0x2781AF8")]
    public WeaponOptionGradeGroupData()
    {
    }
  }
}
