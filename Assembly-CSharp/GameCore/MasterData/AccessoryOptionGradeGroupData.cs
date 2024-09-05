// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionGradeGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F48")]
  [Serializable]
  public sealed class AccessoryOptionGradeGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004CEE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CEF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004CF0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004CF1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int optionGrade;
    [Token(Token = "0x4004CF2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D5E")]
    public int Key
    {
      [Token(Token = "0x6005A0B"), Address(RVA = "0x3C3AF0C", Offset = "0x3C3AF0C", VA = "0x3C3AF0C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A0C")]
    [Address(RVA = "0x3C3AF14", Offset = "0x3C3AF14", VA = "0x3C3AF14", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A0D")]
    [Address(RVA = "0x3C3B140", Offset = "0x3C3B140", VA = "0x3C3B140", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A0E")]
    [Address(RVA = "0x3C3B1F8", Offset = "0x3C3B1F8", VA = "0x3C3B1F8")]
    public AccessoryOptionGradeGroupData()
    {
    }
  }
}
