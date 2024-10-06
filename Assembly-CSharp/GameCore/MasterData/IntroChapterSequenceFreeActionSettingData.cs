// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceFreeActionSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001034")]
  [Serializable]
  public sealed class IntroChapterSequenceFreeActionSettingData : IMasterDataEntity
  {
    [Token(Token = "0x400505B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400505C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int storyFreeActionSettingID;
    [Token(Token = "0x400505D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string advAsset1;
    [Token(Token = "0x400505E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string advFileName1;
    [Token(Token = "0x400505F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string advAsset2;
    [Token(Token = "0x4005060")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string advFileName2;
    [Token(Token = "0x4005061")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int playerFreeActionPlayerId;
    [Token(Token = "0x4005062")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float swipTutorialDisplayTime;

    [Token(Token = "0x17000DE3")]
    public int Key
    {
      [Token(Token = "0x6005E30"), Address(RVA = "0x279A4A4", Offset = "0x279A4A4", VA = "0x279A4A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E31")]
    [Address(RVA = "0x279A4AC", Offset = "0x279A4AC", VA = "0x279A4AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E32")]
    [Address(RVA = "0x279A7F8", Offset = "0x279A7F8", VA = "0x279A7F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E33")]
    [Address(RVA = "0x279A8EC", Offset = "0x279A8EC", VA = "0x279A8EC")]
    public IntroChapterSequenceFreeActionSettingData()
    {
    }
  }
}
