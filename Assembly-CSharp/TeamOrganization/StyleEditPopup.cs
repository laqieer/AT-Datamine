// Decompiled with JetBrains decompiler
// Type: TeamOrganization.StyleEditPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Common;
using Scenes.OutGame.Icon;
using Scenes.OutGame.Info.Style.UI;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000802")]
  public class StyleEditPopup : MonoBehaviour
  {
    [Token(Token = "0x40025B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvas;
    [Token(Token = "0x40025B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40025B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private HorizontalGridInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x40025B7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject nothingObject;
    [Token(Token = "0x40025B8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x40025B9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float rowWidth;
    [Token(Token = "0x40025BA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI styleCharaName;
    [Token(Token = "0x40025BB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI styleName;
    [Token(Token = "0x40025BC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TypeIcon classIcon;
    [Token(Token = "0x40025BD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TypeIcon moveIcon;
    [Token(Token = "0x40025BE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI styleLv;
    [Token(Token = "0x40025BF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI styleBattlePower;
    [Token(Token = "0x40025C0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI styleLife;
    [Token(Token = "0x40025C1")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI styleStrength;
    [Token(Token = "0x40025C2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI styleIntelligence;
    [Token(Token = "0x40025C3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI styleVitality;
    [Token(Token = "0x40025C4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI styleMind;
    [Token(Token = "0x40025C5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI styleAgility;
    [Token(Token = "0x40025C6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI styleDexterity;
    [Token(Token = "0x40025C7")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI styleLuck;
    [Token(Token = "0x40025C8")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TextMeshProUGUI styleMove;
    [Token(Token = "0x40025C9")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Canvas statusCanvas;
    [Token(Token = "0x40025CA")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton sortFilterButton;
    [Token(Token = "0x40025CB")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject selectButtonsObject;
    [Token(Token = "0x40025CC")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text selectButtonText;
    [Token(Token = "0x40025CD")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject changeButtonObject;
    [Token(Token = "0x40025CE")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject removeButtonObject;
    [Token(Token = "0x40025CF")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x40025D0")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40025D1")]
    [FieldOffset(Offset = "0x100")]
    private List<StaqData.Style> styleList;
    [Token(Token = "0x40025D2")]
    [FieldOffset(Offset = "0x108")]
    private List<StyleEquipThumbResource> resources;
    [Token(Token = "0x40025D3")]
    [FieldOffset(Offset = "0x110")]
    public StaqData.Style organizedStyle;
    [Token(Token = "0x40025D4")]
    [FieldOffset(Offset = "0x118")]
    public int slotIndex;
    [Token(Token = "0x40025D5")]
    private const float ScrollAdjustmentTime = 0.25f;
    [Token(Token = "0x40025D6")]
    [FieldOffset(Offset = "0x120")]
    private Action<StaqData.Style, int> changeAction;
    [Token(Token = "0x40025D7")]
    [FieldOffset(Offset = "0x128")]
    private Action closeAction;
    [Token(Token = "0x40025D8")]
    [FieldOffset(Offset = "0x130")]
    private Action changeSceneAction;
    [Token(Token = "0x40025D9")]
    [FieldOffset(Offset = "0x138")]
    private Action backSceneAction;
    [Token(Token = "0x40025DA")]
    [FieldOffset(Offset = "0x140")]
    private bool isSelect;
    [Token(Token = "0x40025DB")]
    [FieldOffset(Offset = "0x148")]
    private StyleEquipThumbResource selectResource;
    [Token(Token = "0x40025DC")]
    [FieldOffset(Offset = "0x150")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40025DD")]
    [FieldOffset(Offset = "0x158")]
    private Color NomalTextColor;
    [Token(Token = "0x40025DE")]
    [FieldOffset(Offset = "0x168")]
    private Color DownTextColor;
    [Token(Token = "0x40025DF")]
    [FieldOffset(Offset = "0x178")]
    private Color UpTextColor;
    [Token(Token = "0x40025E2")]
    [FieldOffset(Offset = "0x191")]
    private bool isGuildRaid;
    [Token(Token = "0x40025E3")]
    [FieldOffset(Offset = "0x198")]
    private List<string> usedStyleIds;
    [Token(Token = "0x40025E4")]
    [FieldOffset(Offset = "0x1A0")]
    private bool checkDuplication;
    [Token(Token = "0x40025E5")]
    [FieldOffset(Offset = "0x1A8")]
    private StylePopup stylePopup;
    [Token(Token = "0x40025E6")]
    [FieldOffset(Offset = "0x1B0")]
    private bool isOpenDetailPopup;
    [Token(Token = "0x40025E7")]
    [FieldOffset(Offset = "0x1B8")]
    public StaqData.Style selectStyle;

    [Token(Token = "0x6002DDC")]
    [Address(RVA = "0x3A8BD90", Offset = "0x3A8BD90", VA = "0x3A8BD90")]
    public AssetCachedSpawner GetAssetCachedSpawner() => (AssetCachedSpawner) null;

    [Token(Token = "0x170006DA")]
    public List<int> partySetStyleIdList
    {
      [Token(Token = "0x6002DDD"), Address(RVA = "0x3A8BD98", Offset = "0x3A8BD98", VA = "0x3A8BD98")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6002DDE"), Address(RVA = "0x3A8BDA0", Offset = "0x3A8BDA0", VA = "0x3A8BDA0")] private set
      {
      }
    }

    [Token(Token = "0x170006DB")]
    public bool IsApplyLost
    {
      [Token(Token = "0x6002DDF"), Address(RVA = "0x3A8BDA8", Offset = "0x3A8BDA8", VA = "0x3A8BDA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002DE0"), Address(RVA = "0x3A8BDB0", Offset = "0x3A8BDB0", VA = "0x3A8BDB0")] set
      {
      }
    }

    [Token(Token = "0x6002DE1")]
    [Address(RVA = "0x3A8BDBC", Offset = "0x3A8BDBC", VA = "0x3A8BDBC")]
    private void Update()
    {
    }

    [Token(Token = "0x6002DE2")]
    [Address(RVA = "0x3A8BDD8", Offset = "0x3A8BDD8", VA = "0x3A8BDD8")]
    public void Initialized(
      bool isApplyLost,
      bool isGuildRaid,
      List<string> usedStyleIds,
      Action<StaqData.Style, int> changeAction,
      Action closeAction)
    {
    }

    [Token(Token = "0x6002DE3")]
    [Address(RVA = "0x3A8C028", Offset = "0x3A8C028", VA = "0x3A8C028")]
    public void Open(StaqData.Style style, int slotIndex, List<int> setStyleIdList)
    {
    }

    [Token(Token = "0x6002DE4")]
    [Address(RVA = "0x3A8C2B8", Offset = "0x3A8C2B8", VA = "0x3A8C2B8")]
    public void Close()
    {
    }

    [Token(Token = "0x6002DE5")]
    [Address(RVA = "0x3A8C430", Offset = "0x3A8C430", VA = "0x3A8C430")]
    private void FinishedClose()
    {
    }

    [Token(Token = "0x6002DE6")]
    [Address(RVA = "0x3A8C4D8", Offset = "0x3A8C4D8", VA = "0x3A8C4D8")]
    public void ChangeSelectSlotIndex(StaqData.Style style, int slotIndex)
    {
    }

    [Token(Token = "0x6002DE7")]
    [Address(RVA = "0x3A8C4F8", Offset = "0x3A8C4F8", VA = "0x3A8C4F8")]
    public void OnStyleChangeButton()
    {
    }

    [Token(Token = "0x6002DE8")]
    [Address(RVA = "0x3A8C5A0", Offset = "0x3A8C5A0", VA = "0x3A8C5A0")]
    public void OnStyleDetailButton()
    {
    }

    [Token(Token = "0x6002DE9")]
    [Address(RVA = "0x3A8C5C0", Offset = "0x3A8C5C0", VA = "0x3A8C5C0")]
    private void OpenStyleDetailPopup()
    {
    }

    [Token(Token = "0x6002DEA")]
    [Address(RVA = "0x3A8CBB4", Offset = "0x3A8CBB4", VA = "0x3A8CBB4")]
    private void CloseDetalPopup()
    {
    }

    [Token(Token = "0x6002DEB")]
    [Address(RVA = "0x3A8CC44", Offset = "0x3A8CC44", VA = "0x3A8CC44")]
    public void OnStrengthButton()
    {
    }

    [Token(Token = "0x6002DEC")]
    [Address(RVA = "0x3A8CD3C", Offset = "0x3A8CD3C", VA = "0x3A8CD3C")]
    public void OnStyleSelect(StyleEquipThumbResource resource)
    {
    }

    [Token(Token = "0x6002DED")]
    [Address(RVA = "0x3A8C3A4", Offset = "0x3A8C3A4", VA = "0x3A8C3A4")]
    private void SelectStyleClear()
    {
    }

    [Token(Token = "0x6002DEE")]
    [Address(RVA = "0x3A8C56C", Offset = "0x3A8C56C", VA = "0x3A8C56C")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002DEF")]
    [Address(RVA = "0x3A8CF1C", Offset = "0x3A8CF1C", VA = "0x3A8CF1C")]
    public void OnSortFilterButton()
    {
    }

    [Token(Token = "0x6002DF0")]
    [Address(RVA = "0x3A8CFBC", Offset = "0x3A8CFBC", VA = "0x3A8CFBC")]
    private void UpdateSortFilterAction(List<StaqData.Style> sortFilterList)
    {
    }

    [Token(Token = "0x6002DF1")]
    [Address(RVA = "0x3A8D630", Offset = "0x3A8D630", VA = "0x3A8D630")]
    public void OnBackScene()
    {
    }

    [Token(Token = "0x6002DF2")]
    [Address(RVA = "0x3A8C0E4", Offset = "0x3A8C0E4", VA = "0x3A8C0E4")]
    public void UpdateStyleList()
    {
    }

    [Token(Token = "0x6002DF3")]
    [Address(RVA = "0x3A8D5B4", Offset = "0x3A8D5B4", VA = "0x3A8D5B4")]
    private IEnumerator SetScrollPos(int index, Action action) => (IEnumerator) null;

    [Token(Token = "0x6002DF4")]
    [Address(RVA = "0x3A8D4E8", Offset = "0x3A8D4E8", VA = "0x3A8D4E8")]
    private int GetIndexMatchThumbList(int styleId) => new int();

    [Token(Token = "0x6002DF5")]
    [Address(RVA = "0x3A8D6A4", Offset = "0x3A8D6A4", VA = "0x3A8D6A4")]
    private void CreateStyleList()
    {
    }

    [Token(Token = "0x6002DF6")]
    [Address(RVA = "0x3A8D12C", Offset = "0x3A8D12C", VA = "0x3A8D12C")]
    private void CreateStyleList(List<StaqData.Style> styles)
    {
    }

    [Token(Token = "0x6002DF7")]
    [Address(RVA = "0x3A8D798", Offset = "0x3A8D798", VA = "0x3A8D798")]
    private void RegisterStyleResource()
    {
    }

    [Token(Token = "0x6002DF8")]
    [Address(RVA = "0x3A8D1D8", Offset = "0x3A8D1D8", VA = "0x3A8D1D8")]
    private void SetStyleList()
    {
    }

    [Token(Token = "0x6002DF9")]
    [Address(RVA = "0x3A8DC20", Offset = "0x3A8DC20", VA = "0x3A8DC20")]
    private bool CheckSelectedStyle(int styleId) => new bool();

    [Token(Token = "0x6002DFA")]
    [Address(RVA = "0x3A8DC54", Offset = "0x3A8DC54", VA = "0x3A8DC54")]
    private bool CheckOrganizedStyle(int styleId) => new bool();

    [Token(Token = "0x6002DFB")]
    [Address(RVA = "0x3A8DDB8", Offset = "0x3A8DDB8", VA = "0x3A8DDB8")]
    private bool CheckLostCharacter(StaqData.Style style) => new bool();

    [Token(Token = "0x6002DFC")]
    [Address(RVA = "0x3A8DE4C", Offset = "0x3A8DE4C", VA = "0x3A8DE4C")]
    private bool CheckAlreadyDispatchedStyle(StaqData.Style style) => new bool();

    [Token(Token = "0x6002DFD")]
    [Address(RVA = "0x3A8C26C", Offset = "0x3A8C26C", VA = "0x3A8C26C")]
    private void UpdateSelectStyleParameter()
    {
    }

    [Token(Token = "0x6002DFE")]
    [Address(RVA = "0x3A8EF30", Offset = "0x3A8EF30", VA = "0x3A8EF30")]
    private void ResetStyleParameter()
    {
    }

    [Token(Token = "0x6002DFF")]
    [Address(RVA = "0x3A8EA00", Offset = "0x3A8EA00", VA = "0x3A8EA00")]
    private void UpdateStyleParameter(StaqData.Style style)
    {
    }

    [Token(Token = "0x6002E00")]
    [Address(RVA = "0x3A8DF08", Offset = "0x3A8DF08", VA = "0x3A8DF08")]
    private void UpdateStyleParameter(StaqData.Style baseStyle, StaqData.Style selectStyle)
    {
    }

    [Token(Token = "0x6002E01")]
    [Address(RVA = "0x3A8F2F0", Offset = "0x3A8F2F0", VA = "0x3A8F2F0")]
    private Color GetParameterColor(int baseValue, int selectValue) => new Color();

    [Token(Token = "0x6002E02")]
    [Address(RVA = "0x3A8F348", Offset = "0x3A8F348", VA = "0x3A8F348")]
    public void SetChangeSceneAction(Action action)
    {
    }

    [Token(Token = "0x6002E03")]
    [Address(RVA = "0x3A8F350", Offset = "0x3A8F350", VA = "0x3A8F350")]
    public void SetBackSceneAction(Action action)
    {
    }

    [Token(Token = "0x6002E04")]
    [Address(RVA = "0x3A8C71C", Offset = "0x3A8C71C", VA = "0x3A8C71C")]
    private Action CreateEnhanceAction(UniqueID uniqueID, SafeObjectCallback closeAction)
    {
      return (Action) null;
    }

    [Token(Token = "0x6002E05")]
    [Address(RVA = "0x3A8D684", Offset = "0x3A8D684", VA = "0x3A8D684")]
    private void SetCanvasInteractable(bool state)
    {
    }

    [Token(Token = "0x6002E06")]
    [Address(RVA = "0x3A8F360", Offset = "0x3A8F360", VA = "0x3A8F360")]
    public StyleEditPopup()
    {
    }
  }
}
