// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CharacterLimitReleaseDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001368")]
  [Serializable]
  public sealed class CharacterLimitReleaseDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4005B11")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B12")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int characterLimitRelease;
    [Token(Token = "0x4005B13")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int releaseState;
    [Token(Token = "0x4005B14")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int influenceRateLimit;

    [Token(Token = "0x17001075")]
    public int Key
    {
      [Token(Token = "0x6006D48"), Address(RVA = "0x46FB7BC", Offset = "0x46FB7BC", VA = "0x46FB7BC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D49")]
    [Address(RVA = "0x46FB7C4", Offset = "0x46FB7C4", VA = "0x46FB7C4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D4A")]
    [Address(RVA = "0x46FB990", Offset = "0x46FB990", VA = "0x46FB990", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D4B")]
    [Address(RVA = "0x46FBA34", Offset = "0x46FBA34", VA = "0x46FBA34")]
    public CharacterLimitReleaseDetailData()
    {
    }
  }
}
