// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.ProfileData.PocketBookProfileDataContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.ProfileData
{
  [Token(Token = "0x2002E4A")]
  public class PocketBookProfileDataContainer : MonoBehaviour
  {
    [Token(Token = "0x400C687")]
    private const string RADAR_CHART_PARAM_IN = "Param_In";
    [Token(Token = "0x400C688")]
    private const string EMBLEM_ICON_NAME = "Img_Emblem_big";
    [Token(Token = "0x400C689")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C68A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text charName;
    [Token(Token = "0x400C68B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400C68C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RadarChart radarChart;
    [Token(Token = "0x400C68D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TweenRadarChart tweenRadarChart;
    [Token(Token = "0x400C68E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image emblemIcon;
    [Token(Token = "0x400C68F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x17003D88")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6012182"), Address(RVA = "0x4384F20", Offset = "0x4384F20", VA = "0x4384F20")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6012183")]
    [Address(RVA = "0x4384F28", Offset = "0x4384F28", VA = "0x4384F28")]
    public void Initialize(PocketBookLoader loader, SpriteAtlas spriteAtlas)
    {
    }

    [Token(Token = "0x6012184")]
    [Address(RVA = "0x43852F4", Offset = "0x43852F4", VA = "0x43852F4")]
    public void PlayToEnableAnimation()
    {
    }

    [Token(Token = "0x6012185")]
    [Address(RVA = "0x438535C", Offset = "0x438535C", VA = "0x438535C")]
    public PocketBookProfileDataContainer()
    {
    }
  }
}
