// Decompiled with JetBrains decompiler
// Type: Gacha.GachaBGView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014F4")]
  internal class GachaBGView : MonoBehaviour, IGachaBGView
  {
    [Token(Token = "0x4006042")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage stillImage;
    [Token(Token = "0x4006043")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage videoImage;
    [Token(Token = "0x4006044")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x4006045")]
    [FieldOffset(Offset = "0x30")]
    private RenderTextureHandle renderTextureHandle;
    [Token(Token = "0x4006046")]
    [FieldOffset(Offset = "0x38")]
    private Action videoFinishedEvent;
    [Token(Token = "0x4006047")]
    [FieldOffset(Offset = "0x40")]
    private GachaBGPresenter presenter;
    [Token(Token = "0x4006048")]
    [FieldOffset(Offset = "0x48")]
    private GachaBGView.PlayState playState;

    [Token(Token = "0x1700124D")]
    public Action VideoFinished
    {
      [Token(Token = "0x6007668"), Address(RVA = "0x44E9108", Offset = "0x44E9108", VA = "0x44E9108", Slot = "4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6007669"), Address(RVA = "0x44E9110", Offset = "0x44E9110", VA = "0x44E9110", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x1700124E")]
    public GachaBGPresenter Presenter
    {
      [Token(Token = "0x600766A"), Address(RVA = "0x44E9118", Offset = "0x44E9118", VA = "0x44E9118", Slot = "9")] set
      {
      }
    }

    [Token(Token = "0x600766B")]
    [Address(RVA = "0x44E9868", Offset = "0x44E9868", VA = "0x44E9868")]
    private void InitializeVideoPlayer()
    {
    }

    [Token(Token = "0x600766C")]
    [Address(RVA = "0x44E9988", Offset = "0x44E9988", VA = "0x44E9988")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600766D")]
    [Address(RVA = "0x44E99AC", Offset = "0x44E99AC", VA = "0x44E99AC", Slot = "6")]
    public void SetStillImage(Texture2D texture)
    {
    }

    [Token(Token = "0x600766E")]
    [Address(RVA = "0x44E9A1C", Offset = "0x44E9A1C", VA = "0x44E9A1C", Slot = "7")]
    public void PlayVideo(string url)
    {
    }

    [Token(Token = "0x600766F")]
    [Address(RVA = "0x44E9B24", Offset = "0x44E9B24", VA = "0x44E9B24", Slot = "8")]
    public void StopVideo()
    {
    }

    [Token(Token = "0x6007670")]
    [Address(RVA = "0x44E9B68", Offset = "0x44E9B68", VA = "0x44E9B68")]
    private void OnVideoPlayerFinished(VideoPlayer source)
    {
    }

    [Token(Token = "0x6007671")]
    [Address(RVA = "0x44E9BC8", Offset = "0x44E9BC8", VA = "0x44E9BC8")]
    public void SetStillImageActive(bool isActive)
    {
    }

    [Token(Token = "0x6007672")]
    [Address(RVA = "0x44E9BF8", Offset = "0x44E9BF8", VA = "0x44E9BF8")]
    public void SetVideoImageActive(bool isActive)
    {
    }

    [Token(Token = "0x6007673")]
    [Address(RVA = "0x44E9C28", Offset = "0x44E9C28", VA = "0x44E9C28")]
    private void OnApplicationPause(bool isPause)
    {
    }

    [Token(Token = "0x6007674")]
    [Address(RVA = "0x44E9AD8", Offset = "0x44E9AD8", VA = "0x44E9AD8")]
    private void StopWaitResumeVideo()
    {
    }

    [Token(Token = "0x6007675")]
    [Address(RVA = "0x44E9D24", Offset = "0x44E9D24", VA = "0x44E9D24")]
    private IEnumerator WaitResumeVideo(int waitCount) => (IEnumerator) null;

    [Token(Token = "0x6007676")]
    [Address(RVA = "0x44E9CF8", Offset = "0x44E9CF8", VA = "0x44E9CF8")]
    private void PauseVideo()
    {
    }

    [Token(Token = "0x6007677")]
    [Address(RVA = "0x44E9DC4", Offset = "0x44E9DC4", VA = "0x44E9DC4")]
    private void ResumeVideo()
    {
    }

    [Token(Token = "0x6007678")]
    [Address(RVA = "0x44E9DF0", Offset = "0x44E9DF0", VA = "0x44E9DF0")]
    public GachaBGView()
    {
    }

    [Token(Token = "0x20014F5")]
    private enum PlayState
    {
      [Token(Token = "0x400604A")] Initialize,
      [Token(Token = "0x400604B")] Playing,
      [Token(Token = "0x400604C")] Pause,
      [Token(Token = "0x400604D")] Stop,
    }
  }
}
