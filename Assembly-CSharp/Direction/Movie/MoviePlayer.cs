// Decompiled with JetBrains decompiler
// Type: Direction.Movie.MoviePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace Direction.Movie
{
  [Token(Token = "0x2001F29")]
  public class MoviePlayer : MonoBehaviour, ISyncTimeProvider
  {
    [Token(Token = "0x40085A2")]
    [FieldOffset(Offset = "0x18")]
    private VideoPlayer videoPlayer;
    [Token(Token = "0x40085A3")]
    [FieldOffset(Offset = "0x20")]
    private AudioSource audioSource;
    [Token(Token = "0x40085A4")]
    [FieldOffset(Offset = "0x28")]
    private RenderTexture targetTexture;
    [Token(Token = "0x40085A6")]
    [FieldOffset(Offset = "0x31")]
    private bool createdRenderTexture;

    [Token(Token = "0x1700266E")]
    public bool IsInitialized
    {
      [Token(Token = "0x600B905"), Address(RVA = "0x2138CC4", Offset = "0x2138CC4", VA = "0x2138CC4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B906"), Address(RVA = "0x2138CCC", Offset = "0x2138CCC", VA = "0x2138CCC")] protected set
      {
      }
    }

    [Token(Token = "0x1700266F")]
    public bool IsPlaying
    {
      [Token(Token = "0x600B907"), Address(RVA = "0x21355F8", Offset = "0x21355F8", VA = "0x21355F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002670")]
    public bool IsPrepared
    {
      [Token(Token = "0x600B908"), Address(RVA = "0x2135638", Offset = "0x2135638", VA = "0x2135638")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002671")]
    public float PlaybackSpeed
    {
      [Token(Token = "0x600B909"), Address(RVA = "0x2135678", Offset = "0x2135678", VA = "0x2135678")] get
      {
        return new float();
      }
      [Token(Token = "0x600B90A"), Address(RVA = "0x21356AC", Offset = "0x21356AC", VA = "0x21356AC")] set
      {
      }
    }

    [Token(Token = "0x600B90B")]
    [Address(RVA = "0x2138CD8", Offset = "0x2138CD8", VA = "0x2138CD8")]
    public void Prepare(RenderTexture texture, string assetPath, bool isLoop = false)
    {
    }

    [Token(Token = "0x600B90C")]
    [Address(RVA = "0x2135848", Offset = "0x2135848", VA = "0x2135848")]
    public void Prepare(RawImage targetImage, string assetPath, bool isLoop = false)
    {
    }

    [Token(Token = "0x600B90D")]
    [Address(RVA = "0x2135B4C", Offset = "0x2135B4C", VA = "0x2135B4C")]
    public void Prepare(
      RawImage targetImage,
      string assetPath,
      int movieWidth,
      int movieHeight,
      bool verticalFit,
      bool isLoop = false)
    {
    }

    [Token(Token = "0x600B90E")]
    [Address(RVA = "0x2135DA4", Offset = "0x2135DA4", VA = "0x2135DA4")]
    public void SetSettingVolume()
    {
    }

    [Token(Token = "0x600B90F")]
    [Address(RVA = "0x2135FB4", Offset = "0x2135FB4", VA = "0x2135FB4")]
    public void Play()
    {
    }

    [Token(Token = "0x600B910")]
    [Address(RVA = "0x213613C", Offset = "0x213613C", VA = "0x213613C")]
    public void Pause()
    {
    }

    [Token(Token = "0x600B911")]
    [Address(RVA = "0x2136224", Offset = "0x2136224", VA = "0x2136224")]
    public void Stop()
    {
    }

    [Token(Token = "0x600B912")]
    [Address(RVA = "0x2136324", Offset = "0x2136324", VA = "0x2136324")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600B913")]
    [Address(RVA = "0x2138D88", Offset = "0x2138D88", VA = "0x2138D88")]
    private void Init()
    {
    }

    [Token(Token = "0x600B914")]
    [Address(RVA = "0x2138EB8", Offset = "0x2138EB8", VA = "0x2138EB8")]
    private void PrepareInternal(string assetPath, bool isLoop)
    {
    }

    [Token(Token = "0x600B915")]
    [Address(RVA = "0x2138F20", Offset = "0x2138F20", VA = "0x2138F20", Slot = "4")]
    private float Direction\u002EISyncTimeProvider\u002EGetTime() => new float();

    [Token(Token = "0x600B916")]
    [Address(RVA = "0x2138FA4", Offset = "0x2138FA4", VA = "0x2138FA4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B917")]
    [Address(RVA = "0x2139044", Offset = "0x2139044", VA = "0x2139044")]
    public MoviePlayer()
    {
    }
  }
}
