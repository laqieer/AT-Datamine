// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleStatusDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.Popup;
using Scenes.OutGame.UnitDetail.Popup;
using StaqData;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AA3")]
  public class StyleStatusDetail : MonoBehaviour
  {
    [Token(Token = "0x401018E")]
    private const string ASSET_BUNDLE_STYLE_STATUS = "ui_page_stylestatus";
    [Token(Token = "0x401018F")]
    private const string ASSET_ENHANCED_RESISTANCE = "Com_Popup_Base_L_EnhancedResistance";
    [Token(Token = "0x4010190")]
    private const string ASSET_COMBAT_POWER_POPUP = "Com_Popup_CombatPower_Detail";
    [Token(Token = "0x4010191")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x4010192")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x4010193")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI combatPower;
    [Token(Token = "0x4010194")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject[] initialRarityStars;
    [Token(Token = "0x4010195")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject[] limitBreakGems;
    [Token(Token = "0x4010196")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton enhancedResistanceButton;
    [Token(Token = "0x4010197")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI pinNum;
    [Token(Token = "0x4010198")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI boardNum;
    [Token(Token = "0x4010199")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI reincarnationNum;
    [Token(Token = "0x401019A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionHP;
    [Token(Token = "0x401019B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionAttack;
    [Token(Token = "0x401019C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionMagic;
    [Token(Token = "0x401019D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionDef;
    [Token(Token = "0x401019E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionMDef;
    [Token(Token = "0x401019F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionDexterity;
    [Token(Token = "0x40101A0")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionEvasion;
    [Token(Token = "0x40101A1")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionCritical;
    [Token(Token = "0x40101A2")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI battleRevisionCriticalEvade;
    [Token(Token = "0x40101A3")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private ParameterItemStatus statusLife;
    [Token(Token = "0x40101A4")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private ParameterItemStatus statusStrength;
    [Token(Token = "0x40101A5")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ParameterItemStatus statusMag;
    [Token(Token = "0x40101A6")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private ParameterItemStatus statusDef;
    [Token(Token = "0x40101A7")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private ParameterItemStatus statusSpirit;
    [Token(Token = "0x40101A8")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private ParameterItemStatus statusSpeed;
    [Token(Token = "0x40101A9")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private ParameterItemStatus statusTech;
    [Token(Token = "0x40101AA")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private ParameterItemStatus statusLuck;
    [Token(Token = "0x40101AB")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusHP;
    [Token(Token = "0x40101AC")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusATK;
    [Token(Token = "0x40101AD")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusMATK;
    [Token(Token = "0x40101AE")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusDEF;
    [Token(Token = "0x40101AF")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusMDEF;
    [Token(Token = "0x40101B0")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusDEX;
    [Token(Token = "0x40101B1")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusEVA;
    [Token(Token = "0x40101B2")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusCritical;
    [Token(Token = "0x40101B3")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusCriticalEVA;
    [Token(Token = "0x40101B4")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private ParameterItemBattleStatus battleStatusAGI;
    [Token(Token = "0x40101B5")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private StyleTrainingRankIcon rankIcon;
    [Token(Token = "0x40101B6")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40101B7")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private CommonButton rankDetailButton;
    [Token(Token = "0x40101B8")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40101B9")]
    [FieldOffset(Offset = "0x158")]
    private Style style;
    [Token(Token = "0x40101BA")]
    [FieldOffset(Offset = "0x160")]
    private UITimelineController timelineController;
    [Token(Token = "0x40101BB")]
    [FieldOffset(Offset = "0x168")]
    private EnhancedResistancePopup enhancedResistance;
    [Token(Token = "0x40101BC")]
    [FieldOffset(Offset = "0x170")]
    private StyleTrainingRankDetailPopup rankDetailPopup;

    [Token(Token = "0x60170E7")]
    [Address(RVA = "0x2CE44E4", Offset = "0x2CE44E4", VA = "0x2CE44E4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60170E8")]
    [Address(RVA = "0x2CE46F4", Offset = "0x2CE46F4", VA = "0x2CE46F4")]
    public void SetStyle(Style style)
    {
    }

    [Token(Token = "0x60170E9")]
    [Address(RVA = "0x2CE5374", Offset = "0x2CE5374", VA = "0x2CE5374")]
    public IEnumerator Open() => (IEnumerator) null;

    [Token(Token = "0x60170EA")]
    [Address(RVA = "0x2CE5284", Offset = "0x2CE5284", VA = "0x2CE5284")]
    private static string ParamToString(int param) => (string) null;

    [Token(Token = "0x60170EB")]
    [Address(RVA = "0x2CE5404", Offset = "0x2CE5404", VA = "0x2CE5404")]
    private void Close()
    {
    }

    [Token(Token = "0x60170EC")]
    [Address(RVA = "0x2CE5494", Offset = "0x2CE5494", VA = "0x2CE5494")]
    private void OpenEnhancedResistance()
    {
    }

    [Token(Token = "0x60170ED")]
    [Address(RVA = "0x2CE5694", Offset = "0x2CE5694", VA = "0x2CE5694")]
    private void OpenRankDetailPopup()
    {
    }

    [Token(Token = "0x60170EE")]
    [Address(RVA = "0x2CE5894", Offset = "0x2CE5894", VA = "0x2CE5894")]
    public StyleStatusDetail()
    {
    }
  }
}
