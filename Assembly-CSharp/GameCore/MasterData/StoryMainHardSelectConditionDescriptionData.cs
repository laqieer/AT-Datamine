// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainHardSelectConditionDescriptionData
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
  [Token(Token = "0x200115B")]
  [Serializable]
  public sealed class StoryMainHardSelectConditionDescriptionData : 
    IMasterDataEntity,
    IQuestReleaseConditionDescriptionData
  {
    [Token(Token = "0x4005430")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005431")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int storyMainHardSelectConditionId;
    [Token(Token = "0x4005432")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum booleanType;
    [Token(Token = "0x4005433")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int areaNodeId;
    [Token(Token = "0x4005434")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyChapterId;
    [Token(Token = "0x4005435")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int storyChapterLoopNum;

    [Token(Token = "0x17000F04")]
    public int Key
    {
      [Token(Token = "0x60063CA"), Address(RVA = "0x4AEB3C8", Offset = "0x4AEB3C8", VA = "0x4AEB3C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60063CB")]
    [Address(RVA = "0x4AEB3D0", Offset = "0x4AEB3D0", VA = "0x4AEB3D0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60063CC")]
    [Address(RVA = "0x4AEB65C", Offset = "0x4AEB65C", VA = "0x4AEB65C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F05")]
    public int AreaNodeId
    {
      [Token(Token = "0x60063CD"), Address(RVA = "0x4AEB720", Offset = "0x4AEB720", VA = "0x4AEB720", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F06")]
    public int StoryChapterId
    {
      [Token(Token = "0x60063CE"), Address(RVA = "0x4AEB728", Offset = "0x4AEB728", VA = "0x4AEB728", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F07")]
    public int StoryChapterLoopNum
    {
      [Token(Token = "0x60063CF"), Address(RVA = "0x4AEB730", Offset = "0x4AEB730", VA = "0x4AEB730", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F08")]
    public ConditionOpTypeEnum BooleanType
    {
      [Token(Token = "0x60063D0"), Address(RVA = "0x4AEB738", Offset = "0x4AEB738", VA = "0x4AEB738", Slot = "10")] get
      {
        return new ConditionOpTypeEnum();
      }
    }

    [Token(Token = "0x60063D1")]
    [Address(RVA = "0x4AEB740", Offset = "0x4AEB740", VA = "0x4AEB740")]
    public StoryMainHardSelectConditionDescriptionData()
    {
    }
  }
}
