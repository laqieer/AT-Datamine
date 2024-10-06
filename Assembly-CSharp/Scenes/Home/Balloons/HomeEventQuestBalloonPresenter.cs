// Decompiled with JetBrains decompiler
// Type: Scenes.Home.Balloons.HomeEventQuestBalloonPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.RawData;
using Home;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Home.Balloons
{
  [Token(Token = "0x2002B69")]
  public class HomeEventQuestBalloonPresenter : MonoBehaviour
  {
    [Token(Token = "0x400B8E1")]
    [FieldOffset(Offset = "0x18")]
    [Header("吹き出しのView")]
    [SerializeField]
    private HomeEventQuestBalloonView homeBalloonView;
    [Token(Token = "0x400B8E2")]
    [FieldOffset(Offset = "0x20")]
    [Header("吹き出しのCanvasGroup")]
    [SerializeField]
    private CanvasGroup balloonCanvasGroup;
    [Token(Token = "0x400B8E3")]
    [FieldOffset(Offset = "0x28")]
    private HomeEventQuestBalloonModel model;
    [Token(Token = "0x400B8E4")]
    [FieldOffset(Offset = "0x30")]
    private RawTextureManager textureManager;
    [Token(Token = "0x400B8E5")]
    [FieldOffset(Offset = "0x38")]
    private HomeTransitionContoller transitionContoller;
    [Token(Token = "0x400B8E6")]
    [FieldOffset(Offset = "0x40")]
    private bool nowTransition;

    [Token(Token = "0x6010F71")]
    [Address(RVA = "0x1C71E3C", Offset = "0x1C71E3C", VA = "0x1C71E3C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6010F72")]
    [Address(RVA = "0x1C71F84", Offset = "0x1C71F84", VA = "0x1C71F84")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010F73")]
    [Address(RVA = "0x1C71FA0", Offset = "0x1C71FA0", VA = "0x1C71FA0")]
    public IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x6010F74")]
    [Address(RVA = "0x1C72030", Offset = "0x1C72030", VA = "0x1C72030")]
    private void ViewSetup(Texture2D texture)
    {
    }

    [Token(Token = "0x6010F75")]
    [Address(RVA = "0x1C72118", Offset = "0x1C72118", VA = "0x1C72118")]
    private void OnBannerClick()
    {
    }

    [Token(Token = "0x6010F76")]
    [Address(RVA = "0x1C72260", Offset = "0x1C72260", VA = "0x1C72260")]
    private void OnSwitchShowBanner()
    {
    }

    [Token(Token = "0x6010F77")]
    [Address(RVA = "0x1C72178", Offset = "0x1C72178", VA = "0x1C72178")]
    private void SceneTransitionToScenarioEventQuest()
    {
    }

    [Token(Token = "0x6010F78")]
    [Address(RVA = "0x1C721F8", Offset = "0x1C721F8", VA = "0x1C721F8")]
    private void SceneTransitionToLimitedEventQuestStageSelect()
    {
    }

    [Token(Token = "0x6010F79")]
    [Address(RVA = "0x1C720F8", Offset = "0x1C720F8", VA = "0x1C720F8")]
    private void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6010F7A")]
    [Address(RVA = "0x1C724A8", Offset = "0x1C724A8", VA = "0x1C724A8")]
    private string GetRawDataURL(string imageName) => (string) null;

    [Token(Token = "0x6010F7B")]
    [Address(RVA = "0x1C7251C", Offset = "0x1C7251C", VA = "0x1C7251C")]
    public HomeEventQuestBalloonPresenter()
    {
    }
  }
}
