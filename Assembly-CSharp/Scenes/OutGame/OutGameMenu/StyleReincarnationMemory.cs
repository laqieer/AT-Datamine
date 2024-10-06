// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReincarnationMemory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Icon;
using Scenes.OutGame.UnitDetail.Reincarnation;
using StaqData;
using System;
using System.Collections;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A90")]
  public class StyleReincarnationMemory : MonoBehaviour
  {
    [Token(Token = "0x4010106")]
    private const string PLAY_VOICE_FILE_NAME = "VO_{0}_unit_{1}";
    [Token(Token = "0x4010107")]
    private const string PLAY_VOICE_REINCARNATION = "0015";
    [Token(Token = "0x4010108")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4010109")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x401010A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text[] beforePinAve;
    [Token(Token = "0x401010B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text beforePinAveTotal;
    [Token(Token = "0x401010C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image afterStyleImage;
    [Token(Token = "0x401010D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image[] afterRarityStar;
    [Token(Token = "0x401010E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private LimitBreakIcons gemController;
    [Token(Token = "0x401010F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TypeIcon[] typeIcons;
    [Token(Token = "0x4010110")]
    [FieldOffset(Offset = "0x58")]
    private int typeIconIndex;
    [Token(Token = "0x4010111")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text afterNowLevelText;
    [Token(Token = "0x4010112")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text afterMaxLevelText;
    [Token(Token = "0x4010113")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GaugeScale afterExpSlider;
    [Token(Token = "0x4010114")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text afterCombatPowerText;
    [Token(Token = "0x4010115")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text[] afterParameterText;
    [Token(Token = "0x4010116")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text[] afterPinAve;
    [Token(Token = "0x4010117")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text afterPinAveTotal;
    [Token(Token = "0x4010118")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton memoryButton;
    [Token(Token = "0x4010119")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton reincarnationButton;
    [Token(Token = "0x401011A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton typeIconGroup;
    [Token(Token = "0x401011B")]
    [FieldOffset(Offset = "0xB0")]
    private bool canMemory;
    [Token(Token = "0x401011C")]
    [FieldOffset(Offset = "0xB1")]
    private bool canReincarnationMemory;
    [Token(Token = "0x401011D")]
    [FieldOffset(Offset = "0xB8")]
    private string memoryToasterMsg;
    [Token(Token = "0x401011E")]
    [FieldOffset(Offset = "0xC0")]
    private string reincarnationMemoryToasterMsg;
    [Token(Token = "0x401011F")]
    [FieldOffset(Offset = "0xC8")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x4010120")]
    [FieldOffset(Offset = "0xD0")]
    private Style dispStyle;
    [Token(Token = "0x4010121")]
    [FieldOffset(Offset = "0xD8")]
    private int beforeLv;
    [Token(Token = "0x4010122")]
    private const string noParamText = "--";
    [Token(Token = "0x4010123")]
    private const float ExpRateMax = 1f;
    [Token(Token = "0x4010124")]
    [FieldOffset(Offset = "0xE0")]
    private RarityStyleData rarityStyleData;

    [Token(Token = "0x17004B62")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6017051"), Address(RVA = "0x29CDB18", Offset = "0x29CDB18", VA = "0x29CDB18")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6017052")]
    [Address(RVA = "0x29CDB34", Offset = "0x29CDB34", VA = "0x29CDB34")]
    public IEnumerator InitializeAsync(
      StyleStatusSubScene statusSubScene,
      Style style,
      Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017053")]
    [Address(RVA = "0x29CDBBC", Offset = "0x29CDBBC", VA = "0x29CDBBC")]
    public void SetParam()
    {
    }

    [Token(Token = "0x6017054")]
    [Address(RVA = "0x29CDBC0", Offset = "0x29CDBC0", VA = "0x29CDBC0")]
    private void SetParamInternal()
    {
    }

    [Token(Token = "0x6017055")]
    [Address(RVA = "0x29CF1B8", Offset = "0x29CF1B8", VA = "0x29CF1B8")]
    private void ClearTypeIcon()
    {
    }

    [Token(Token = "0x6017056")]
    [Address(RVA = "0x29CF29C", Offset = "0x29CF29C", VA = "0x29CF29C")]
    private TypeIcon GetEmptyTypeIcon() => (TypeIcon) null;

    [Token(Token = "0x6017057")]
    [Address(RVA = "0x29CE678", Offset = "0x29CE678", VA = "0x29CE678")]
    private void SetTypeIcon()
    {
    }

    [Token(Token = "0x6017058")]
    [Address(RVA = "0x29CF2EC", Offset = "0x29CF2EC", VA = "0x29CF2EC")]
    private void SetTypeIconSprite(Sprite sprite, bool isClass)
    {
    }

    [Token(Token = "0x6017059")]
    [Address(RVA = "0x29CEDFC", Offset = "0x29CEDFC", VA = "0x29CEDFC")]
    private float MemoryExpRate(int memoryLevel, int memoryExp) => new float();

    [Token(Token = "0x601705A")]
    [Address(RVA = "0x29CEFFC", Offset = "0x29CEFFC", VA = "0x29CEFFC")]
    private int MemoryBattlePower(
      ParameterGroup.Parameter parameter,
      IBattleParameter styleMasterBonus,
      StyleData styleData)
    {
      return new int();
    }

    [Token(Token = "0x601705B")]
    [Address(RVA = "0x29CF230", Offset = "0x29CF230", VA = "0x29CF230")]
    public void SetButtonStatus()
    {
    }

    [Token(Token = "0x601705C")]
    [Address(RVA = "0x29CF3F4", Offset = "0x29CF3F4", VA = "0x29CF3F4")]
    private bool CanReincarnationMemorySave(out string errorMessage) => new bool();

    [Token(Token = "0x601705D")]
    [Address(RVA = "0x29CF8CC", Offset = "0x29CF8CC", VA = "0x29CF8CC")]
    private bool CanReincarnationRestore(out string errorMessage) => new bool();

    [Token(Token = "0x601705E")]
    [Address(RVA = "0x29CFDD0", Offset = "0x29CFDD0", VA = "0x29CFDD0")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x601705F")]
    [Address(RVA = "0x29CFE68", Offset = "0x29CFE68", VA = "0x29CFE68")]
    private void PopupCloseAction()
    {
    }

    [Token(Token = "0x6017060")]
    [Address(RVA = "0x29CFEF8", Offset = "0x29CFEF8", VA = "0x29CFEF8")]
    private IEnumerator ConnectReincarnationMemorySave(Action finish) => (IEnumerator) null;

    [Token(Token = "0x6017061")]
    [Address(RVA = "0x29CFF6C", Offset = "0x29CFF6C", VA = "0x29CFF6C")]
    private IEnumerator ConnectReincarnationRestore(Action finish) => (IEnumerator) null;

    [Token(Token = "0x6017062")]
    [Address(RVA = "0x29CFFE0", Offset = "0x29CFFE0", VA = "0x29CFFE0")]
    private IEnumerator EffectReincarnation() => (IEnumerator) null;

    [Token(Token = "0x6017063")]
    [Address(RVA = "0x29D0048", Offset = "0x29D0048", VA = "0x29D0048")]
    private void UpdateSideView()
    {
    }

    [Token(Token = "0x6017064")]
    [Address(RVA = "0x29D0080", Offset = "0x29D0080", VA = "0x29D0080")]
    public StyleReincarnationMemory()
    {
    }
  }
}
