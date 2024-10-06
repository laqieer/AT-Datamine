// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C3")]
  [Serializable]
  public sealed class StoryReplayData : IMasterDataEntity
  {
    [Token(Token = "0x400592A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400592B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400592C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyReplayCategoryType;
    [Token(Token = "0x400592D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int bannerImageId;

    [Token(Token = "0x17001013")]
    public int Key
    {
      [Token(Token = "0x6006A69"), Address(RVA = "0x48D8BA4", Offset = "0x48D8BA4", VA = "0x48D8BA4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A6A")]
    [Address(RVA = "0x48D8BAC", Offset = "0x48D8BAC", VA = "0x48D8BAC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A6B")]
    [Address(RVA = "0x48D8D78", Offset = "0x48D8D78", VA = "0x48D8D78", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006A6C")]
    [Address(RVA = "0x48D8E20", Offset = "0x48D8E20", VA = "0x48D8E20")]
    public StoryReplayData()
    {
    }
  }
}
