// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.MissionDataList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.ItemDetail;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x200298F")]
  public class MissionDataList
  {
    [Token(Token = "0x400B105")]
    [FieldOffset(Offset = "0x10")]
    public int MissionId;
    [Token(Token = "0x400B106")]
    [FieldOffset(Offset = "0x18")]
    public string MissionName;
    [Token(Token = "0x400B107")]
    [FieldOffset(Offset = "0x20")]
    public string DayName;
    [Token(Token = "0x400B108")]
    [FieldOffset(Offset = "0x28")]
    public bool IsOpen;
    [Token(Token = "0x400B109")]
    [FieldOffset(Offset = "0x29")]
    public bool IsAccepted;
    [Token(Token = "0x400B10A")]
    [FieldOffset(Offset = "0x2C")]
    public int ProgressDenominator;
    [Token(Token = "0x400B10B")]
    [FieldOffset(Offset = "0x30")]
    public int ProgressNumerator;
    [Token(Token = "0x400B10C")]
    [FieldOffset(Offset = "0x34")]
    public bool IsNew;
    [Token(Token = "0x400B10D")]
    [FieldOffset(Offset = "0x38")]
    public List<MissionRewardData> Rewards;
    [Token(Token = "0x400B10E")]
    [FieldOffset(Offset = "0x40")]
    public Action<List<int>> OnClickReceipt;
    [Token(Token = "0x400B10F")]
    [FieldOffset(Offset = "0x48")]
    public ItemDetailPopupProvider PopupGenerator;

    [Token(Token = "0x601054E")]
    [Address(RVA = "0x475FC54", Offset = "0x475FC54", VA = "0x475FC54")]
    public MissionDataList(
      int missionId,
      string missionName,
      string day,
      bool isOpen,
      bool isAccepted,
      int progressDenominator,
      int progressNumerator,
      bool isNew,
      List<MissionRewardData> rewards,
      Action<List<int>> oncliclReceipt = null)
    {
    }
  }
}
