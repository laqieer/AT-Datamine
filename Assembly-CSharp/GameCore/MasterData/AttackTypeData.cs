// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AttackTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EB6")]
  [Serializable]
  public sealed class AttackTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400479B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400479C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400479D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D40")]
    public int Key
    {
      [Token(Token = "0x6005925"), Address(RVA = "0x3C30708", Offset = "0x3C30708", VA = "0x3C30708", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005926")]
    [Address(RVA = "0x3C30710", Offset = "0x3C30710", VA = "0x3C30710", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005927")]
    [Address(RVA = "0x3C3087C", Offset = "0x3C3087C", VA = "0x3C3087C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005928")]
    [Address(RVA = "0x3C30918", Offset = "0x3C30918", VA = "0x3C30918")]
    public AttackTypeData()
    {
    }
  }
}
