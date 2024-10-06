// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReinforcement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Scenes.OutGame.StyleLevelUp;
using StaqData;
using System.Collections;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A9C")]
  public class StyleReinforcement : MonoBehaviour
  {
    [Token(Token = "0x401015E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x401015F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image[] statusMark;
    [Token(Token = "0x4010160")]
    [FieldOffset(Offset = "0x28")]
    private float fadeTime;
    [Token(Token = "0x4010161")]
    private const float fadeTimeMax = 0.125f;
    [Token(Token = "0x4010162")]
    [FieldOffset(Offset = "0x30")]
    private ParameterTypeEnum[] warrantyParameterList;
    [Token(Token = "0x4010163")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text beforeLevel;
    [Token(Token = "0x4010164")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text afterLevel;
    [Token(Token = "0x4010165")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x4010166")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ItemIcon needMaterialThumb;
    [Token(Token = "0x4010167")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4010168")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x4010169")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x401016A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x401016B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x401016C")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton levelUpButton;
    [Token(Token = "0x401016D")]
    [FieldOffset(Offset = "0x88")]
    private bool canLevelUp;
    [Token(Token = "0x401016E")]
    [FieldOffset(Offset = "0x90")]
    private string toasterMsg;
    [Token(Token = "0x401016F")]
    [FieldOffset(Offset = "0x98")]
    private Color afterLevelTextUPColor;
    [Token(Token = "0x4010170")]
    [FieldOffset(Offset = "0xA8")]
    private Color afterLevelTextNormalColor;
    [Token(Token = "0x4010171")]
    [FieldOffset(Offset = "0xB8")]
    private StyleStatusSubScene styleStatusSubScene;
    [Token(Token = "0x4010172")]
    [FieldOffset(Offset = "0xC0")]
    private Style dispStyle;
    [Token(Token = "0x4010173")]
    [FieldOffset(Offset = "0xC8")]
    private int styleMaxLevel;
    [Token(Token = "0x4010174")]
    [FieldOffset(Offset = "0xCC")]
    private int targetLevel;
    [Token(Token = "0x4010175")]
    [FieldOffset(Offset = "0xD0")]
    private Soul soul;
    [Token(Token = "0x4010176")]
    [FieldOffset(Offset = "0xD8")]
    private int selectSoulNum;
    [Token(Token = "0x4010177")]
    [FieldOffset(Offset = "0xDC")]
    private int passSoulNum;
    [Token(Token = "0x4010178")]
    [FieldOffset(Offset = "0xE0")]
    private bool isLoadedMaterialThumb;
    [Token(Token = "0x4010179")]
    [FieldOffset(Offset = "0xE8")]
    private StyleLevelUpEffect styleLevelUpEffect;
    [Token(Token = "0x401017A")]
    [FieldOffset(Offset = "0xF0")]
    private Sprite styleSprite;
    [Token(Token = "0x401017B")]
    [FieldOffset(Offset = "0xF8")]
    private APIUnitUnit_levelUp UnitLevelUp;
    [Token(Token = "0x401017C")]
    [FieldOffset(Offset = "0x100")]
    private Style oldStyle;

    [Token(Token = "0x60170A9")]
    [Address(RVA = "0x2CE02CC", Offset = "0x2CE02CC", VA = "0x2CE02CC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60170AA")]
    [Address(RVA = "0x2CE03B0", Offset = "0x2CE03B0", VA = "0x2CE03B0")]
    public void Initialize(StyleStatusSubScene statusSubScene, Style style)
    {
    }

    [Token(Token = "0x60170AB")]
    [Address(RVA = "0x2CE0974", Offset = "0x2CE0974", VA = "0x2CE0974")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x60170AC")]
    [Address(RVA = "0x2CE08E0", Offset = "0x2CE08E0", VA = "0x2CE08E0")]
    private void UpdateSideMenu()
    {
    }

    [Token(Token = "0x60170AD")]
    [Address(RVA = "0x2CE0C7C", Offset = "0x2CE0C7C", VA = "0x2CE0C7C")]
    private void SetLevelInfo()
    {
    }

    [Token(Token = "0x60170AE")]
    [Address(RVA = "0x2CE1054", Offset = "0x2CE1054", VA = "0x2CE1054")]
    public void SetButtonStatus()
    {
    }

    [Token(Token = "0x60170AF")]
    [Address(RVA = "0x2CE12C8", Offset = "0x2CE12C8", VA = "0x2CE12C8")]
    private bool CanLevelUp(out string errorMessage) => new bool();

    [Token(Token = "0x60170B0")]
    [Address(RVA = "0x2CE0A44", Offset = "0x2CE0A44", VA = "0x2CE0A44")]
    private void SetMaterialInfo()
    {
    }

    [Token(Token = "0x60170B1")]
    [Address(RVA = "0x2CE13F4", Offset = "0x2CE13F4", VA = "0x2CE13F4")]
    private int GetNextLevelSoulNum(int targetLevel) => new int();

    [Token(Token = "0x60170B2")]
    [Address(RVA = "0x2CE08F8", Offset = "0x2CE08F8", VA = "0x2CE08F8")]
    public IEnumerator SetStatusMarkInOut(bool inFlag) => (IEnumerator) null;

    [Token(Token = "0x60170B3")]
    [Address(RVA = "0x2CE15A4", Offset = "0x2CE15A4", VA = "0x2CE15A4")]
    public void SetOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x60170B4")]
    [Address(RVA = "0x2CE163C", Offset = "0x2CE163C", VA = "0x2CE163C")]
    private IEnumerator StartStyleLevelUp() => (IEnumerator) null;

    [Token(Token = "0x60170B5")]
    [Address(RVA = "0x2CE16CC", Offset = "0x2CE16CC", VA = "0x2CE16CC")]
    private void UnBanInput()
    {
    }

    [Token(Token = "0x60170B6")]
    [Address(RVA = "0x2CE1808", Offset = "0x2CE1808", VA = "0x2CE1808")]
    private IEnumerator ConnectApi() => (IEnumerator) null;

    [Token(Token = "0x60170B7")]
    [Address(RVA = "0x2CE1898", Offset = "0x2CE1898", VA = "0x2CE1898")]
    private IEnumerator EffectLevelUP() => (IEnumerator) null;

    [Token(Token = "0x60170B8")]
    [Address(RVA = "0x2CE1928", Offset = "0x2CE1928", VA = "0x2CE1928")]
    private void FinishStartStyleLevelUp()
    {
    }

    [Token(Token = "0x60170B9")]
    [Address(RVA = "0x2CE1A00", Offset = "0x2CE1A00", VA = "0x2CE1A00")]
    private void Close()
    {
    }

    [Token(Token = "0x60170BA")]
    [Address(RVA = "0x2CE0EC8", Offset = "0x2CE0EC8", VA = "0x2CE0EC8")]
    private int GetExp(int num) => new int();

    [Token(Token = "0x60170BB")]
    [Address(RVA = "0x2CE0F54", Offset = "0x2CE0F54", VA = "0x2CE0F54")]
    private StyleExpDescriptionData GetExpData(int exp) => (StyleExpDescriptionData) null;

    [Token(Token = "0x60170BC")]
    [Address(RVA = "0x2CE1C3C", Offset = "0x2CE1C3C", VA = "0x2CE1C3C")]
    public StyleReinforcement()
    {
    }
  }
}
