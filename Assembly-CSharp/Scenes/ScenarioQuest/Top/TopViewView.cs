// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.Top.TopViewView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.ScenarioQuest.UI.Top;
using System.Collections;

#nullable disable
namespace Scenes.ScenarioQuest.Top
{
  [Token(Token = "0x2002969")]
  public class TopViewView
  {
    [Token(Token = "0x400B06D")]
    [FieldOffset(Offset = "0x10")]
    private UITImelineControllerFacade timeline;
    [Token(Token = "0x400B06E")]
    [FieldOffset(Offset = "0x18")]
    private ScenarioQuestTopUI topUI;
    [Token(Token = "0x400B06F")]
    [FieldOffset(Offset = "0x20")]
    private BannerCache bannerCache;
    [Token(Token = "0x400B070")]
    [FieldOffset(Offset = "0x28")]
    private bool busy;

    [Token(Token = "0x601047D")]
    [Address(RVA = "0x47557E0", Offset = "0x47557E0", VA = "0x47557E0")]
    public TopViewView(
      UITImelineControllerFacade timeline,
      ScenarioQuestTopUI topUI,
      BannerCache bannerCache)
    {
    }

    [Token(Token = "0x601047E")]
    [Address(RVA = "0x4756694", Offset = "0x4756694", VA = "0x4756694")]
    public void SetPlayableDateTime(string text)
    {
    }

    [Token(Token = "0x601047F")]
    [Address(RVA = "0x47572F0", Offset = "0x47572F0", VA = "0x47572F0")]
    public bool IsBusy() => new bool();

    [Token(Token = "0x6010480")]
    [Address(RVA = "0x47572F8", Offset = "0x47572F8", VA = "0x47572F8")]
    public IEnumerator ChangeHide() => (IEnumerator) null;

    [Token(Token = "0x6010481")]
    [Address(RVA = "0x4757388", Offset = "0x4757388", VA = "0x4757388")]
    public IEnumerator ChangeShow() => (IEnumerator) null;

    [Token(Token = "0x6010482")]
    [Address(RVA = "0x47566B4", Offset = "0x47566B4", VA = "0x47566B4")]
    public void TopBanner(int bannerID)
    {
    }

    [Token(Token = "0x6010483")]
    [Address(RVA = "0x47567B8", Offset = "0x47567B8", VA = "0x47567B8")]
    public void SetUIButton(
      bool isFreeBattle,
      bool isSpecialBattle,
      bool isScoreAttack,
      bool isNewOpenFreeBattle,
      bool isNewOpenSpecialBattle,
      bool isNewOpenAttack,
      bool isActiveSpecial,
      bool isActiveScoreAttack)
    {
    }
  }
}
