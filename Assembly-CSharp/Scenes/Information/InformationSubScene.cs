// Decompiled with JetBrains decompiler
// Type: Scenes.Information.InformationSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.RawData;
using HTMLViewer;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Information
{
  [Token(Token = "0x2002ABE")]
  public class InformationSubScene : GlobalMenuFrontContentsBase
  {
    [Token(Token = "0x400B5ED")]
    public const string SubSceneInformationSideList = "ui_page_htmlviewer_prefab";
    [Token(Token = "0x400B5EE")]
    public const string SubSceneInformationSideListPrefabName = "Container_SideMenu_Information";
    [Token(Token = "0x400B5EF")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<Category, TabType> CategoryToTab;
    [Token(Token = "0x400B5F0")]
    [FieldOffset(Offset = "0x8")]
    public static readonly Dictionary<Category, HeaderTypeEnum> CategoryToHeaderTypeEnum;
    [Token(Token = "0x400B5F1")]
    private const string HTML_VIEWER_PREFAB_ASSETBUNDLE_NAME = "ui_page_htmlviewer_prefab";
    [Token(Token = "0x400B5F2")]
    private const string Container_Popup_Information_Chara = "Container_Popup_Information_Chara";
    [Token(Token = "0x400B5F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400B5F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject infomationListRoot;
    [Token(Token = "0x400B5F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject infomationListGameObj;
    [Token(Token = "0x400B5F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject nothingRoot;
    [Token(Token = "0x400B5F7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text nothingText;
    [Token(Token = "0x400B5F8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton alreadyRead;
    [Token(Token = "0x400B5F9")]
    [FieldOffset(Offset = "0x58")]
    private List<InformationList> enableInformationLists;
    [Token(Token = "0x400B5FA")]
    [FieldOffset(Offset = "0x60")]
    private Stack<InformationList> disableInformationLists;
    [Token(Token = "0x400B5FB")]
    [FieldOffset(Offset = "0x68")]
    private TabType currentTypeMode;
    [Token(Token = "0x400B5FC")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B5FD")]
    [FieldOffset(Offset = "0x78")]
    private InformationSideMenu informationSideMenu;
    [Token(Token = "0x400B5FE")]
    [FieldOffset(Offset = "0x80")]
    private List<OfficialInformationArticleType> officialInformationArticleTypeList;
    [Token(Token = "0x400B5FF")]
    [FieldOffset(Offset = "0x88")]
    private InformationPopup informationPopup;
    [Token(Token = "0x400B600")]
    [FieldOffset(Offset = "0x90")]
    private RawTextureManager rawTextureManager;
    [Token(Token = "0x400B601")]
    [FieldOffset(Offset = "0x98")]
    private ScrollRect scrollRect;

    [Token(Token = "0x6010B60")]
    [Address(RVA = "0x4BD5CC0", Offset = "0x4BD5CC0", VA = "0x4BD5CC0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010B61")]
    [Address(RVA = "0x4BD5CDC", Offset = "0x4BD5CDC", VA = "0x4BD5CDC", Slot = "4")]
    public override void Initialize(Transform left, Scenes.GlobalMenuFrontView.GlobalMenuFrontView view)
    {
    }

    [Token(Token = "0x6010B62")]
    [Address(RVA = "0x4BD5F40", Offset = "0x4BD5F40", VA = "0x4BD5F40", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010B63")]
    [Address(RVA = "0x4BD5FD0", Offset = "0x4BD5FD0", VA = "0x4BD5FD0")]
    public static void PreloadPopup(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010B64")]
    [Address(RVA = "0x4BD6050", Offset = "0x4BD6050", VA = "0x4BD6050")]
    private IEnumerator LoadAsset() => (IEnumerator) null;

    [Token(Token = "0x6010B65")]
    [Address(RVA = "0x4BD60E0", Offset = "0x4BD60E0", VA = "0x4BD60E0")]
    private static IEnumerator RequestOfficialInfo(Action<APIOfficialInfoResponse> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010B66")]
    [Address(RVA = "0x4BD6170", Offset = "0x4BD6170", VA = "0x4BD6170")]
    public static IEnumerator RequestMessageRead(int messageId, Action onReadRequestEnd = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010B67")]
    [Address(RVA = "0x4BD6210", Offset = "0x4BD6210", VA = "0x4BD6210")]
    private void InitReadInformation()
    {
    }

    [Token(Token = "0x6010B68")]
    [Address(RVA = "0x4BD6398", Offset = "0x4BD6398", VA = "0x4BD6398")]
    private void InitSideMenu()
    {
    }

    [Token(Token = "0x6010B69")]
    [Address(RVA = "0x4BD6534", Offset = "0x4BD6534", VA = "0x4BD6534")]
    private bool IsUnreadOfficialInformationArticle(TabType tabType) => new bool();

    [Token(Token = "0x6010B6A")]
    [Address(RVA = "0x4BD69C4", Offset = "0x4BD69C4", VA = "0x4BD69C4")]
    private List<int> GetOfficialInformationArticleId(TabType tabType) => (List<int>) null;

    [Token(Token = "0x6010B6B")]
    [Address(RVA = "0x4BD68FC", Offset = "0x4BD68FC", VA = "0x4BD68FC")]
    private bool IsUnreadOfficialMessageArticle() => new bool();

    [Token(Token = "0x6010B6C")]
    [Address(RVA = "0x4BD6B90", Offset = "0x4BD6B90", VA = "0x4BD6B90")]
    private void InitInformationList(TabType tabType)
    {
    }

    [Token(Token = "0x6010B6D")]
    [Address(RVA = "0x4BD6EFC", Offset = "0x4BD6EFC", VA = "0x4BD6EFC")]
    private void CreateInformationList(
      List<OfficialInformationArticleType> articles,
      Func<bool, bool> isCreate)
    {
    }

    [Token(Token = "0x6010B6E")]
    [Address(RVA = "0x4BD708C", Offset = "0x4BD708C", VA = "0x4BD708C")]
    private void CreateInformation(
      List<OfficialInformationArticleType> articles,
      int index,
      bool isRead)
    {
    }

    [Token(Token = "0x6010B6F")]
    [Address(RVA = "0x4BD7414", Offset = "0x4BD7414", VA = "0x4BD7414")]
    private void InitMessageList()
    {
    }

    [Token(Token = "0x6010B70")]
    [Address(RVA = "0x4BD7520", Offset = "0x4BD7520", VA = "0x4BD7520")]
    private void CreateMessageInformation(
      List<OfficialMessageArticleType> articles,
      bool isReadCreate)
    {
    }

    [Token(Token = "0x6010B71")]
    [Address(RVA = "0x4BD3714", Offset = "0x4BD3714", VA = "0x4BD3714")]
    public static HeaderTypeEnum GetMessageHeaderTypeEnum(OfficialMessageArticleType article)
    {
      return new HeaderTypeEnum();
    }

    [Token(Token = "0x6010B72")]
    [Address(RVA = "0x4BD703C", Offset = "0x4BD703C", VA = "0x4BD703C")]
    private bool IsInfomationListNothing() => new bool();

    [Token(Token = "0x6010B73")]
    [Address(RVA = "0x4BD6744", Offset = "0x4BD6744", VA = "0x4BD6744")]
    private void ChangeMode()
    {
    }

    [Token(Token = "0x6010B74")]
    [Address(RVA = "0x4BD726C", Offset = "0x4BD726C", VA = "0x4BD726C")]
    private InformationList AddInfomationList(int siblingIndex) => (InformationList) null;

    [Token(Token = "0x6010B75")]
    [Address(RVA = "0x4BD6E78", Offset = "0x4BD6E78", VA = "0x4BD6E78")]
    private void RemoveAllInformationList()
    {
    }

    [Token(Token = "0x6010B76")]
    [Address(RVA = "0x4BD7728", Offset = "0x4BD7728", VA = "0x4BD7728")]
    private void RemoveInformationList(InformationList info)
    {
    }

    [Token(Token = "0x6010B77")]
    [Address(RVA = "0x4BD77D0", Offset = "0x4BD77D0", VA = "0x4BD77D0")]
    private InformationPopup GetInformationPopup() => (InformationPopup) null;

    [Token(Token = "0x6010B78")]
    [Address(RVA = "0x4BD792C", Offset = "0x4BD792C", VA = "0x4BD792C")]
    public static InformationPopup CreateInfomationPopup(AssetCachedSpawner assetCachedSpawner)
    {
      return (InformationPopup) null;
    }

    [Token(Token = "0x6010B79")]
    [Address(RVA = "0x4BD7A38", Offset = "0x4BD7A38", VA = "0x4BD7A38")]
    public static void CreateInfomationPopupById(
      AssetCachedSpawner assetCachedSpawner,
      int articleId,
      Action<InformationPopup> onCreated)
    {
    }

    [Token(Token = "0x6010B7A")]
    [Address(RVA = "0x4BD7B7C", Offset = "0x4BD7B7C", VA = "0x4BD7B7C")]
    public static bool IsTodayInfomationDisplaying() => new bool();

    [Token(Token = "0x6010B7B")]
    [Address(RVA = "0x4BD7F3C", Offset = "0x4BD7F3C", VA = "0x4BD7F3C")]
    private void ShowInformationDetail(List<OfficialInformationArticleType> articles, int index)
    {
    }

    [Token(Token = "0x6010B7C")]
    [Address(RVA = "0x4BD80A8", Offset = "0x4BD80A8", VA = "0x4BD80A8")]
    private void ShowMessageDetail(List<OfficialMessageArticleType> articles, int index)
    {
    }

    [Token(Token = "0x6010B7D")]
    [Address(RVA = "0x4BD8208", Offset = "0x4BD8208", VA = "0x4BD8208")]
    public static void OnClickLink(string url)
    {
    }

    [Token(Token = "0x6010B7E")]
    [Address(RVA = "0x4BD8210", Offset = "0x4BD8210", VA = "0x4BD8210")]
    private void OnClickAlreadyReadButton()
    {
    }

    [Token(Token = "0x6010B7F")]
    [Address(RVA = "0x4BD8438", Offset = "0x4BD8438", VA = "0x4BD8438")]
    public InformationSubScene()
    {
    }

    [Token(Token = "0x6010B80")]
    [Address(RVA = "0x4BD84A0", Offset = "0x4BD84A0", VA = "0x4BD84A0")]
    static InformationSubScene()
    {
    }
  }
}
