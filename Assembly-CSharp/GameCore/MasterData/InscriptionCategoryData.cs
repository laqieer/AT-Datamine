// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.InscriptionCategoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F53")]
  [Serializable]
  public sealed class InscriptionCategoryData : IMasterDataEntity
  {
    [Token(Token = "0x4004D05")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004D07")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int inscription;

    [Token(Token = "0x17000D63")]
    public int Key
    {
      [Token(Token = "0x6005A36"), Address(RVA = "0x3C3C244", Offset = "0x3C3C244", VA = "0x3C3C244", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A37")]
    [Address(RVA = "0x3C3C24C", Offset = "0x3C3C24C", VA = "0x3C3C24C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A38")]
    [Address(RVA = "0x3C3C3B8", Offset = "0x3C3C3B8", VA = "0x3C3C3B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A39")]
    [Address(RVA = "0x3C3C450", Offset = "0x3C3C450", VA = "0x3C3C450")]
    public InscriptionCategoryData()
    {
    }
  }
}
