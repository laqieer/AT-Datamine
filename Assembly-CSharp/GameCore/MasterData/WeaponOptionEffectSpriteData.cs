// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionEffectSpriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F82")]
  [Serializable]
  public sealed class WeaponOptionEffectSpriteData : IMasterDataEntity
  {
    [Token(Token = "0x4004E54")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E55")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int spriteId;

    [Token(Token = "0x17000D7F")]
    public int Key
    {
      [Token(Token = "0x6005B37"), Address(RVA = "0x2780754", Offset = "0x2780754", VA = "0x2780754", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B38")]
    [Address(RVA = "0x278075C", Offset = "0x278075C", VA = "0x278075C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B39")]
    [Address(RVA = "0x2780868", Offset = "0x2780868", VA = "0x2780868", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B3A")]
    [Address(RVA = "0x27808EC", Offset = "0x27808EC", VA = "0x27808EC")]
    public WeaponOptionEffectSpriteData()
    {
    }
  }
}
