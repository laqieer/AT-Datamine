// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterInfluenceRateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001364")]
  [Serializable]
  public sealed class CharacterInfluenceRateData : IMasterDataEntity
  {
    [Token(Token = "0x4005B0A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B0B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rank;
    [Token(Token = "0x4005B0C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int influenceRate;

    [Token(Token = "0x17001074")]
    public int Key
    {
      [Token(Token = "0x6006D36"), Address(RVA = "0x46FADC0", Offset = "0x46FADC0", VA = "0x46FADC0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D37")]
    [Address(RVA = "0x46FADC8", Offset = "0x46FADC8", VA = "0x46FADC8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D38")]
    [Address(RVA = "0x46FAF34", Offset = "0x46FAF34", VA = "0x46FAF34", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D39")]
    [Address(RVA = "0x46FAFC8", Offset = "0x46FAFC8", VA = "0x46FAFC8")]
    public CharacterInfluenceRateData()
    {
    }
  }
}
