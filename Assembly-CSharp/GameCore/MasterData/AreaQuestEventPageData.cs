// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestEventPageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001108")]
  [Serializable]
  public sealed class AreaQuestEventPageData : IMasterDataEntity
  {
    [Token(Token = "0x4005317")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005318")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x4005319")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public SchedulePeriodTypeEnum pageSchedulePeriodType;
    [Token(Token = "0x400531A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime pageScheduleStartAt;
    [Token(Token = "0x400531B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime pageScheduleEndAt;
    [Token(Token = "0x400531C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int areaGroupId;
    [Token(Token = "0x400531D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int medalTradeShopId;
    [Token(Token = "0x400531E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int missionGroupId;
    [Token(Token = "0x400531F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int missionScheduleId;
    [Token(Token = "0x4005320")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int totalMissionEventId;
    [Token(Token = "0x4005321")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int bannerId;
    [Token(Token = "0x4005322")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int pageResourceId;
    [Token(Token = "0x4005323")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string bgmPackName;
    [Token(Token = "0x4005324")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public string bgmEventName;

    [Token(Token = "0x17000EA5")]
    public int Key
    {
      [Token(Token = "0x6006229"), Address(RVA = "0x4ADCE48", Offset = "0x4ADCE48", VA = "0x4ADCE48", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600622A")]
    [Address(RVA = "0x4ADCE50", Offset = "0x4ADCE50", VA = "0x4ADCE50", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600622B")]
    [Address(RVA = "0x4ADD3DC", Offset = "0x4ADD3DC", VA = "0x4ADD3DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EA6")]
    public bool IsHeldNow
    {
      [Token(Token = "0x600622C"), Address(RVA = "0x4ADCB98", Offset = "0x4ADCB98", VA = "0x4ADCB98")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600622D")]
    [Address(RVA = "0x4ADD584", Offset = "0x4ADD584", VA = "0x4ADD584")]
    public AreaQuestEventPageData()
    {
    }
  }
}
