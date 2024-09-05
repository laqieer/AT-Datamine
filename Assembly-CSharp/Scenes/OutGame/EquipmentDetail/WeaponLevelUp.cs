// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.WeaponLevelUp
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
  [Token(Token = "0x20036AA")]
  public class WeaponLevelUp : MonoBehaviour
  {
    [Token(Token = "0x400EE08")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text infomationText;
    [Token(Token = "0x400EE09")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text beforeLevel;
    [Token(Token = "0x400EE0A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text afterLevel;
    [Token(Token = "0x400EE0B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x400EE0C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400EE0D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon needMaterialThumb;
    [Token(Token = "0x400EE0E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text needMaterialNumText;
    [Token(Token = "0x400EE0F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400EE10")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400EE11")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400EE12")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400EE13")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400EE14")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton levelUpButton;
    [Token(Token = "0x400EE15")]
    [FieldOffset(Offset = "0x80")]
    private Color afterLevelTextUPColor;
    [Token(Token = "0x400EE16")]
    [FieldOffset(Offset = "0x90")]
    private Color afterLevelTextNormalColor;
    [Token(Token = "0x400EE17")]
    [FieldOffset(Offset = "0xA0")]
    private WeaponDetailSubScene weaponDetailSubScene;
    [Token(Token = "0x400EE18")]
    [FieldOffset(Offset = "0xA8")]
    private Weapon dispWeapon;
    [Token(Token = "0x400EE19")]
    [FieldOffset(Offset = "0xB0")]
    private int maxLevel;
    [Token(Token = "0x400EE1A")]
    [FieldOffset(Offset = "0xB4")]
    private int targetLevel;
    [Token(Token = "0x400EE1B")]
    [FieldOffset(Offset = "0xB8")]
    private int selectSoulNum;
    [Token(Token = "0x400EE1C")]
    [FieldOffset(Offset = "0xBC")]
    private int passSoulNum;
    [Token(Token = "0x400EE1D")]
    [FieldOffset(Offset = "0xC0")]
    private bool isLoadedMaterialThumb;
    [Token(Token = "0x400EE1E")]
    [FieldOffset(Offset = "0xC1")]
    private bool isConnectApi;
    [Token(Token = "0x400EE1F")]
    [FieldOffset(Offset = "0xC2")]
    private bool canLevelUp;
    [Token(Token = "0x400EE20")]
    [FieldOffset(Offset = "0xC8")]
    private string toasterMsg;
    [Token(Token = "0x400EE21")]
    [FieldOffset(Offset = "0xD0")]
    private int lvUpValue;
    [Token(Token = "0x400EE22")]
    [FieldOffset(Offset = "0xD4")]
    private int currentMasterBonusLv;
    [Token(Token = "0x400EE23")]
    [FieldOffset(Offset = "0xD8")]
    private ItemDetailPopupProvider itemDetailPopupProvider;

    [Token(Token = "0x1700474F")]
    public int TargetLevel
    {
      [Token(Token = "0x6015843"), Address(RVA = "0x1A5D060", Offset = "0x1A5D060", VA = "0x1A5D060")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004750")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6015844"), Address(RVA = "0x1A5D068", Offset = "0x1A5D068", VA = "0x1A5D068")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x6015845")]
    [Address(RVA = "0x1A5C764", Offset = "0x1A5C764", VA = "0x1A5C764")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6015846")]
    [Address(RVA = "0x1A5D084", Offset = "0x1A5D084", VA = "0x1A5D084")]
    private void Awake()
    {
    }

    [Token(Token = "0x6015847")]
    [Address(RVA = "0x1A5A5EC", Offset = "0x1A5A5EC", VA = "0x1A5A5EC")]
    public void Initialize(WeaponDetailSubScene statusSubScene)
    {
    }

    [Token(Token = "0x6015848")]
    [Address(RVA = "0x1A5D0E0", Offset = "0x1A5D0E0", VA = "0x1A5D0E0")]
    private void UpdateSideMenu()
    {
    }

    [Token(Token = "0x6015849")]
    [Address(RVA = "0x1A5D57C", Offset = "0x1A5D57C", VA = "0x1A5D57C")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x601584A")]
    [Address(RVA = "0x1A5D300", Offset = "0x1A5D300", VA = "0x1A5D300")]
    private void SetLevelInfo()
    {
    }

    [Token(Token = "0x601584B")]
    [Address(RVA = "0x1A5D6EC", Offset = "0x1A5D6EC", VA = "0x1A5D6EC")]
    public void SetButtonStatus()
    {
    }

    [Token(Token = "0x601584C")]
    [Address(RVA = "0x1A5D974", Offset = "0x1A5D974", VA = "0x1A5D974")]
    private bool CanLevelUp(out string errorMessage) => new bool();

    [Token(Token = "0x601584D")]
    [Address(RVA = "0x1A5D0F8", Offset = "0x1A5D0F8", VA = "0x1A5D0F8")]
    private void SetMaterialInfo()
    {
    }

    [Token(Token = "0x601584E")]
    [Address(RVA = "0x1A5DAA0", Offset = "0x1A5DAA0", VA = "0x1A5DAA0")]
    private int GetNextLevelSoulNum(int targetLevel) => new int();

    [Token(Token = "0x601584F")]
    [Address(RVA = "0x1A5DBB4", Offset = "0x1A5DBB4", VA = "0x1A5DBB4")]
    private IEnumerator ConnectApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6015850")]
    [Address(RVA = "0x1A5DC50", Offset = "0x1A5DC50", VA = "0x1A5DC50")]
    private IEnumerator EffectLevelUp() => (IEnumerator) null;

    [Token(Token = "0x6015851")]
    [Address(RVA = "0x1A5DCE0", Offset = "0x1A5DCE0", VA = "0x1A5DCE0")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x6015852")]
    [Address(RVA = "0x1A5D5D8", Offset = "0x1A5D5D8", VA = "0x1A5D5D8")]
    private int GetExp(int num) => new int();

    [Token(Token = "0x6015853")]
    [Address(RVA = "0x1A5D664", Offset = "0x1A5D664", VA = "0x1A5D664")]
    private WeaponExpData GetExpData(int exp) => (WeaponExpData) null;

    [Token(Token = "0x6015854")]
    [Address(RVA = "0x1A5DF90", Offset = "0x1A5DF90", VA = "0x1A5DF90")]
    public WeaponLevelUp()
    {
    }
  }
}
