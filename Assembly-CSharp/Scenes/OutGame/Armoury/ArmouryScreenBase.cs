// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryScreenBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037EC")]
  public abstract class ArmouryScreenBase : MonoBehaviour
  {
    [Token(Token = "0x400F450")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F451")]
    [FieldOffset(Offset = "0x20")]
    private ArmouryScreenTimeLine _timeline;
    [Token(Token = "0x400F452")]
    [FieldOffset(Offset = "0x28")]
    protected AssetCachedSpawner _spawner;
    [Token(Token = "0x400F453")]
    [FieldOffset(Offset = "0x30")]
    protected bool _isNeedGridButton;
    [Token(Token = "0x400F454")]
    [FieldOffset(Offset = "0x34")]
    private ArmouryScreenType _screenType;
    [Token(Token = "0x400F455")]
    [FieldOffset(Offset = "0x38")]
    protected SettingHorizontalInfiniteScrollViewProperty _normalScrpllSetting;
    [Token(Token = "0x400F456")]
    [FieldOffset(Offset = "0x58")]
    protected SettingHorizontalInfiniteScrollViewProperty _smallScrollSetting;
    [Token(Token = "0x400F457")]
    [FieldOffset(Offset = "0x78")]
    protected Action<bool> _homeButtonAction;
    [Token(Token = "0x400F458")]
    [FieldOffset(Offset = "0x80")]
    protected Action<ArmouryScreenType, ArmouryChangeScreenParam> _changeScreenAction;
    [Token(Token = "0x400F459")]
    [FieldOffset(Offset = "0x88")]
    private bool _isOpenSideMenu;

    [Token(Token = "0x170048BB")]
    public bool IsNeedGridButton
    {
      [Token(Token = "0x6015FF7"), Address(RVA = "0x20EA42C", Offset = "0x20EA42C", VA = "0x20EA42C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015FF8"), Address(RVA = "0x20EA434", Offset = "0x20EA434", VA = "0x20EA434")] protected set
      {
      }
    }

    [Token(Token = "0x170048BC")]
    public ArmouryScreenType ScreenType
    {
      [Token(Token = "0x6015FF9"), Address(RVA = "0x20EA440", Offset = "0x20EA440", VA = "0x20EA440")] get
      {
        return new ArmouryScreenType();
      }
    }

    [Token(Token = "0x170048BD")]
    public SettingHorizontalInfiniteScrollViewProperty NormalScrpllSetting
    {
      [Token(Token = "0x6015FFA"), Address(RVA = "0x20EA448", Offset = "0x20EA448", VA = "0x20EA448")] get
      {
        return new SettingHorizontalInfiniteScrollViewProperty();
      }
      [Token(Token = "0x6015FFB"), Address(RVA = "0x20EA458", Offset = "0x20EA458", VA = "0x20EA458")] protected set
      {
      }
    }

    [Token(Token = "0x170048BE")]
    public SettingHorizontalInfiniteScrollViewProperty SmallScrollSetting
    {
      [Token(Token = "0x6015FFC"), Address(RVA = "0x20EA468", Offset = "0x20EA468", VA = "0x20EA468")] get
      {
        return new SettingHorizontalInfiniteScrollViewProperty();
      }
      [Token(Token = "0x6015FFD"), Address(RVA = "0x20EA478", Offset = "0x20EA478", VA = "0x20EA478")] protected set
      {
      }
    }

    [Token(Token = "0x170048BF")]
    public bool IsOpenSubMenu
    {
      [Token(Token = "0x6015FFE"), Address(RVA = "0x20EA488", Offset = "0x20EA488", VA = "0x20EA488")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015FFF"), Address(RVA = "0x20EA490", Offset = "0x20EA490", VA = "0x20EA490")] private set
      {
      }
    }

    [Token(Token = "0x6016000")]
    [Address(RVA = "0x20EA49C", Offset = "0x20EA49C", VA = "0x20EA49C", Slot = "4")]
    public virtual void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016001")]
    [Address(RVA = "0x20EA58C", Offset = "0x20EA58C", VA = "0x20EA58C", Slot = "5")]
    public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016002")]
    [Address(RVA = "0x20EA61C", Offset = "0x20EA61C", VA = "0x20EA61C", Slot = "6")]
    public virtual void FinishInitialize()
    {
    }

    [Token(Token = "0x6016003")]
    [Address(RVA = "0x20EA620", Offset = "0x20EA620", VA = "0x20EA620", Slot = "7")]
    public virtual void OnBeforeBackScene(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016004")]
    [Address(RVA = "0x20EA624", Offset = "0x20EA624", VA = "0x20EA624", Slot = "8")]
    public virtual void Active(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016005")]
    [Address(RVA = "0x20EA628", Offset = "0x20EA628", VA = "0x20EA628", Slot = "9")]
    public virtual void InActive()
    {
    }

    [Token(Token = "0x6016006")]
    [Address(RVA = "0x20EA62C", Offset = "0x20EA62C", VA = "0x20EA62C", Slot = "10")]
    public virtual void OnClickGridButton()
    {
    }

    [Token(Token = "0x6016007")]
    [Address(RVA = "0x20EA630", Offset = "0x20EA630", VA = "0x20EA630", Slot = "11")]
    public virtual void OnClickBackKey()
    {
    }

    [Token(Token = "0x6016008")]
    [Address(RVA = "0x20EA634", Offset = "0x20EA634", VA = "0x20EA634", Slot = "12")]
    public virtual IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6016009")]
    [Address(RVA = "0x20EA6C4", Offset = "0x20EA6C4", VA = "0x20EA6C4", Slot = "13")]
    public virtual IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x601600A")]
    [Address(RVA = "0x20EA754", Offset = "0x20EA754", VA = "0x20EA754", Slot = "14")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x601600B")]
    [Address(RVA = "0x20EA758", Offset = "0x20EA758", VA = "0x20EA758")]
    public void CreateScreen(
      ArmouryScreenType type,
      AssetCachedSpawner spawner,
      Action<bool> homeButtonAction = null,
      Action<ArmouryScreenType, ArmouryChangeScreenParam> changeScreemAction = null)
    {
    }

    [Token(Token = "0x601600C")]
    [Address(RVA = "0x20EA768", Offset = "0x20EA768", VA = "0x20EA768")]
    public void SetTimeLineLastFrame()
    {
    }

    [Token(Token = "0x601600D")]
    [Address(RVA = "0x20EA7D4", Offset = "0x20EA7D4", VA = "0x20EA7D4")]
    public void SetHomeButtonAction()
    {
    }

    [Token(Token = "0x601600E")]
    [Address(RVA = "0x20EA7FC", Offset = "0x20EA7FC", VA = "0x20EA7FC")]
    protected void ChangeScreen(ArmouryScreenType type, ArmouryChangeScreenParam param)
    {
    }

    [Token(Token = "0x601600F")]
    [Address(RVA = "0x20EA818", Offset = "0x20EA818", VA = "0x20EA818")]
    protected void OpenSubMenu()
    {
    }

    [Token(Token = "0x6016010")]
    [Address(RVA = "0x20EA84C", Offset = "0x20EA84C", VA = "0x20EA84C")]
    protected void CloseSubMenu()
    {
    }

    [Token(Token = "0x6016011")]
    [Address(RVA = "0x20EA87C", Offset = "0x20EA87C", VA = "0x20EA87C")]
    protected SettingHorizontalInfiniteScrollViewProperty GetScrollPropety(
      HorizontalGridInfiniteScrollView scroll)
    {
      return new SettingHorizontalInfiniteScrollViewProperty();
    }

    [Token(Token = "0x6016012")]
    [Address(RVA = "0x20EA8BC", Offset = "0x20EA8BC", VA = "0x20EA8BC")]
    protected void ChangeSubScene(
      string assetBundleName,
      string assetName,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016013")]
    [Address(RVA = "0x20EA974", Offset = "0x20EA974", VA = "0x20EA974")]
    private bool CheckTimeLineEnd() => new bool();

    [Token(Token = "0x6016014")]
    [Address(RVA = "0x20EA990", Offset = "0x20EA990", VA = "0x20EA990")]
    protected ArmouryScreenBase()
    {
    }
  }
}
