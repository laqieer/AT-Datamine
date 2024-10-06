// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitSimpleStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using StaqData.StatusIcon;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023FF")]
  public class FieldUnitSimpleStatus : MonoBehaviour
  {
    [Token(Token = "0x40099BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40099BD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<ImageContainer> elementalTypeIcons;
    [Token(Token = "0x40099BE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<ImageContainer> frontUnitAbnormalConditions;
    [Token(Token = "0x40099BF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image frontUnitThumbnail;
    [Token(Token = "0x40099C0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI frontUnitName;
    [Token(Token = "0x40099C1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text frontUnitHp;
    [Token(Token = "0x40099C2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text frontUnitMaxHp;
    [Token(Token = "0x40099C3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Slider frontUnitHpSlider;
    [Token(Token = "0x40099C4")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<UI.Utilities.SerializeUI.TextContainer> frontUnitHpStocks;
    [Token(Token = "0x40099C5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<ImageContainer> backUnitAbnormalConditions;
    [Token(Token = "0x40099C6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image backUnitThumbnail;
    [Token(Token = "0x40099C7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI backUnitName;
    [Token(Token = "0x40099C8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text backUnitHp;
    [Token(Token = "0x40099C9")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text backUnitMaxHp;
    [Token(Token = "0x40099CA")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Slider backUnitHpSlider;
    [Token(Token = "0x40099CB")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UI.Utilities.SerializeUI.TextContainer backUnitHpStock;
    [Token(Token = "0x40099CC")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text level;
    [Token(Token = "0x40099CD")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text unitPower;
    [Token(Token = "0x40099CE")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text physicalAttack;
    [Token(Token = "0x40099CF")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text magicalAttack;
    [Token(Token = "0x40099D0")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text physicalDefence;
    [Token(Token = "0x40099D1")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text magicalDefence;
    [Token(Token = "0x40099D2")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    [FormerlySerializedAs("unitMove")]
    private Text attackSpeed;
    [Token(Token = "0x40099D3")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text hitAccuracy;
    [Token(Token = "0x40099D4")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text evasionRate;
    [Token(Token = "0x40099D5")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text deadly;
    [Token(Token = "0x40099D6")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text deadlyEvasion;
    [Token(Token = "0x40099D7")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text barrierIndexNumberText;
    [Token(Token = "0x40099D8")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private ActiveObjectContainers forceLayoutParts;
    [Token(Token = "0x40099D9")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Color defaultParameterColor;
    [Token(Token = "0x40099DA")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Color upParameterColor;
    [Token(Token = "0x40099DB")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Color downParameterColor;
    [Token(Token = "0x40099DC")]
    [FieldOffset(Offset = "0x130")]
    private List<string> tweenPlayList;
    [Token(Token = "0x40099DD")]
    [FieldOffset(Offset = "0x138")]
    private UnityAction tweenCallback;
    [Token(Token = "0x40099DE")]
    [FieldOffset(Offset = "0x140")]
    private bool visible;
    [Token(Token = "0x40099DF")]
    [FieldOffset(Offset = "0x141")]
    private bool hasBack;
    [Token(Token = "0x40099E0")]
    [FieldOffset(Offset = "0x148")]
    private UnitParameterData unit;
    [Token(Token = "0x40099E1")]
    [FieldOffset(Offset = "0x150")]
    public UnityAction<UnitParameterData, int> OnSelectUnitDetail;
    [Token(Token = "0x40099E2")]
    [FieldOffset(Offset = "0x158")]
    private Dictionary<int, Sprite> unitThumbnailSprites;
    [Token(Token = "0x40099E3")]
    [FieldOffset(Offset = "0x160")]
    private IconFactory iconFactory;
    [Token(Token = "0x40099E4")]
    [FieldOffset(Offset = "0x168")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40099E5")]
    [FieldOffset(Offset = "0x170")]
    private int barrierIndex;

    [Token(Token = "0x600DC89")]
    [Address(RVA = "0x1E1E420", Offset = "0x1E1E420", VA = "0x1E1E420")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600DC8A")]
    [Address(RVA = "0x1E1E53C", Offset = "0x1E1E53C", VA = "0x1E1E53C")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600DC8B")]
    [Address(RVA = "0x1E1E5F8", Offset = "0x1E1E5F8", VA = "0x1E1E5F8")]
    public void OnClickUnitDetail()
    {
    }

    [Token(Token = "0x600DC8C")]
    [Address(RVA = "0x1E1E61C", Offset = "0x1E1E61C", VA = "0x1E1E61C")]
    private void SetParameterText(Text text, int correctedValue, object differenceValue)
    {
    }

    [Token(Token = "0x600DC8D")]
    [Address(RVA = "0x1E1E734", Offset = "0x1E1E734", VA = "0x1E1E734")]
    public void UpdateUnitParameterData(
      UnitParameterData unitParamData,
      BattlePlayerData owner,
      GridData selectGrid,
      bool isAlly)
    {
    }

    [Token(Token = "0x600DC8E")]
    [Address(RVA = "0x1E209AC", Offset = "0x1E209AC", VA = "0x1E209AC")]
    public void Show(UnityAction callback = null)
    {
    }

    [Token(Token = "0x600DC8F")]
    [Address(RVA = "0x1E20C64", Offset = "0x1E20C64", VA = "0x1E20C64")]
    private IEnumerator IEShow(UnityAction callback = null) => (IEnumerator) null;

    [Token(Token = "0x600DC90")]
    [Address(RVA = "0x1E20D00", Offset = "0x1E20D00", VA = "0x1E20D00")]
    public void Hide(UnityAction callback = null)
    {
    }

    [Token(Token = "0x600DC91")]
    [Address(RVA = "0x1E20D34", Offset = "0x1E20D34", VA = "0x1E20D34")]
    private IEnumerator IEHide(UnityAction callback = null) => (IEnumerator) null;

    [Token(Token = "0x600DC92")]
    [Address(RVA = "0x1E20A60", Offset = "0x1E20A60", VA = "0x1E20A60")]
    private void UpdateForceColor()
    {
    }

    [Token(Token = "0x600DC93")]
    [Address(RVA = "0x1E20148", Offset = "0x1E20148", VA = "0x1E20148")]
    private void SetAbnormalIcon(UnitParameterData unitParam, List<ImageContainer> viewIconList)
    {
    }

    [Token(Token = "0x600DC94")]
    [Address(RVA = "0x1E203BC", Offset = "0x1E203BC", VA = "0x1E203BC")]
    private void SetTycoonIcon(UnitParameterData unitParam, List<ImageContainer> viewIconList)
    {
    }

    [Token(Token = "0x600DC95")]
    [Address(RVA = "0x1E20774", Offset = "0x1E20774", VA = "0x1E20774")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x600DC96")]
    [Address(RVA = "0x1E20904", Offset = "0x1E20904", VA = "0x1E20904")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x600DC97")]
    [Address(RVA = "0x1E20B70", Offset = "0x1E20B70", VA = "0x1E20B70")]
    public void PlayTweenPlayList(UnityAction callback)
    {
    }

    [Token(Token = "0x600DC98")]
    [Address(RVA = "0x1E20DD0", Offset = "0x1E20DD0", VA = "0x1E20DD0")]
    public void StopTween()
    {
    }

    [Token(Token = "0x600DC99")]
    [Address(RVA = "0x1E20E20", Offset = "0x1E20E20", VA = "0x1E20E20")]
    private int CalcBaseCombatPower(IBattleParameter battleBaseParameter) => new int();

    [Token(Token = "0x600DC9A")]
    [Address(RVA = "0x1E212FC", Offset = "0x1E212FC", VA = "0x1E212FC")]
    public FieldUnitSimpleStatus()
    {
    }
  }
}
