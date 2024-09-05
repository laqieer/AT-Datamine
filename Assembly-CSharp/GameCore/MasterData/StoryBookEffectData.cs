// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D6")]
  [Serializable]
  public sealed class StoryBookEffectData : IMasterDataEntity
  {
    [Token(Token = "0x400596C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400596D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400596E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rentalConditionAbility;
    [Token(Token = "0x400596F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pageNum;
    [Token(Token = "0x4005970")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int firstReward;
    [Token(Token = "0x4005971")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int repeatReward;
    [Token(Token = "0x4005972")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int type;
    [Token(Token = "0x4005973")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int category;
    [Token(Token = "0x4005974")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int arg1;
    [Token(Token = "0x4005975")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int arg2;
    [Token(Token = "0x4005976")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int arg3;

    [Token(Token = "0x1700101C")]
    public int Key
    {
      [Token(Token = "0x6006AAE"), Address(RVA = "0x48DB364", Offset = "0x48DB364", VA = "0x48DB364", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AAF")]
    [Address(RVA = "0x48DB36C", Offset = "0x48DB36C", VA = "0x48DB36C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006AB0")]
    [Address(RVA = "0x48DB7D8", Offset = "0x48DB7D8", VA = "0x48DB7D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700101D")]
    public string FirstCompleteText
    {
      [Token(Token = "0x6006AB1"), Address(RVA = "0x48DB8F0", Offset = "0x48DB8F0", VA = "0x48DB8F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700101E")]
    public string CompleteText
    {
      [Token(Token = "0x6006AB2"), Address(RVA = "0x48DB9CC", Offset = "0x48DB9CC", VA = "0x48DB9CC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700101F")]
    public string AppendEffectText
    {
      [Token(Token = "0x6006AB3"), Address(RVA = "0x48DBAA8", Offset = "0x48DBAA8", VA = "0x48DBAA8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006AB4")]
    [Address(RVA = "0x48DBB84", Offset = "0x48DBB84", VA = "0x48DBB84")]
    public StoryBookEffectData()
    {
    }
  }
}
