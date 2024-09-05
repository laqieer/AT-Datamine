// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F2A")]
  [Serializable]
  public sealed class StyleGroupTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004BEB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004BEC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D52")]
    public int Key
    {
      [Token(Token = "0x60059A8"), Address(RVA = "0x3C33770", Offset = "0x3C33770", VA = "0x3C33770", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059A9")]
    [Address(RVA = "0x3C33778", Offset = "0x3C33778", VA = "0x3C33778", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059AA")]
    [Address(RVA = "0x3C33884", Offset = "0x3C33884", VA = "0x3C33884", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D53")]
    public string DisplayName
    {
      [Token(Token = "0x60059AB"), Address(RVA = "0x3C3390C", Offset = "0x3C3390C", VA = "0x3C3390C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60059AC")]
    [Address(RVA = "0x3C339E8", Offset = "0x3C339E8", VA = "0x3C339E8")]
    public StyleGroupTypeData()
    {
    }
  }
}
