// Decompiled with JetBrains decompiler
// Type: GameCore.Movie.MovieManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace GameCore.Movie
{
  [Token(Token = "0x2000D2B")]
  public class MovieManager : SingletonMonoBehaviour<MovieManager>
  {
    [Token(Token = "0x4003AED")]
    private const int ConstMovieWidth = 640;
    [Token(Token = "0x4003AEE")]
    private const int ConstMovieHeight = 360;
    [Token(Token = "0x4003AEF")]
    [FieldOffset(Offset = "0x20")]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x4003AF0")]
    [FieldOffset(Offset = "0x28")]
    private RectTransform vpRect;
    [Token(Token = "0x4003AF1")]
    [FieldOffset(Offset = "0x30")]
    private RawImage image;

    [Token(Token = "0x6004BBA")]
    [Address(RVA = "0x32E8474", Offset = "0x32E8474", VA = "0x32E8474")]
    public void Initialize(VideoPlayer videoPlayer)
    {
    }

    [Token(Token = "0x6004BBB")]
    [Address(RVA = "0x32E850C", Offset = "0x32E850C", VA = "0x32E850C")]
    public void Play()
    {
    }

    [Token(Token = "0x6004BBC")]
    [Address(RVA = "0x32E8528", Offset = "0x32E8528", VA = "0x32E8528")]
    public void Stop()
    {
    }

    [Token(Token = "0x6004BBD")]
    [Address(RVA = "0x32E8544", Offset = "0x32E8544", VA = "0x32E8544")]
    public void SetPlayer(string movieName, bool isLoop = false)
    {
    }

    [Token(Token = "0x6004BBE")]
    [Address(RVA = "0x32E87C4", Offset = "0x32E87C4", VA = "0x32E87C4")]
    public MovieManager()
    {
    }
  }
}
