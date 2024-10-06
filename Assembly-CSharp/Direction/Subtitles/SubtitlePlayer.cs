// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.SubtitlePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F26")]
  public class SubtitlePlayer : MonoBehaviour
  {
    [Token(Token = "0x4008594")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject subtitleUIObject;
    [Token(Token = "0x4008595")]
    [FieldOffset(Offset = "0x20")]
    private ISubtitleUI subtitleUI;
    [Token(Token = "0x4008599")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<uint, SubtitleAction> actionDic;
    [Token(Token = "0x400859A")]
    [FieldOffset(Offset = "0x38")]
    private SubtitlesSettings settings;
    [Token(Token = "0x400859B")]
    [FieldOffset(Offset = "0x40")]
    private bool isLooping;
    [Token(Token = "0x400859C")]
    [FieldOffset(Offset = "0x44")]
    private int currentIndex;
    [Token(Token = "0x400859D")]
    [FieldOffset(Offset = "0x48")]
    private SubtitleAction currentAction;
    [Token(Token = "0x400859E")]
    [FieldOffset(Offset = "0x50")]
    private ISyncTimeProvider syncTime;
    [Token(Token = "0x400859F")]
    [FieldOffset(Offset = "0x58")]
    private ISubtilesTextProvider text;

    [Token(Token = "0x1700266B")]
    public bool IsReady
    {
      [Token(Token = "0x600B8EC"), Address(RVA = "0x21384B4", Offset = "0x21384B4", VA = "0x21384B4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8ED"), Address(RVA = "0x21384BC", Offset = "0x21384BC", VA = "0x21384BC")] private set
      {
      }
    }

    [Token(Token = "0x1700266C")]
    public bool IsPlaying
    {
      [Token(Token = "0x600B8EE"), Address(RVA = "0x21384C8", Offset = "0x21384C8", VA = "0x21384C8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8EF"), Address(RVA = "0x21384D0", Offset = "0x21384D0", VA = "0x21384D0")] private set
      {
      }
    }

    [Token(Token = "0x1700266D")]
    public float Time
    {
      [Token(Token = "0x600B8F0"), Address(RVA = "0x21384DC", Offset = "0x21384DC", VA = "0x21384DC")] get
      {
        return new float();
      }
      [Token(Token = "0x600B8F1"), Address(RVA = "0x21384E4", Offset = "0x21384E4", VA = "0x21384E4")] private set
      {
      }
    }

    [Token(Token = "0x600B8F2")]
    [Address(RVA = "0x2135984", Offset = "0x2135984", VA = "0x2135984")]
    public void Prepare(
      SubtitlesSettings settingsData,
      bool isLoop,
      ISubtilesTextProvider textProvider)
    {
    }

    [Token(Token = "0x600B8F3")]
    [Address(RVA = "0x2135FD0", Offset = "0x2135FD0", VA = "0x2135FD0")]
    public void Play(ISyncTimeProvider syncTimeProvider = null, bool restart = false)
    {
    }

    [Token(Token = "0x600B8F4")]
    [Address(RVA = "0x2136158", Offset = "0x2136158", VA = "0x2136158")]
    public void Pause()
    {
    }

    [Token(Token = "0x600B8F5")]
    [Address(RVA = "0x2136240", Offset = "0x2136240", VA = "0x2136240")]
    public void Stop()
    {
    }

    [Token(Token = "0x600B8F6")]
    [Address(RVA = "0x2138760", Offset = "0x2138760", VA = "0x2138760")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600B8F7")]
    [Address(RVA = "0x21384EC", Offset = "0x21384EC", VA = "0x21384EC")]
    private void Init()
    {
    }

    [Token(Token = "0x600B8F8")]
    [Address(RVA = "0x213874C", Offset = "0x213874C", VA = "0x213874C")]
    private void ResetStatus()
    {
    }

    [Token(Token = "0x600B8F9")]
    [Address(RVA = "0x2138814", Offset = "0x2138814", VA = "0x2138814")]
    private void Update()
    {
    }

    [Token(Token = "0x600B8FA")]
    [Address(RVA = "0x213882C", Offset = "0x213882C", VA = "0x213882C")]
    private void UpdateProgress()
    {
    }

    [Token(Token = "0x600B8FB")]
    [Address(RVA = "0x21388E4", Offset = "0x21388E4", VA = "0x21388E4")]
    private void UpdateTime()
    {
    }

    [Token(Token = "0x600B8FC")]
    [Address(RVA = "0x21389A4", Offset = "0x21389A4", VA = "0x21389A4")]
    private bool UpdateData(SubtitleData data) => new bool();

    [Token(Token = "0x600B8FD")]
    [Address(RVA = "0x2138AEC", Offset = "0x2138AEC", VA = "0x2138AEC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B8FE")]
    [Address(RVA = "0x2138AF4", Offset = "0x2138AF4", VA = "0x2138AF4")]
    public SubtitlePlayer()
    {
    }
  }
}
