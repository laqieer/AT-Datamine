// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitlePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.DLC;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x2003471")]
  public class TitlePopup : PopupBase
  {
    [Token(Token = "0x400E414")]
    private const string AssetName = "Container_Popup_TitleDetail";
    [Token(Token = "0x400E415")]
    public const string AssetBundleName = "ui_page_outgame_popup_titleselect";
    [Token(Token = "0x400E416")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonToggle[] toggles;
    [Token(Token = "0x400E417")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400E418")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private SelectedTitlePanel selectedTitle;
    [Token(Token = "0x400E419")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TitleNameList titleNameList;
    [Token(Token = "0x400E41A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TitleFrameList titleFrameList;
    [Token(Token = "0x400E41B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TitleUniqueList titleUniqueList;
    [Token(Token = "0x400E41C")]
    [FieldOffset(Offset = "0xB8")]
    private TitlePopup.TitleHolder titleHolder;
    [Token(Token = "0x400E41D")]
    [FieldOffset(Offset = "0xC0")]
    private TitlePopup.CategoryTab selectedTab;
    [Token(Token = "0x400E41E")]
    [FieldOffset(Offset = "0xC8")]
    private Action onCloseAction;
    [Token(Token = "0x400E41F")]
    [FieldOffset(Offset = "0xD0")]
    private Action<TitleSet> onConfirmAction;
    [Token(Token = "0x400E420")]
    [FieldOffset(Offset = "0xD8")]
    private Action<string> onClickUnlockAction;
    [Token(Token = "0x400E421")]
    [FieldOffset(Offset = "0xE0")]
    private ITitleLoader titleLoader;
    [Token(Token = "0x400E422")]
    [FieldOffset(Offset = "0xE8")]
    private CancellationTokenSource listingCanceller;

    [Token(Token = "0x601492F")]
    [Address(RVA = "0x1AA80F4", Offset = "0x1AA80F4", VA = "0x1AA80F4")]
    public static UniTask<TitlePopup> LoadAsync(
      AsyncAssetLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask<TitlePopup>();
    }

    [Token(Token = "0x6014930")]
    [Address(RVA = "0x1AA81A8", Offset = "0x1AA81A8", VA = "0x1AA81A8")]
    public void Initialize(
      TitleSet titleSet,
      ITitleLoader loader,
      Action<string> onClickUnlockAction,
      Action<TitleSet> onConfirmAction,
      Action onCloseAction)
    {
    }

    [Token(Token = "0x6014931")]
    [Address(RVA = "0x1AA8B28", Offset = "0x1AA8B28", VA = "0x1AA8B28")]
    public void OnClickToToggle(int index)
    {
    }

    [Token(Token = "0x6014932")]
    [Address(RVA = "0x1AA856C", Offset = "0x1AA856C", VA = "0x1AA856C")]
    private void CreateList()
    {
    }

    [Token(Token = "0x6014933")]
    [Address(RVA = "0x1AA8C24", Offset = "0x1AA8C24", VA = "0x1AA8C24")]
    private void ActivateListView(MonoBehaviour target)
    {
    }

    [Token(Token = "0x6014934")]
    [Address(RVA = "0x1AA9730", Offset = "0x1AA9730", VA = "0x1AA9730")]
    private TitleSet GetFrameUpdatedTitleSet(ITitleMasterData title) => new TitleSet();

    [Token(Token = "0x6014935")]
    [Address(RVA = "0x1AA97D0", Offset = "0x1AA97D0", VA = "0x1AA97D0")]
    private TitleSet GetFrontUpdatedTitleSet(ITitleMasterData title) => new TitleSet();

    [Token(Token = "0x6014936")]
    [Address(RVA = "0x1AA9898", Offset = "0x1AA9898", VA = "0x1AA9898")]
    private TitleSet GetBackUpdatedTitleSet(ITitleMasterData title) => new TitleSet();

    [Token(Token = "0x6014937")]
    [Address(RVA = "0x1AA9960", Offset = "0x1AA9960", VA = "0x1AA9960")]
    private TitleSet GetBunchUpdatedTitleSet(ITitleMasterData title) => new TitleSet();

    [Token(Token = "0x6014938")]
    [Address(RVA = "0x1AA99CC", Offset = "0x1AA99CC", VA = "0x1AA99CC")]
    private void OnClick(int titleId, bool unlocked, Func<ITitleMasterData, TitleSet> newTitleSet)
    {
    }

    [Token(Token = "0x6014939")]
    [Address(RVA = "0x1AA9B98", Offset = "0x1AA9B98", VA = "0x1AA9B98")]
    public void OnClickToCloseAction()
    {
    }

    [Token(Token = "0x601493A")]
    [Address(RVA = "0x1AA9BB4", Offset = "0x1AA9BB4", VA = "0x1AA9BB4")]
    public void OnClickToConfirmAction()
    {
    }

    [Token(Token = "0x601493B")]
    [Address(RVA = "0x1AA9C08", Offset = "0x1AA9C08", VA = "0x1AA9C08")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601493C")]
    [Address(RVA = "0x1AA9C1C", Offset = "0x1AA9C1C", VA = "0x1AA9C1C")]
    public TitlePopup()
    {
    }

    [Token(Token = "0x2003472")]
    private enum CategoryTab
    {
      [Token(Token = "0x400E424")] Frame,
      [Token(Token = "0x400E425")] PreTitle,
      [Token(Token = "0x400E426")] PostTitle,
      [Token(Token = "0x400E427")] Bunch,
    }

    [Token(Token = "0x2003473")]
    private class TitleHolder
    {
      [Token(Token = "0x400E428")]
      [FieldOffset(Offset = "0x10")]
      private IDictionary<TitlePopup.CategoryTab, ITitleMasterData[]> titles;

      [Token(Token = "0x1700445A")]
      public ITitleMasterData PreDefault
      {
        [Token(Token = "0x6014942"), Address(RVA = "0x1AA9EF8", Offset = "0x1AA9EF8", VA = "0x1AA9EF8")] get
        {
          return (ITitleMasterData) null;
        }
      }

      [Token(Token = "0x1700445B")]
      public ITitleMasterData PostDefault
      {
        [Token(Token = "0x6014943"), Address(RVA = "0x1AA9F00", Offset = "0x1AA9F00", VA = "0x1AA9F00")] get
        {
          return (ITitleMasterData) null;
        }
      }

      [Token(Token = "0x1700445C")]
      public ITitleMasterData FrameDefault
      {
        [Token(Token = "0x6014944"), Address(RVA = "0x1AA9F08", Offset = "0x1AA9F08", VA = "0x1AA9F08")] get
        {
          return (ITitleMasterData) null;
        }
      }

      [Token(Token = "0x6014945")]
      [Address(RVA = "0x1AA8300", Offset = "0x1AA8300", VA = "0x1AA8300")]
      public TitleHolder(IEnumerable<ITitleMasterData> titles)
      {
      }

      [Token(Token = "0x6014946")]
      [Address(RVA = "0x1AA9F18", Offset = "0x1AA9F18", VA = "0x1AA9F18")]
      private static TitlePopup.CategoryTab DetermineCategoryTab(ITitleMasterData title)
      {
        return new TitlePopup.CategoryTab();
      }

      [Token(Token = "0x6014947")]
      [Address(RVA = "0x1AAA010", Offset = "0x1AAA010", VA = "0x1AAA010")]
      private static void AssertSingle(ref ITitleMasterData before, ITitleMasterData after)
      {
      }

      [Token(Token = "0x6014948")]
      [Address(RVA = "0x1AA8B7C", Offset = "0x1AA8B7C", VA = "0x1AA8B7C")]
      public IReadOnlyList<ITitleMasterData> GetTitles(TitlePopup.CategoryTab tab)
      {
        return (IReadOnlyList<ITitleMasterData>) null;
      }
    }
  }
}
