// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmourySubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x20037F7")]
  public class ArmourySubScene : SubScene
  {
    [Token(Token = "0x400F48A")]
    [FieldOffset(Offset = "0x58")]
    private ArmourySubSceneView _view;
    [Token(Token = "0x400F48B")]
    [FieldOffset(Offset = "0x60")]
    private ArmourySubSceneModel _model;
    [Token(Token = "0x400F48C")]
    [FieldOffset(Offset = "0x68")]
    private ArmouryScreenHandler _screenHandler;
    [Token(Token = "0x400F48D")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x400F48E")]
    [FieldOffset(Offset = "0x78")]
    private ArmourySubScene.Parameter _sceneParam;

    [Token(Token = "0x6016047")]
    [Address(RVA = "0x20EBB04", Offset = "0x20EBB04", VA = "0x20EBB04")]
    public static void ChangeSubScene(ArmouryScreenType type = ArmouryScreenType.Style)
    {
    }

    [Token(Token = "0x6016048")]
    [Address(RVA = "0x20EBC18", Offset = "0x20EBC18", VA = "0x20EBC18", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016049")]
    [Address(RVA = "0x20EC198", Offset = "0x20EC198", VA = "0x20EC198", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601604A")]
    [Address(RVA = "0x20EC228", Offset = "0x20EC228", VA = "0x20EC228", Slot = "23")]
    public override void FinishInitialize(ChangeSceneParameter param)
    {
    }

    [Token(Token = "0x601604B")]
    [Address(RVA = "0x20EC22C", Offset = "0x20EC22C", VA = "0x20EC22C", Slot = "24")]
    public override void OnBeforeBackScene()
    {
    }

    [Token(Token = "0x601604C")]
    [Address(RVA = "0x20EC2A4", Offset = "0x20EC2A4", VA = "0x20EC2A4", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x601604D")]
    [Address(RVA = "0x20EC334", Offset = "0x20EC334", VA = "0x20EC334", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x601604E")]
    [Address(RVA = "0x20EC3C4", Offset = "0x20EC3C4", VA = "0x20EC3C4", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x601604F")]
    [Address(RVA = "0x20EC454", Offset = "0x20EC454", VA = "0x20EC454", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016050")]
    [Address(RVA = "0x20EC538", Offset = "0x20EC538", VA = "0x20EC538")]
    public void SetBeforeBackSceneParam(ArmouryChangeScreenParam param)
    {
    }

    [Token(Token = "0x6016051")]
    [Address(RVA = "0x20EC554", Offset = "0x20EC554", VA = "0x20EC554")]
    private void EnableGridButton(Action action = null)
    {
    }

    [Token(Token = "0x6016052")]
    [Address(RVA = "0x20EC58C", Offset = "0x20EC58C", VA = "0x20EC58C")]
    private void SetGridButtonAction()
    {
    }

    [Token(Token = "0x6016053")]
    [Address(RVA = "0x20EC618", Offset = "0x20EC618", VA = "0x20EC618")]
    private void DisableGridButton()
    {
    }

    [Token(Token = "0x6016054")]
    [Address(RVA = "0x20EC650", Offset = "0x20EC650", VA = "0x20EC650")]
    private void OnClickSideMenu(ArmouryScreenType type, ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016055")]
    [Address(RVA = "0x20EC6A0", Offset = "0x20EC6A0", VA = "0x20EC6A0")]
    private void ChangeScreen(ArmouryScreenType type, ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016056")]
    [Address(RVA = "0x20EC750", Offset = "0x20EC750", VA = "0x20EC750")]
    private void ChangeScreenAndChangeSideMenu(
      ArmouryScreenType type,
      ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016057")]
    [Address(RVA = "0x20EC7B8", Offset = "0x20EC7B8", VA = "0x20EC7B8")]
    private void Back()
    {
    }

    [Token(Token = "0x6016058")]
    [Address(RVA = "0x20EC004", Offset = "0x20EC004", VA = "0x20EC004")]
    private void CreateSpawner()
    {
    }

    [Token(Token = "0x6016059")]
    [Address(RVA = "0x20EC7C4", Offset = "0x20EC7C4", VA = "0x20EC7C4")]
    public ArmourySubScene()
    {
    }

    [Token(Token = "0x20037F8")]
    public class Parameter : ChangeSceneParameter
    {
      [Token(Token = "0x170048CC")]
      public ArmouryScreenType Type
      {
        [Token(Token = "0x601605F"), Address(RVA = "0x20EC8D0", Offset = "0x20EC8D0", VA = "0x20EC8D0")] get
        {
          return new ArmouryScreenType();
        }
        [Token(Token = "0x6016060"), Address(RVA = "0x20EC8D8", Offset = "0x20EC8D8", VA = "0x20EC8D8")] private set
        {
        }
      }

      [Token(Token = "0x6016061")]
      [Address(RVA = "0x20EBBEC", Offset = "0x20EBBEC", VA = "0x20EBBEC")]
      public Parameter(ArmouryScreenType type)
      {
      }
    }
  }
}
