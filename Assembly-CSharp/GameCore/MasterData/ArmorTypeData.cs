// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmorTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EB3")]
  [Serializable]
  public sealed class ArmorTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004790")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004791")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004792")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D3F")]
    public int Key
    {
      [Token(Token = "0x600591D"), Address(RVA = "0x3C303E8", Offset = "0x3C303E8", VA = "0x3C303E8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600591E")]
    [Address(RVA = "0x3C303F0", Offset = "0x3C303F0", VA = "0x3C303F0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600591F")]
    [Address(RVA = "0x3C3055C", Offset = "0x3C3055C", VA = "0x3C3055C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005920")]
    [Address(RVA = "0x3C305F8", Offset = "0x3C305F8", VA = "0x3C305F8")]
    public ArmorTypeData()
    {
    }
  }
}
