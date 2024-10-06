// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSwitchingPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D6")]
  [Serializable]
  public sealed class StoryAreaMovableSwitchingPatternData : IMasterDataEntity
  {
    [Token(Token = "0x40055B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40055B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int defaultMobBuildID;
    [Token(Token = "0x40055B6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int outdoorRainyMobBuildID;

    [Token(Token = "0x17000F63")]
    public int Key
    {
      [Token(Token = "0x6006608"), Address(RVA = "0x4D217D4", Offset = "0x4D217D4", VA = "0x4D217D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006609")]
    [Address(RVA = "0x4D217DC", Offset = "0x4D217DC", VA = "0x4D217DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600660A")]
    [Address(RVA = "0x4D219A8", Offset = "0x4D219A8", VA = "0x4D219A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600660B")]
    [Address(RVA = "0x4D21A50", Offset = "0x4D21A50", VA = "0x4D21A50")]
    public StoryAreaMovableSwitchingPatternData()
    {
    }
  }
}
