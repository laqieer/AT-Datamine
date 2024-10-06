// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using Il2CppDummyDll;
using Story.KizunaQuest;
using System;
using System.Collections;
using TMPro;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E9B")]
  public class KizunaListView : MonoBehaviour
  {
    [Token(Token = "0x400C7C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private KizunaListCharacterView scrollElementPrefab;
    [Token(Token = "0x400C7C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI kizunaQuestCountText;
    [Token(Token = "0x400C7C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject noKizunaQuestDisplay;
    [Token(Token = "0x400C7C7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400C7C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400C7C9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ScrollControl scrollControl;
    [Token(Token = "0x400C7CA")]
    [FieldOffset(Offset = "0x48")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x400C7CB")]
    [FieldOffset(Offset = "0x50")]
    private KizunaListCharacterImageLoader characterImageLoader;
    [Token(Token = "0x400C7CC")]
    [FieldOffset(Offset = "0x58")]
    private KizunaQuestInfo kizunaQuestInfo;
    [Token(Token = "0x400C7CD")]
    [FieldOffset(Offset = "0x60")]
    private KizunaQuestPopupHandler kizunaQuestPopupHandler;
    [Token(Token = "0x400C7CE")]
    [FieldOffset(Offset = "0x68")]
    private bool isShowingKizunaQuestPopup;
    [Token(Token = "0x400C7CF")]
    [FieldOffset(Offset = "0x70")]
    private IKizunaListEventHandler eventHandler;
    [Token(Token = "0x400C7D0")]
    [FieldOffset(Offset = "0x78")]
    public bool Interactable;

    [Token(Token = "0x17003DCA")]
    public Action OnCancel
    {
      [Token(Token = "0x601231A"), Address(RVA = "0x45944B0", Offset = "0x45944B0", VA = "0x45944B0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601231B"), Address(RVA = "0x45944B8", Offset = "0x45944B8", VA = "0x45944B8")] set
      {
      }
    }

    [Token(Token = "0x17003DCB")]
    public Action OnBackKey
    {
      [Token(Token = "0x601231C"), Address(RVA = "0x45944C0", Offset = "0x45944C0", VA = "0x45944C0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601231D"), Address(RVA = "0x459301C", Offset = "0x459301C", VA = "0x459301C")] set
      {
      }
    }

    [Token(Token = "0x601231E")]
    [Address(RVA = "0x45944DC", Offset = "0x45944DC", VA = "0x45944DC")]
    private void OnCancelButtonClicked()
    {
    }

    [Token(Token = "0x601231F")]
    [Address(RVA = "0x4592F38", Offset = "0x4592F38", VA = "0x4592F38")]
    public IEnumerator InitializeAsync(
      KizunaQuestInfo kizunaQuestInfo,
      IKizunaListEventHandler eventHandler)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012320")]
    [Address(RVA = "0x4594520", Offset = "0x4594520", VA = "0x4594520")]
    private void InitializeMainViewElement()
    {
    }

    [Token(Token = "0x6012321")]
    [Address(RVA = "0x4594624", Offset = "0x4594624", VA = "0x4594624")]
    private void InitializeScrollControl()
    {
    }

    [Token(Token = "0x6012322")]
    [Address(RVA = "0x45947FC", Offset = "0x45947FC", VA = "0x45947FC")]
    private IEnumerator InitializeCharacterImageLoader() => (IEnumerator) null;

    [Token(Token = "0x6012323")]
    [Address(RVA = "0x459488C", Offset = "0x459488C", VA = "0x459488C")]
    private void InitializeCharacterView()
    {
    }

    [Token(Token = "0x6012324")]
    [Address(RVA = "0x4594B58", Offset = "0x4594B58", VA = "0x4594B58")]
    private void OpenKizunaQuestPopup(KizunaQuestInfo.KizunaQuestCharacterInfo info)
    {
    }

    [Token(Token = "0x6012325")]
    [Address(RVA = "0x4594B90", Offset = "0x4594B90", VA = "0x4594B90")]
    private IEnumerator OpenKizunaQuestPopupAsync(KizunaQuestInfo.KizunaQuestCharacterInfo info)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6012326")]
    [Address(RVA = "0x4592FB4", Offset = "0x4592FB4", VA = "0x4592FB4")]
    public IEnumerator ShowAnimation() => (IEnumerator) null;

    [Token(Token = "0x6012327")]
    [Address(RVA = "0x4592CF0", Offset = "0x4592CF0", VA = "0x4592CF0")]
    public IEnumerator HideAnimation() => (IEnumerator) null;

    [Token(Token = "0x6012328")]
    [Address(RVA = "0x4592BB0", Offset = "0x4592BB0", VA = "0x4592BB0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6012329")]
    [Address(RVA = "0x4594C7C", Offset = "0x4594C7C", VA = "0x4594C7C")]
    public KizunaListView()
    {
    }

    [Token(Token = "0x2002E9C")]
    public class Loader
    {
      [Token(Token = "0x400C7D2")]
      private const string KizunaListAssetBundleName = "ui_page_kizunalist_prefab";
      [Token(Token = "0x400C7D3")]
      private const string KizunaListAssetName = "KizunaList_View";

      [Token(Token = "0x601232A")]
      [Address(RVA = "0x4593154", Offset = "0x4593154", VA = "0x4593154")]
      public IEnumerator Load() => (IEnumerator) null;

      [Token(Token = "0x601232B")]
      [Address(RVA = "0x45931B4", Offset = "0x45931B4", VA = "0x45931B4")]
      public KizunaListView Create(Transform parent) => (KizunaListView) null;

      [Token(Token = "0x601232C")]
      [Address(RVA = "0x45932E8", Offset = "0x45932E8", VA = "0x45932E8")]
      public void Clear()
      {
      }

      [Token(Token = "0x601232D")]
      [Address(RVA = "0x459314C", Offset = "0x459314C", VA = "0x459314C")]
      public Loader()
      {
      }
    }
  }
}
