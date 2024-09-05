// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleGetExp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002372")]
  public class BattleGetExp : MonoBehaviour
  {
    [Token(Token = "0x40096BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40096BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI mainUnitText;
    [Token(Token = "0x40096BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mainUnitLevelText;
    [Token(Token = "0x40096C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mainUnitExpText;
    [Token(Token = "0x40096C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider mainUnitExpGauge;
    [Token(Token = "0x40096C2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mainWeaponExpText;
    [Token(Token = "0x40096C3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider mainUnitWeaponGauge;
    [Token(Token = "0x40096C4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text mainWeaponLevelText;
    [Token(Token = "0x40096C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image mainUnitImage;
    [Token(Token = "0x40096C6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI subUnitText;
    [Token(Token = "0x40096C7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text subUnitLevelText;
    [Token(Token = "0x40096C8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text subUnitExpText;
    [Token(Token = "0x40096C9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Slider subUnitExpGauge;
    [Token(Token = "0x40096CA")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image subUnitImage;
    [Token(Token = "0x40096CB")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private FormationSlotEquipmentThumb weaponIcon;
    [Token(Token = "0x40096CC")]
    [FieldOffset(Offset = "0x90")]
    private UnitParameterData unit;
    [Token(Token = "0x40096CD")]
    [FieldOffset(Offset = "0x98")]
    private bool hasBack;
    [Token(Token = "0x40096CE")]
    [FieldOffset(Offset = "0xA0")]
    private Dictionary<int, Sprite> unitThumbnailSprites;
    [Token(Token = "0x40096CF")]
    [FieldOffset(Offset = "0xA8")]
    private BattleExpInfo frontInfo;
    [Token(Token = "0x40096D0")]
    [FieldOffset(Offset = "0xB0")]
    private BattleExpInfo backInfo;
    [Token(Token = "0x40096D1")]
    [FieldOffset(Offset = "0xB8")]
    private bool showFlag;
    [Token(Token = "0x40096D2")]
    [FieldOffset(Offset = "0xB9")]
    private bool showLevelUpEffect;
    [Token(Token = "0x40096D3")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject levelUpEffectPrefab;
    [Token(Token = "0x40096D4")]
    [FieldOffset(Offset = "0xC8")]
    private BattleGetExp.ExpGaugeType playType;
    [Token(Token = "0x40096D5")]
    [FieldOffset(Offset = "0xCC")]
    private int weaponMaxLv;
    [Token(Token = "0x40096D6")]
    [FieldOffset(Offset = "0xD0")]
    private bool allLevelMax;
    [Token(Token = "0x40096D7")]
    [FieldOffset(Offset = "0xD4")]
    private float endTime;
    [Token(Token = "0x40096D8")]
    [FieldOffset(Offset = "0xD8")]
    private float endExpBarTime;
    [Token(Token = "0x40096D9")]
    [FieldOffset(Offset = "0xDC")]
    private bool isFrontLevelMax;
    [Token(Token = "0x40096DA")]
    [FieldOffset(Offset = "0xDD")]
    private bool isFrontWeaponLevelMax;
    [Token(Token = "0x40096DB")]
    [FieldOffset(Offset = "0xDE")]
    private bool isBackLevelMax;
    [Token(Token = "0x40096DC")]
    [FieldOffset(Offset = "0xE0")]
    private Action HideAction;
    [Token(Token = "0x40096DD")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private PlayableDirector playableDirector;

    [Token(Token = "0x600D881")]
    [Address(RVA = "0x1B9512C", Offset = "0x1B9512C", VA = "0x1B9512C")]
    public void Initialize(IDirector director)
    {
    }

    [Token(Token = "0x600D882")]
    [Address(RVA = "0x1B951E0", Offset = "0x1B951E0", VA = "0x1B951E0")]
    public void SetUnitParameterData(BattleExpInfo frontInfo, BattleExpInfo backInfo)
    {
    }

    [Token(Token = "0x600D883")]
    [Address(RVA = "0x1B9591C", Offset = "0x1B9591C", VA = "0x1B9591C")]
    private void SetIsLevelMax(
      BattleExpInfo frontInfo,
      BattleExpInfo backInfo,
      WeaponParameterData weapon)
    {
    }

    [Token(Token = "0x600D884")]
    [Address(RVA = "0x1B95AC4", Offset = "0x1B95AC4", VA = "0x1B95AC4")]
    public void Show(Action action)
    {
    }

    [Token(Token = "0x600D885")]
    [Address(RVA = "0x1B95C48", Offset = "0x1B95C48", VA = "0x1B95C48")]
    public void Hide()
    {
    }

    [Token(Token = "0x600D886")]
    [Address(RVA = "0x1B95BE0", Offset = "0x1B95BE0", VA = "0x1B95BE0")]
    private IEnumerator CheckSliderAnimation() => (IEnumerator) null;

    [Token(Token = "0x600D887")]
    [Address(RVA = "0x1B95D2C", Offset = "0x1B95D2C", VA = "0x1B95D2C")]
    private void PlayTimeline(string trackGroupName)
    {
    }

    [Token(Token = "0x600D888")]
    [Address(RVA = "0x1B960CC", Offset = "0x1B960CC", VA = "0x1B960CC")]
    private IEnumerator UnitExpCoroutine(float duration, BattleGetExp.ExpGaugeType type)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600D889")]
    [Address(RVA = "0x1B9617C", Offset = "0x1B9617C", VA = "0x1B9617C")]
    public void UnitExpSkip()
    {
    }

    [Token(Token = "0x600D88A")]
    [Address(RVA = "0x1B966D0", Offset = "0x1B966D0", VA = "0x1B966D0")]
    private IEnumerator EffectLevelUP() => (IEnumerator) null;

    [Token(Token = "0x600D88B")]
    [Address(RVA = "0x1B96760", Offset = "0x1B96760", VA = "0x1B96760")]
    public void effectReincarnationLvUPFinish()
    {
    }

    [Token(Token = "0x600D88C")]
    [Address(RVA = "0x1B96768", Offset = "0x1B96768", VA = "0x1B96768")]
    public BattleGetExp()
    {
    }

    [Token(Token = "0x2002373")]
    public enum ExpGaugeType
    {
      [Token(Token = "0x40096DF")] FrontUnit,
      [Token(Token = "0x40096E0")] FrontWeapon,
      [Token(Token = "0x40096E1")] SubUnit,
      [Token(Token = "0x40096E2")] AnimaEnd,
      [Token(Token = "0x40096E3")] Non,
    }
  }
}
