// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitCommandPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.Process;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023C4")]
  public sealed class UnitCommandPanel : MonoBehaviour
  {
    [Token(Token = "0x4009870")]
    [FieldOffset(Offset = "0x18")]
    [Header("アニメーション")]
    [SerializeField]
    private UnitCommandTween tweener;
    [Token(Token = "0x4009871")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SkillExplanation skillExplanation;
    [Token(Token = "0x4009872")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject tutorialArrow;
    [Token(Token = "0x4009873")]
    [FieldOffset(Offset = "0x30")]
    [Header("メインコマンド")]
    [SerializeField]
    private GameObject mainCommandRoot;
    [Token(Token = "0x4009874")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommandButton normalAttackButton;
    [Token(Token = "0x4009875")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CanvasGroup normalAttackButtonDecision;
    [Token(Token = "0x4009876")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image normalAttackButtonIcon;
    [Token(Token = "0x4009877")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI normalAttackButtonText;
    [Token(Token = "0x4009878")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommandButton skillCommandButton;
    [Token(Token = "0x4009879")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CanvasGroup skillCommandButtonDecision;
    [Token(Token = "0x400987A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400987B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommandButton doubleOpenButton;
    [Token(Token = "0x400987C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommandButton interactOpenButton;
    [Token(Token = "0x400987D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400987E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommandButton stayButton;
    [Token(Token = "0x400987F")]
    [FieldOffset(Offset = "0x90")]
    [Header("スキルコマンド")]
    [SerializeField]
    public CanvasGroup skillCommandCanvas;
    [Token(Token = "0x4009880")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private SkillButton skillCommandButtonBase;
    [Token(Token = "0x4009881")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private RectTransform skillScrollContent;
    [Token(Token = "0x4009882")]
    [FieldOffset(Offset = "0xA8")]
    private List<SkillButton> skillButtons;
    [Token(Token = "0x4009883")]
    [FieldOffset(Offset = "0xB0")]
    [Header("ダブルコマンド")]
    [SerializeField]
    private DoubleCommandPanel doubleCommandPanel;
    [Token(Token = "0x4009884")]
    [FieldOffset(Offset = "0xB8")]
    public Action<bool> OnDoubleConfirm;
    [Token(Token = "0x4009885")]
    [FieldOffset(Offset = "0xC0")]
    [Header("インタラクトコマンド")]
    [SerializeField]
    private InteractCommandPanel interactCommandPanel;
    [Token(Token = "0x4009886")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    [Header("装備武器表示")]
    private CanvasGroup WeaponLabelObject;
    [Token(Token = "0x4009887")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private UITweenGroup weaponLabelObjectTween;
    [Token(Token = "0x4009888")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private WeaponLabel currentWeaponLabel1;
    [Token(Token = "0x4009889")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private WeaponLabel currentWeaponLabel2;
    [Token(Token = "0x400988A")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Button buttonSwitchWeapon;
    [Token(Token = "0x400988B")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject durabilityDownPoint;
    [Token(Token = "0x400988C")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text durabilityDownPointText;
    [Token(Token = "0x400988D")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Image skillNumIcon1;
    [Token(Token = "0x400988E")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Image skillNumIcon2;
    [Token(Token = "0x400988F")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Image skillNumIcon3;
    [Token(Token = "0x4009890")]
    [FieldOffset(Offset = "0x118")]
    private Image[] skillNumIcons;
    [Token(Token = "0x4009891")]
    [FieldOffset(Offset = "0x120")]
    [HideInInspector]
    public bool EnableSwitchWeapon;
    [Token(Token = "0x4009892")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009893")]
    [FieldOffset(Offset = "0x130")]
    private CommandType commandFlags;
    [Token(Token = "0x4009894")]
    [FieldOffset(Offset = "0x138")]
    private UnitParameterData ownerUnit;
    [Token(Token = "0x4009895")]
    [FieldOffset(Offset = "0x140")]
    private UsableWeaponSkillMap usabelWeaponSkillMap;
    [Token(Token = "0x4009896")]
    [FieldOffset(Offset = "0x148")]
    [HideInInspector]
    public int SelectedSkillParamId;
    [Token(Token = "0x4009897")]
    [FieldOffset(Offset = "0x14C")]
    private bool cancelable;
    [Token(Token = "0x4009899")]
    [FieldOffset(Offset = "0x158")]
    private IEnumerator currentRoutine;

    [Token(Token = "0x17002F2F")]
    public CommandButton NormalAttackButton
    {
      [Token(Token = "0x600DAE3"), Address(RVA = "0x2147158", Offset = "0x2147158", VA = "0x2147158")] get
      {
        return (CommandButton) null;
      }
    }

    [Token(Token = "0x17002F30")]
    private bool isNormalAttackButtonDecision
    {
      [Token(Token = "0x600DAE4"), Address(RVA = "0x2147160", Offset = "0x2147160", VA = "0x2147160")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002F31")]
    public CommandButton SkillCommandButton
    {
      [Token(Token = "0x600DAE5"), Address(RVA = "0x214718C", Offset = "0x214718C", VA = "0x214718C")] get
      {
        return (CommandButton) null;
      }
    }

    [Token(Token = "0x17002F32")]
    private bool isSkillCommandButtonDecision
    {
      [Token(Token = "0x600DAE6"), Address(RVA = "0x2147194", Offset = "0x2147194", VA = "0x2147194")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002F33")]
    public CommandButton DoubleOpenButton
    {
      [Token(Token = "0x600DAE7"), Address(RVA = "0x21471C0", Offset = "0x21471C0", VA = "0x21471C0")] get
      {
        return (CommandButton) null;
      }
    }

    [Token(Token = "0x17002F34")]
    public CommandButton StayButton
    {
      [Token(Token = "0x600DAE8"), Address(RVA = "0x21471C8", Offset = "0x21471C8", VA = "0x21471C8")] get
      {
        return (CommandButton) null;
      }
    }

    [Token(Token = "0x17002F35")]
    public DoubleCommandPanel DoubleCommandPanel
    {
      [Token(Token = "0x600DAE9"), Address(RVA = "0x21471D0", Offset = "0x21471D0", VA = "0x21471D0")] get
      {
        return (DoubleCommandPanel) null;
      }
    }

    [Token(Token = "0x17002F36")]
    public UnityAction SwitchToNextWeapon
    {
      [Token(Token = "0x600DAEA"), Address(RVA = "0x21471D8", Offset = "0x21471D8", VA = "0x21471D8")] set
      {
      }
    }

    [Token(Token = "0x17002F37")]
    public bool Cancelable
    {
      [Token(Token = "0x600DAEB"), Address(RVA = "0x2147228", Offset = "0x2147228", VA = "0x2147228")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DAEC"), Address(RVA = "0x2147230", Offset = "0x2147230", VA = "0x2147230")] set
      {
      }
    }

    [Token(Token = "0x17002F38")]
    public ManualActionSelector manualActionSelector
    {
      [Token(Token = "0x600DAED"), Address(RVA = "0x214723C", Offset = "0x214723C", VA = "0x214723C")] private get
      {
        return (ManualActionSelector) null;
      }
      [Token(Token = "0x600DAEE"), Address(RVA = "0x2147244", Offset = "0x2147244", VA = "0x2147244")] set
      {
      }
    }

    [Token(Token = "0x17002F39")]
    public bool IsLuaCommand
    {
      [Token(Token = "0x600DAEF"), Address(RVA = "0x214724C", Offset = "0x214724C", VA = "0x214724C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002F3A")]
    public bool IsInteractCommand
    {
      [Token(Token = "0x600DAF0"), Address(RVA = "0x2147260", Offset = "0x2147260", VA = "0x2147260")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600DAF1")]
    [Address(RVA = "0x214727C", Offset = "0x214727C", VA = "0x214727C")]
    private new Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600DAF2")]
    [Address(RVA = "0x21472C0", Offset = "0x21472C0", VA = "0x21472C0")]
    private void StopCurrentCoroutine()
    {
    }

    [Token(Token = "0x600DAF3")]
    [Address(RVA = "0x21472E8", Offset = "0x21472E8", VA = "0x21472E8")]
    public bool IsAnimation() => new bool();

    [Token(Token = "0x600DAF4")]
    [Address(RVA = "0x214730C", Offset = "0x214730C", VA = "0x214730C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600DAF5")]
    [Address(RVA = "0x2147BE4", Offset = "0x2147BE4", VA = "0x2147BE4")]
    public void OpenMainCommand(
      CommandType commandFlags,
      UnitParameterData ownerUnit,
      UsableWeaponSkillMap usabelWeaponSkillMap,
      bool showCancel,
      bool isStatusPanelShow)
    {
    }

    [Token(Token = "0x600DAF6")]
    [Address(RVA = "0x2147CBC", Offset = "0x2147CBC", VA = "0x2147CBC")]
    private void PlayShowMainCommand(bool isStatusPanelShow)
    {
    }

    [Token(Token = "0x600DAF7")]
    [Address(RVA = "0x2148398", Offset = "0x2148398", VA = "0x2148398")]
    public void OpenSkillCommand(
      CommandType commandFlags,
      UnitParameterData ownerUnit,
      UsableWeaponSkillMap usableSkills)
    {
    }

    [Token(Token = "0x600DAF8")]
    [Address(RVA = "0x21483A4", Offset = "0x21483A4", VA = "0x21483A4")]
    private void OpenSkillCommand()
    {
    }

    [Token(Token = "0x600DAF9")]
    [Address(RVA = "0x2148658", Offset = "0x2148658", VA = "0x2148658")]
    private void PlayShowNormalAttackCommand()
    {
    }

    [Token(Token = "0x600DAFA")]
    [Address(RVA = "0x214930C", Offset = "0x214930C", VA = "0x214930C")]
    private void PlayShowSkillCommand(bool isTargetEffective)
    {
    }

    [Token(Token = "0x600DAFB")]
    [Address(RVA = "0x214892C", Offset = "0x214892C", VA = "0x214892C")]
    private void SetSkillCommand(bool isTargetEffective)
    {
    }

    [Token(Token = "0x600DAFC")]
    [Address(RVA = "0x214951C", Offset = "0x214951C", VA = "0x214951C")]
    private bool IsRangeOut(SkillParameterData skillParam) => new bool();

    [Token(Token = "0x600DAFD")]
    [Address(RVA = "0x21495C8", Offset = "0x21495C8", VA = "0x21495C8")]
    private void SelectSkillButton(SkillButtonInfo info)
    {
    }

    [Token(Token = "0x600DAFE")]
    [Address(RVA = "0x2149D4C", Offset = "0x2149D4C", VA = "0x2149D4C")]
    public void OpenDoubleCommand(
      CommandType commandFlags,
      UnitParameterData ownerUnit,
      UsableWeaponSkillMap usableSkills,
      bool showCancel)
    {
    }

    [Token(Token = "0x600DAFF")]
    [Address(RVA = "0x2149D84", Offset = "0x2149D84", VA = "0x2149D84")]
    private void OpenDoubleCommand(CommandType command)
    {
    }

    [Token(Token = "0x600DB00")]
    [Address(RVA = "0x2149E48", Offset = "0x2149E48", VA = "0x2149E48")]
    private void OpenInteractCommand()
    {
    }

    [Token(Token = "0x600DB01")]
    [Address(RVA = "0x2149F0C", Offset = "0x2149F0C", VA = "0x2149F0C")]
    public void OpenInteractCommand(
      CommandType commandFlags,
      UnitParameterData ownerUnit,
      UsableWeaponSkillMap usableSkills,
      bool showCancel)
    {
    }

    [Token(Token = "0x600DB02")]
    [Address(RVA = "0x2149F20", Offset = "0x2149F20", VA = "0x2149F20")]
    private void OnNormalAttackButton()
    {
    }

    [Token(Token = "0x600DB03")]
    [Address(RVA = "0x214A144", Offset = "0x214A144", VA = "0x214A144")]
    private void OnSkillCommandButton()
    {
    }

    [Token(Token = "0x600DB04")]
    [Address(RVA = "0x214A1AC", Offset = "0x214A1AC", VA = "0x214A1AC")]
    private void OnDoubleButton()
    {
    }

    [Token(Token = "0x600DB05")]
    [Address(RVA = "0x214A1E0", Offset = "0x214A1E0", VA = "0x214A1E0")]
    private void OnInteractButton()
    {
    }

    [Token(Token = "0x600DB06")]
    [Address(RVA = "0x214A224", Offset = "0x214A224", VA = "0x214A224")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x600DB07")]
    [Address(RVA = "0x214A288", Offset = "0x214A288", VA = "0x214A288")]
    private void OnBackButton()
    {
    }

    [Token(Token = "0x600DB08")]
    [Address(RVA = "0x214A480", Offset = "0x214A480", VA = "0x214A480")]
    public void RequestSwitchWeapon()
    {
    }

    [Token(Token = "0x600DB09")]
    [Address(RVA = "0x214BD7C", Offset = "0x214BD7C", VA = "0x214BD7C")]
    private void ChangeWeaponByOpenSkillCommand(SkillParameterData beforeSkill)
    {
    }

    [Token(Token = "0x600DB0A")]
    [Address(RVA = "0x214C0A0", Offset = "0x214C0A0", VA = "0x214C0A0")]
    private void ChangeWeaponByNoOpenSkillCommand()
    {
    }

    [Token(Token = "0x600DB0B")]
    [Address(RVA = "0x214C100", Offset = "0x214C100", VA = "0x214C100")]
    public void UpdateRootCommandEnable(CommandType commandFlags)
    {
    }

    [Token(Token = "0x600DB0C")]
    [Address(RVA = "0x214C108", Offset = "0x214C108", VA = "0x214C108")]
    public void ResetSkillCommand(UnitParameterData ownerUnit, UsableWeaponSkillMap usableSkills)
    {
    }

    [Token(Token = "0x600DB0D")]
    [Address(RVA = "0x214C144", Offset = "0x214C144", VA = "0x214C144")]
    public void CloseCommand()
    {
    }

    [Token(Token = "0x600DB0E")]
    [Address(RVA = "0x214A250", Offset = "0x214A250", VA = "0x214A250")]
    private void DispatchSelected(CommandType command)
    {
    }

    [Token(Token = "0x600DB0F")]
    [Address(RVA = "0x2147C94", Offset = "0x2147C94", VA = "0x2147C94")]
    public void ResetOpenFlag()
    {
    }

    [Token(Token = "0x600DB10")]
    [Address(RVA = "0x2148358", Offset = "0x2148358", VA = "0x2148358")]
    private bool HasSkillCommand(CommandType command) => new bool();

    [Token(Token = "0x600DB11")]
    [Address(RVA = "0x2148368", Offset = "0x2148368", VA = "0x2148368")]
    private bool HasDoubleCommand(CommandType command) => new bool();

    [Token(Token = "0x600DB12")]
    [Address(RVA = "0x2148374", Offset = "0x2148374", VA = "0x2148374")]
    private bool HasInteractCommand(CommandType command) => new bool();

    [Token(Token = "0x600DB13")]
    [Address(RVA = "0x21477A0", Offset = "0x21477A0", VA = "0x21477A0")]
    public void SetActiveWeaponLabel(bool active)
    {
    }

    [Token(Token = "0x600DB14")]
    [Address(RVA = "0x214BA20", Offset = "0x214BA20", VA = "0x214BA20")]
    private void OnWeaponChangeNum()
    {
    }

    [Token(Token = "0x600DB15")]
    [Address(RVA = "0x214882C", Offset = "0x214882C", VA = "0x214882C")]
    private void ShowDurabilityDownPoint(SkillParameterData skillParam)
    {
    }

    [Token(Token = "0x600DB16")]
    [Address(RVA = "0x2148218", Offset = "0x2148218", VA = "0x2148218")]
    private void ShowDurabilityDownPoint(bool active)
    {
    }

    [Token(Token = "0x600DB17")]
    [Address(RVA = "0x214C370", Offset = "0x214C370", VA = "0x214C370")]
    public void DisableSkillButtons()
    {
    }

    [Token(Token = "0x600DB18")]
    [Address(RVA = "0x214C3CC", Offset = "0x214C3CC", VA = "0x214C3CC")]
    public void SetActiveSkillCommandByLua(int selectIndex)
    {
    }

    [Token(Token = "0x600DB19")]
    [Address(RVA = "0x214C478", Offset = "0x214C478", VA = "0x214C478")]
    public void DisActiveUnitCommandPanelByLua()
    {
    }

    [Token(Token = "0x600DB1A")]
    [Address(RVA = "0x214C5C8", Offset = "0x214C5C8", VA = "0x214C5C8")]
    public void ShowTutorialArrow(int posIdx)
    {
    }

    [Token(Token = "0x600DB1B")]
    [Address(RVA = "0x214861C", Offset = "0x214861C", VA = "0x214861C")]
    public void HideTutorialArrow()
    {
    }

    [Token(Token = "0x600DB1C")]
    [Address(RVA = "0x214C6FC", Offset = "0x214C6FC", VA = "0x214C6FC")]
    public void BlinkTutorialArrow(float sec)
    {
    }

    [Token(Token = "0x600DB1D")]
    [Address(RVA = "0x214C718", Offset = "0x214C718", VA = "0x214C718")]
    private IEnumerator IEBlinkTutorialArrow(float sec) => (IEnumerator) null;

    [Token(Token = "0x600DB1E")]
    [Address(RVA = "0x2147C58", Offset = "0x2147C58", VA = "0x2147C58")]
    private void SetActiveMainObjectRoot(bool isActive)
    {
    }

    [Token(Token = "0x600DB1F")]
    [Address(RVA = "0x214C7B8", Offset = "0x214C7B8", VA = "0x214C7B8")]
    public UnitCommandPanel()
    {
    }
  }
}
