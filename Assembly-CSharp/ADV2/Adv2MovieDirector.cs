// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2MovieDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Direction;
using Direction.Subtitles;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E19")]
  public class Adv2MovieDirector : MonoBehaviour, ISubtilesTextProvider
  {
    [Token(Token = "0x4011073")]
    [FieldOffset(Offset = "0x18")]
    private MovieDirector movieDirector;
    [Token(Token = "0x4011074")]
    [FieldOffset(Offset = "0x20")]
    protected Transform hierarchyRoot;
    [Token(Token = "0x4011075")]
    [FieldOffset(Offset = "0x28")]
    private Adv2SubtitleUI adv2SubtitleUI;
    [Token(Token = "0x4011076")]
    [FieldOffset(Offset = "0x30")]
    protected Adv2Manager.OnProccessSignal playingSignal;
    [Token(Token = "0x4011077")]
    [FieldOffset(Offset = "0x38")]
    protected Adv2Manager.OnProccessSignal loadSignal;
    [Token(Token = "0x4011078")]
    [FieldOffset(Offset = "0x40")]
    private bool played;
    [Token(Token = "0x4011079")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string MOVIE_SUBTILES_AB_BASE;
    [Token(Token = "0x401107A")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string MOVIE_SUBTILES_AB_ASSETNAME_BASE;
    [Token(Token = "0x401107B")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string TEXT_AB_BASE;
    [Token(Token = "0x401107C")]
    [FieldOffset(Offset = "0x18")]
    private static readonly string TEXT_AB_ASSETNAME_BASE;
    [Token(Token = "0x401107D")]
    [FieldOffset(Offset = "0x48")]
    private string textAssetbundleName;

    [Token(Token = "0x601900D")]
    [Address(RVA = "0x2CBC1D8", Offset = "0x2CBC1D8", VA = "0x2CBC1D8")]
    public static Adv2MovieDirector Create(GameObject addComponent, Transform parentHierarchy)
    {
      return (Adv2MovieDirector) null;
    }

    [Token(Token = "0x601900E")]
    [Address(RVA = "0x2CBC270", Offset = "0x2CBC270", VA = "0x2CBC270")]
    public void SetBindObject(GameObject prefab, bool isActive)
    {
    }

    [Token(Token = "0x601900F")]
    [Address(RVA = "0x2CBC360", Offset = "0x2CBC360", VA = "0x2CBC360")]
    public Adv2Manager.OnProccessSignal LoadMovie(
      string movieFileName,
      string subtitlesBaseName,
      bool existH265,
      int movieWidth,
      int movieHeight,
      bool verticalFit)
    {
      return (Adv2Manager.OnProccessSignal) null;
    }

    [Token(Token = "0x6019010")]
    [Address(RVA = "0x2CBC4AC", Offset = "0x2CBC4AC", VA = "0x2CBC4AC")]
    private void Prepare(
      string movieAssetPath,
      int movieWidth,
      int movieHeight,
      bool verticalFit,
      SubtitlesSettings subtitlesSettings = null,
      ISubtilesTextProvider subtilesTextProvider = null)
    {
    }

    [Token(Token = "0x6019011")]
    [Address(RVA = "0x2CBC4C4", Offset = "0x2CBC4C4", VA = "0x2CBC4C4")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x6019012")]
    [Address(RVA = "0x2CBC4DC", Offset = "0x2CBC4DC", VA = "0x2CBC4DC")]
    public Adv2Manager.OnProccessSignal Play() => (Adv2Manager.OnProccessSignal) null;

    [Token(Token = "0x6019013")]
    [Address(RVA = "0x2CBC5B4", Offset = "0x2CBC5B4", VA = "0x2CBC5B4")]
    public void Stop()
    {
    }

    [Token(Token = "0x6019014")]
    [Address(RVA = "0x2CBC664", Offset = "0x2CBC664", VA = "0x2CBC664")]
    public void Pause()
    {
    }

    [Token(Token = "0x6019015")]
    [Address(RVA = "0x2CBC678", Offset = "0x2CBC678", VA = "0x2CBC678")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6019016")]
    [Address(RVA = "0x2CBC67C", Offset = "0x2CBC67C", VA = "0x2CBC67C")]
    public void SetPalybackSpeed(float speed)
    {
    }

    [Token(Token = "0x6019017")]
    [Address(RVA = "0x2CBC698", Offset = "0x2CBC698", VA = "0x2CBC698")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6019018")]
    [Address(RVA = "0x2CBC3FC", Offset = "0x2CBC3FC", VA = "0x2CBC3FC")]
    private IEnumerator coLoadMovie(
      string movieFileName,
      string subtitlesBaseName,
      bool existH265,
      int movieWidth,
      int movieHeight,
      bool verticalFit)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6019019")]
    [Address(RVA = "0x2CBC784", Offset = "0x2CBC784", VA = "0x2CBC784", Slot = "4")]
    private string Direction\u002EISubtilesTextProvider\u002EGetText(string textId)
    {
      return (string) null;
    }

    [Token(Token = "0x601901A")]
    [Address(RVA = "0x2CBC958", Offset = "0x2CBC958", VA = "0x2CBC958")]
    public Adv2MovieDirector()
    {
    }

    [Token(Token = "0x601901B")]
    [Address(RVA = "0x2CBC9DC", Offset = "0x2CBC9DC", VA = "0x2CBC9DC")]
    static Adv2MovieDirector()
    {
    }
  }
}
