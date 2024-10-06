// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventVideoPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B74")]
  public class HomeEventVideoPlayer : MonoBehaviour
  {
    [Token(Token = "0x4003434")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x4003435")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton canvas;
    [Token(Token = "0x4003436")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform videoPanel;
    [Token(Token = "0x4003437")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RawImage videoImage;
    [Token(Token = "0x4003438")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x4003439")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject skipObject;
    [Token(Token = "0x400343A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton skipButton;
    [Token(Token = "0x400343B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private float switchSec;
    [Token(Token = "0x400343C")]
    [FieldOffset(Offset = "0x58")]
    private Action finishAction;
    [Token(Token = "0x400343D")]
    [FieldOffset(Offset = "0x60")]
    private RenderTexture renderTexture;
    [Token(Token = "0x400343E")]
    [FieldOffset(Offset = "0x68")]
    private float sec;

    [Token(Token = "0x600412F")]
    [Address(RVA = "0x2A2DE78", Offset = "0x2A2DE78", VA = "0x2A2DE78")]
    private void Update()
    {
    }

    [Token(Token = "0x6004130")]
    [Address(RVA = "0x2A2D350", Offset = "0x2A2D350", VA = "0x2A2D350")]
    public IEnumerator InitializeAsync(string path, Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6004131")]
    [Address(RVA = "0x2A2D3CC", Offset = "0x2A2D3CC", VA = "0x2A2D3CC")]
    public void PlayVideo()
    {
    }

    [Token(Token = "0x6004132")]
    [Address(RVA = "0x2A2CC3C", Offset = "0x2A2CC3C", VA = "0x2A2CC3C")]
    public void VideoFinish(VideoPlayer source = null)
    {
    }

    [Token(Token = "0x6004133")]
    [Address(RVA = "0x2A2DF88", Offset = "0x2A2DF88", VA = "0x2A2DF88")]
    private void SetFinishAction(Action finishAction)
    {
    }

    [Token(Token = "0x6004134")]
    [Address(RVA = "0x2A2DF08", Offset = "0x2A2DF08", VA = "0x2A2DF08")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004135")]
    [Address(RVA = "0x2A2E074", Offset = "0x2A2E074", VA = "0x2A2E074")]
    public HomeEventVideoPlayer()
    {
    }
  }
}
