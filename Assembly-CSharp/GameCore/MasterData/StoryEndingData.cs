// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryEndingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012DF")]
  [Serializable]
  public sealed class StoryEndingData : IMasterDataEntity
  {
    [Token(Token = "0x400598E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400598F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequenceID;
    [Token(Token = "0x4005990")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int endingAdvID;
    [Token(Token = "0x4005991")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int epilogueAdvID;

    [Token(Token = "0x17001028")]
    public int Key
    {
      [Token(Token = "0x6006ADC"), Address(RVA = "0x48DD0F0", Offset = "0x48DD0F0", VA = "0x48DD0F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006ADD")]
    [Address(RVA = "0x48DD0F8", Offset = "0x48DD0F8", VA = "0x48DD0F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006ADE")]
    [Address(RVA = "0x48DD2C4", Offset = "0x48DD2C4", VA = "0x48DD2C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006ADF")]
    [Address(RVA = "0x48DD368", Offset = "0x48DD368", VA = "0x48DD368")]
    public StoryEndingData()
    {
    }
  }
}
