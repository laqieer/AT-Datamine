// Decompiled with JetBrains decompiler
// Type: GameCore.Movie.SimpleMoviePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace GameCore.Movie
{
  [Token(Token = "0x2000D2C")]
  public class SimpleMoviePlayer : MonoBehaviour
  {
    [Token(Token = "0x4003AF2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string defaultMoviePath;
    [Token(Token = "0x4003AF3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int movieWidth;
    [Token(Token = "0x4003AF4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int movieHeight;
    [Token(Token = "0x4003AF5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x4003AF6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RawImage videoImage;
    [Token(Token = "0x4003AF7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool IsLoop;
    [Token(Token = "0x4003AF8")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private float volumeRate;
    [Token(Token = "0x4003AF9")]
    [FieldOffset(Offset = "0x40")]
    private RenderTexture videoTexture;
    [Token(Token = "0x4003AFA")]
    [FieldOffset(Offset = "0x48")]
    private SoundVolumeSaveData soundSettings;
    [Token(Token = "0x4003AFB")]
    [FieldOffset(Offset = "0x50")]
    private bool isPlaying;

    [Token(Token = "0x6004BBF")]
    [Address(RVA = "0x32E8870", Offset = "0x32E8870", VA = "0x32E8870")]
    private void Start()
    {
    }

    [Token(Token = "0x6004BC0")]
    [Address(RVA = "0x32E8918", Offset = "0x32E8918", VA = "0x32E8918")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6004BC1")]
    [Address(RVA = "0x32E8A4C", Offset = "0x32E8A4C", VA = "0x32E8A4C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6004BC2")]
    [Address(RVA = "0x32E8A94", Offset = "0x32E8A94", VA = "0x32E8A94")]
    public IEnumerator LoadAsync(string filePath, Action OnLoaded = null) => (IEnumerator) null;

    [Token(Token = "0x6004BC3")]
    [Address(RVA = "0x32E8B38", Offset = "0x32E8B38", VA = "0x32E8B38")]
    public void Release()
    {
    }

    [Token(Token = "0x6004BC4")]
    [Address(RVA = "0x32E8A04", Offset = "0x32E8A04", VA = "0x32E8A04")]
    public void Play()
    {
    }

    [Token(Token = "0x6004BC5")]
    [Address(RVA = "0x32E8A78", Offset = "0x32E8A78", VA = "0x32E8A78")]
    public void Pause()
    {
    }

    [Token(Token = "0x6004BC6")]
    [Address(RVA = "0x32E8940", Offset = "0x32E8940", VA = "0x32E8940")]
    public void Stop()
    {
    }

    [Token(Token = "0x6004BC7")]
    [Address(RVA = "0x32E8BBC", Offset = "0x32E8BBC", VA = "0x32E8BBC")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x6004BC8")]
    [Address(RVA = "0x32E8BC4", Offset = "0x32E8BC4", VA = "0x32E8BC4")]
    public SimpleMoviePlayer()
    {
    }
  }
}
