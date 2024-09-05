// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionMissionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.Input;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200231C")]
  public class FieldOptionMissionInfo : MonoBehaviour
  {
    [Token(Token = "0x40094BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40094BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x40094BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject firstClearTitleObj;
    [Token(Token = "0x40094C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject firstClearObj;
    [Token(Token = "0x40094C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform clearRewardIconTrans;
    [Token(Token = "0x40094C2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject firstClearIconEff;
    [Token(Token = "0x40094C3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform missionListTrans;
    [Token(Token = "0x40094C4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text firstRewardName;
    [Token(Token = "0x40094C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text firstRewardNum;
    [Token(Token = "0x40094C6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI goldDropText;
    [Token(Token = "0x40094C7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI silverDropText;
    [Token(Token = "0x40094C8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI bronzeDropText;
    [Token(Token = "0x40094C9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject missionBaseObj;
    [Token(Token = "0x40094CA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40094CB")]
    [FieldOffset(Offset = "0x88")]
    private bool showFlag;
    [Token(Token = "0x40094CC")]
    [FieldOffset(Offset = "0x90")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x40094CD")]
    [FieldOffset(Offset = "0x98")]
    private Transform frontTrans;
    [Token(Token = "0x40094CE")]
    [FieldOffset(Offset = "0xA0")]
    private UnityAction endCallback;

    [Token(Token = "0x17002E4A")]
    public UnityAction CloseButtonEvent
    {
      [Token(Token = "0x600D6A2"), Address(RVA = "0x1D21074", Offset = "0x1D21074", VA = "0x1D21074")] set
      {
      }
    }

    [Token(Token = "0x600D6A3")]
    [Address(RVA = "0x1D21098", Offset = "0x1D21098", VA = "0x1D21098")]
    public IEnumerator InitializeCoroutine(
      int firstClearId,
      bool isFirstClear,
      BoardData board,
      IEnumerable<(IMissionData mission, bool isAlreadyClear)> missionParams,
      GameObject itemPrefab,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      Transform frontTrans,
      UnityAction callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D6A4")]
    [Address(RVA = "0x1D21180", Offset = "0x1D21180", VA = "0x1D21180")]
    private void OnClickItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x600D6A5")]
    [Address(RVA = "0x1D211F8", Offset = "0x1D211F8", VA = "0x1D211F8")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x600D6A6")]
    [Address(RVA = "0x1D2120C", Offset = "0x1D2120C", VA = "0x1D2120C")]
    private void SetUpDropItem(IReadOnlyDictionary<int, int> dropItems)
    {
    }

    [Token(Token = "0x600D6A7")]
    [Address(RVA = "0x1D2143C", Offset = "0x1D2143C", VA = "0x1D2143C")]
    public void Show()
    {
    }

    [Token(Token = "0x600D6A8")]
    [Address(RVA = "0x1D214E0", Offset = "0x1D214E0", VA = "0x1D214E0")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D6A9")]
    [Address(RVA = "0x1D21588", Offset = "0x1D21588", VA = "0x1D21588")]
    public IEnumerator PopupDelete() => (IEnumerator) null;

    [Token(Token = "0x600D6AA")]
    [Address(RVA = "0x1D21618", Offset = "0x1D21618", VA = "0x1D21618")]
    public FieldOptionMissionInfo()
    {
    }
  }
}
