// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionEffectSpriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F40")]
  [Serializable]
  public sealed class AccessoryOptionEffectSpriteData : IMasterDataEntity
  {
    [Token(Token = "0x4004CE0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CE1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int spriteId;

    [Token(Token = "0x17000D59")]
    public int Key
    {
      [Token(Token = "0x60059E8"), Address(RVA = "0x3C39EF4", Offset = "0x3C39EF4", VA = "0x3C39EF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059E9")]
    [Address(RVA = "0x3C39EFC", Offset = "0x3C39EFC", VA = "0x3C39EFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059EA")]
    [Address(RVA = "0x3C3A008", Offset = "0x3C3A008", VA = "0x3C3A008", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60059EB")]
    [Address(RVA = "0x3C3A08C", Offset = "0x3C3A08C", VA = "0x3C3A08C")]
    public AccessoryOptionEffectSpriteData()
    {
    }
  }
}
