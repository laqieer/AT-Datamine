// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvPersonalUpTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DBE")]
  [Serializable]
  public sealed class AdvPersonalUpTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40041C0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40041C1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int minValue;
    [Token(Token = "0x40041C2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int maxValue;
    [Token(Token = "0x40041C3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string seName;
    [Token(Token = "0x40041C4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int[] trackNums;

    [Token(Token = "0x17000BFF")]
    public int Key
    {
      [Token(Token = "0x600540A"), Address(RVA = "0x3AA0720", Offset = "0x3AA0720", VA = "0x3AA0720", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600540B")]
    [Address(RVA = "0x3AA0728", Offset = "0x3AA0728", VA = "0x3AA0728", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600540C")]
    [Address(RVA = "0x3AA09E4", Offset = "0x3AA09E4", VA = "0x3AA09E4")]
    public AdvPersonalUpTypeData()
    {
    }
  }
}
