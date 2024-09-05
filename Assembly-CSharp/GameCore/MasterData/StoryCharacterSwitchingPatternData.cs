// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCharacterSwitchingPatternData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011ED")]
  [Serializable]
  public sealed class StoryCharacterSwitchingPatternData : IMasterDataEntity
  {
    [Token(Token = "0x40055FE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005600")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int statusStyleID;
    [Token(Token = "0x4005601")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int normalCharcterBuildDataID;
    [Token(Token = "0x4005602")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int killersCharcterBuildDataID;
    [Token(Token = "0x4005603")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int outdoorRainyCharcterBuildDataID;

    [Token(Token = "0x17000F73")]
    public int Key
    {
      [Token(Token = "0x6006663"), Address(RVA = "0x4D250E8", Offset = "0x4D250E8", VA = "0x4D250E8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006664")]
    [Address(RVA = "0x4D250F0", Offset = "0x4D250F0", VA = "0x4D250F0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006665")]
    [Address(RVA = "0x4D2537C", Offset = "0x4D2537C", VA = "0x4D2537C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006666")]
    [Address(RVA = "0x4D25444", Offset = "0x4D25444", VA = "0x4D25444")]
    public StoryCharacterSwitchingPatternData()
    {
    }
  }
}
