// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BarrierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DFE")]
  [Serializable]
  public sealed class BarrierData : IMasterDataEntity
  {
    [Token(Token = "0x40042D2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042D3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int resistValue;
    [Token(Token = "0x40042D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public bool weakFire;
    [Token(Token = "0x40042D5")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    public bool weakIce;
    [Token(Token = "0x40042D6")]
    [FieldOffset(Offset = "0x1A")]
    [SerializeField]
    public bool weakThunder;
    [Token(Token = "0x40042D7")]
    [FieldOffset(Offset = "0x1B")]
    [SerializeField]
    public bool weakWind;
    [Token(Token = "0x40042D8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool weakLight;
    [Token(Token = "0x40042D9")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    public bool weakDark;
    [Token(Token = "0x40042DA")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    public bool breakableCounter;
    [Token(Token = "0x40042DB")]
    [FieldOffset(Offset = "0x20")]
    private HashSet<ElementTypeEnum> weakElementHash;

    [Token(Token = "0x17000C3D")]
    public int Key
    {
      [Token(Token = "0x6005557"), Address(RVA = "0x3AAF640", Offset = "0x3AAF640", VA = "0x3AAF640", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005558")]
    [Address(RVA = "0x3AAF648", Offset = "0x3AAF648", VA = "0x3AAF648", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005559")]
    [Address(RVA = "0x3AAFA10", Offset = "0x3AAFA10", VA = "0x3AAFA10", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600555A")]
    [Address(RVA = "0x3AAFB04", Offset = "0x3AAFB04", VA = "0x3AAFB04")]
    public bool IsWeak(ElementTypeEnum element) => new bool();

    [Token(Token = "0x600555B")]
    [Address(RVA = "0x3AAF52C", Offset = "0x3AAF52C", VA = "0x3AAF52C")]
    public void Setup()
    {
    }

    [Token(Token = "0x600555C")]
    private void AddWeak<T>(bool isWeak, HashSet<T> hash, T t) where T : Enum
    {
    }

    [Token(Token = "0x600555D")]
    [Address(RVA = "0x3AAFB5C", Offset = "0x3AAFB5C", VA = "0x3AAFB5C")]
    public BarrierData()
    {
    }
  }
}
