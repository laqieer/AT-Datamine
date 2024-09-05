// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E91")]
  [Serializable]
  public sealed class SubEquipmentClassificationData : IMasterDataEntity
  {
    [Token(Token = "0x4004687")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004688")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D2B")]
    public int Key
    {
      [Token(Token = "0x60058A1"), Address(RVA = "0x3C2C8D0", Offset = "0x3C2C8D0", VA = "0x3C2C8D0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058A2")]
    [Address(RVA = "0x3C2C8D8", Offset = "0x3C2C8D8", VA = "0x3C2C8D8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058A3")]
    [Address(RVA = "0x3C2C9E4", Offset = "0x3C2C9E4", VA = "0x3C2C9E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058A4")]
    [Address(RVA = "0x3C2CA6C", Offset = "0x3C2CA6C", VA = "0x3C2CA6C")]
    public SubEquipmentClassificationData()
    {
    }
  }
}
