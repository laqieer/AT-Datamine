// Decompiled with JetBrains decompiler
// Type: Gacha.GachaPreviousResultPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001546")]
  public class GachaPreviousResultPopup : PopupBase
  {
    [Token(Token = "0x40061B4")]
    private const string assetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x40061B5")]
    private const string assetName = "Container_Popup_GachaPreviousResult";
    [Token(Token = "0x40061B6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject noBonusObj;
    [Token(Token = "0x40061B7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject bonusObj;
    [Token(Token = "0x40061B8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ItemIcon itemIconPrefab;
    [Token(Token = "0x40061B9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleThumb styleThumbPrefab;
    [Token(Token = "0x40061BA")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private MindequipmentThumb mindThumbPrefab;
    [Token(Token = "0x40061BB")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text textSchedule;
    [Token(Token = "0x40061BC")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Header("NoBonus")]
    private Transform noBonusResultParent;
    [Token(Token = "0x40061BD")]
    [FieldOffset(Offset = "0xC0")]
    [Header("Bonus")]
    [SerializeField]
    private Transform resultParent;
    [Token(Token = "0x40061BE")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Transform bonusParent;
    [Token(Token = "0x40061BF")]
    [FieldOffset(Offset = "0xD0")]
    private APIGachaPrevious_resultResponse response;

    [Token(Token = "0x17001284")]
    private AssetBundleManager assetBundleManager
    {
      [Token(Token = "0x6007875"), Address(RVA = "0x44FAA7C", Offset = "0x44FAA7C", VA = "0x44FAA7C")] get
      {
        return (AssetBundleManager) null;
      }
    }

    [Token(Token = "0x17001285")]
    private MasterDataManager masterDataManager
    {
      [Token(Token = "0x6007876"), Address(RVA = "0x44FAAE8", Offset = "0x44FAAE8", VA = "0x44FAAE8")] get
      {
        return (MasterDataManager) null;
      }
    }

    [Token(Token = "0x6007877")]
    [Address(RVA = "0x44FAB54", Offset = "0x44FAB54", VA = "0x44FAB54")]
    public static (string, string) GetAssetName() => ();

    [Token(Token = "0x6007878")]
    [Address(RVA = "0x44FABE4", Offset = "0x44FABE4", VA = "0x44FABE4")]
    private void Start()
    {
    }

    [Token(Token = "0x6007879")]
    [Address(RVA = "0x44FAC40", Offset = "0x44FAC40", VA = "0x44FAC40", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x600787A")]
    [Address(RVA = "0x44FAD44", Offset = "0x44FAD44", VA = "0x44FAD44", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x600787B")]
    [Address(RVA = "0x44FACD0", Offset = "0x44FACD0", VA = "0x44FACD0")]
    public IEnumerator Initialize(Action onComplete) => (IEnumerator) null;

    [Token(Token = "0x600787C")]
    [Address(RVA = "0x44FAD74", Offset = "0x44FAD74", VA = "0x44FAD74")]
    private IEnumerator UpdateDisplay() => (IEnumerator) null;

    [Token(Token = "0x600787D")]
    [Address(RVA = "0x44FAE04", Offset = "0x44FAE04", VA = "0x44FAE04")]
    private void CreateIcon(
      Transform parent,
      GachaResultHistoryEntityType entity,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600787E")]
    [Address(RVA = "0x44FB054", Offset = "0x44FB054", VA = "0x44FB054")]
    private void CreateItemIcon(
      Transform parent,
      GachaResultHistoryEntityType entity,
      ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x600787F")]
    [Address(RVA = "0x44FB184", Offset = "0x44FB184", VA = "0x44FB184")]
    private void CreateStyleThumb(Transform parent, GachaResultHistoryEntityType entity)
    {
    }

    [Token(Token = "0x6007880")]
    [Address(RVA = "0x44FAF18", Offset = "0x44FAF18", VA = "0x44FAF18")]
    private void CreateMindIcon(
      Transform parent,
      ItemUtility.Parameter param,
      AssetCachedSpawner spawner,
      GachaResultHistoryEntityType entity)
    {
    }

    [Token(Token = "0x6007881")]
    [Address(RVA = "0x44FB328", Offset = "0x44FB328", VA = "0x44FB328")]
    private IEnumerator RequestPreviousResult() => (IEnumerator) null;

    [Token(Token = "0x6007882")]
    [Address(RVA = "0x44FB3B8", Offset = "0x44FB3B8", VA = "0x44FB3B8")]
    public GachaPreviousResultPopup()
    {
    }
  }
}
