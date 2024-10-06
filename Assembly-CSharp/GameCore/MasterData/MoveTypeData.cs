// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MoveTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EFF")]
  [Serializable]
  public sealed class MoveTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004A5E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004A5F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004A60")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D49")]
    public int Key
    {
      [Token(Token = "0x600596E"), Address(RVA = "0x3C320C0", Offset = "0x3C320C0", VA = "0x3C320C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600596F")]
    [Address(RVA = "0x3C320C8", Offset = "0x3C320C8", VA = "0x3C320C8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005970")]
    [Address(RVA = "0x3C32234", Offset = "0x3C32234", VA = "0x3C32234", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005971")]
    [Address(RVA = "0x3C322D0", Offset = "0x3C322D0", VA = "0x3C322D0")]
    public MoveTypeData()
    {
    }
  }
}
