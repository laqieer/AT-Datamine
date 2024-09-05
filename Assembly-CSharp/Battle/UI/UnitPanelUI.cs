// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitPanelUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.Info.Style;
using Scenes.OutGame.Info.Style.UI;
using System;
using TeamOrganization;
using UI;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A9")]
  public class UnitPanelUI : MonoBehaviour
  {
    [Token(Token = "0x40097D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleProfileUI styleProfile;
    [Token(Token = "0x40097D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x40097D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AdditionalParametersUI additionalParameters;
    [Token(Token = "0x40097D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitSlotView slotView;
    [Token(Token = "0x40097D8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StyleDotUI styleDot;
    [Token(Token = "0x40097D9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextAccessor combatPower;
    [Token(Token = "0x40097DA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CurrentMaxGaugeUI unitHP;
    [Token(Token = "0x40097DB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BarrierStockUI barrierStock;
    [Token(Token = "0x40097DC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private SkillListUI skillList;
    [Token(Token = "0x40097DD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private BattleConditionView conditionView;
    [Token(Token = "0x40097DE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton prev;
    [Token(Token = "0x40097DF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton next;
    [Token(Token = "0x40097E0")]
    [FieldOffset(Offset = "0x78")]
    protected bool isNeedLp;

    [Token(Token = "0x600DA06")]
    [Address(RVA = "0x22D47C4", Offset = "0x22D47C4", VA = "0x22D47C4")]
    public void Initialize(bool isNeedLp)
    {
    }

    [Token(Token = "0x600DA07")]
    [Address(RVA = "0x22D4840", Offset = "0x22D4840", VA = "0x22D4840")]
    public UnitPanelUI.UnitPanelView CreateView(IAssetProvider assetProvider, Action action)
    {
      return (UnitPanelUI.UnitPanelView) null;
    }

    [Token(Token = "0x600DA08")]
    [Address(RVA = "0x22D4A68", Offset = "0x22D4A68", VA = "0x22D4A68")]
    public void SetActiveLpUI(bool isEnable)
    {
    }

    [Token(Token = "0x600DA09")]
    [Address(RVA = "0x22D4B94", Offset = "0x22D4B94", VA = "0x22D4B94")]
    public void SetActiveEquipmentDurableUI(bool isEnable)
    {
    }

    [Token(Token = "0x600DA0A")]
    [Address(RVA = "0x22D4F88", Offset = "0x22D4F88", VA = "0x22D4F88")]
    public UnitPanelUI()
    {
    }

    [Token(Token = "0x20023AA")]
    public class UnitPanelView
    {
      [Token(Token = "0x40097ED")]
      [FieldOffset(Offset = "0x70")]
      private Action onClickPrev;
      [Token(Token = "0x40097EE")]
      [FieldOffset(Offset = "0x78")]
      private Action onClickNext;

      [Token(Token = "0x17002F03")]
      public StyleStatusView StyleStatusView
      {
        [Token(Token = "0x600DA0B"), Address(RVA = "0x22D4F90", Offset = "0x22D4F90", VA = "0x22D4F90")] get
        {
          return (StyleStatusView) null;
        }
        [Token(Token = "0x600DA0C"), Address(RVA = "0x22D4F98", Offset = "0x22D4F98", VA = "0x22D4F98")] set
        {
        }
      }

      [Token(Token = "0x17002F04")]
      public ParameterView ParametersView
      {
        [Token(Token = "0x600DA0D"), Address(RVA = "0x22D4FA0", Offset = "0x22D4FA0", VA = "0x22D4FA0")] get
        {
          return (ParameterView) null;
        }
        [Token(Token = "0x600DA0E"), Address(RVA = "0x22D4FA8", Offset = "0x22D4FA8", VA = "0x22D4FA8")] set
        {
        }
      }

      [Token(Token = "0x17002F05")]
      public AdditionalParameterView AdditionalParametersView
      {
        [Token(Token = "0x600DA0F"), Address(RVA = "0x22D4FB0", Offset = "0x22D4FB0", VA = "0x22D4FB0")] get
        {
          return (AdditionalParameterView) null;
        }
        [Token(Token = "0x600DA10"), Address(RVA = "0x22D4FB8", Offset = "0x22D4FB8", VA = "0x22D4FB8")] set
        {
        }
      }

      [Token(Token = "0x17002F06")]
      public SlotViewAdapter SlotView
      {
        [Token(Token = "0x600DA11"), Address(RVA = "0x22D4FC0", Offset = "0x22D4FC0", VA = "0x22D4FC0")] get
        {
          return (SlotViewAdapter) null;
        }
        [Token(Token = "0x600DA12"), Address(RVA = "0x22D4FC8", Offset = "0x22D4FC8", VA = "0x22D4FC8")] set
        {
        }
      }

      [Token(Token = "0x17002F07")]
      public StyleDotUI StyleDot
      {
        [Token(Token = "0x600DA13"), Address(RVA = "0x22D4FD0", Offset = "0x22D4FD0", VA = "0x22D4FD0")] private get
        {
          return (StyleDotUI) null;
        }
        [Token(Token = "0x600DA14"), Address(RVA = "0x22D4FD8", Offset = "0x22D4FD8", VA = "0x22D4FD8")] set
        {
        }
      }

      [Token(Token = "0x17002F08")]
      public TextAccessor CombatPower
      {
        [Token(Token = "0x600DA15"), Address(RVA = "0x22D4FE0", Offset = "0x22D4FE0", VA = "0x22D4FE0")] private get
        {
          return (TextAccessor) null;
        }
        [Token(Token = "0x600DA16"), Address(RVA = "0x22D4FE8", Offset = "0x22D4FE8", VA = "0x22D4FE8")] set
        {
        }
      }

      [Token(Token = "0x17002F09")]
      public CurrentMaxGaugeUI UnitHP
      {
        [Token(Token = "0x600DA17"), Address(RVA = "0x22D4FF0", Offset = "0x22D4FF0", VA = "0x22D4FF0")] private get
        {
          return (CurrentMaxGaugeUI) null;
        }
        [Token(Token = "0x600DA18"), Address(RVA = "0x22D4FF8", Offset = "0x22D4FF8", VA = "0x22D4FF8")] set
        {
        }
      }

      [Token(Token = "0x17002F0A")]
      public BarrierStockUI BarrierStock
      {
        [Token(Token = "0x600DA19"), Address(RVA = "0x22D5000", Offset = "0x22D5000", VA = "0x22D5000")] private get
        {
          return (BarrierStockUI) null;
        }
        [Token(Token = "0x600DA1A"), Address(RVA = "0x22D5008", Offset = "0x22D5008", VA = "0x22D5008")] set
        {
        }
      }

      [Token(Token = "0x17002F0B")]
      public SkillListUI SkillList
      {
        [Token(Token = "0x600DA1B"), Address(RVA = "0x22D5010", Offset = "0x22D5010", VA = "0x22D5010")] private get
        {
          return (SkillListUI) null;
        }
        [Token(Token = "0x600DA1C"), Address(RVA = "0x22D5018", Offset = "0x22D5018", VA = "0x22D5018")] set
        {
        }
      }

      [Token(Token = "0x17002F0C")]
      public BattleConditionView BattleConditionView
      {
        [Token(Token = "0x600DA1D"), Address(RVA = "0x22D5020", Offset = "0x22D5020", VA = "0x22D5020")] get
        {
          return (BattleConditionView) null;
        }
        [Token(Token = "0x600DA1E"), Address(RVA = "0x22D5028", Offset = "0x22D5028", VA = "0x22D5028")] set
        {
        }
      }

      [Token(Token = "0x17002F0D")]
      public CommonButton Prev
      {
        [Token(Token = "0x600DA1F"), Address(RVA = "0x22D5030", Offset = "0x22D5030", VA = "0x22D5030")] private get
        {
          return (CommonButton) null;
        }
        [Token(Token = "0x600DA20"), Address(RVA = "0x22D5038", Offset = "0x22D5038", VA = "0x22D5038")] set
        {
        }
      }

      [Token(Token = "0x17002F0E")]
      public CommonButton Next
      {
        [Token(Token = "0x600DA21"), Address(RVA = "0x22D5040", Offset = "0x22D5040", VA = "0x22D5040")] private get
        {
          return (CommonButton) null;
        }
        [Token(Token = "0x600DA22"), Address(RVA = "0x22D5048", Offset = "0x22D5048", VA = "0x22D5048")] set
        {
        }
      }

      [Token(Token = "0x17002F0F")]
      public IAssetProvider AssetProvider
      {
        [Token(Token = "0x600DA23"), Address(RVA = "0x22D5050", Offset = "0x22D5050", VA = "0x22D5050")] private get
        {
          return (IAssetProvider) null;
        }
        [Token(Token = "0x600DA24"), Address(RVA = "0x22D5058", Offset = "0x22D5058", VA = "0x22D5058")] set
        {
        }
      }

      [Token(Token = "0x600DA25")]
      [Address(RVA = "0x22D4DDC", Offset = "0x22D4DDC", VA = "0x22D4DDC")]
      public void Initialize()
      {
      }

      [Token(Token = "0x600DA26")]
      [Address(RVA = "0x22D5060", Offset = "0x22D5060", VA = "0x22D5060")]
      public void SetCombatPower(int value)
      {
      }

      [Token(Token = "0x600DA27")]
      [Address(RVA = "0x22D50A0", Offset = "0x22D50A0", VA = "0x22D50A0")]
      public void SetDot(GameObject dotUnit)
      {
      }

      [Token(Token = "0x600DA28")]
      [Address(RVA = "0x22D50BC", Offset = "0x22D50BC", VA = "0x22D50BC")]
      public void SetHP(int hp, int max, int remainingStock, ForceTypeEnum force)
      {
      }

      [Token(Token = "0x600DA29")]
      [Address(RVA = "0x22D5198", Offset = "0x22D5198", VA = "0x22D5198")]
      public void SetBarrierStock(int stock, int max, string barrierIndex)
      {
      }

      [Token(Token = "0x600DA2A")]
      [Address(RVA = "0x22D51B4", Offset = "0x22D51B4", VA = "0x22D51B4")]
      public SkillListCategoryUI GetSkillCategory(int index, string category)
      {
        return (SkillListCategoryUI) null;
      }

      [Token(Token = "0x600DA2B")]
      [Address(RVA = "0x22D5218", Offset = "0x22D5218", VA = "0x22D5218")]
      public SkillView GetSkillElement(int index) => (SkillView) null;

      [Token(Token = "0x600DA2C")]
      [Address(RVA = "0x22D52C0", Offset = "0x22D52C0", VA = "0x22D52C0")]
      public void SetOnClickSlotAction(
        Action onClickStyle,
        Action<OrganizationEquipmentSlot.EquipmentSlotType> onClickEquipment)
      {
      }

      [Token(Token = "0x600DA2D")]
      [Address(RVA = "0x22D52DC", Offset = "0x22D52DC", VA = "0x22D52DC")]
      public void SetOnClickSelectAction(Action onClickPrev, Action onClickNext)
      {
      }

      [Token(Token = "0x600DA2E")]
      [Address(RVA = "0x22D52E4", Offset = "0x22D52E4", VA = "0x22D52E4")]
      public void SetSelectButton(bool prevActive, bool nextActive)
      {
      }

      [Token(Token = "0x600DA2F")]
      [Address(RVA = "0x22D5344", Offset = "0x22D5344", VA = "0x22D5344")]
      public void SetOnClickConditionDetail(Action onClick)
      {
      }

      [Token(Token = "0x600DA30")]
      [Address(RVA = "0x22D5360", Offset = "0x22D5360", VA = "0x22D5360")]
      private void OnClickPrevUnit()
      {
      }

      [Token(Token = "0x600DA31")]
      [Address(RVA = "0x22D537C", Offset = "0x22D537C", VA = "0x22D537C")]
      private void OnClickNextUnit()
      {
      }

      [Token(Token = "0x600DA32")]
      [Address(RVA = "0x22D4DD4", Offset = "0x22D4DD4", VA = "0x22D4DD4")]
      public UnitPanelView()
      {
      }
    }
  }
}
