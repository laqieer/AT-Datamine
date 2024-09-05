// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionChangeItemRecipeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F88")]
  [Serializable]
  public sealed class WeaponOptionChangeItemRecipeData : IMasterDataEntity
  {
    [Token(Token = "0x4004E5F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E60")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004E61")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int numberToUse;

    [Token(Token = "0x17000D83")]
    public int Key
    {
      [Token(Token = "0x6005B53"), Address(RVA = "0x27814A4", Offset = "0x27814A4", VA = "0x27814A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B54")]
    [Address(RVA = "0x27814AC", Offset = "0x27814AC", VA = "0x27814AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B55")]
    [Address(RVA = "0x2781618", Offset = "0x2781618", VA = "0x2781618", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B56")]
    [Address(RVA = "0x27816AC", Offset = "0x27816AC", VA = "0x27816AC")]
    public WeaponOptionChangeItemRecipeData()
    {
    }
  }
}
