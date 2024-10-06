// Decompiled with JetBrains decompiler
// Type: Gacha.GachaTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200152F")]
  internal class GachaTopView : MonoBehaviour, IGachaBGView
  {
    [Token(Token = "0x400615F")]
    private const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x4006160")]
    private const string AssetName = "Container_GachaTop";
    [Token(Token = "0x4006161")]
    [FieldOffset(Offset = "0x18")]
    [Header("入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4006162")]
    [FieldOffset(Offset = "0x20")]
    [Header("アニメーション制御用")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4006163")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4006164")]
    [FieldOffset(Offset = "0x30")]
    [Header("開催期間")]
    [SerializeField]
    private GachaScheduleView gachaScheduleView;
    [Token(Token = "0x4006165")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("背景")]
    private GachaBGView bgView;
    [Token(Token = "0x4006166")]
    [FieldOffset(Offset = "0x40")]
    [Header("ガチャボタン制御用")]
    [SerializeField]
    private GachaPayButtonGroup gachaPayButtonGroup;
    [Token(Token = "0x4006167")]
    [FieldOffset(Offset = "0x48")]
    public Action<GachaPayButtonGroupType> PayToggleChanged;
    [Token(Token = "0x4006168")]
    [FieldOffset(Offset = "0x50")]
    private GachaTopView.BGStateTypeEnum bGStateType;

    [Token(Token = "0x17001275")]
    private Action Gacha\u002EIGachaBGView\u002EVideoFinished
    {
      [Token(Token = "0x6007808"), Address(RVA = "0x44F723C", Offset = "0x44F723C", VA = "0x44F723C", Slot = "4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6007809"), Address(RVA = "0x44F7258", Offset = "0x44F7258", VA = "0x44F7258", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x17001276")]
    public GachaTopView.BGStateTypeEnum BGStateType
    {
      [Token(Token = "0x600780A"), Address(RVA = "0x44F7274", Offset = "0x44F7274", VA = "0x44F7274")] get
      {
        return new GachaTopView.BGStateTypeEnum();
      }
    }

    [Token(Token = "0x17001277")]
    private GachaBGPresenter Gacha\u002EIGachaBGView\u002EPresenter
    {
      [Token(Token = "0x600780B"), Address(RVA = "0x44F727C", Offset = "0x44F727C", VA = "0x44F727C", Slot = "9")] set
      {
      }
    }

    [Token(Token = "0x17001278")]
    public GachaPayButtonGroup GachaPayButtonGroupView
    {
      [Token(Token = "0x600780C"), Address(RVA = "0x44F7294", Offset = "0x44F7294", VA = "0x44F7294")] get
      {
        return (GachaPayButtonGroup) null;
      }
    }

    [Token(Token = "0x600780D")]
    [Address(RVA = "0x44F729C", Offset = "0x44F729C", VA = "0x44F729C")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600780E")]
    [Address(RVA = "0x44F731C", Offset = "0x44F731C", VA = "0x44F731C")]
    public static IEnumerator Create(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<GachaTopView> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600780F")]
    [Address(RVA = "0x44F73C0", Offset = "0x44F73C0", VA = "0x44F73C0", Slot = "10")]
    public virtual IEnumerator Initialize(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x6007810")]
    [Address(RVA = "0x44F745C", Offset = "0x44F745C", VA = "0x44F745C")]
    private void InitializePayButtonGroup(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007811")]
    [Address(RVA = "0x44F7478", Offset = "0x44F7478", VA = "0x44F7478")]
    public void PlayBGTextureToMovie(Action onAnimationComplete)
    {
    }

    [Token(Token = "0x6007812")]
    [Address(RVA = "0x44F5CB8", Offset = "0x44F5CB8", VA = "0x44F5CB8")]
    public void PlayBGMovieToTexture(Action onAnimationComplete)
    {
    }

    [Token(Token = "0x6007813")]
    [Address(RVA = "0x44F74E4", Offset = "0x44F74E4", VA = "0x44F74E4", Slot = "6")]
    private void Gacha\u002EIGachaBGView\u002ESetStillImage(Texture2D texture)
    {
    }

    [Token(Token = "0x6007814")]
    [Address(RVA = "0x44F5EC0", Offset = "0x44F5EC0", VA = "0x44F5EC0")]
    public void SetStillImageActive(bool isActive)
    {
    }

    [Token(Token = "0x6007815")]
    [Address(RVA = "0x44F5EDC", Offset = "0x44F5EDC", VA = "0x44F5EDC")]
    public void SetVideoImageActive(bool isActive)
    {
    }

    [Token(Token = "0x6007816")]
    [Address(RVA = "0x44F7528", Offset = "0x44F7528", VA = "0x44F7528", Slot = "7")]
    private void Gacha\u002EIGachaBGView\u002EPlayVideo(string url)
    {
    }

    [Token(Token = "0x6007817")]
    [Address(RVA = "0x44F756C", Offset = "0x44F756C", VA = "0x44F756C", Slot = "8")]
    private void Gacha\u002EIGachaBGView\u002EStopVideo()
    {
    }

    [Token(Token = "0x6007818")]
    [Address(RVA = "0x44F5EA4", Offset = "0x44F5EA4", VA = "0x44F5EA4")]
    public void SetSchedule(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x6007819")]
    [Address(RVA = "0x44F7584", Offset = "0x44F7584", VA = "0x44F7584")]
    public void SetTopTexture(Texture2D texture)
    {
    }

    [Token(Token = "0x600781A")]
    [Address(RVA = "0x44F5C20", Offset = "0x44F5C20", VA = "0x44F5C20")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x600781B")]
    [Address(RVA = "0x44F759C", Offset = "0x44F759C", VA = "0x44F759C")]
    public GachaTopView()
    {
    }

    [Token(Token = "0x2001530")]
    public enum BGStateTypeEnum
    {
      [Token(Token = "0x400616A")] Default,
      [Token(Token = "0x400616B")] Texture,
      [Token(Token = "0x400616C")] Movie,
    }
  }
}
