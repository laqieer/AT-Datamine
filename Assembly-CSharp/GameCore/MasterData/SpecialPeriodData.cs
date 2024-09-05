// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpecialPeriodData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001147")]
  [Serializable]
  public sealed class SpecialPeriodData : IMasterDataEntity
  {
    [Token(Token = "0x40053EA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public DateTime openAt;
    [Token(Token = "0x40053EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime playableStartAt;
    [Token(Token = "0x40053ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime playableEndAt;
    [Token(Token = "0x40053EE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime closeAt;
    [Token(Token = "0x40053EF")]
    [FieldOffset(Offset = "0x38")]
    private bool isSearchedScenarioQuestID;
    [Token(Token = "0x40053F0")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, List<int>> dicReleaseScenarioQuestIDs;

    [Token(Token = "0x17000EE6")]
    public int Key
    {
      [Token(Token = "0x6006354"), Address(RVA = "0x4AE7254", Offset = "0x4AE7254", VA = "0x4AE7254", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006355")]
    [Address(RVA = "0x4AE725C", Offset = "0x4AE725C", VA = "0x4AE725C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006356")]
    [Address(RVA = "0x4AE7488", Offset = "0x4AE7488", VA = "0x4AE7488", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EE7")]
    public bool IsExistReleaseScenarioQuestIDs
    {
      [Token(Token = "0x6006357"), Address(RVA = "0x4AE75CC", Offset = "0x4AE75CC", VA = "0x4AE75CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EE8")]
    public Dictionary<int, List<int>> DicReleaseScenarioQuestIDs
    {
      [Token(Token = "0x6006358"), Address(RVA = "0x4AE7C48", Offset = "0x4AE7C48", VA = "0x4AE7C48")] get
      {
        return (Dictionary<int, List<int>>) null;
      }
    }

    [Token(Token = "0x6006359")]
    [Address(RVA = "0x4AE75F0", Offset = "0x4AE75F0", VA = "0x4AE75F0")]
    private void SearchReleaseScenarioQuestID(IReadOnlyCollection<SpecialQuestData> questDatas = null)
    {
    }

    [Token(Token = "0x600635A")]
    [Address(RVA = "0x4AE7E58", Offset = "0x4AE7E58", VA = "0x4AE7E58")]
    private void EntryScenarioQuestID(int specialQuestID, int scenarioQuestID)
    {
    }

    [Token(Token = "0x600635B")]
    [Address(RVA = "0x4AE6D64", Offset = "0x4AE6D64", VA = "0x4AE6D64")]
    public bool CheckInRelease(in DateTime datetime) => new bool();

    [Token(Token = "0x600635C")]
    [Address(RVA = "0x4AE80FC", Offset = "0x4AE80FC", VA = "0x4AE80FC")]
    public bool CheckInPlayable(in DateTime datetime) => new bool();

    [Token(Token = "0x17000EE9")]
    public bool IsNotPlayable
    {
      [Token(Token = "0x600635D"), Address(RVA = "0x4AE81AC", Offset = "0x4AE81AC", VA = "0x4AE81AC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EEA")]
    public bool IsEndPlayable
    {
      [Token(Token = "0x600635E"), Address(RVA = "0x4AE8284", Offset = "0x4AE8284", VA = "0x4AE8284")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000EEB")]
    public IReadOnlyCollection<SpecialQuestData> QuestDatas
    {
      [Token(Token = "0x600635F"), Address(RVA = "0x4AE8318", Offset = "0x4AE8318", VA = "0x4AE8318")] get
      {
        return (IReadOnlyCollection<SpecialQuestData>) null;
      }
    }

    [Token(Token = "0x6006360")]
    [Address(RVA = "0x4AE83B4", Offset = "0x4AE83B4", VA = "0x4AE83B4")]
    public SpecialPeriodData()
    {
    }
  }
}
