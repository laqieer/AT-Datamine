// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.StyleDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData.StatusIcon;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003443")]
  public class StyleDetailPopup : PopupBase
  {
    [Token(Token = "0x400E382")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text characterName;
    [Token(Token = "0x400E383")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text styleName;
    [Token(Token = "0x400E384")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400E385")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleDetailPopup.LimitBreakIcon[] limitBreakIcons;
    [Token(Token = "0x400E386")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text className;
    [Token(Token = "0x400E387")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TypeIcon classTypeIcon;
    [Token(Token = "0x400E388")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TypeIcon[] typeIcons;
    [Token(Token = "0x400E389")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject[] emptyTypeIcons;
    [Token(Token = "0x400E38A")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TypeIcon[] speciesIcons;
    [Token(Token = "0x400E38B")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject[] emptySpeciesIcons;
    [Token(Token = "0x400E38C")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TypeIcon killersIcon;
    [Token(Token = "0x400E38D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject emptykillersIcon;
    [Token(Token = "0x400E38E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private RectTransform skillParent;
    [Token(Token = "0x400E38F")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private DetailSkillListThumb baseSkillList;
    [Token(Token = "0x400E390")]
    [FieldOffset(Offset = "0xF8")]
    private List<StyleDetailPopup.DetalSkill> detalSkills;
    [Token(Token = "0x400E391")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private StyleDetailPopup.SwapButton skillButton;
    [Token(Token = "0x400E392")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private StyleDetailPopup.SwapButton memoryButton;
    [Token(Token = "0x400E393")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private GameObject detailSkillParentObj;
    [Token(Token = "0x400E394")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text memoryText;
    [Token(Token = "0x400E395")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject memoruGroup;
    [Token(Token = "0x400E396")]
    [FieldOffset(Offset = "0x128")]
    private IconFactory iconFactory;
    [Token(Token = "0x400E397")]
    [FieldOffset(Offset = "0x130")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x1700444D")]
    public Action<int> OnClickSkillDetail
    {
      [Token(Token = "0x6014896"), Address(RVA = "0x1A9DCA8", Offset = "0x1A9DCA8", VA = "0x1A9DCA8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6014897"), Address(RVA = "0x1A9DCB0", Offset = "0x1A9DCB0", VA = "0x1A9DCB0")] set
      {
      }
    }

    [Token(Token = "0x6014898")]
    [Address(RVA = "0x1A9DCB8", Offset = "0x1A9DCB8", VA = "0x1A9DCB8")]
    private void InitStyleThumb(int styleId, StyleData styleMasterData, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6014899")]
    [Address(RVA = "0x1A9DDB4", Offset = "0x1A9DDB4", VA = "0x1A9DDB4")]
    public IEnumerator SetData(int styleId, AssetCachedSpawner spawner, IconFactory iconFactory)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601489A")]
    [Address(RVA = "0x1A9DE68", Offset = "0x1A9DE68", VA = "0x1A9DE68")]
    public IEnumerator SetSkill(int styleId) => (IEnumerator) null;

    [Token(Token = "0x601489B")]
    [Address(RVA = "0x1A9DF08", Offset = "0x1A9DF08", VA = "0x1A9DF08")]
    public void OnClickChangeToggleBySkill()
    {
    }

    [Token(Token = "0x601489C")]
    [Address(RVA = "0x1A9DFC4", Offset = "0x1A9DFC4", VA = "0x1A9DFC4")]
    public void OnClickChangeToggleByMemory()
    {
    }

    [Token(Token = "0x601489D")]
    [Address(RVA = "0x1A9E044", Offset = "0x1A9E044", VA = "0x1A9E044")]
    public StyleDetailPopup()
    {
    }

    [Token(Token = "0x2003444")]
    [Serializable]
    public class SwapButton
    {
      [Token(Token = "0x400E399")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject onObj;
      [Token(Token = "0x400E39A")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject offObj;
      [Token(Token = "0x400E39B")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private bool isOn;

      [Token(Token = "0x1700444E")]
      public bool IsOn
      {
        [Token(Token = "0x601489F"), Address(RVA = "0x1A9E14C", Offset = "0x1A9E14C", VA = "0x1A9E14C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60148A0")]
      [Address(RVA = "0x1A9DF78", Offset = "0x1A9DF78", VA = "0x1A9DF78")]
      public void SetFlg(bool isOn)
      {
      }

      [Token(Token = "0x60148A1")]
      [Address(RVA = "0x1A9E154", Offset = "0x1A9E154", VA = "0x1A9E154")]
      public SwapButton()
      {
      }
    }

    [Token(Token = "0x2003445")]
    [Serializable]
    public class LimitBreakIcon
    {
      [Token(Token = "0x400E39C")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject bg;
      [Token(Token = "0x400E39D")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject on;

      [Token(Token = "0x60148A2")]
      [Address(RVA = "0x1A9E15C", Offset = "0x1A9E15C", VA = "0x1A9E15C")]
      public void Set(bool isOn)
      {
      }

      [Token(Token = "0x60148A3")]
      [Address(RVA = "0x1A9E1A4", Offset = "0x1A9E1A4", VA = "0x1A9E1A4")]
      public LimitBreakIcon()
      {
      }
    }

    [Token(Token = "0x2003446")]
    public class DetalSkill
    {
      [Token(Token = "0x400E39E")]
      [FieldOffset(Offset = "0x10")]
      private DetailSkillListThumb detailSkillListThumb;
      [Token(Token = "0x400E39F")]
      [FieldOffset(Offset = "0x18")]
      private SkillIconSub[] skillIconSubs;

      [Token(Token = "0x60148A4")]
      [Address(RVA = "0x1A9E1AC", Offset = "0x1A9E1AC", VA = "0x1A9E1AC")]
      public void Destroy()
      {
      }

      [Token(Token = "0x60148A5")]
      [Address(RVA = "0x1A9E250", Offset = "0x1A9E250", VA = "0x1A9E250")]
      public void SetDisableObjActive(bool isActive)
      {
      }

      [Token(Token = "0x60148A6")]
      [Address(RVA = "0x1A9E334", Offset = "0x1A9E334", VA = "0x1A9E334")]
      public DetalSkill(
        DetailSkillListThumb detailSkillList,
        int skillId,
        int level,
        IAssetProvider assetProvider,
        Action<int> onClickSkillDetail = null)
      {
      }

      [Token(Token = "0x60148A7")]
      [Address(RVA = "0x1A9E49C", Offset = "0x1A9E49C", VA = "0x1A9E49C")]
      public void SetTypeIcon(SkillTypeEnum skillType)
      {
      }

      [Token(Token = "0x60148A8")]
      [Address(RVA = "0x1A9E5A0", Offset = "0x1A9E5A0", VA = "0x1A9E5A0")]
      public bool SetSubSkill(IconFactory iconFactory, int skillId, int level = 1) => new bool();
    }
  }
}
