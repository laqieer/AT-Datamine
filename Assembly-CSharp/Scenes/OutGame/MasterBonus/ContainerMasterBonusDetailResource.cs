// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerMasterBonusDetailResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x200350C")]
  public class ContainerMasterBonusDetailResource
  {
    [Token(Token = "0x400E6C6")]
    [FieldOffset(Offset = "0x10")]
    public List<DiffParemeter> masterBonusValues;
    [Token(Token = "0x400E6C7")]
    [FieldOffset(Offset = "0x18")]
    public IMasterBonusData masterbonusdata;
    [Token(Token = "0x400E6C8")]
    [FieldOffset(Offset = "0x20")]
    public Sprite iconMasterBonusType;
    [Token(Token = "0x400E6C9")]
    [FieldOffset(Offset = "0x28")]
    public string textMasterBonusType;
    [Token(Token = "0x400E6CA")]
    [FieldOffset(Offset = "0x30")]
    private Func<string> PhysicalDamageText;
    [Token(Token = "0x400E6CB")]
    [FieldOffset(Offset = "0x38")]
    private Func<string> MagicDamage;
    [Token(Token = "0x400E6CC")]
    [FieldOffset(Offset = "0x40")]
    private Func<string> TakenPhysicalDamage;
    [Token(Token = "0x400E6CD")]
    [FieldOffset(Offset = "0x48")]
    private Func<string> TakenMagicDamage;
    [Token(Token = "0x400E6CE")]
    [FieldOffset(Offset = "0x50")]
    private Func<string> TakenHit;
    [Token(Token = "0x400E6CF")]
    [FieldOffset(Offset = "0x58")]
    private Func<string> Hit;
    [Token(Token = "0x400E6D0")]
    [FieldOffset(Offset = "0x60")]
    private Func<string> Critical;
    [Token(Token = "0x400E6D1")]
    [FieldOffset(Offset = "0x68")]
    private Func<string> TakenCritical;
    [Token(Token = "0x400E6D2")]
    [FieldOffset(Offset = "0x70")]
    private Func<string> Hp;

    [Token(Token = "0x6014CF4")]
    [Address(RVA = "0x1B37A5C", Offset = "0x1B37A5C", VA = "0x1B37A5C")]
    public void AddEffectValues(
      StyleMasterBonusDescriptionData beforeDescriptionData,
      StyleMasterBonusDescriptionData afterDescriptionData)
    {
    }

    [Token(Token = "0x6014CF5")]
    [Address(RVA = "0x1B380E0", Offset = "0x1B380E0", VA = "0x1B380E0")]
    public void AddEffectValues(
      WeaponMasterBonusDescriptionData beforeDescriptionData,
      WeaponMasterBonusDescriptionData afterDescriptionData)
    {
    }

    [Token(Token = "0x6014CF6")]
    [Address(RVA = "0x1B38764", Offset = "0x1B38764", VA = "0x1B38764")]
    public ContainerMasterBonusDetailResource()
    {
    }
  }
}
