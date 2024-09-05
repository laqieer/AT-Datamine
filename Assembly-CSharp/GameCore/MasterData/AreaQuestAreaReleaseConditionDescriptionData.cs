// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaReleaseConditionDescriptionData
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
  [Token(Token = "0x2001100")]
  [Serializable]
  public sealed class AreaQuestAreaReleaseConditionDescriptionData : 
    IMasterDataEntity,
    IQuestReleaseConditionDescriptionData
  {
    [Token(Token = "0x40052FF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005300")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaReleaseConditionId;
    [Token(Token = "0x4005301")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum booleanType;
    [Token(Token = "0x4005302")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int areaNodeId;

    [Token(Token = "0x17000E9E")]
    public int Key
    {
      [Token(Token = "0x6006205"), Address(RVA = "0x4ADB980", Offset = "0x4ADB980", VA = "0x4ADB980", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006206")]
    [Address(RVA = "0x4ADB988", Offset = "0x4ADB988", VA = "0x4ADB988", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006207")]
    [Address(RVA = "0x4ADBB54", Offset = "0x4ADBB54", VA = "0x4ADBB54", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E9F")]
    public int AreaNodeId
    {
      [Token(Token = "0x6006208"), Address(RVA = "0x4ADBBF8", Offset = "0x4ADBBF8", VA = "0x4ADBBF8", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EA0")]
    public int StoryChapterId
    {
      [Token(Token = "0x6006209"), Address(RVA = "0x4ADBC00", Offset = "0x4ADBC00", VA = "0x4ADBC00", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EA1")]
    public int StoryChapterLoopNum
    {
      [Token(Token = "0x600620A"), Address(RVA = "0x4ADBC08", Offset = "0x4ADBC08", VA = "0x4ADBC08", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EA2")]
    public ConditionOpTypeEnum BooleanType
    {
      [Token(Token = "0x600620B"), Address(RVA = "0x4ADBC10", Offset = "0x4ADBC10", VA = "0x4ADBC10", Slot = "10")] get
      {
        return new ConditionOpTypeEnum();
      }
    }

    [Token(Token = "0x600620C")]
    [Address(RVA = "0x4ADBC18", Offset = "0x4ADBC18", VA = "0x4ADBC18")]
    public AreaQuestAreaReleaseConditionDescriptionData()
    {
    }
  }
}
