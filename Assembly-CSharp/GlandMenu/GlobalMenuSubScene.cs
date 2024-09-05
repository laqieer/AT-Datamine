// Decompiled with JetBrains decompiler
// Type: GlandMenu.GlobalMenuSubScene
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
using UnityEngine.UI;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x200095E")]
  public class GlobalMenuSubScene : SubScene
  {
    [Token(Token = "0x4002B7C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4002B7D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitImageFullLoader unitImageLoader;
    [Token(Token = "0x4002B7E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private RawImage blurImage;
    [Token(Token = "0x4002B7F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x4002B80")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GlobalMenuButtonGroup buttonGroup;
    [Token(Token = "0x4002B81")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ContentLockController contentLockController;
    [Token(Token = "0x4002B82")]
    [FieldOffset(Offset = "0x88")]
    private GlobalMenuSubScene.SubSceneParam subSceneParam;

    [Token(Token = "0x60034F5")]
    [Address(RVA = "0x3637774", Offset = "0x3637774", VA = "0x3637774", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60034F6")]
    [Address(RVA = "0x36379C0", Offset = "0x36379C0", VA = "0x36379C0", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60034F7")]
    [Address(RVA = "0x3637A50", Offset = "0x3637A50", VA = "0x3637A50", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60034F8")]
    [Address(RVA = "0x3637B9C", Offset = "0x3637B9C", VA = "0x3637B9C", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60034F9")]
    [Address(RVA = "0x3637C2C", Offset = "0x3637C2C", VA = "0x3637C2C", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x60034FA")]
    [Address(RVA = "0x3637CBC", Offset = "0x3637CBC", VA = "0x3637CBC", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60034FB")]
    [Address(RVA = "0x3637D70", Offset = "0x3637D70", VA = "0x3637D70")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x60034FC")]
    [Address(RVA = "0x3637CC0", Offset = "0x3637CC0", VA = "0x3637CC0")]
    private void OnBack()
    {
    }

    [Token(Token = "0x60034FD")]
    [Address(RVA = "0x36378B4", Offset = "0x36378B4", VA = "0x36378B4")]
    private void UpdateData()
    {
    }

    [Token(Token = "0x60034FE")]
    [Address(RVA = "0x3637AD0", Offset = "0x3637AD0", VA = "0x3637AD0")]
    private void PlayInAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x60034FF")]
    [Address(RVA = "0x3637D7C", Offset = "0x3637D7C", VA = "0x3637D7C")]
    private void PlayOutAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x6003500")]
    [Address(RVA = "0x3637DA0", Offset = "0x3637DA0", VA = "0x3637DA0")]
    public GlobalMenuSubScene()
    {
    }

    [Token(Token = "0x200095F")]
    public class SubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x4002B83")]
      [FieldOffset(Offset = "0x18")]
      public Action OnFinish;
      [Token(Token = "0x4002B84")]
      [FieldOffset(Offset = "0x20")]
      public RenderTexture renderTexture;

      [Token(Token = "0x6003503")]
      [Address(RVA = "0x3635850", Offset = "0x3635850", VA = "0x3635850")]
      public SubSceneParam(Action onFinish = null)
      {
      }

      [Token(Token = "0x6003504")]
      [Address(RVA = "0x3637C3C", Offset = "0x3637C3C", VA = "0x3637C3C")]
      public void Release()
      {
      }

      [Token(Token = "0x6003505")]
      [Address(RVA = "0x3637E3C", Offset = "0x3637E3C", VA = "0x3637E3C")]
      private void OnCaptureComplete(RenderTexture texture)
      {
      }
    }
  }
}
