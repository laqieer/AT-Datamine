// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.EnhanceEffectBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A63")]
  public class EnhanceEffectBase : MonoBehaviour
  {
    [Token(Token = "0x400FFEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400FFEF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector director;
    [Token(Token = "0x400FFF0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image target;
    [Token(Token = "0x400FFF1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton tapNext;
    [Token(Token = "0x400FFF2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BtnFullScreen fullScreenButton;
    [Token(Token = "0x400FFF3")]
    [FieldOffset(Offset = "0x40")]
    private bool closing;
    [Token(Token = "0x400FFF4")]
    [FieldOffset(Offset = "0x48")]
    public Action MuteTrackAction;

    [Token(Token = "0x6016F3E")]
    [Address(RVA = "0x29C2184", Offset = "0x29C2184", VA = "0x29C2184")]
    public void SetCloseAction(Action action)
    {
    }

    [Token(Token = "0x6016F3F")]
    [Address(RVA = "0x29C22C0", Offset = "0x29C22C0", VA = "0x29C22C0")]
    public void SetCloseButtonInteractable(bool state)
    {
    }

    [Token(Token = "0x6016F40")]
    [Address(RVA = "0x29C2304", Offset = "0x29C2304", VA = "0x29C2304")]
    private void Close(Action action = null)
    {
    }

    [Token(Token = "0x6016F41")]
    [Address(RVA = "0x29C2480", Offset = "0x29C2480", VA = "0x29C2480")]
    protected IEnumerator SetTargetSprite(
      AssetCachedSpawner assetCachedSpawner,
      string abName,
      string aName)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016F42")]
    [Address(RVA = "0x29C2530", Offset = "0x29C2530", VA = "0x29C2530")]
    protected IEnumerator SetDelayAction(float frame, Action action) => (IEnumerator) null;

    [Token(Token = "0x6016F43")]
    [Address(RVA = "0x29C25E0", Offset = "0x29C25E0", VA = "0x29C25E0")]
    protected void MuteTrack(string trackName, bool isMuted)
    {
    }

    [Token(Token = "0x6016F44")]
    [Address(RVA = "0x29C2400", Offset = "0x29C2400", VA = "0x29C2400")]
    protected IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016F45")]
    [Address(RVA = "0x29C2628", Offset = "0x29C2628", VA = "0x29C2628")]
    public EnhanceEffectBase()
    {
    }
  }
}
