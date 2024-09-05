// Decompiled with JetBrains decompiler
// Type: Direction.MovieDirectorTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Direction.Subtitles;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Direction
{
  [Token(Token = "0x2001F1B")]
  public class MovieDirectorTest : MonoBehaviour, ISubtilesTextProvider
  {
    [Token(Token = "0x4008569")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MovieDirector director;
    [Token(Token = "0x400856A")]
    [FieldOffset(Offset = "0x20")]
    private string movieAssetPath;
    [Token(Token = "0x400856B")]
    [FieldOffset(Offset = "0x28")]
    private SubtitlesSettings subtitlesSettings;
    [Token(Token = "0x400856C")]
    [FieldOffset(Offset = "0x30")]
    [Space]
    [SerializeField]
    private Text debugText;
    [Token(Token = "0x400856D")]
    [FieldOffset(Offset = "0x38")]
    private MovieDirectorTest.State currentState;
    [Token(Token = "0x400856E")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Rect buttonRect;
    [Token(Token = "0x400856F")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Rect subButtonTect;
    [Token(Token = "0x4008570")]
    [FieldOffset(Offset = "0x40")]
    private GUIStyle buttonStyle;
    [Token(Token = "0x4008571")]
    private const string MOVIE_FILE_NAME = "Style/101010002/101010002_SingleSkill";
    [Token(Token = "0x4008572")]
    private const string MOVIE_SUBTILES_AB = "content_movie_openingmovie";
    [Token(Token = "0x4008573")]
    private const string MOVIE_SUBTILES_AB_ASSETNAME = "OpeningMovieSubtitles";
    [Token(Token = "0x4008574")]
    private const string TEXT_AB = "text_movie_subtitles_openingmovie";
    [Token(Token = "0x4008575")]
    private const string TEXT_AB_ASSETNAME = "Assets/AssetBundle/text/movie_subtitles/openingmovie/{0}/text.text.bytes";
    [Token(Token = "0x4008576")]
    [FieldOffset(Offset = "0x48")]
    private bool isStartEnded;

    [Token(Token = "0x600B8B7")]
    [Address(RVA = "0x21365D0", Offset = "0x21365D0", VA = "0x21365D0")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600B8B8")]
    [Address(RVA = "0x2136660", Offset = "0x2136660", VA = "0x2136660", Slot = "4")]
    private string Direction\u002EISubtilesTextProvider\u002EGetText(string textId)
    {
      return (string) null;
    }

    [Token(Token = "0x600B8B9")]
    [Address(RVA = "0x21366D0", Offset = "0x21366D0", VA = "0x21366D0")]
    private void Prepare()
    {
    }

    [Token(Token = "0x600B8BA")]
    [Address(RVA = "0x2136768", Offset = "0x2136768", VA = "0x2136768")]
    private void Play()
    {
    }

    [Token(Token = "0x600B8BB")]
    [Address(RVA = "0x21367E8", Offset = "0x21367E8", VA = "0x21367E8")]
    private void Stop()
    {
    }

    [Token(Token = "0x600B8BC")]
    [Address(RVA = "0x2136868", Offset = "0x2136868", VA = "0x2136868")]
    private void Finish()
    {
    }

    [Token(Token = "0x600B8BD")]
    [Address(RVA = "0x21368F4", Offset = "0x21368F4", VA = "0x21368F4")]
    private void ChangeState(MovieDirectorTest.State next)
    {
    }

    [Token(Token = "0x600B8BE")]
    [Address(RVA = "0x21368FC", Offset = "0x21368FC", VA = "0x21368FC")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x600B8BF")]
    [Address(RVA = "0x2136C50", Offset = "0x2136C50", VA = "0x2136C50")]
    private void ShowGUIButton(Rect rect, string label, Action action)
    {
    }

    [Token(Token = "0x600B8C0")]
    [Address(RVA = "0x2136D24", Offset = "0x2136D24", VA = "0x2136D24")]
    public MovieDirectorTest()
    {
    }

    [Token(Token = "0x600B8C1")]
    [Address(RVA = "0x2136D2C", Offset = "0x2136D2C", VA = "0x2136D2C")]
    static MovieDirectorTest()
    {
    }

    [Token(Token = "0x2001F1C")]
    private enum State
    {
      [Token(Token = "0x4008578")] None,
      [Token(Token = "0x4008579")] Prepared,
      [Token(Token = "0x400857A")] Playing,
      [Token(Token = "0x400857B")] Stopping,
    }
  }
}
