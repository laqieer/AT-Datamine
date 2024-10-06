// Decompiled with JetBrains decompiler
// Type: Gacha.GachaCharacterGetPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x20014F8")]
  public class GachaCharacterGetPanel : MonoBehaviour
  {
    [Token(Token = "0x4006056")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x4006057")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text nameText;
    [Token(Token = "0x4006058")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RawImage characterTextureImage;
    [Token(Token = "0x4006059")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TimelineAsset getCharacterTimelineIn;
    [Token(Token = "0x400605A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TimelineAsset getCharacterTimelineOut;

    [Token(Token = "0x6007683")]
    [Address(RVA = "0x44EA114", Offset = "0x44EA114", VA = "0x44EA114")]
    public void SetCharacterImage(Texture texture)
    {
    }

    [Token(Token = "0x6007684")]
    [Address(RVA = "0x44EA130", Offset = "0x44EA130", VA = "0x44EA130")]
    public void SetCharacterImageLayout(IllustLayoutInfo info)
    {
    }

    [Token(Token = "0x6007685")]
    [Address(RVA = "0x44EA1CC", Offset = "0x44EA1CC", VA = "0x44EA1CC")]
    public void SetInTimeline()
    {
    }

    [Token(Token = "0x6007686")]
    [Address(RVA = "0x44EA1F0", Offset = "0x44EA1F0", VA = "0x44EA1F0")]
    public void SetOutTimeline()
    {
    }

    [Token(Token = "0x6007687")]
    [Address(RVA = "0x44EA214", Offset = "0x44EA214", VA = "0x44EA214")]
    public void Play()
    {
    }

    [Token(Token = "0x6007688")]
    [Address(RVA = "0x44EA248", Offset = "0x44EA248", VA = "0x44EA248")]
    public bool CanSkipNext() => new bool();

    [Token(Token = "0x6007689")]
    [Address(RVA = "0x44EA37C", Offset = "0x44EA37C", VA = "0x44EA37C")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x600768A")]
    [Address(RVA = "0x44EA3A4", Offset = "0x44EA3A4", VA = "0x44EA3A4")]
    public void EndTimeline()
    {
    }

    [Token(Token = "0x600768B")]
    [Address(RVA = "0x44EA3D0", Offset = "0x44EA3D0", VA = "0x44EA3D0")]
    public void SetCharacterName(string characterName)
    {
    }

    [Token(Token = "0x600768C")]
    [Address(RVA = "0x44EA3F4", Offset = "0x44EA3F4", VA = "0x44EA3F4")]
    public void SetActive(bool value)
    {
    }

    [Token(Token = "0x600768D")]
    [Address(RVA = "0x44EA41C", Offset = "0x44EA41C", VA = "0x44EA41C")]
    public GachaCharacterGetPanel()
    {
    }
  }
}
