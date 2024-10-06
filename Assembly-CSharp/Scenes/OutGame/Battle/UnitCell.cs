// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.UnitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Battle.ResultUnit;
using Scenes.OutGame.Effect;
using Scenes.OutGame.StyleLevelUp;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003796")]
  public class UnitCell : MonoBehaviour
  {
    [Token(Token = "0x400F2C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string levelupIconAnimName;
    [Token(Token = "0x400F2C4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int weaponCount;
    [Token(Token = "0x400F2C5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F2C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI leveltext;
    [Token(Token = "0x400F2C7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider expSlider;
    [Token(Token = "0x400F2C8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text point;
    [Token(Token = "0x400F2C9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ResultEquipCell[] equipCell;
    [Token(Token = "0x400F2CA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private WeaponProficiencyController weaponProficiencyController;
    [Token(Token = "0x400F2CB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x400F2CC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject unitImageLoading;
    [Token(Token = "0x400F2CD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private LongPressButton styleButton;
    [Token(Token = "0x400F2CE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image[] elementIcon;
    [Token(Token = "0x400F2D0")]
    [FieldOffset(Offset = "0x80")]
    private List<WeaponCell> weaponCells;
    [Token(Token = "0x400F2D1")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject[] lpDisplayList;
    [Token(Token = "0x400F2D2")]
    [FieldOffset(Offset = "0x90")]
    private bool playEffectLevelUp;
    [Token(Token = "0x400F2D3")]
    [FieldOffset(Offset = "0x98")]
    private StyleExpData styleExp;
    [Token(Token = "0x400F2D4")]
    [FieldOffset(Offset = "0xA0")]
    private Style style;
    [Token(Token = "0x400F2D5")]
    [FieldOffset(Offset = "0xA8")]
    public bool IsWeaponProficiencyAnimPlay;
    [Token(Token = "0x400F2D6")]
    [FieldOffset(Offset = "0xB0")]
    private string ThumbAssetBundleName;
    [Token(Token = "0x400F2D7")]
    [FieldOffset(Offset = "0xB8")]
    private string ThumbAssetName;
    [Token(Token = "0x400F2D8")]
    private const int MaxTrustValue = 10000;
    [Token(Token = "0x400F2D9")]
    [FieldOffset(Offset = "0xC0")]
    private List<IEquipCellApplyer> _equipCellApplyers;
    [Token(Token = "0x400F2DA")]
    [FieldOffset(Offset = "0xC8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F2DC")]
    [FieldOffset(Offset = "0xD8")]
    private Action showStyleLevelUp;
    [Token(Token = "0x400F2DD")]
    [FieldOffset(Offset = "0xE0")]
    private Coroutine coroutineStyleLevelUp;
    [Token(Token = "0x400F2DE")]
    [FieldOffset(Offset = "0xE8")]
    private StyleLevelUpEffect styleLevelUpEffect;

    [Token(Token = "0x17004873")]
    public bool IsSkillUnlock
    {
      [Token(Token = "0x6015E2E"), Address(RVA = "0x2320960", Offset = "0x2320960", VA = "0x2320960")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015E2F"), Address(RVA = "0x2320968", Offset = "0x2320968", VA = "0x2320968")] private set
      {
      }
    }

    [Token(Token = "0x17004874")]
    public Action OnClickedShowStyleLevelUp
    {
      [Token(Token = "0x6015E30"), Address(RVA = "0x2320974", Offset = "0x2320974", VA = "0x2320974")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015E31"), Address(RVA = "0x232097C", Offset = "0x232097C", VA = "0x232097C")] set
      {
      }
    }

    [Token(Token = "0x17004875")]
    public bool IsBusyStyleLevelUp
    {
      [Token(Token = "0x6015E32"), Address(RVA = "0x2320984", Offset = "0x2320984", VA = "0x2320984")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015E33")]
    [Address(RVA = "0x2320A00", Offset = "0x2320A00", VA = "0x2320A00")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6015E34")]
    [Address(RVA = "0x2320B1C", Offset = "0x2320B1C", VA = "0x2320B1C")]
    public void Show(
      ResultData.UnitDifference diffUnit,
      bool lpDisp,
      int unitId,
      Style beforeStyle,
      PlayerUnitType afterUnit,
      Dictionary<int, int> LevelUpPlayedDic)
    {
    }

    [Token(Token = "0x6015E35")]
    [Address(RVA = "0x2321750", Offset = "0x2321750", VA = "0x2321750")]
    public void ShowStyleLevelUp()
    {
    }

    [Token(Token = "0x6015E36")]
    [Address(RVA = "0x232176C", Offset = "0x232176C", VA = "0x232176C")]
    private void ShowStyleLevelUp(
      ResultData.UnitDifference diffUnit,
      Style beforeStyle,
      PlayerUnitType afterUnit)
    {
    }

    [Token(Token = "0x6015E37")]
    [Address(RVA = "0x2321894", Offset = "0x2321894", VA = "0x2321894")]
    private IEnumerator DoShowStyleLevelUp(
      ResultData.UnitDifference diffUnit,
      Style beforeStyle,
      PlayerUnitType afterUnit)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015E38")]
    [Address(RVA = "0x2321948", Offset = "0x2321948", VA = "0x2321948")]
    private void FinishStyleLevelUp()
    {
    }

    [Token(Token = "0x6015E39")]
    [Address(RVA = "0x2321360", Offset = "0x2321360", VA = "0x2321360")]
    private void SetStyleLevel(int level)
    {
    }

    [Token(Token = "0x6015E3A")]
    [Address(RVA = "0x2321410", Offset = "0x2321410", VA = "0x2321410")]
    private void SetStyleExp(int exp)
    {
    }

    [Token(Token = "0x6015E3B")]
    [Address(RVA = "0x2321A64", Offset = "0x2321A64", VA = "0x2321A64")]
    public bool StyleExpAnimation(GaugeUpControl gaugeUpControl, ResultData.UnitDifference diffUnit)
    {
      return new bool();
    }

    [Token(Token = "0x6015E3C")]
    [Address(RVA = "0x2321AC0", Offset = "0x2321AC0", VA = "0x2321AC0")]
    private bool StyleExpSliderAnimation(
      GaugeUpControl gaugeUpControl,
      ResultData.UnitDifference diffUnit)
    {
      return new bool();
    }

    [Token(Token = "0x6015E3D")]
    [Address(RVA = "0x2321D8C", Offset = "0x2321D8C", VA = "0x2321D8C")]
    private void StyleExpAnimationFinish(int exp)
    {
    }

    [Token(Token = "0x6015E3E")]
    [Address(RVA = "0x2321DF0", Offset = "0x2321DF0", VA = "0x2321DF0")]
    public void SetWeaponExp(int[] exps)
    {
    }

    [Token(Token = "0x6015E3F")]
    [Address(RVA = "0x2321F60", Offset = "0x2321F60", VA = "0x2321F60")]
    public void WeaponExpAnimation(
      GaugeUpControl gaugeUpControl,
      WeaponExpData beforExp,
      WeaponExpData afterExp,
      int beforExpNum,
      int afterExpNum,
      int weaponCount)
    {
    }

    [Token(Token = "0x6015E40")]
    [Address(RVA = "0x2322300", Offset = "0x2322300", VA = "0x2322300")]
    public void AccessoryExpAnimation(
      GaugeUpControl gaugeUpControl,
      AccessoriesExpData beforExp,
      AccessoriesExpData afterExp,
      int beforExpNum,
      int afterExpNum)
    {
    }

    [Token(Token = "0x6015E41")]
    [Address(RVA = "0x2320AF8", Offset = "0x2320AF8", VA = "0x2320AF8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6015E42")]
    [Address(RVA = "0x2322430", Offset = "0x2322430", VA = "0x2322430")]
    public void ShowStatusUp()
    {
    }

    [Token(Token = "0x6015E43")]
    [Address(RVA = "0x2322434", Offset = "0x2322434", VA = "0x2322434")]
    public IEnumerator PlayWeaponProficiency(
      GaugeUpControl gaugeUpControl,
      List<UnitView.stWeaponProficiency> list)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015E44")]
    [Address(RVA = "0x23212F8", Offset = "0x23212F8", VA = "0x23212F8")]
    private IEnumerator LoadWaitthumb() => (IEnumerator) null;

    [Token(Token = "0x6015E45")]
    [Address(RVA = "0x2322500", Offset = "0x2322500", VA = "0x2322500")]
    public UnitCell()
    {
    }
  }
}
