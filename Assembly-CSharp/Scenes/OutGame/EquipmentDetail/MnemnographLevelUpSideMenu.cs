// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.MnemnographLevelUpSideMenu
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
using UI.Common;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x20036DF")]
  public class MnemnographLevelUpSideMenu : MnemnographDetailSideMenuBase
  {
    [Token(Token = "0x400EF72")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EF73")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text beforeText;
    [Token(Token = "0x400EF74")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text afterText;
    [Token(Token = "0x400EF75")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x400EF76")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject thumbnailLayoutGroup;
    [Token(Token = "0x400EF77")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text useNumText;
    [Token(Token = "0x400EF78")]
    [FieldOffset(Offset = "0x88")]
    private MnemnographDetailSubScene detailSubScene;
    [Token(Token = "0x400EF79")]
    [FieldOffset(Offset = "0x90")]
    private int useItemCount;
    [Token(Token = "0x400EF7A")]
    [FieldOffset(Offset = "0x94")]
    private int useMax;
    [Token(Token = "0x400EF7B")]
    [FieldOffset(Offset = "0x98")]
    private int soulPossession;
    [Token(Token = "0x400EF7C")]
    [FieldOffset(Offset = "0xA0")]
    private ItemIcon redSoulItemIcon;
    [Token(Token = "0x400EF7D")]
    private const string LevelText = "Lv";
    [Token(Token = "0x400EF7E")]
    [FieldOffset(Offset = "0xA8")]
    private int lvUpValue;
    [Token(Token = "0x400EF7F")]
    [FieldOffset(Offset = "0xB0")]
    private ItemDetailPopupProvider itemDetailPopupProvider;

    [Token(Token = "0x17004782")]
    public int TargetLevel
    {
      [Token(Token = "0x60159BD"), Address(RVA = "0x1D7BE28", Offset = "0x1D7BE28", VA = "0x1D7BE28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004783")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x60159BE"), Address(RVA = "0x1D7BED8", Offset = "0x1D7BED8", VA = "0x1D7BED8")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x60159BF")]
    [Address(RVA = "0x1D7B068", Offset = "0x1D7B068", VA = "0x1D7B068")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60159C0")]
    [Address(RVA = "0x1D7BEF4", Offset = "0x1D7BEF4", VA = "0x1D7BEF4")]
    public void Initialize(MnemnographDetailSubScene detailSubScene)
    {
    }

    [Token(Token = "0x60159C1")]
    [Address(RVA = "0x1D7BF2C", Offset = "0x1D7BF2C", VA = "0x1D7BF2C", Slot = "4")]
    protected override void OnClickMinButton()
    {
    }

    [Token(Token = "0x60159C2")]
    [Address(RVA = "0x1D7C1C8", Offset = "0x1D7C1C8", VA = "0x1D7C1C8", Slot = "5")]
    protected override void OnClickMinusButton()
    {
    }

    [Token(Token = "0x60159C3")]
    [Address(RVA = "0x1D7C4B8", Offset = "0x1D7C4B8", VA = "0x1D7C4B8", Slot = "6")]
    protected override void OnClickPlusButton()
    {
    }

    [Token(Token = "0x60159C4")]
    [Address(RVA = "0x1D7C534", Offset = "0x1D7C534", VA = "0x1D7C534", Slot = "7")]
    protected override void OnClickMaxButton()
    {
    }

    [Token(Token = "0x60159C5")]
    [Address(RVA = "0x1D7C62C", Offset = "0x1D7C62C", VA = "0x1D7C62C", Slot = "8")]
    protected override void OnClickEnhanceButton()
    {
    }

    [Token(Token = "0x60159C6")]
    [Address(RVA = "0x1D7C9C4", Offset = "0x1D7C9C4", VA = "0x1D7C9C4", Slot = "9")]
    public override void Set(MindEquipment mindEquipment, Action onClickCloseButton)
    {
    }

    [Token(Token = "0x60159C7")]
    [Address(RVA = "0x1D7CCBC", Offset = "0x1D7CCBC", VA = "0x1D7CCBC")]
    private void UpdateSoulPossession()
    {
    }

    [Token(Token = "0x60159C8")]
    [Address(RVA = "0x1D7CD68", Offset = "0x1D7CD68", VA = "0x1D7CD68")]
    private void SetSelectButtonState()
    {
    }

    [Token(Token = "0x60159C9")]
    [Address(RVA = "0x1D7D100", Offset = "0x1D7D100", VA = "0x1D7D100", Slot = "10")]
    protected override void UpdateInfo(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x60159CA")]
    [Address(RVA = "0x1D7D1EC", Offset = "0x1D7D1EC", VA = "0x1D7D1EC", Slot = "11")]
    protected override void InitializedInternal()
    {
    }

    [Token(Token = "0x60159CB")]
    [Address(RVA = "0x1D7D1F0", Offset = "0x1D7D1F0", VA = "0x1D7D1F0", Slot = "12")]
    protected override IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60159CC")]
    [Address(RVA = "0x1D7C95C", Offset = "0x1D7C95C", VA = "0x1D7C95C")]
    private IEnumerator ExecuteLimitBreak() => (IEnumerator) null;

    [Token(Token = "0x60159CD")]
    [Address(RVA = "0x1D7D2A8", Offset = "0x1D7D2A8", VA = "0x1D7D2A8")]
    private IEnumerator EffectLevelUp() => (IEnumerator) null;

    [Token(Token = "0x60159CE")]
    [Address(RVA = "0x1D7D338", Offset = "0x1D7D338", VA = "0x1D7D338")]
    private void UpdateSideView()
    {
    }

    [Token(Token = "0x60159CF")]
    [Address(RVA = "0x1D7BF34", Offset = "0x1D7BF34", VA = "0x1D7BF34")]
    private void SetNextLevel()
    {
    }

    [Token(Token = "0x60159D0")]
    [Address(RVA = "0x1D7D538", Offset = "0x1D7D538", VA = "0x1D7D538")]
    private int CalcState(int min, int max, int nowLevel, int maxLevel) => new int();

    [Token(Token = "0x60159D1")]
    [Address(RVA = "0x1D7D428", Offset = "0x1D7D428", VA = "0x1D7D428")]
    private void SetTextNumWithEnhanceButtonInteractable()
    {
    }

    [Token(Token = "0x60159D2")]
    [Address(RVA = "0x1D7C86C", Offset = "0x1D7C86C", VA = "0x1D7C86C")]
    private bool IsUnavailableLevelUp() => new bool();

    [Token(Token = "0x60159D3")]
    [Address(RVA = "0x1D7C270", Offset = "0x1D7C270", VA = "0x1D7C270")]
    private int GetExp(int num) => new int();

    [Token(Token = "0x60159D4")]
    [Address(RVA = "0x1D7C384", Offset = "0x1D7C384", VA = "0x1D7C384")]
    private int GetNeedExp(int level) => new int();

    [Token(Token = "0x60159D5")]
    [Address(RVA = "0x1D7C2FC", Offset = "0x1D7C2FC", VA = "0x1D7C2FC")]
    private MindEquipmentExpData GetExpData(int exp) => (MindEquipmentExpData) null;

    [Token(Token = "0x60159D6")]
    [Address(RVA = "0x1D7CFEC", Offset = "0x1D7CFEC", VA = "0x1D7CFEC")]
    private int GetNextLevelSoulNum(int targetLevel) => new int();

    [Token(Token = "0x60159D7")]
    [Address(RVA = "0x1D7D57C", Offset = "0x1D7D57C", VA = "0x1D7D57C")]
    private void UpdateSideMenu()
    {
    }

    [Token(Token = "0x60159D8")]
    [Address(RVA = "0x1D7D594", Offset = "0x1D7D594", VA = "0x1D7D594")]
    public MnemnographLevelUpSideMenu()
    {
    }
  }
}
