// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceHomeTutorialSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001036")]
  [Serializable]
  public sealed class IntroChapterSequenceHomeTutorialSettingData : IMasterDataEntity
  {
    [Token(Token = "0x4005063")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005064")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string sceneName;
    [Token(Token = "0x4005065")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string subSceneAsset;
    [Token(Token = "0x4005066")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string subSceneName;
    [Token(Token = "0x4005067")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string advAsset;
    [Token(Token = "0x4005068")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string advFileName;

    [Token(Token = "0x17000DE4")]
    public int Key
    {
      [Token(Token = "0x6005E38"), Address(RVA = "0x279A9FC", Offset = "0x279A9FC", VA = "0x279A9FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E39")]
    [Address(RVA = "0x279AA04", Offset = "0x279AA04", VA = "0x279AA04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E3A")]
    [Address(RVA = "0x279AC90", Offset = "0x279AC90", VA = "0x279AC90", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E3B")]
    [Address(RVA = "0x279AD68", Offset = "0x279AD68", VA = "0x279AD68")]
    public IntroChapterSequenceHomeTutorialSettingData()
    {
    }
  }
}
