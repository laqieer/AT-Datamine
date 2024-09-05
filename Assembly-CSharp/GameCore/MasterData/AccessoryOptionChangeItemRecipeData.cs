// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionChangeItemRecipeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F46")]
  [Serializable]
  public sealed class AccessoryOptionChangeItemRecipeData : IMasterDataEntity
  {
    [Token(Token = "0x4004CEB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CEC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004CED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int numberToUse;

    [Token(Token = "0x17000D5D")]
    public int Key
    {
      [Token(Token = "0x6005A03"), Address(RVA = "0x3C3ABF4", Offset = "0x3C3ABF4", VA = "0x3C3ABF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A04")]
    [Address(RVA = "0x3C3ABFC", Offset = "0x3C3ABFC", VA = "0x3C3ABFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A05")]
    [Address(RVA = "0x3C3AD68", Offset = "0x3C3AD68", VA = "0x3C3AD68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A06")]
    [Address(RVA = "0x3C3ADFC", Offset = "0x3C3ADFC", VA = "0x3C3ADFC")]
    public AccessoryOptionChangeItemRecipeData()
    {
    }
  }
}
