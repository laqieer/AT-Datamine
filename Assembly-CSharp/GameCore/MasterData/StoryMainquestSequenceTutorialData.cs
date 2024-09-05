// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainquestSequenceTutorialData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012AD")]
  [Serializable]
  public sealed class StoryMainquestSequenceTutorialData : IMasterDataEntity
  {
    [Token(Token = "0x40058FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058FC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int chapterId;
    [Token(Token = "0x40058FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int sequenceId;
    [Token(Token = "0x40058FE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int tutorialId;

    [Token(Token = "0x17001008")]
    public int Key
    {
      [Token(Token = "0x6006A0F"), Address(RVA = "0x48D615C", Offset = "0x48D615C", VA = "0x48D615C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A10")]
    [Address(RVA = "0x48D6164", Offset = "0x48D6164", VA = "0x48D6164", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A11")]
    [Address(RVA = "0x48D6330", Offset = "0x48D6330", VA = "0x48D6330", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A12")]
    [Address(RVA = "0x48D63D4", Offset = "0x48D63D4", VA = "0x48D63D4")]
    public StoryMainquestSequenceTutorialData()
    {
    }
  }
}
