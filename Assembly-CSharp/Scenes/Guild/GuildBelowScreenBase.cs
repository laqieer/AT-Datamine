// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.GuildBelowScreenBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Guild
{
  [Token(Token = "0x2002B6F")]
  public class GuildBelowScreenBase : MonoBehaviour
  {
    [Token(Token = "0x400B8F5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400B8F6")]
    [FieldOffset(Offset = "0x20")]
    private GuildSubScene guildSubScene;

    [Token(Token = "0x17003A9B")]
    public GuildAssetBundleParam.GuildScreenType? ScreenType
    {
      [Token(Token = "0x6010F98"), Address(RVA = "0x1C72A78", Offset = "0x1C72A78", VA = "0x1C72A78")] get
      {
        return new GuildAssetBundleParam.GuildScreenType?();
      }
      [Token(Token = "0x6010F99"), Address(RVA = "0x1C72A80", Offset = "0x1C72A80", VA = "0x1C72A80")] private set
      {
      }
    }

    [Token(Token = "0x17003A9C")]
    public bool IsDirection
    {
      [Token(Token = "0x6010F9A"), Address(RVA = "0x1C72A88", Offset = "0x1C72A88", VA = "0x1C72A88")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010F9B"), Address(RVA = "0x1C72A90", Offset = "0x1C72A90", VA = "0x1C72A90")] private set
      {
      }
    }

    [Token(Token = "0x17003A9D")]
    public GuildLoader GuildLoader
    {
      [Token(Token = "0x6010F9C"), Address(RVA = "0x1C72A9C", Offset = "0x1C72A9C", VA = "0x1C72A9C")] get
      {
        return (GuildLoader) null;
      }
    }

    [Token(Token = "0x6010F9D")]
    [Address(RVA = "0x1C72AB8", Offset = "0x1C72AB8", VA = "0x1C72AB8", Slot = "4")]
    public virtual void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6010F9E")]
    [Address(RVA = "0x1C72AC0", Offset = "0x1C72AC0", VA = "0x1C72AC0", Slot = "5")]
    public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010F9F")]
    [Address(RVA = "0x1C72B48", Offset = "0x1C72B48", VA = "0x1C72B48", Slot = "6")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x6010FA0")]
    [Address(RVA = "0x1C72B4C", Offset = "0x1C72B4C", VA = "0x1C72B4C", Slot = "7")]
    public virtual void Open()
    {
    }

    [Token(Token = "0x6010FA1")]
    [Address(RVA = "0x1C72B78", Offset = "0x1C72B78", VA = "0x1C72B78", Slot = "8")]
    public virtual void Close()
    {
    }

    [Token(Token = "0x6010FA2")]
    [Address(RVA = "0x1C72B7C", Offset = "0x1C72B7C", VA = "0x1C72B7C", Slot = "9")]
    public virtual IEnumerator CloseSync() => (IEnumerator) null;

    [Token(Token = "0x6010FA3")]
    [Address(RVA = "0x1C72C04", Offset = "0x1C72C04", VA = "0x1C72C04", Slot = "10")]
    public virtual IEnumerator ReOpenUpdate(GuildBelowScreenParam param) => (IEnumerator) null;

    [Token(Token = "0x6010FA4")]
    [Address(RVA = "0x1C72C8C", Offset = "0x1C72C8C", VA = "0x1C72C8C")]
    protected void InAnimation(GuildAssetBundleParam.TimelineSettingType type = GuildAssetBundleParam.TimelineSettingType.Common, Action finishAction = null)
    {
    }

    [Token(Token = "0x6010FA5")]
    [Address(RVA = "0x1C72DE0", Offset = "0x1C72DE0", VA = "0x1C72DE0")]
    protected void OutAnimation(GuildAssetBundleParam.TimelineSettingType type = GuildAssetBundleParam.TimelineSettingType.Common, Action finishAction = null)
    {
    }

    [Token(Token = "0x6010FA6")]
    [Address(RVA = "0x1C72F08", Offset = "0x1C72F08", VA = "0x1C72F08")]
    public void ChangeBelowScreen(
      GuildAssetBundleParam.GuildScreenType type,
      bool isStack = true,
      GuildBelowScreenParam param = null,
      bool closeAnimationSkip = false)
    {
    }

    [Token(Token = "0x6010FA7")]
    public void LoadPopup<T>(GuildAssetBundleParam.GuildPopupType type, Action<T> onComplete) where T : PopupBase
    {
    }

    [Token(Token = "0x6010FA8")]
    [Address(RVA = "0x1C73014", Offset = "0x1C73014", VA = "0x1C73014")]
    public void OnBackScreen(bool isAll = false)
    {
    }

    [Token(Token = "0x6010FA9")]
    [Address(RVA = "0x1C73068", Offset = "0x1C73068", VA = "0x1C73068")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x6010FAA")]
    [Address(RVA = "0x1C72B50", Offset = "0x1C72B50", VA = "0x1C72B50")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x6010FAB")]
    [Address(RVA = "0x1C730B0", Offset = "0x1C730B0", VA = "0x1C730B0")]
    public void SetCanvasEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6010FAC")]
    [Address(RVA = "0x1C730F8", Offset = "0x1C730F8", VA = "0x1C730F8")]
    public void OnClickGuildFacilityInvest(int facilityId)
    {
    }

    [Token(Token = "0x6010FAD")]
    public IEnumerator LoadRequest<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010FAE")]
    public void LoadRequestBySubScene<T>(
      string assetBundleName,
      string assetName,
      Action<T> onComplete)
      where T : UnityEngine.Object
    {
    }

    [Token(Token = "0x6010FAF")]
    [Address(RVA = "0x1C73134", Offset = "0x1C73134", VA = "0x1C73134")]
    public GuildBelowScreenBase()
    {
    }
  }
}
