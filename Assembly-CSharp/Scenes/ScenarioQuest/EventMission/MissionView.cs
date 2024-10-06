// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.MissionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x20029A5")]
  public class MissionView : MonoBehaviour
  {
    [Token(Token = "0x400B166")]
    [FieldOffset(Offset = "0x18")]
    [Header("一括受け取りボタン")]
    [SerializeField]
    private CommonButton receiptButton;
    [Token(Token = "0x400B167")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("右下側 イベントリスト")]
    [Space(5f)]
    private EventMissionListView eventMissionListView;
    [Token(Token = "0x400B168")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(5f)]
    [Header("タイムリミット")]
    protected TextMeshProUGUI limitDateText;
    [Token(Token = "0x400B169")]
    [FieldOffset(Offset = "0x30")]
    protected AssetCachedSpawner _spawner;

    [Token(Token = "0x17003918")]
    public CommonButton BulkReceiptButton
    {
      [Token(Token = "0x60105AF"), Address(RVA = "0x4881BC8", Offset = "0x4881BC8", VA = "0x4881BC8")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x60105B0")]
    [Address(RVA = "0x4881BD0", Offset = "0x4881BD0", VA = "0x4881BD0")]
    public void Initialize(AssetCachedSpawner acspawner)
    {
    }

    [Token(Token = "0x60105B1")]
    [Address(RVA = "0x4881BD8", Offset = "0x4881BD8", VA = "0x4881BD8")]
    public void SetTimeLimitDateText(int day, int hour, int minutes)
    {
    }

    [Token(Token = "0x60105B2")]
    [Address(RVA = "0x4881D0C", Offset = "0x4881D0C", VA = "0x4881D0C")]
    public void SetMissionListData(List<MissionDataList> missionDataList)
    {
    }

    [Token(Token = "0x60105B3")]
    [Address(RVA = "0x4881D28", Offset = "0x4881D28", VA = "0x4881D28")]
    public void ViewGetRewards(List<DisplayItemRewardInfoData> rewards, Action callback)
    {
    }

    [Token(Token = "0x60105B4")]
    [Address(RVA = "0x4881DBC", Offset = "0x4881DBC", VA = "0x4881DBC")]
    public void SetInteractableBulkReceiptButton(bool interactable)
    {
    }

    [Token(Token = "0x60105B5")]
    [Address(RVA = "0x4881D48", Offset = "0x4881D48", VA = "0x4881D48")]
    private IEnumerator ShowRewardNofity(List<DisplayItemRewardInfoData> rewards, Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60105B6")]
    [Address(RVA = "0x4881288", Offset = "0x4881288", VA = "0x4881288")]
    public MissionView()
    {
    }
  }
}
