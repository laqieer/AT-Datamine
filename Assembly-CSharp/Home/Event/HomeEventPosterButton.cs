// Decompiled with JetBrains decompiler
// Type: Home.Event.HomeEventPosterButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace Home.Event
{
  [Token(Token = "0x2000B69")]
  internal class HomeEventPosterButton : MonoBehaviour
  {
    [Token(Token = "0x4003407")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4003408")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI buttonText;
    [Token(Token = "0x4003409")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400340A")]
    [FieldOffset(Offset = "0x30")]
    private HomeEventPosterUI posterUI;
    [Token(Token = "0x400340B")]
    [FieldOffset(Offset = "0x38")]
    private EventButtonData master;
    [Token(Token = "0x400340C")]
    [FieldOffset(Offset = "0x40")]
    private bool outOfTerm;

    [Token(Token = "0x60040E2")]
    [Address(RVA = "0x2A2A608", Offset = "0x2A2A608", VA = "0x2A2A608")]
    public void Initialize(
      int eventButtonId,
      AssetCachedSpawner assetCachedSpawner,
      HomeEventPosterUI posterUI)
    {
    }

    [Token(Token = "0x60040E3")]
    [Address(RVA = "0x2A2A868", Offset = "0x2A2A868", VA = "0x2A2A868")]
    private void OnClickAction()
    {
    }

    [Token(Token = "0x60040E4")]
    [Address(RVA = "0x2A2AAB8", Offset = "0x2A2AAB8", VA = "0x2A2AAB8")]
    private void DivideOnClickAction()
    {
    }

    [Token(Token = "0x60040E5")]
    [Address(RVA = "0x2A2AB50", Offset = "0x2A2AB50", VA = "0x2A2AB50")]
    private void ConfirmPlayVideo()
    {
    }

    [Token(Token = "0x60040E6")]
    [Address(RVA = "0x2A2BE90", Offset = "0x2A2BE90", VA = "0x2A2BE90")]
    private IEnumerator PlayMovie() => (IEnumerator) null;

    [Token(Token = "0x60040E7")]
    [Address(RVA = "0x2A2BF20", Offset = "0x2A2BF20", VA = "0x2A2BF20")]
    private void PlayAdv()
    {
    }

    [Token(Token = "0x60040E8")]
    [Address(RVA = "0x2A2AE94", Offset = "0x2A2AE94", VA = "0x2A2AE94")]
    private void PlayTutorial()
    {
    }

    [Token(Token = "0x60040E9")]
    [Address(RVA = "0x2A2AFC0", Offset = "0x2A2AFC0", VA = "0x2A2AFC0")]
    private void TransitionScenarioEvent()
    {
    }

    [Token(Token = "0x60040EA")]
    [Address(RVA = "0x2A2B240", Offset = "0x2A2B240", VA = "0x2A2B240")]
    private void TransitionLimitedEvent()
    {
    }

    [Token(Token = "0x60040EB")]
    [Address(RVA = "0x2A2B524", Offset = "0x2A2B524", VA = "0x2A2B524")]
    private void TransitionExternalSite()
    {
    }

    [Token(Token = "0x60040EC")]
    [Address(RVA = "0x2A2BAB8", Offset = "0x2A2BAB8", VA = "0x2A2BAB8")]
    private void TransitionAreaQuestTop()
    {
    }

    [Token(Token = "0x60040ED")]
    [Address(RVA = "0x2A2B600", Offset = "0x2A2B600", VA = "0x2A2B600")]
    private void ShowInformation()
    {
    }

    [Token(Token = "0x60040EE")]
    [Address(RVA = "0x2A2BD38", Offset = "0x2A2BD38", VA = "0x2A2BD38")]
    private void TransitionGuild()
    {
    }

    [Token(Token = "0x60040EF")]
    [Address(RVA = "0x2A2C158", Offset = "0x2A2C158", VA = "0x2A2C158")]
    public HomeEventPosterButton()
    {
    }
  }
}
