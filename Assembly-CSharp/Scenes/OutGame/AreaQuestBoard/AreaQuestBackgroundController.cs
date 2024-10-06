// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.AreaQuestBackgroundController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Movie;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038A9")]
  public class AreaQuestBackgroundController : MonoBehaviour
  {
    [Token(Token = "0x400F7D5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform rootBackGround;
    [Token(Token = "0x400F7D6")]
    private const string assetbundleName = "content_areaquestboard_areaquestbg_";
    [Token(Token = "0x400F7D7")]
    private const string assetName = "_Container_AreaQuestBG";
    [Token(Token = "0x400F7D8")]
    private const string movieName = "AreaQuest/area_{0}";
    [Token(Token = "0x400F7D9")]
    private const int defaultBgResourceId = 1000000;
    [Token(Token = "0x400F7DA")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine loadCoroutine;
    [Token(Token = "0x400F7DB")]
    [FieldOffset(Offset = "0x28")]
    private SimpleMoviePlayer moviePlayer;
    [Token(Token = "0x400F7DC")]
    [FieldOffset(Offset = "0x30")]
    private int playingMovieId;
    [Token(Token = "0x400F7DD")]
    [FieldOffset(Offset = "0x34")]
    private int requestMovieId;
    [Token(Token = "0x400F7DE")]
    [FieldOffset(Offset = "0x38")]
    private UITimelineController uITimelineController;

    [Token(Token = "0x6016469")]
    [Address(RVA = "0x1E015A8", Offset = "0x1E015A8", VA = "0x1E015A8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x601646A")]
    [Address(RVA = "0x1E015E0", Offset = "0x1E015E0", VA = "0x1E015E0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601646B")]
    [Address(RVA = "0x1E01674", Offset = "0x1E01674", VA = "0x1E01674")]
    public IEnumerator InitializeAsync(AssetCachedSpawner spawner, int areaBgResourceId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601646C")]
    [Address(RVA = "0x1E0171C", Offset = "0x1E0171C", VA = "0x1E0171C")]
    public void PlayMovie(int movieId)
    {
    }

    [Token(Token = "0x601646D")]
    [Address(RVA = "0x1E0185C", Offset = "0x1E0185C", VA = "0x1E0185C")]
    public void MoveLeft()
    {
    }

    [Token(Token = "0x601646E")]
    [Address(RVA = "0x1E01860", Offset = "0x1E01860", VA = "0x1E01860")]
    public void MoveRight()
    {
    }

    [Token(Token = "0x601646F")]
    [Address(RVA = "0x1E017E4", Offset = "0x1E017E4", VA = "0x1E017E4")]
    private IEnumerator ChangeMovie(int movieId) => (IEnumerator) null;

    [Token(Token = "0x6016470")]
    [Address(RVA = "0x1E0188C", Offset = "0x1E0188C", VA = "0x1E0188C")]
    public AreaQuestBackgroundController()
    {
    }
  }
}
