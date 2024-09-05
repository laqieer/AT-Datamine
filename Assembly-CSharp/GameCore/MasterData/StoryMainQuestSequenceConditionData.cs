// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A1")]
  [Serializable]
  public sealed class StoryMainQuestSequenceConditionData : IMasterDataEntity
  {
    [Token(Token = "0x40058D2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058D3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequenceID;
    [Token(Token = "0x40058D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int storyPointId;
    [Token(Token = "0x40058D5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int storyPointValue;
    [Token(Token = "0x40058D6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int nextSequenceId;
    [Token(Token = "0x40058D7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool turningPoint;
    [Token(Token = "0x40058D8")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17000FF9")]
    public int Key
    {
      [Token(Token = "0x60069C8"), Address(RVA = "0x48D3248", Offset = "0x48D3248", VA = "0x48D3248", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069C9")]
    [Address(RVA = "0x48D3250", Offset = "0x48D3250", VA = "0x48D3250", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069CA")]
    [Address(RVA = "0x48D34E0", Offset = "0x48D34E0", VA = "0x48D34E0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FFA")]
    public string Text
    {
      [Token(Token = "0x60069CB"), Address(RVA = "0x48D35A4", Offset = "0x48D35A4", VA = "0x48D35A4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60069CC")]
    [Address(RVA = "0x48D3680", Offset = "0x48D3680", VA = "0x48D3680")]
    public StoryMainQuestSequenceConditionData()
    {
    }
  }
}
