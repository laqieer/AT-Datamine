// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.MindequipmentDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData.StatusIcon;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x200343D")]
  public class MindequipmentDetailPopup : PopupBase
  {
    [Token(Token = "0x400E35B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text mindEquipmentName;
    [Token(Token = "0x400E35C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private MindequipmentThumb thumb;
    [Token(Token = "0x400E35D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private MindequipmentDetailPopup.LimitBreakIcon[] limitBreakIcons;
    [Token(Token = "0x400E35E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text nowLv;
    [Token(Token = "0x400E35F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text maxLv;
    [Token(Token = "0x400E360")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text totalPower;
    [Token(Token = "0x400E361")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text[] statusTexts;
    [Token(Token = "0x400E362")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;
    [Token(Token = "0x400E363")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Image skillTypeIcon;
    [Token(Token = "0x400E364")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text skillTypeText;
    [Token(Token = "0x400E365")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private SkillIconSub[] skillIconSubs;
    [Token(Token = "0x400E366")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject emptySubSkillIcon;
    [Token(Token = "0x400E367")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject customSkillGroup;
    [Token(Token = "0x400E368")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CustomSkillIcon customSkillIcon;
    [Token(Token = "0x400E369")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text customSkillName;
    [Token(Token = "0x400E36A")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private MindequipmentDetailPopup.SwapButton addStatusButton;
    [Token(Token = "0x400E36B")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private MindequipmentDetailPopup.SwapButton memoryButton;
    [Token(Token = "0x400E36C")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private AddStatusView addStatusView;
    [Token(Token = "0x400E36D")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text memoryText;
    [Token(Token = "0x400E36E")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject memoruGroup;
    [Token(Token = "0x400E36F")]
    [FieldOffset(Offset = "0x128")]
    private IconFactory iconFactory;
    [Token(Token = "0x400E370")]
    [FieldOffset(Offset = "0x130")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400E372")]
    [FieldOffset(Offset = "0x140")]
    private MindEquipmentData mindEquipmentMasterData;

    [Token(Token = "0x17004449")]
    public Action<int> OnClickSkillDetail
    {
      [Token(Token = "0x601487E"), Address(RVA = "0x1A9CCAC", Offset = "0x1A9CCAC", VA = "0x1A9CCAC")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601487F"), Address(RVA = "0x1A9CCB4", Offset = "0x1A9CCB4", VA = "0x1A9CCB4")] set
      {
      }
    }

    [Token(Token = "0x6014880")]
    [Address(RVA = "0x1A9CCBC", Offset = "0x1A9CCBC", VA = "0x1A9CCBC")]
    public IEnumerator SetData(
      int equipmentId,
      RewardTypeEnum rewardType,
      AssetCachedSpawner assetCachedSpawner,
      IconFactory iconFactory)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014881")]
    [Address(RVA = "0x1A9CD74", Offset = "0x1A9CD74", VA = "0x1A9CD74")]
    public void OnClickToPartySkillDetail()
    {
    }

    [Token(Token = "0x6014882")]
    [Address(RVA = "0x1A9CDAC", Offset = "0x1A9CDAC", VA = "0x1A9CDAC")]
    public void OnClickToCustomSkillDetail()
    {
    }

    [Token(Token = "0x6014883")]
    [Address(RVA = "0x1A9CDF0", Offset = "0x1A9CDF0", VA = "0x1A9CDF0")]
    public void OnClickChangeToggleByAddStatus()
    {
    }

    [Token(Token = "0x6014884")]
    [Address(RVA = "0x1A9CEB8", Offset = "0x1A9CEB8", VA = "0x1A9CEB8")]
    public void OnClickChangeToggleByMemory()
    {
    }

    [Token(Token = "0x6014885")]
    [Address(RVA = "0x1A9CF44", Offset = "0x1A9CF44", VA = "0x1A9CF44")]
    public MindequipmentDetailPopup()
    {
    }

    [Token(Token = "0x200343E")]
    [Serializable]
    public class SwapButton
    {
      [Token(Token = "0x400E373")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject onObj;
      [Token(Token = "0x400E374")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject offObj;
      [Token(Token = "0x400E375")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private bool isOn;

      [Token(Token = "0x1700444A")]
      public bool IsOn
      {
        [Token(Token = "0x6014886"), Address(RVA = "0x1A9CF9C", Offset = "0x1A9CF9C", VA = "0x1A9CF9C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6014887")]
      [Address(RVA = "0x1A9CE6C", Offset = "0x1A9CE6C", VA = "0x1A9CE6C")]
      public void SetFlg(bool isOn)
      {
      }

      [Token(Token = "0x6014888")]
      [Address(RVA = "0x1A9CFA4", Offset = "0x1A9CFA4", VA = "0x1A9CFA4")]
      public SwapButton()
      {
      }
    }

    [Token(Token = "0x200343F")]
    [Serializable]
    public class LimitBreakIcon
    {
      [Token(Token = "0x400E376")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject bg;
      [Token(Token = "0x400E377")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject on;

      [Token(Token = "0x6014889")]
      [Address(RVA = "0x1A9CFAC", Offset = "0x1A9CFAC", VA = "0x1A9CFAC")]
      public void Set(bool isOn)
      {
      }

      [Token(Token = "0x601488A")]
      [Address(RVA = "0x1A9CFF4", Offset = "0x1A9CFF4", VA = "0x1A9CFF4")]
      public LimitBreakIcon()
      {
      }
    }
  }
}
