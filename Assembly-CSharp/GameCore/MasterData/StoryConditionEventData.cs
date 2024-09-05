// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryConditionEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120F")]
  [Serializable]
  public sealed class StoryConditionEventData : IMasterDataEntity
  {
    [Token(Token = "0x4005662")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005663")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005664")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int orCondition;
    [Token(Token = "0x4005665")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int sequenceBegin;
    [Token(Token = "0x4005666")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int sequenceEnd;
    [Token(Token = "0x4005667")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int subquest_1;
    [Token(Token = "0x4005668")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int subquest_2;
    [Token(Token = "0x4005669")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int subquest_3;
    [Token(Token = "0x400566A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int eventquest_1;
    [Token(Token = "0x400566B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int eventquest_2;
    [Token(Token = "0x400566C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int eventquest_3;

    [Token(Token = "0x17000F86")]
    public int Key
    {
      [Token(Token = "0x60066FF"), Address(RVA = "0x4D2A910", Offset = "0x4D2A910", VA = "0x4D2A910", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006700")]
    [Address(RVA = "0x4D2A918", Offset = "0x4D2A918", VA = "0x4D2A918", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006701")]
    [Address(RVA = "0x4D2AD84", Offset = "0x4D2AD84", VA = "0x4D2AD84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006702")]
    [Address(RVA = "0x4D2AE9C", Offset = "0x4D2AE9C", VA = "0x4D2AE9C")]
    public bool IsCreatedBySubquest(int subquestID) => new bool();

    [Token(Token = "0x6006703")]
    [Address(RVA = "0x4D2B060", Offset = "0x4D2B060", VA = "0x4D2B060")]
    public bool IsCreatedByEventQuest(int eventQuestID) => new bool();

    [Token(Token = "0x6006704")]
    [Address(RVA = "0x4D2B224", Offset = "0x4D2B224", VA = "0x4D2B224")]
    public StoryConditionEventData()
    {
    }
  }
}
