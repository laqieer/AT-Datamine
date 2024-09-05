// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionOpenDataCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002992")]
  public class EventMissionOpenDataCell : MonoBehaviour
  {
    [Token(Token = "0x400B117")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("左側")]
    [Space(5f)]
    private TextMeshProUGUI missionSummary;
    [Token(Token = "0x400B118")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("アイテム表示")]
    private GameObject itemRoot;
    [Token(Token = "0x400B119")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemIcon itemContent;
    [Token(Token = "0x400B11A")]
    [FieldOffset(Offset = "0x30")]
    [Header("ボタン")]
    [Space(5f)]
    [SerializeField]
    [Header("右側")]
    private Button buttonReceipt;
    [Token(Token = "0x400B11B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton noFinishBtn;
    [Token(Token = "0x400B11C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button buttonClose;
    [Token(Token = "0x400B11D")]
    [FieldOffset(Offset = "0x48")]
    [Header("進捗ゲージ")]
    [SerializeField]
    private Slider currGauge;
    [Token(Token = "0x400B11E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI progressDenominator;
    [Token(Token = "0x400B11F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI progressNumerator;
    [Token(Token = "0x400B120")]
    [FieldOffset(Offset = "0x60")]
    [Header("NewBadge")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400B121")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup tg;
    [Token(Token = "0x400B122")]
    [FieldOffset(Offset = "0x70")]
    private EventMissionCellData _cellData;

    [Token(Token = "0x6010551")]
    [Address(RVA = "0x475CB6C", Offset = "0x475CB6C", VA = "0x475CB6C")]
    public void Initialize(EventMissionCellData cellData)
    {
    }

    [Token(Token = "0x6010552")]
    [Address(RVA = "0x4760F90", Offset = "0x4760F90", VA = "0x4760F90")]
    private void SettingRectTransform()
    {
    }

    [Token(Token = "0x6010553")]
    [Address(RVA = "0x47617B0", Offset = "0x47617B0", VA = "0x47617B0")]
    private void ButtonSetting()
    {
    }

    [Token(Token = "0x6010554")]
    [Address(RVA = "0x4761120", Offset = "0x4761120", VA = "0x4761120")]
    private void SettingItemList()
    {
    }

    [Token(Token = "0x6010555")]
    [Address(RVA = "0x476103C", Offset = "0x476103C", VA = "0x476103C")]
    private void SettingGauge()
    {
    }

    [Token(Token = "0x6010556")]
    [Address(RVA = "0x4761984", Offset = "0x4761984", VA = "0x4761984")]
    public void OpenItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010557")]
    [Address(RVA = "0x47619B0", Offset = "0x47619B0", VA = "0x47619B0")]
    public EventMissionOpenDataCell()
    {
    }
  }
}
