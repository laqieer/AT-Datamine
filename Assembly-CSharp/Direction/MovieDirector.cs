// Decompiled with JetBrains decompiler
// Type: Direction.MovieDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Direction.Movie;
using Direction.Subtitles;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Direction
{
  [Token(Token = "0x2001F18")]
  public class MovieDirector : MonoBehaviour
  {
    [Token(Token = "0x4008565")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MoviePlayer moviePlayer;
    [Token(Token = "0x4008566")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage rawImage;
    [Token(Token = "0x4008567")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SubtitlePlayer subtitlePlayer;
    [Token(Token = "0x4008568")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject backgroundObject;

    [Token(Token = "0x17002664")]
    public bool IsPlaying
    {
      [Token(Token = "0x600B8A8"), Address(RVA = "0x21355D4", Offset = "0x21355D4", VA = "0x21355D4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002665")]
    public bool IsPrepared
    {
      [Token(Token = "0x600B8A9"), Address(RVA = "0x2135614", Offset = "0x2135614", VA = "0x2135614")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002666")]
    public float PlaybackSpeed
    {
      [Token(Token = "0x600B8AA"), Address(RVA = "0x2135654", Offset = "0x2135654", VA = "0x2135654")] get
      {
        return new float();
      }
      [Token(Token = "0x600B8AB"), Address(RVA = "0x2135694", Offset = "0x2135694", VA = "0x2135694")] set
      {
      }
    }

    [Token(Token = "0x600B8AC")]
    [Address(RVA = "0x2135758", Offset = "0x2135758", VA = "0x2135758")]
    public void Prepare(
      string movieAssetPath,
      SubtitlesSettings subtitlesSettings = null,
      ISubtilesTextProvider subtilesTextProvider = null)
    {
    }

    [Token(Token = "0x600B8AD")]
    [Address(RVA = "0x2135A2C", Offset = "0x2135A2C", VA = "0x2135A2C")]
    public void Prepare(
      string movieAssetPath,
      int movieWidth,
      int movieHeight,
      bool verticalFit,
      SubtitlesSettings subtitlesSettings = null,
      ISubtilesTextProvider subtilesTextProvider = null)
    {
    }

    [Token(Token = "0x600B8AE")]
    [Address(RVA = "0x2135EEC", Offset = "0x2135EEC", VA = "0x2135EEC")]
    public void Play()
    {
    }

    [Token(Token = "0x600B8AF")]
    [Address(RVA = "0x2136084", Offset = "0x2136084", VA = "0x2136084")]
    public void Pause()
    {
    }

    [Token(Token = "0x600B8B0")]
    [Address(RVA = "0x2136160", Offset = "0x2136160", VA = "0x2136160")]
    public void Stop()
    {
    }

    [Token(Token = "0x600B8B1")]
    [Address(RVA = "0x2136254", Offset = "0x2136254", VA = "0x2136254")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600B8B2")]
    [Address(RVA = "0x213634C", Offset = "0x213634C", VA = "0x213634C")]
    public MovieDirector()
    {
    }
  }
}
