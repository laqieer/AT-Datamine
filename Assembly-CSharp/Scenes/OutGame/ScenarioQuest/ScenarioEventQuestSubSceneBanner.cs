// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.ScenarioEventQuestSubSceneBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest
{
  [Token(Token = "0x20034E2")]
  public class ScenarioEventQuestSubSceneBanner : MonoBehaviour
  {
    [Token(Token = "0x400E61E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400E61F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RawImage banner;
    [Token(Token = "0x400E620")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextContainer endAtText;
    [Token(Token = "0x400E621")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject newMark;
    [Token(Token = "0x400E622")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400E623")]
    [FieldOffset(Offset = "0x40")]
    private StoryScenarioQuestData _questData;

    [Token(Token = "0x6014BE5")]
    [Address(RVA = "0x1D71998", Offset = "0x1D71998", VA = "0x1D71998")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014BE6")]
    [Address(RVA = "0x1D71A3C", Offset = "0x1D71A3C", VA = "0x1D71A3C")]
    public void Initialize(StoryScenarioQuestData data, Texture2D tex)
    {
    }

    [Token(Token = "0x6014BE7")]
    [Address(RVA = "0x1D71C40", Offset = "0x1D71C40", VA = "0x1D71C40")]
    public void SetNewBadge()
    {
    }

    [Token(Token = "0x6014BE8")]
    [Address(RVA = "0x1D71D58", Offset = "0x1D71D58", VA = "0x1D71D58")]
    public void SetNewMarkActive(bool isActive)
    {
    }

    [Token(Token = "0x6014BE9")]
    [Address(RVA = "0x1D71D78", Offset = "0x1D71D78", VA = "0x1D71D78")]
    private void ChangeScenarioTopScene()
    {
    }

    [Token(Token = "0x6014BEA")]
    [Address(RVA = "0x1D71D38", Offset = "0x1D71D38", VA = "0x1D71D38")]
    public void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x6014BEB")]
    [Address(RVA = "0x1D71D9C", Offset = "0x1D71D9C", VA = "0x1D71D9C")]
    public ScenarioEventQuestSubSceneBanner()
    {
    }
  }
}
