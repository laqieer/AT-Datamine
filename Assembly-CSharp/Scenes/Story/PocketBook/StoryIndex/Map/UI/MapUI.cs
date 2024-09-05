// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.Map.UI.MapUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.Map.UI
{
  [Token(Token = "0x2002E0E")]
  [Serializable]
  public class MapUI
  {
    [Token(Token = "0x400C5AE")]
    [FieldOffset(Offset = "0x10")]
    [Header("マップ切り替え中に操作するCanvasGroup")]
    public CanvasGroup CanvasGroup;
    [Token(Token = "0x400C5AF")]
    [FieldOffset(Offset = "0x18")]
    [Header("マップ画像")]
    public Image DisplayMapImage;
    [Token(Token = "0x400C5B0")]
    [FieldOffset(Offset = "0x20")]
    [Header("トライアングル模様")]
    public Image Triangle;
    [Token(Token = "0x400C5B1")]
    [FieldOffset(Offset = "0x28")]
    [Header("MAP用のアクションアイコン")]
    public MapActionIcon ActionIcon;
    [Token(Token = "0x400C5B2")]
    [FieldOffset(Offset = "0x30")]
    [Header("MAP用のコミュキャラアイコン")]
    public MapActionIcon CommuCharaIcon;
    [Token(Token = "0x400C5B3")]
    [FieldOffset(Offset = "0x38")]
    [Header("MAP用のファストトラベル")]
    public GameObject FastTravel;
    [Token(Token = "0x400C5B4")]
    [FieldOffset(Offset = "0x40")]
    [Header("MAP用の遷移UI")]
    public GameObject Transition;
    [Token(Token = "0x400C5B5")]
    [FieldOffset(Offset = "0x48")]
    [Header("現在位置")]
    public RectTransform CurrentLocation;
    [Token(Token = "0x400C5B6")]
    [FieldOffset(Offset = "0x50")]
    [Header("現在のエリア名")]
    public TextAccessor TitleText;
    [Token(Token = "0x400C5B7")]
    [FieldOffset(Offset = "0x58")]
    [Header("マップ拡縮スライダ")]
    public Slider ScaleSlider;
    [Token(Token = "0x400C5B8")]
    [FieldOffset(Offset = "0x60")]
    [Header("マップ拡縮率")]
    public TextAccessor ScalePercentText;
    [Token(Token = "0x400C5B9")]
    [FieldOffset(Offset = "0x68")]
    [Header("ピンチイン速度")]
    public float PinchInSpeed;
    [Token(Token = "0x400C5BA")]
    [FieldOffset(Offset = "0x6C")]
    [Header("ピンチアウト速度")]
    public float PinchOutSpeed;
    [Token(Token = "0x400C5BB")]
    [FieldOffset(Offset = "0x70")]
    [Header("トグル：場所一覧")]
    public Toggle AreaListToggle;
    [Token(Token = "0x400C5BC")]
    [FieldOffset(Offset = "0x78")]
    [Header("トグル：スケジュール一覧")]
    public Toggle ScheduleListToggle;

    [Token(Token = "0x17003D52")]
    public MapUIAnimation Animation
    {
      [Token(Token = "0x6011FEB"), Address(RVA = "0x437861C", Offset = "0x437861C", VA = "0x437861C")] get
      {
        return (MapUIAnimation) null;
      }
    }

    [Token(Token = "0x6011FEC")]
    [Address(RVA = "0x437870C", Offset = "0x437870C", VA = "0x437870C")]
    public MapUI()
    {
    }
  }
}
