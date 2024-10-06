// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceConditionTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A3")]
  [Serializable]
  public sealed class StoryMainQuestSequenceConditionTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40058D9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058DA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public StorySequenceConditionTypeEnum StorySequenceConditionType;

    [Token(Token = "0x17000FFB")]
    public int Key
    {
      [Token(Token = "0x60069D1"), Address(RVA = "0x48D3790", Offset = "0x48D3790", VA = "0x48D3790", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069D2")]
    [Address(RVA = "0x48D3798", Offset = "0x48D3798", VA = "0x48D3798", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069D3")]
    [Address(RVA = "0x48D3974", Offset = "0x48D3974", VA = "0x48D3974", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60069D4")]
    [Address(RVA = "0x48D39F8", Offset = "0x48D39F8", VA = "0x48D39F8")]
    public StoryMainQuestSequenceConditionTypeData()
    {
    }
  }
}
