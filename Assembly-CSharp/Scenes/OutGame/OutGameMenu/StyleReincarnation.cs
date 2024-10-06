// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReincarnation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Scenes.OutGame.UnitDetail.Reincarnation;
using StaqData;
using System;
using System.Collections;
using Tween.Tweeners;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A80")]
  public class StyleReincarnation : MonoBehaviour
  {
    [Token(Token = "0x401008B")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x401008C")]
    private const string PLAY_VOICE_REINCARNATION = "0015";
    [Token(Token = "0x401008D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x401008E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TweenAlpha HighLight_Effect_TweenAlpha;
    [Token(Token = "0x401008F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup HighLight_Effect_CanvasGroup;
    [Token(Token = "0x4010090")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text beforeNowLevelText;
    [Token(Token = "0x4010091")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text beforeMaxLevelText;
    [Token(Token = "0x4010092")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text[] beforePinAve;
    [Token(Token = "0x4010093")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text beforePinAveTotal;
    [Token(Token = "0x4010094")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CanvasGroup statusParamCanvasGroup;
    [Token(Token = "0x4010095")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CanvasGroup reincarnationAfterParamCanvasGroup;
    [Token(Token = "0x4010096")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text[] reincarnationBeforeParameter;
    [Token(Token = "0x4010097")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text beforeCombatPowerText;
    [Token(Token = "0x4010098")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GaugeScale beforeExpSlider;
    [Token(Token = "0x4010099")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text afterNowLevelText;
    [Token(Token = "0x401009A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text afterMaxLevelText;
    [Token(Token = "0x401009B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GaugeScale afterExpSlider;
    [Token(Token = "0x401009C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text afterCombatPowerText;
    [Token(Token = "0x401009D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text[] afterParameterText;
    [Token(Token = "0x401009E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject[] afterParameterMark;
    [Token(Token = "0x401009F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Toggle[] AfterPinMark;
    [Token(Token = "0x40100A0")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text AfterPinMarkText;
    [Token(Token = "0x40100A1")]
    [FieldOffset(Offset = "0xB8")]
    private Color AfterPinMarkTextColor;
    [Token(Token = "0x40100A2")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonToggle Toggle_Reincarnation;
    [Token(Token = "0x40100A3")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonToggle Toggle_SpecialReincarnation;
    [Token(Token = "0x40100A4")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonToggle Toggle_ReincarnationMemory;
    [Token(Token = "0x40100A5")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text info;
    [Token(Token = "0x40100A6")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text beforeLevel;
    [Token(Token = "0x40100A7")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text specialLevel;
    [Token(Token = "0x40100A8")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text reincarnationNumText;
    [Token(Token = "0x40100A9")]
    [FieldOffset(Offset = "0x100")]
    private Func<string> ReincarnationCountFormat;
    [Token(Token = "0x40100AA")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private GameObject nothing;
    [Token(Token = "0x40100AB")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private GameObject slot;
    [Token(Token = "0x40100AC")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private GameObject trust;
    [Token(Token = "0x40100AD")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Text trustName;
    [Token(Token = "0x40100AE")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private ItemIcon bounsTrustIcon;
    [Token(Token = "0x40100AF")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private GameObject NeedMaterial_Img_Base;
    [Token(Token = "0x40100B0")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private ItemIcon reincarnationMaterial;
    [Token(Token = "0x40100B1")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private CommonButton reincarnationButton;
    [Token(Token = "0x40100B2")]
    [FieldOffset(Offset = "0x148")]
    private bool canReincarnation;
    [Token(Token = "0x40100B3")]
    [FieldOffset(Offset = "0x149")]
    private bool canSpecialReincarnation;
    [Token(Token = "0x40100B4")]
    [FieldOffset(Offset = "0x150")]
    private string toasterMsg;
    [Token(Token = "0x40100B5")]
    [FieldOffset(Offset = "0x158")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x40100B6")]
    [FieldOffset(Offset = "0x160")]
    private Style dispStyle;
    [Token(Token = "0x40100B7")]
    [FieldOffset(Offset = "0x168")]
    private Style beforeStyle;
    [Token(Token = "0x40100B8")]
    [FieldOffset(Offset = "0x170")]
    private APIUnitReincarnationResetResponse response;
    [Token(Token = "0x40100B9")]
    [FieldOffset(Offset = "0x178")]
    private int pinParameterIndex;
    [Token(Token = "0x40100BA")]
    [FieldOffset(Offset = "0x180")]
    private int[] warrantyParameterList;
    [Token(Token = "0x40100BB")]
    [FieldOffset(Offset = "0x188")]
    private readonly Func<string>[] paramNameText;
    [Token(Token = "0x40100BC")]
    [FieldOffset(Offset = "0x190")]
    private ToggleGroup toggleGroup;
    [Token(Token = "0x40100BD")]
    [FieldOffset(Offset = "0x198")]
    private bool isSpecialReincarnation;
    [Token(Token = "0x40100BE")]
    [FieldOffset(Offset = "0x1A0")]
    private float[] pinAverages;
    [Token(Token = "0x40100BF")]
    [FieldOffset(Offset = "0x1A8")]
    private StyleReincarnation.ToggleType toggleType;

    [Token(Token = "0x17004B50")]
    private bool isEnoughCost
    {
      [Token(Token = "0x6016FD3"), Address(RVA = "0x29C79C8", Offset = "0x29C79C8", VA = "0x29C79C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004B51")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6016FD4"), Address(RVA = "0x29C7AD8", Offset = "0x29C7AD8", VA = "0x29C7AD8")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6016FD5")]
    [Address(RVA = "0x29C7AF4", Offset = "0x29C7AF4", VA = "0x29C7AF4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016FD6")]
    [Address(RVA = "0x29C7B28", Offset = "0x29C7B28", VA = "0x29C7B28")]
    public void Initialize(StyleStatusSubScene statusSubScene, Style style)
    {
    }

    [Token(Token = "0x6016FD7")]
    [Address(RVA = "0x29C8268", Offset = "0x29C8268", VA = "0x29C8268")]
    private void InitToggleReincarnation()
    {
    }

    [Token(Token = "0x6016FD8")]
    [Address(RVA = "0x29C9664", Offset = "0x29C9664", VA = "0x29C9664")]
    private void UpdateNeedMaterial()
    {
    }

    [Token(Token = "0x6016FD9")]
    [Address(RVA = "0x29C844C", Offset = "0x29C844C", VA = "0x29C844C")]
    private void InitNeedMaterial()
    {
    }

    [Token(Token = "0x6016FDA")]
    [Address(RVA = "0x29C97B8", Offset = "0x29C97B8", VA = "0x29C97B8")]
    private void UpdateMaterialIcon()
    {
    }

    [Token(Token = "0x6016FDB")]
    [Address(RVA = "0x29C96B0", Offset = "0x29C96B0", VA = "0x29C96B0")]
    private void UpdateMaterialIcon(ItemTypeEnum itemType, int itemId)
    {
    }

    [Token(Token = "0x6016FDC")]
    [Address(RVA = "0x29C97E0", Offset = "0x29C97E0", VA = "0x29C97E0")]
    private void SetMaterialIcon(
      ItemTypeEnum itemTypeEnum,
      int id,
      int needAMount,
      int possessionAmount)
    {
    }

    [Token(Token = "0x6016FDD")]
    [Address(RVA = "0x29C98F0", Offset = "0x29C98F0", VA = "0x29C98F0")]
    private void CallbackStyleStatusDialog(StyleReincarnation_Popup_Confirm.eResult result)
    {
    }

    [Token(Token = "0x6016FDE")]
    [Address(RVA = "0x29C991C", Offset = "0x29C991C", VA = "0x29C991C")]
    private IEnumerator ExecuteReincarnation() => (IEnumerator) null;

    [Token(Token = "0x6016FDF")]
    [Address(RVA = "0x29C99AC", Offset = "0x29C99AC", VA = "0x29C99AC")]
    private void SetButtonStatus()
    {
    }

    [Token(Token = "0x6016FE0")]
    [Address(RVA = "0x29CA3A0", Offset = "0x29CA3A0", VA = "0x29CA3A0")]
    private static bool IsRarityStarMax(Style style) => new bool();

    [Token(Token = "0x6016FE1")]
    [Address(RVA = "0x29C9A04", Offset = "0x29C9A04", VA = "0x29C9A04")]
    private bool CanSpecialReincarnation(out string errorMessage) => new bool();

    [Token(Token = "0x6016FE2")]
    [Address(RVA = "0x29C9F14", Offset = "0x29C9F14", VA = "0x29C9F14")]
    private bool CanReincarnation(out string errorMessage) => new bool();

    [Token(Token = "0x6016FE3")]
    [Address(RVA = "0x29CA534", Offset = "0x29CA534", VA = "0x29CA534")]
    private void SetToggle(bool flg, int index)
    {
    }

    [Token(Token = "0x6016FE4")]
    [Address(RVA = "0x29CA5F0", Offset = "0x29CA5F0", VA = "0x29CA5F0")]
    public void SetParam()
    {
    }

    [Token(Token = "0x6016FE5")]
    [Address(RVA = "0x29C85E4", Offset = "0x29C85E4", VA = "0x29C85E4")]
    private void SetParamInternal()
    {
    }

    [Token(Token = "0x6016FE6")]
    [Address(RVA = "0x29CA5F4", Offset = "0x29CA5F4", VA = "0x29CA5F4")]
    private int AfterBattlePower(
      ParameterGroup.Parameter parameter,
      IBattleParameter styleMasterBonus,
      StyleData styleData)
    {
      return new int();
    }

    [Token(Token = "0x6016FE7")]
    [Address(RVA = "0x29CA7B0", Offset = "0x29CA7B0", VA = "0x29CA7B0")]
    private void PopupCloseAction()
    {
    }

    [Token(Token = "0x6016FE8")]
    [Address(RVA = "0x29CA840", Offset = "0x29CA840", VA = "0x29CA840")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016FE9")]
    [Address(RVA = "0x29CA8D8", Offset = "0x29CA8D8", VA = "0x29CA8D8")]
    private IEnumerator connectReincarnation() => (IEnumerator) null;

    [Token(Token = "0x6016FEA")]
    [Address(RVA = "0x29C95E8", Offset = "0x29C95E8", VA = "0x29C95E8")]
    public IEnumerator ChangeParameter(bool In) => (IEnumerator) null;

    [Token(Token = "0x6016FEB")]
    [Address(RVA = "0x29CA990", Offset = "0x29CA990", VA = "0x29CA990")]
    private IEnumerator EffectReincarnation() => (IEnumerator) null;

    [Token(Token = "0x6016FEC")]
    [Address(RVA = "0x29CAA20", Offset = "0x29CAA20", VA = "0x29CAA20")]
    public void ReincarnationEffectFinish()
    {
    }

    [Token(Token = "0x6016FED")]
    [Address(RVA = "0x29CAA58", Offset = "0x29CAA58", VA = "0x29CAA58")]
    private IEnumerator EffectLevelUP() => (IEnumerator) null;

    [Token(Token = "0x6016FEE")]
    [Address(RVA = "0x29CAAC0", Offset = "0x29CAAC0", VA = "0x29CAAC0")]
    public void EffectFinish()
    {
    }

    [Token(Token = "0x6016FEF")]
    [Address(RVA = "0x29CAB2C", Offset = "0x29CAB2C", VA = "0x29CAB2C")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x6016FF0")]
    [Address(RVA = "0x29CAB44", Offset = "0x29CAB44", VA = "0x29CAB44")]
    public StyleReincarnation()
    {
    }

    [Token(Token = "0x2003A81")]
    public enum ToggleType
    {
      [Token(Token = "0x40100C1")] Normal,
      [Token(Token = "0x40100C2")] Special,
      [Token(Token = "0x40100C3")] Memory,
    }
  }
}
