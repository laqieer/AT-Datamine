// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleMoviePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028F0")]
  public class TitleMoviePlayer : MonoBehaviour
  {
    [Token(Token = "0x400AE98")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string MovieNamePath;
    [Token(Token = "0x400AE99")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int movieWidth;
    [Token(Token = "0x400AE9A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int movieHeight;
    [Token(Token = "0x400AE9B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x400AE9C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RawImage videoImage;
    [Token(Token = "0x400AE9D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool IsLoop;
    [Token(Token = "0x400AE9E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float volumeRate;
    [Token(Token = "0x400AE9F")]
    [FieldOffset(Offset = "0x40")]
    private RenderTexture videoTexture;
    [Token(Token = "0x400AEA0")]
    [FieldOffset(Offset = "0x48")]
    private SoundVolumeSaveData soundSettings;
    [Token(Token = "0x400AEA1")]
    [FieldOffset(Offset = "0x50")]
    private float bgmVolume;
    [Token(Token = "0x400AEA2")]
    [FieldOffset(Offset = "0x54")]
    private float delayVolumeParameter;
    [Token(Token = "0x400AEA3")]
    [FieldOffset(Offset = "0x58")]
    private float delayVolumeTime;
    [Token(Token = "0x400AEA4")]
    [FieldOffset(Offset = "0x5C")]
    private bool isDelayVolume;

    [Token(Token = "0x60101AA")]
    [Address(RVA = "0x4171FBC", Offset = "0x4171FBC", VA = "0x4171FBC")]
    private void Start()
    {
    }

    [Token(Token = "0x60101AB")]
    [Address(RVA = "0x4172068", Offset = "0x4172068", VA = "0x4172068")]
    private void Update()
    {
    }

    [Token(Token = "0x60101AC")]
    [Address(RVA = "0x4172158", Offset = "0x4172158", VA = "0x4172158")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x60101AD")]
    [Address(RVA = "0x41721E8", Offset = "0x41721E8", VA = "0x41721E8")]
    public void Release()
    {
    }

    [Token(Token = "0x60101AE")]
    [Address(RVA = "0x41722AC", Offset = "0x41722AC", VA = "0x41722AC")]
    public void Play()
    {
    }

    [Token(Token = "0x60101AF")]
    [Address(RVA = "0x41722EC", Offset = "0x41722EC", VA = "0x41722EC")]
    public void StartDelayVolume()
    {
    }

    [Token(Token = "0x60101B0")]
    [Address(RVA = "0x417232C", Offset = "0x417232C", VA = "0x417232C")]
    public void Pause()
    {
    }

    [Token(Token = "0x60101B1")]
    [Address(RVA = "0x417226C", Offset = "0x417226C", VA = "0x417226C")]
    public void Stop()
    {
    }

    [Token(Token = "0x60101B2")]
    [Address(RVA = "0x4172348", Offset = "0x4172348", VA = "0x4172348")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x60101B3")]
    [Address(RVA = "0x417206C", Offset = "0x417206C", VA = "0x417206C")]
    private void UpdateVolume()
    {
    }

    [Token(Token = "0x60101B4")]
    [Address(RVA = "0x4172364", Offset = "0x4172364", VA = "0x4172364")]
    public TitleMoviePlayer()
    {
    }
  }
}
