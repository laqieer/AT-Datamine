// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F44")]
  [Serializable]
  public sealed class AccessoryOptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004CE5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CE6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string referenceName;
    [Token(Token = "0x4004CE7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int optionGrade;
    [Token(Token = "0x4004CE8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AccessroyOptionEffectTypeEnum effectType;
    [Token(Token = "0x4004CE9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float randomValueMinimum;
    [Token(Token = "0x4004CEA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float randomValueMaximum;

    [Token(Token = "0x17000D5B")]
    public int Key
    {
      [Token(Token = "0x60059FA"), Address(RVA = "0x3C3A718", Offset = "0x3C3A718", VA = "0x3C3A718", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059FB")]
    [Address(RVA = "0x3C3A720", Offset = "0x3C3A720", VA = "0x3C3A720", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059FC")]
    [Address(RVA = "0x3C3A9AC", Offset = "0x3C3A9AC", VA = "0x3C3A9AC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D5C")]
    public string Name
    {
      [Token(Token = "0x60059FD"), Address(RVA = "0x3C3AA74", Offset = "0x3C3AA74", VA = "0x3C3AA74")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60059FE")]
    [Address(RVA = "0x3C3AAE4", Offset = "0x3C3AAE4", VA = "0x3C3AAE4")]
    public AccessoryOptionData()
    {
    }
  }
}
