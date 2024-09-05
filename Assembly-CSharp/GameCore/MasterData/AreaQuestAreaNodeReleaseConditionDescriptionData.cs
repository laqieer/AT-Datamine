// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeReleaseConditionDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F6")]
  [Serializable]
  public sealed class AreaQuestAreaNodeReleaseConditionDescriptionData : 
    IMasterDataEntity,
    IQuestReleaseConditionDescriptionData
  {
    [Token(Token = "0x40052DB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052DC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaNodeReleaseConditionId;
    [Token(Token = "0x40052DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum booleanType;
    [Token(Token = "0x40052DE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int areaNodeId;

    [Token(Token = "0x17000E92")]
    public int Key
    {
      [Token(Token = "0x60061CC"), Address(RVA = "0x4AD8838", Offset = "0x4AD8838", VA = "0x4AD8838", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061CD")]
    [Address(RVA = "0x4AD8840", Offset = "0x4AD8840", VA = "0x4AD8840", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061CE")]
    [Address(RVA = "0x4AD8A0C", Offset = "0x4AD8A0C", VA = "0x4AD8A0C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E93")]
    public int AreaNodeId
    {
      [Token(Token = "0x60061CF"), Address(RVA = "0x4AD8AB0", Offset = "0x4AD8AB0", VA = "0x4AD8AB0", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E94")]
    public int StoryChapterId
    {
      [Token(Token = "0x60061D0"), Address(RVA = "0x4AD8AB8", Offset = "0x4AD8AB8", VA = "0x4AD8AB8", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E95")]
    public int StoryChapterLoopNum
    {
      [Token(Token = "0x60061D1"), Address(RVA = "0x4AD8AC0", Offset = "0x4AD8AC0", VA = "0x4AD8AC0", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E96")]
    public ConditionOpTypeEnum BooleanType
    {
      [Token(Token = "0x60061D2"), Address(RVA = "0x4AD8AC8", Offset = "0x4AD8AC8", VA = "0x4AD8AC8", Slot = "10")] get
      {
        return new ConditionOpTypeEnum();
      }
    }

    [Token(Token = "0x60061D3")]
    [Address(RVA = "0x4AD8AD0", Offset = "0x4AD8AD0", VA = "0x4AD8AD0")]
    public AreaQuestAreaNodeReleaseConditionDescriptionData()
    {
    }
  }
}
