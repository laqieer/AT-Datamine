// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceBattleSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001031")]
  [Serializable]
  public sealed class IntroChapterSequenceBattleSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005051")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005052")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int storyMainBattleQuestID;

    [Token(Token = "0x17000DE2")]
    public int Key
    {
      [Token(Token = "0x6005E28"), Address(RVA = "0x279A1FC", Offset = "0x279A1FC", VA = "0x279A1FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E29")]
    [Address(RVA = "0x279A204", Offset = "0x279A204", VA = "0x279A204", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E2A")]
    [Address(RVA = "0x279A310", Offset = "0x279A310", VA = "0x279A310", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E2B")]
    [Address(RVA = "0x279A394", Offset = "0x279A394", VA = "0x279A394")]
    public IntroChapterSequenceBattleSettingData()
    {
    }
  }
}
