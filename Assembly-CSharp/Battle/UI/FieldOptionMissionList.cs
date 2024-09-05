// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldOptionMissionList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002320")]
  public class FieldOptionMissionList : MonoBehaviour
  {
    [Token(Token = "0x40094DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform clearRewardIconTrans;
    [Token(Token = "0x40094E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text missionText;
    [Token(Token = "0x40094E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text itemNameText;
    [Token(Token = "0x40094E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text rewardNumText;
    [Token(Token = "0x40094E3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject checkBoxOn;
    [Token(Token = "0x40094E4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject checkBoxOff;
    [Token(Token = "0x40094E5")]
    [FieldOffset(Offset = "0x48")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x40094E6")]
    [FieldOffset(Offset = "0x50")]
    private Transform frontTrans;

    [Token(Token = "0x600D6BC")]
    [Address(RVA = "0x1D22574", Offset = "0x1D22574", VA = "0x1D22574")]
    public void Initialize(
      IMissionData mission,
      bool isAlreadyClear,
      GameObject itemPrefab,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      Transform frontTrans)
    {
    }

    [Token(Token = "0x600D6BD")]
    [Address(RVA = "0x1D22E04", Offset = "0x1D22E04", VA = "0x1D22E04")]
    private void OnClickItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x600D6BE")]
    [Address(RVA = "0x1D22E7C", Offset = "0x1D22E7C", VA = "0x1D22E7C")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x600D6BF")]
    [Address(RVA = "0x1D22E90", Offset = "0x1D22E90", VA = "0x1D22E90")]
    public FieldOptionMissionList()
    {
    }
  }
}
