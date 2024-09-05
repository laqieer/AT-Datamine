// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.GuildSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Guild
{
  [Token(Token = "0x2002B85")]
  public class GuildSubScene : SubScene
  {
    [Token(Token = "0x400B946")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GuildBelowScreenHandler belowScreenHandler;
    [Token(Token = "0x400B947")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400B948")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner assetLoader;
    [Token(Token = "0x400B949")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CanvasGroup contentCanvasGroup;
    [Token(Token = "0x400B94A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject defaultBG;
    [Token(Token = "0x400B94B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject facilityBG;
    [Token(Token = "0x400B94C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B94D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject header;
    [Token(Token = "0x400B94E")]
    [FieldOffset(Offset = "0x98")]
    private GuildLoader guildLoader;
    [Token(Token = "0x400B950")]
    public const string SubSceneAssetBundleName = "ui_page_header";
    [Token(Token = "0x400B951")]
    public const string SubScenePrefabName = "Com_OutGameMenu_View_Guild";
    [Token(Token = "0x400B952")]
    public const string HeaderTitleInTweenName = "Guild_In";
    [Token(Token = "0x400B953")]
    public const string HeaderTitleOutTweenName = "Guild_Out";

    [Token(Token = "0x17003AAF")]
    public GuildLoader GuildLoader
    {
      [Token(Token = "0x6010FFD"), Address(RVA = "0x1C74EF4", Offset = "0x1C74EF4", VA = "0x1C74EF4")] get
      {
        return (GuildLoader) null;
      }
    }

    [Token(Token = "0x17003AB0")]
    public ItemDetailPopupProvider ItemDetailPopupProvider
    {
      [Token(Token = "0x6010FFE"), Address(RVA = "0x1C74EFC", Offset = "0x1C74EFC", VA = "0x1C74EFC")] get
      {
        return (ItemDetailPopupProvider) null;
      }
    }

    [Token(Token = "0x17003AB1")]
    private PopupManager popupManager
    {
      [Token(Token = "0x6010FFF"), Address(RVA = "0x1C74F04", Offset = "0x1C74F04", VA = "0x1C74F04")] get
      {
        return (PopupManager) null;
      }
    }

    [Token(Token = "0x6011000")]
    [Address(RVA = "0x1C74F70", Offset = "0x1C74F70", VA = "0x1C74F70", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6011001")]
    [Address(RVA = "0x1C75188", Offset = "0x1C75188", VA = "0x1C75188", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011002")]
    [Address(RVA = "0x1C75218", Offset = "0x1C75218", VA = "0x1C75218", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6011003")]
    [Address(RVA = "0x1C72F28", Offset = "0x1C72F28", VA = "0x1C72F28")]
    public void ChangeScreen(
      GuildAssetBundleParam.GuildScreenType type,
      bool isStack = true,
      GuildBelowScreenParam param = null,
      bool closeAnimationSkip = false)
    {
    }

    [Token(Token = "0x6011004")]
    [Address(RVA = "0x1C75274", Offset = "0x1C75274", VA = "0x1C75274")]
    public IEnumerator LoadPopup(
      GuildAssetBundleParam.GuildPopupType type,
      Action<GameObject> onComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011005")]
    [Address(RVA = "0x1C7531C", Offset = "0x1C7531C", VA = "0x1C7531C")]
    public void ClearBelowScreenStack()
    {
    }

    [Token(Token = "0x6011006")]
    [Address(RVA = "0x1C75384", Offset = "0x1C75384", VA = "0x1C75384", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6011007")]
    [Address(RVA = "0x1C73030", Offset = "0x1C73030", VA = "0x1C73030")]
    public void OnBackScreen(bool isAll)
    {
    }

    [Token(Token = "0x6011008")]
    [Address(RVA = "0x1C755BC", Offset = "0x1C755BC", VA = "0x1C755BC")]
    public void OnGlobalMenu()
    {
    }

    [Token(Token = "0x6011009")]
    [Address(RVA = "0x1C7563C", Offset = "0x1C7563C", VA = "0x1C7563C", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x601100A")]
    [Address(RVA = "0x1C75248", Offset = "0x1C75248", VA = "0x1C75248")]
    public void LoadRequest(
      GuildAssetBundleParam.GuildScreenType type,
      Action<GameObject> onComplete)
    {
    }

    [Token(Token = "0x601100B")]
    [Address(RVA = "0x1C72DB4", Offset = "0x1C72DB4", VA = "0x1C72DB4")]
    public void LoadRequest(
      GuildAssetBundleParam.TimelineSettingType type,
      Action<UITimelineSettingAsset> onComplete)
    {
    }

    [Token(Token = "0x601100C")]
    public IEnumerator LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601100D")]
    [Address(RVA = "0x1C73090", Offset = "0x1C73090", VA = "0x1C73090")]
    public void SetActiveInteractableContentCanvas(bool isActive)
    {
    }

    [Token(Token = "0x601100E")]
    [Address(RVA = "0x1C730CC", Offset = "0x1C730CC", VA = "0x1C730CC")]
    public void SetAlphaContentCanvas(bool isActive)
    {
    }

    [Token(Token = "0x601100F")]
    [Address(RVA = "0x1C756CC", Offset = "0x1C756CC", VA = "0x1C756CC")]
    public void ChangeBackground(GuildAssetBundleParam.GuildScreenType type)
    {
    }

    [Token(Token = "0x6011010")]
    [Address(RVA = "0x1C75738", Offset = "0x1C75738", VA = "0x1C75738")]
    public void SetActiveHeader(bool isActive)
    {
    }

    [Token(Token = "0x6011011")]
    [Address(RVA = "0x1C75064", Offset = "0x1C75064", VA = "0x1C75064")]
    private void PlayBGM()
    {
    }

    [Token(Token = "0x6011012")]
    [Address(RVA = "0x1C75758", Offset = "0x1C75758", VA = "0x1C75758")]
    public GuildSubScene()
    {
    }
  }
}
