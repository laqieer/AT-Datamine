// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.PararaUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D42")]
  public class PararaUnit : MonoBehaviour
  {
    [Token(Token = "0x400C214")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Img_Icon_Lock;
    [Token(Token = "0x400C215")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject Img_Icon_Style;
    [Token(Token = "0x400C216")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject Thumbnail;
    [Token(Token = "0x400C217")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private StyleThumb Com_StyleThumb;
    [Token(Token = "0x400C218")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image UnitNumber10;
    [Token(Token = "0x400C219")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image UnitNumber01;
    [Token(Token = "0x400C21A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text LifeValue;
    [Token(Token = "0x400C21B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text LifeSlash;
    [Token(Token = "0x400C21C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text LifeLimit;
    [Token(Token = "0x400C21D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PararaBoostUp LifePararaBoost;
    [Token(Token = "0x400C21E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text PowerValue;
    [Token(Token = "0x400C21F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text PowerSlash;
    [Token(Token = "0x400C220")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text PowerLimit;
    [Token(Token = "0x400C221")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PararaBoostUp PowerPararaBoost;
    [Token(Token = "0x400C222")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text MagicValue;
    [Token(Token = "0x400C223")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text MagicSlash;
    [Token(Token = "0x400C224")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text MagicLimit;
    [Token(Token = "0x400C225")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private PararaBoostUp MagicPararaBoost;
    [Token(Token = "0x400C226")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text DefenseValue;
    [Token(Token = "0x400C227")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text DefenseSlash;
    [Token(Token = "0x400C228")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text DefenseLimit;
    [Token(Token = "0x400C229")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private PararaBoostUp DefensePararaBoost;
    [Token(Token = "0x400C22A")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text SpiritValue;
    [Token(Token = "0x400C22B")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text SpiritSlash;
    [Token(Token = "0x400C22C")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text SpiritLimit;
    [Token(Token = "0x400C22D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private PararaBoostUp SpiritPararaBoost;
    [Token(Token = "0x400C22E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Text SpeedValue;
    [Token(Token = "0x400C22F")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Text SpeedSlash;
    [Token(Token = "0x400C230")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private Text SpeedLimit;
    [Token(Token = "0x400C231")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private PararaBoostUp SpeedPararaBoost;
    [Token(Token = "0x400C232")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private Text TechniqueValue;
    [Token(Token = "0x400C233")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text TechniqueSlash;
    [Token(Token = "0x400C234")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text TechniqueLimit;
    [Token(Token = "0x400C235")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private PararaBoostUp TechniquePararaBoost;
    [Token(Token = "0x400C236")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private Text FortuneValue;
    [Token(Token = "0x400C237")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private Text FortuneSlash;
    [Token(Token = "0x400C238")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private Text FortuneLimit;
    [Token(Token = "0x400C239")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private PararaBoostUp FortunePararaBoost;
    [Token(Token = "0x400C23A")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C23B")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private GameObject emptyParam;
    [Token(Token = "0x400C23C")]
    private const int MAX_BOOST_EFFECT = 5;
    [Token(Token = "0x400C23D")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private Color normalTextColor;
    [Token(Token = "0x400C23E")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private Color maxTextColor;

    [Token(Token = "0x6011B12")]
    [Address(RVA = "0x42B20B8", Offset = "0x42B20B8", VA = "0x42B20B8")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      int slotNumber,
      Style style,
      bool isLock,
      ExpeditionBossDescriptionData bossData)
    {
    }

    [Token(Token = "0x6011B13")]
    [Address(RVA = "0x42B24B4", Offset = "0x42B24B4", VA = "0x42B24B4")]
    private void InitSlotNumber(AssetCachedSpawner assetCachedSpawner, int slotNumber)
    {
    }

    [Token(Token = "0x6011B14")]
    [Address(RVA = "0x42B25C4", Offset = "0x42B25C4", VA = "0x42B25C4")]
    private bool InitLock(bool isLock) => new bool();

    [Token(Token = "0x6011B15")]
    [Address(RVA = "0x42B26B4", Offset = "0x42B26B4", VA = "0x42B26B4")]
    private bool InitSlotEmpty(Style style) => new bool();

    [Token(Token = "0x6011B16")]
    [Address(RVA = "0x42B2734", Offset = "0x42B2734", VA = "0x42B2734")]
    private void InitStyleThumb(Style style, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6011B17")]
    [Address(RVA = "0x42B2930", Offset = "0x42B2930", VA = "0x42B2930")]
    private void InitParara(Style style)
    {
    }

    [Token(Token = "0x6011B18")]
    [Address(RVA = "0x42B3480", Offset = "0x42B3480", VA = "0x42B3480")]
    private void DisableParam()
    {
    }

    [Token(Token = "0x6011B19")]
    [Address(RVA = "0x42B3220", Offset = "0x42B3220", VA = "0x42B3220")]
    private void InitPararaEffect(ExpeditionBossDescriptionData bossData, Style style)
    {
    }

    [Token(Token = "0x6011B1A")]
    [Address(RVA = "0x42B2644", Offset = "0x42B2644", VA = "0x42B2644")]
    private void InitPararaEffectOff()
    {
    }

    [Token(Token = "0x6011B1B")]
    [Address(RVA = "0x42B3820", Offset = "0x42B3820", VA = "0x42B3820")]
    private float CalcPararaUpPercent(ExpeditionBossDescriptionData bossData, Style style)
    {
      return new float();
    }

    [Token(Token = "0x6011B1C")]
    [Address(RVA = "0x42B3A78", Offset = "0x42B3A78", VA = "0x42B3A78")]
    private float CalcOnePararaUpPercent(
      float parara,
      float pararaStageLimit,
      float pararaStyleLimit)
    {
      return new float();
    }

    [Token(Token = "0x6011B1D")]
    [Address(RVA = "0x42B3CFC", Offset = "0x42B3CFC", VA = "0x42B3CFC")]
    public PararaUnit()
    {
    }
  }
}
