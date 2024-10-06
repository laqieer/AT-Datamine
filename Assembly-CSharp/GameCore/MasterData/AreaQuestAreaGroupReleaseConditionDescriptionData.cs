// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaGroupReleaseConditionDescriptionData
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
  [Token(Token = "0x20010EA")]
  [Serializable]
  public sealed class AreaQuestAreaGroupReleaseConditionDescriptionData : 
    IMasterDataEntity,
    IQuestReleaseConditionDescriptionData
  {
    [Token(Token = "0x40052BA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052BB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaGroupReleaseConditionId;
    [Token(Token = "0x40052BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConditionOpTypeEnum booleanType;
    [Token(Token = "0x40052BD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int areaNodeId;
    [Token(Token = "0x40052BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storyChapterId;
    [Token(Token = "0x40052BF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int storyChapterLoopNum;

    [Token(Token = "0x17000E83")]
    public int Key
    {
      [Token(Token = "0x6006187"), Address(RVA = "0x28E14A4", Offset = "0x28E14A4", VA = "0x28E14A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006188")]
    [Address(RVA = "0x28E14AC", Offset = "0x28E14AC", VA = "0x28E14AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006189")]
    [Address(RVA = "0x28E1738", Offset = "0x28E1738", VA = "0x28E1738", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E84")]
    public int AreaNodeId
    {
      [Token(Token = "0x600618A"), Address(RVA = "0x28E17FC", Offset = "0x28E17FC", VA = "0x28E17FC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E85")]
    public int StoryChapterId
    {
      [Token(Token = "0x600618B"), Address(RVA = "0x28E1804", Offset = "0x28E1804", VA = "0x28E1804", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E86")]
    public int StoryChapterLoopNum
    {
      [Token(Token = "0x600618C"), Address(RVA = "0x28E180C", Offset = "0x28E180C", VA = "0x28E180C", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E87")]
    public ConditionOpTypeEnum BooleanType
    {
      [Token(Token = "0x600618D"), Address(RVA = "0x28E1814", Offset = "0x28E1814", VA = "0x28E1814", Slot = "10")] get
      {
        return new ConditionOpTypeEnum();
      }
    }

    [Token(Token = "0x600618E")]
    [Address(RVA = "0x28E181C", Offset = "0x28E181C", VA = "0x28E181C")]
    public AreaQuestAreaGroupReleaseConditionDescriptionData()
    {
    }
  }
}
