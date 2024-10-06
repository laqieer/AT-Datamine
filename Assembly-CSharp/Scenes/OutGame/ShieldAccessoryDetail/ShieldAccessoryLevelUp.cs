// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ShieldAccessoryDetail.ShieldAccessoryLevelUp
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
namespace Scenes.OutGame.ShieldAccessoryDetail
{
  [Token(Token = "0x2003397")]
  public class ShieldAccessoryLevelUp : MonoBehaviour
  {
    [Token(Token = "0x400DFF8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text infomationText;
    [Token(Token = "0x400DFF9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text beforeLevel;
    [Token(Token = "0x400DFFA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text afterLevel;
    [Token(Token = "0x400DFFB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GaugeScale expSlider;
    [Token(Token = "0x400DFFC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform needMaterialTrans;
    [Token(Token = "0x400DFFD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon needMaterialThumb;
    [Token(Token = "0x400DFFE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text needMaterialNumText;
    [Token(Token = "0x400DFFF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400E000")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton defaultButton;
    [Token(Token = "0x400E001")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400E002")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400E003")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton maxButton;
    [Token(Token = "0x400E004")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton levelUpButton;
    [Token(Token = "0x400E005")]
    [FieldOffset(Offset = "0x80")]
    private Color afterLevelTextUPColor;
    [Token(Token = "0x400E006")]
    [FieldOffset(Offset = "0x90")]
    private Color afterLevelTextNormalColor;
    [Token(Token = "0x400E007")]
    [FieldOffset(Offset = "0xA0")]
    private ShieldAccessoryDetailSubScene accessoryDetailSubScene;
    [Token(Token = "0x400E008")]
    [FieldOffset(Offset = "0xA8")]
    private Accessory dispAccessory;
    [Token(Token = "0x400E009")]
    [FieldOffset(Offset = "0xB0")]
    private int maxLevel;
    [Token(Token = "0x400E00A")]
    [FieldOffset(Offset = "0xB4")]
    private int targetLevel;
    [Token(Token = "0x400E00B")]
    [FieldOffset(Offset = "0xB8")]
    private int selectSoulNum;
    [Token(Token = "0x400E00C")]
    [FieldOffset(Offset = "0xBC")]
    private int passSoulNum;
    [Token(Token = "0x400E00D")]
    [FieldOffset(Offset = "0xC0")]
    private bool isLoadedMaterialThumb;
    [Token(Token = "0x400E00E")]
    [FieldOffset(Offset = "0xC1")]
    private bool isConnectApi;
    [Token(Token = "0x400E00F")]
    [FieldOffset(Offset = "0xC2")]
    private bool canLevelUp;
    [Token(Token = "0x400E010")]
    [FieldOffset(Offset = "0xC8")]
    private string toasterMsg;
    [Token(Token = "0x400E011")]
    [FieldOffset(Offset = "0xD0")]
    private int lvUpValue;
    [Token(Token = "0x400E012")]
    [FieldOffset(Offset = "0xD8")]
    private ItemDetailPopupProvider itemDetailPopupProvider;

    [Token(Token = "0x170043A6")]
    public int TargetLevel
    {
      [Token(Token = "0x6014488"), Address(RVA = "0x2067554", Offset = "0x2067554", VA = "0x2067554")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170043A7")]
    private AssetCachedSpawner assetCachedSpawner
    {
      [Token(Token = "0x6014489"), Address(RVA = "0x206755C", Offset = "0x206755C", VA = "0x206755C")] get
      {
        return (AssetCachedSpawner) null;
      }
    }

    [Token(Token = "0x601448A")]
    [Address(RVA = "0x2066D50", Offset = "0x2066D50", VA = "0x2066D50")]
    public static void Preload(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601448B")]
    [Address(RVA = "0x2067578", Offset = "0x2067578", VA = "0x2067578")]
    private void Awake()
    {
    }

    [Token(Token = "0x601448C")]
    [Address(RVA = "0x2064D80", Offset = "0x2064D80", VA = "0x2064D80")]
    public void Initialize(ShieldAccessoryDetailSubScene statusSubScene)
    {
    }

    [Token(Token = "0x601448D")]
    [Address(RVA = "0x20675D4", Offset = "0x20675D4", VA = "0x20675D4")]
    private void UpdateSideMenu()
    {
    }

    [Token(Token = "0x601448E")]
    [Address(RVA = "0x2067A04", Offset = "0x2067A04", VA = "0x2067A04")]
    private void OnClickPrevNext()
    {
    }

    [Token(Token = "0x601448F")]
    [Address(RVA = "0x20677F8", Offset = "0x20677F8", VA = "0x20677F8")]
    private void SetLevelInfo()
    {
    }

    [Token(Token = "0x6014490")]
    [Address(RVA = "0x2067B74", Offset = "0x2067B74", VA = "0x2067B74")]
    public void SetButtonStatus()
    {
    }

    [Token(Token = "0x6014491")]
    [Address(RVA = "0x2067DFC", Offset = "0x2067DFC", VA = "0x2067DFC")]
    private bool CanLevelUp(out string errorMessage) => new bool();

    [Token(Token = "0x6014492")]
    [Address(RVA = "0x20675EC", Offset = "0x20675EC", VA = "0x20675EC")]
    private void SetMaterialInfo()
    {
    }

    [Token(Token = "0x6014493")]
    [Address(RVA = "0x2067F28", Offset = "0x2067F28", VA = "0x2067F28")]
    private int GetNextLevelSoulNum(int targetLevel) => new int();

    [Token(Token = "0x6014494")]
    [Address(RVA = "0x206803C", Offset = "0x206803C", VA = "0x206803C")]
    private IEnumerator ConnectApi(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6014495")]
    [Address(RVA = "0x20680D8", Offset = "0x20680D8", VA = "0x20680D8")]
    private IEnumerator EffectLevelUp() => (IEnumerator) null;

    [Token(Token = "0x6014496")]
    [Address(RVA = "0x2068168", Offset = "0x2068168", VA = "0x2068168")]
    private void FinishEffectAction()
    {
    }

    [Token(Token = "0x6014497")]
    [Address(RVA = "0x2067A60", Offset = "0x2067A60", VA = "0x2067A60")]
    private int GetExp(int num) => new int();

    [Token(Token = "0x6014498")]
    [Address(RVA = "0x2067AEC", Offset = "0x2067AEC", VA = "0x2067AEC")]
    private AccessoriesExpData GetExpData(int exp) => (AccessoriesExpData) null;

    [Token(Token = "0x6014499")]
    [Address(RVA = "0x20681C4", Offset = "0x20681C4", VA = "0x20681C4")]
    public ShieldAccessoryLevelUp()
    {
    }
  }
}
