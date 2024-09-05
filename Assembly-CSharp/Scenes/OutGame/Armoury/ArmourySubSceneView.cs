// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmourySubSceneView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003800")]
  public class ArmourySubSceneView : MonoBehaviour
  {
    [Token(Token = "0x400F4A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton buttonBack;
    [Token(Token = "0x400F4A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GridChangeButton buttonGrid;
    [Token(Token = "0x400F4A4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SideMenu sideMenu;
    [Token(Token = "0x400F4A5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform transformScreenParent;
    [Token(Token = "0x400F4A6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private HomeButtonAnimationController homeButtonAnimationController;
    [Token(Token = "0x400F4A7")]
    [FieldOffset(Offset = "0x40")]
    private UITimelineController _timeline;
    [Token(Token = "0x400F4A8")]
    [FieldOffset(Offset = "0x48")]
    private ArmourySubSceneTimeLine _topTimeLine;
    [Token(Token = "0x400F4A9")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner _spawner;

    [Token(Token = "0x170048D8")]
    public Transform TransformScreenParent
    {
      [Token(Token = "0x601608D"), Address(RVA = "0x20ED334", Offset = "0x20ED334", VA = "0x20ED334")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170048D9")]
    public bool IsAvtiveGridButton
    {
      [Token(Token = "0x601608E"), Address(RVA = "0x20ECA20", Offset = "0x20ECA20", VA = "0x20ECA20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601608F")]
    [Address(RVA = "0x20EC090", Offset = "0x20EC090", VA = "0x20EC090")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016090")]
    [Address(RVA = "0x20EC130", Offset = "0x20EC130", VA = "0x20EC130")]
    public void InitializeSideMenu(ArmouryScreenType type, Action<ArmouryScreenType> action)
    {
    }

    [Token(Token = "0x6016091")]
    [Address(RVA = "0x20EC78C", Offset = "0x20EC78C", VA = "0x20EC78C")]
    public void ChangeSideMenu(ArmouryScreenType type)
    {
    }

    [Token(Token = "0x6016092")]
    [Address(RVA = "0x20ECBC0", Offset = "0x20ECBC0", VA = "0x20ECBC0")]
    public void UpdateSideMenu()
    {
    }

    [Token(Token = "0x6016093")]
    [Address(RVA = "0x20ECE00", Offset = "0x20ECE00", VA = "0x20ECE00")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016094")]
    [Address(RVA = "0x20EC7F8", Offset = "0x20EC7F8", VA = "0x20EC7F8")]
    public bool CheckInitialized() => new bool();

    [Token(Token = "0x6016095")]
    [Address(RVA = "0x20ECB9C", Offset = "0x20ECB9C", VA = "0x20ECB9C")]
    public void TimelineIn()
    {
    }

    [Token(Token = "0x6016096")]
    [Address(RVA = "0x20EC9FC", Offset = "0x20EC9FC", VA = "0x20EC9FC")]
    public void TimelineOut()
    {
    }

    [Token(Token = "0x6016097")]
    [Address(RVA = "0x20EC838", Offset = "0x20EC838", VA = "0x20EC838")]
    public bool CheckTimeLineEnd() => new bool();

    [Token(Token = "0x6016098")]
    [Address(RVA = "0x20EC148", Offset = "0x20EC148", VA = "0x20EC148")]
    public void SetBackButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x6016099")]
    [Address(RVA = "0x20EC574", Offset = "0x20EC574", VA = "0x20EC574")]
    public void GridButtonEnable(Action action)
    {
    }

    [Token(Token = "0x601609A")]
    [Address(RVA = "0x20ED544", Offset = "0x20ED544", VA = "0x20ED544")]
    public void SetGridButtonAction(Action action)
    {
    }

    [Token(Token = "0x601609B")]
    [Address(RVA = "0x20EC638", Offset = "0x20EC638", VA = "0x20EC638")]
    public void GridButtonDisable()
    {
    }

    [Token(Token = "0x601609C")]
    [Address(RVA = "0x20ED5C4", Offset = "0x20ED5C4", VA = "0x20ED5C4")]
    public void PlayHomeButtonAnimation(bool isOen)
    {
    }

    [Token(Token = "0x601609D")]
    [Address(RVA = "0x20ED60C", Offset = "0x20ED60C", VA = "0x20ED60C")]
    private void CreateSpawner()
    {
    }

    [Token(Token = "0x601609E")]
    [Address(RVA = "0x20ED698", Offset = "0x20ED698", VA = "0x20ED698")]
    public ArmourySubSceneView()
    {
    }
  }
}
