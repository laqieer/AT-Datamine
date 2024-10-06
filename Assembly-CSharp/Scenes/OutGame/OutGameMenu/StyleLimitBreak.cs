// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleLimitBreak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Common;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A70")]
  public class StyleLimitBreak : MonoBehaviour
  {
    [Token(Token = "0x4010024")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x4010025")]
    private const string PLAY_VOICE_LIMIT_BREAK = "0013";
    [Token(Token = "0x4010026")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4010027")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI rewardSkillText;
    [Token(Token = "0x4010028")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI[] upParameters;
    [Token(Token = "0x4010029")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private LimitBreakIcons beforeGem;
    [Token(Token = "0x401002A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private LimitBreakIcons afterGem;
    [Token(Token = "0x401002B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon needMaterialThumb;
    [Token(Token = "0x401002C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x401002D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x401002E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x401002F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x4010030")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x4010031")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton limitBreakButton;
    [Token(Token = "0x4010032")]
    [FieldOffset(Offset = "0x78")]
    private bool canLimitBreak;
    [Token(Token = "0x4010033")]
    [FieldOffset(Offset = "0x80")]
    private string toasterMsg;
    [Token(Token = "0x4010034")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Color warningColor;
    [Token(Token = "0x4010035")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x4010036")]
    [FieldOffset(Offset = "0xA8")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x4010037")]
    [FieldOffset(Offset = "0xB0")]
    private Style dispStyle;
    [Token(Token = "0x4010038")]
    [FieldOffset(Offset = "0xB8")]
    private BasicParameter initialParam;
    [Token(Token = "0x4010039")]
    [FieldOffset(Offset = "0xC0")]
    private int limitBreakNum;
    [Token(Token = "0x401003A")]
    [FieldOffset(Offset = "0xC4")]
    private int limitBreakNumMax;
    [Token(Token = "0x401003B")]
    [FieldOffset(Offset = "0xC8")]
    private bool isEnoughCost;
    [Token(Token = "0x401003C")]
    [FieldOffset(Offset = "0xC9")]
    private bool isConnect;
    [Token(Token = "0x401003D")]
    [FieldOffset(Offset = "0xCA")]
    private bool isLoadedMaterialThumb;

    [Token(Token = "0x17004B42")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6016F76"), Address(RVA = "0x29C380C", Offset = "0x29C380C", VA = "0x29C380C")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6016F77")]
    [Address(RVA = "0x29C3828", Offset = "0x29C3828", VA = "0x29C3828")]
    public void Initialize(StyleStatusSubScene statusSubScene, Style style)
    {
    }

    [Token(Token = "0x6016F78")]
    [Address(RVA = "0x29C3E40", Offset = "0x29C3E40", VA = "0x29C3E40")]
    private int CalcMaxNumCanLimitBreak() => new int();

    [Token(Token = "0x6016F79")]
    [Address(RVA = "0x29C3EC0", Offset = "0x29C3EC0", VA = "0x29C3EC0")]
    private void UpdaetInfo(bool isInitialize = false)
    {
    }

    [Token(Token = "0x6016F7A")]
    [Address(RVA = "0x29C41CC", Offset = "0x29C41CC", VA = "0x29C41CC")]
    public void InitializeActiveAccess()
    {
    }

    [Token(Token = "0x6016F7B")]
    [Address(RVA = "0x29C3EF8", Offset = "0x29C3EF8", VA = "0x29C3EF8")]
    private void SetSideMenu()
    {
    }

    [Token(Token = "0x6016F7C")]
    [Address(RVA = "0x29C43A8", Offset = "0x29C43A8", VA = "0x29C43A8")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x6016F7D")]
    [Address(RVA = "0x29C42C8", Offset = "0x29C42C8", VA = "0x29C42C8")]
    private void SetMaterialIcon(
      ItemTypeEnum itemTypeEnum,
      int id,
      int needAMount,
      int possessionAmount)
    {
    }

    [Token(Token = "0x6016F7E")]
    [Address(RVA = "0x29C407C", Offset = "0x29C407C", VA = "0x29C407C")]
    public void SetButtonStat()
    {
    }

    [Token(Token = "0x6016F7F")]
    [Address(RVA = "0x29C456C", Offset = "0x29C456C", VA = "0x29C456C")]
    private bool CanLimitBreak(out string errorMessage) => new bool();

    [Token(Token = "0x6016F80")]
    [Address(RVA = "0x29C468C", Offset = "0x29C468C", VA = "0x29C468C")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6016F81")]
    [Address(RVA = "0x29C4724", Offset = "0x29C4724", VA = "0x29C4724")]
    private IEnumerator ConnectToApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6016F82")]
    [Address(RVA = "0x29C47C0", Offset = "0x29C47C0", VA = "0x29C47C0")]
    private IEnumerator EffectLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x6016F83")]
    [Address(RVA = "0x29C4850", Offset = "0x29C4850", VA = "0x29C4850")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x6016F84")]
    [Address(RVA = "0x29C41B0", Offset = "0x29C41B0", VA = "0x29C41B0")]
    private void SetLimitBreakBonus(bool isInitialize)
    {
    }

    [Token(Token = "0x6016F85")]
    [Address(RVA = "0x29C4954", Offset = "0x29C4954", VA = "0x29C4954")]
    private void SetUpParameter(bool isInitialize)
    {
    }

    [Token(Token = "0x6016F86")]
    [Address(RVA = "0x29C4C14", Offset = "0x29C4C14", VA = "0x29C4C14")]
    private void SetRewardSkill()
    {
    }

    [Token(Token = "0x6016F87")]
    [Address(RVA = "0x29C4DD0", Offset = "0x29C4DD0", VA = "0x29C4DD0")]
    private void UpdateItemParameter()
    {
    }

    [Token(Token = "0x6016F88")]
    [Address(RVA = "0x29C4DE8", Offset = "0x29C4DE8", VA = "0x29C4DE8")]
    public StyleLimitBreak()
    {
    }
  }
}
