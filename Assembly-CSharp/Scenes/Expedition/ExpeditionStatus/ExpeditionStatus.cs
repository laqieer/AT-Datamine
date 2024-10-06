// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionStatus.ExpeditionStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.ExpeditionStatus
{
  [Token(Token = "0x2002CF8")]
  public class ExpeditionStatus : MonoBehaviour
  {
    [Token(Token = "0x400C07C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400C07D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Image> detailIconList;
    [Token(Token = "0x400C07E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text rareText;
    [Token(Token = "0x400C07F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text nameJapaneseText;
    [Token(Token = "0x400C080")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text nameEnglishText;
    [Token(Token = "0x400C081")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text nameTextHpBanner;
    [Token(Token = "0x400C082")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider hpSlider;
    [Token(Token = "0x400C083")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text hpText;
    [Token(Token = "0x400C084")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text hpMaxText;
    [Token(Token = "0x400C085")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text nameText;
    [Token(Token = "0x400C086")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text lvText;
    [Token(Token = "0x400C087")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text nextLvText;
    [Token(Token = "0x400C088")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400C089")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text lifeText;
    [Token(Token = "0x400C08A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text strText;
    [Token(Token = "0x400C08B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text intText;
    [Token(Token = "0x400C08C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text defText;
    [Token(Token = "0x400C08D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text mindText;
    [Token(Token = "0x400C08E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text agiText;
    [Token(Token = "0x400C08F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text tecText;
    [Token(Token = "0x400C090")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text luckText;
    [Token(Token = "0x400C091")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text moveText;
    [Token(Token = "0x400C092")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text physicsAttackText;
    [Token(Token = "0x400C093")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text magicAttackText;
    [Token(Token = "0x400C094")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text physicsGuardText;
    [Token(Token = "0x400C095")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text magicGuardText;
    [Token(Token = "0x400C096")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text hitText;
    [Token(Token = "0x400C097")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private List<ExpeditionEquipmentRaw> equipmentRawList;
    [Token(Token = "0x400C098")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private List<ExpeditionStatusSkillIcon> unitSkillIconList;
    [Token(Token = "0x400C099")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private List<ExpeditionStatusSkillIcon> equipmentSkillIconList;
    [Token(Token = "0x400C09A")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private List<ExpeditionStatusSkillIcon> customSkillIconList;
    [Token(Token = "0x400C09B")]
    [FieldOffset(Offset = "0x110")]
    private Style targetStyle;
    [Token(Token = "0x400C09C")]
    [FieldOffset(Offset = "0x118")]
    private Character targetCharacter;
    [Token(Token = "0x400C09D")]
    [FieldOffset(Offset = "0x120")]
    private ExpeditionStatusPopup popup;
    [Token(Token = "0x400C09E")]
    [FieldOffset(Offset = "0x128")]
    private NpcUnitDataData npcData;
    [Token(Token = "0x400C09F")]
    private const string UnitDetailAssetName = "page_outgame_unitdetail";
    [Token(Token = "0x400C0A0")]
    private const string UnitDetailSubSceneName = "UnitDetailSubScene";
    [Token(Token = "0x400C0A1")]
    private const string DetailIconAssetsFolder = "2dassts_contents_expedition_statusdetailicon_";
    [Token(Token = "0x400C0A2")]
    private const string WeaponIconAssetsFolder = "weapon";
    [Token(Token = "0x400C0A3")]
    private const string ElementIconAssetsFolder = "element";
    [Token(Token = "0x400C0A4")]
    private const string ArmyIconAssetsFolder = "army";
    [Token(Token = "0x400C0A5")]
    private const string DetailIconFileName = "img_icon_cont";

    [Token(Token = "0x601199F")]
    [Address(RVA = "0x46A4660", Offset = "0x46A4660", VA = "0x46A4660")]
    public void Init(Style inputStyle)
    {
    }

    [Token(Token = "0x60119A0")]
    [Address(RVA = "0x46A59B0", Offset = "0x46A59B0", VA = "0x46A59B0")]
    public void InitNPC(int npcMasterKey, int maxHp)
    {
    }

    [Token(Token = "0x60119A1")]
    [Address(RVA = "0x46A5284", Offset = "0x46A5284", VA = "0x46A5284")]
    public void SetDetailIcons(bool isPlayerUnit = true)
    {
    }

    [Token(Token = "0x60119A2")]
    [Address(RVA = "0x46A6AC0", Offset = "0x46A6AC0", VA = "0x46A6AC0")]
    public void SetPopupClass(ExpeditionStatusPopup inputPopup)
    {
    }

    [Token(Token = "0x60119A3")]
    [Address(RVA = "0x46A6AC8", Offset = "0x46A6AC8", VA = "0x46A6AC8")]
    public void OpenSubParameter()
    {
    }

    [Token(Token = "0x60119A4")]
    [Address(RVA = "0x46A6B8C", Offset = "0x46A6B8C", VA = "0x46A6B8C")]
    public void OpenSkillDetail(SkillDetailData inputSkillDetailData)
    {
    }

    [Token(Token = "0x60119A5")]
    [Address(RVA = "0x46A4638", Offset = "0x46A4638", VA = "0x46A4638")]
    public void OpenEquipmentDetail(Equipment inputEquipment = null)
    {
    }

    [Token(Token = "0x60119A6")]
    [Address(RVA = "0x46A6BAC", Offset = "0x46A6BAC", VA = "0x46A6BAC")]
    public void OnClickClose()
    {
    }

    [Token(Token = "0x60119A7")]
    [Address(RVA = "0x46A6BCC", Offset = "0x46A6BCC", VA = "0x46A6BCC")]
    public ExpeditionStatus()
    {
    }
  }
}
