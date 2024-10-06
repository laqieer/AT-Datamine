// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.ExpeditionPartyUnitCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Expedition.BossList.BossDetail;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CB5")]
  public class ExpeditionPartyUnitCell : MonoBehaviour
  {
    [Token(Token = "0x400BEC6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button styleThumbButton;
    [Token(Token = "0x400BEC7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform styleThumbParent;
    [Token(Token = "0x400BEC8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400BEC9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject levelObj;
    [Token(Token = "0x400BECA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400BECB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform styleExpGauge;
    [Token(Token = "0x400BECC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject levelUpObj;
    [Token(Token = "0x400BECD")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI levelUpText;
    [Token(Token = "0x400BECE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject slotSelectObj;
    [Token(Token = "0x400BECF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton releaseButton;
    [Token(Token = "0x400BED0")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button searchButton;
    [Token(Token = "0x400BED1")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject styleIcon;
    [Token(Token = "0x400BED2")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject lockIcon;
    [Token(Token = "0x400BED3")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private PararaBoostUp pararaBoostUp;
    [Token(Token = "0x400BED4")]
    [FieldOffset(Offset = "0x88")]
    [Header("戦闘力")]
    [SerializeField]
    private GameObject combatPowerObj;
    [Token(Token = "0x400BED5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image combatPowerBaseImg;
    [Token(Token = "0x400BED6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x400BED7")]
    [FieldOffset(Offset = "0xA0")]
    private Action<int> onClickUnitSlot;
    [Token(Token = "0x400BED8")]
    [FieldOffset(Offset = "0xA8")]
    private Action onReleaseAction;
    [Token(Token = "0x400BED9")]
    [FieldOffset(Offset = "0xB0")]
    private Style styleData;
    [Token(Token = "0x400BEDB")]
    [FieldOffset(Offset = "0xBC")]
    private bool isLock;
    [Token(Token = "0x400BEDC")]
    [FieldOffset(Offset = "0xBD")]
    private bool isBoss;
    [Token(Token = "0x400BEDD")]
    [FieldOffset(Offset = "0xC0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BEDE")]
    [FieldOffset(Offset = "0xC8")]
    private ExpeditionBossDescriptionData bossData;

    [Token(Token = "0x17003C2C")]
    public string StyleId
    {
      [Token(Token = "0x60117C7"), Address(RVA = "0x4939AB8", Offset = "0x4939AB8", VA = "0x4939AB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003C2D")]
    public int Index
    {
      [Token(Token = "0x60117C8"), Address(RVA = "0x49418AC", Offset = "0x49418AC", VA = "0x49418AC")] get
      {
        return new int();
      }
      [Token(Token = "0x60117C9"), Address(RVA = "0x49418B4", Offset = "0x49418B4", VA = "0x49418B4")] private set
      {
      }
    }

    [Token(Token = "0x60117CA")]
    [Address(RVA = "0x4939C04", Offset = "0x4939C04", VA = "0x4939C04")]
    public void Initialize(
      bool isBoss,
      Action<int> onSlotAction,
      Action onReleaseAction,
      AssetCachedSpawner spawner,
      ExpeditionBossDescriptionData bossData)
    {
    }

    [Token(Token = "0x60117CB")]
    [Address(RVA = "0x4939DF4", Offset = "0x4939DF4", VA = "0x4939DF4")]
    public void UpdateView(int index, Style style, int storedExperience, int combatPower)
    {
    }

    [Token(Token = "0x60117CC")]
    [Address(RVA = "0x4941D1C", Offset = "0x4941D1C", VA = "0x4941D1C")]
    public void SetLock(bool isLock)
    {
    }

    [Token(Token = "0x60117CD")]
    [Address(RVA = "0x493BDD0", Offset = "0x493BDD0", VA = "0x493BDD0")]
    public void UpdateSelect(bool isSelect)
    {
    }

    [Token(Token = "0x60117CE")]
    [Address(RVA = "0x4939B34", Offset = "0x4939B34", VA = "0x4939B34")]
    public void UpdateUnitExp(int storedExperience)
    {
    }

    [Token(Token = "0x60117CF")]
    [Address(RVA = "0x49418BC", Offset = "0x49418BC", VA = "0x49418BC")]
    private void UpdateUnitView(int storedExperience, int combatPower)
    {
    }

    [Token(Token = "0x60117D0")]
    [Address(RVA = "0x4941D28", Offset = "0x4941D28", VA = "0x4941D28")]
    private void UnitEmpty()
    {
    }

    [Token(Token = "0x60117D1")]
    [Address(RVA = "0x4941E64", Offset = "0x4941E64", VA = "0x4941E64")]
    private void OnStyleThumbButton(int index)
    {
    }

    [Token(Token = "0x60117D2")]
    [Address(RVA = "0x4941E90", Offset = "0x4941E90", VA = "0x4941E90")]
    private void OnReleaseButton()
    {
    }

    [Token(Token = "0x60117D3")]
    [Address(RVA = "0x4941EAC", Offset = "0x4941EAC", VA = "0x4941EAC")]
    private void OnSearchButton()
    {
    }

    [Token(Token = "0x60117D4")]
    [Address(RVA = "0x4941ED0", Offset = "0x4941ED0", VA = "0x4941ED0")]
    public ExpeditionPartyUnitCell()
    {
    }
  }
}
