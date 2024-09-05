// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001106")]
  [Serializable]
  public sealed class AreaQuestAreaData : IMasterDataEntity
  {
    [Token(Token = "0x4005307")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005308")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string refName;
    [Token(Token = "0x4005309")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int areaGroupId;
    [Token(Token = "0x400530A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int areaReleaseConditionId;
    [Token(Token = "0x400530B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public SchedulePeriodTypeEnum schedulePeriodType;
    [Token(Token = "0x400530C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime scheduleStartAt;
    [Token(Token = "0x400530D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime scheduleEndAt;
    [Token(Token = "0x400530E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int areanodeShortcutGroupId;
    [Token(Token = "0x400530F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int firstPositionAreaNodeId;
    [Token(Token = "0x4005310")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int dotStyleIdOnAreaNode;
    [Token(Token = "0x4005311")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int areaImageId;
    [Token(Token = "0x4005312")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int screenScrollHeightLimit;
    [Token(Token = "0x4005313")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int screenScrollWidthLimit;
    [Token(Token = "0x4005314")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string bgmPackName;
    [Token(Token = "0x4005315")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public string bgmEventName;
    [Token(Token = "0x4005316")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public bool hasAreaReleaseDirection;

    [Token(Token = "0x17000EA4")]
    public int Key
    {
      [Token(Token = "0x600621F"), Address(RVA = "0x4ADC22C", Offset = "0x4ADC22C", VA = "0x4ADC22C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006220")]
    [Address(RVA = "0x4ADC234", Offset = "0x4ADC234", VA = "0x4ADC234", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006221")]
    [Address(RVA = "0x4ADC884", Offset = "0x4ADC884", VA = "0x4ADC884", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006222")]
    [Address(RVA = "0x4ADCA48", Offset = "0x4ADCA48", VA = "0x4ADCA48")]
    public AreaQuestAreaData()
    {
    }
  }
}
