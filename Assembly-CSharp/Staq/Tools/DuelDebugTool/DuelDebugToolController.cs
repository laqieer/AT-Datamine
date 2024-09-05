// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugToolController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000986")]
  public class DuelDebugToolController
  {
    [Token(Token = "0x4002C46")]
    [FieldOffset(Offset = "0x10")]
    private readonly GroupBox _mainGroup;
    [Token(Token = "0x4002C47")]
    [FieldOffset(Offset = "0x18")]
    private readonly VisualElement _leftPanelInstance;
    [Token(Token = "0x4002C48")]
    [FieldOffset(Offset = "0x20")]
    private readonly VisualElement _environmentPanelInstance;
    [Token(Token = "0x4002C49")]
    [FieldOffset(Offset = "0x28")]
    private readonly VisualElement _actorPanelInstance;
    [Token(Token = "0x4002C4A")]
    [FieldOffset(Offset = "0x30")]
    private readonly VisualElement _actionPanelInstance;
    [Token(Token = "0x4002C4B")]
    [FieldOffset(Offset = "0x38")]
    private readonly LeftPanelController _leftPanelController;
    [Token(Token = "0x4002C4C")]
    [FieldOffset(Offset = "0x40")]
    private readonly EnvironmentPanelController _environmentPanelController;
    [Token(Token = "0x4002C4D")]
    [FieldOffset(Offset = "0x48")]
    private readonly ActorPanelController _actorPanelController;
    [Token(Token = "0x4002C4E")]
    [FieldOffset(Offset = "0x50")]
    private readonly ActionPanelController _actionPanelController;
    [Token(Token = "0x4002C4F")]
    [FieldOffset(Offset = "0x58")]
    private readonly DuelManager _duelManager;
    [Token(Token = "0x4002C50")]
    [FieldOffset(Offset = "0x60")]
    private readonly DuelDebugDataContainer _dataContainer;

    [Token(Token = "0x600361D")]
    [Address(RVA = "0x3531C90", Offset = "0x3531C90", VA = "0x3531C90")]
    public DuelDebugToolController(
      DuelManager duelManager,
      VisualElement root,
      VisualTreeAsset leftPanelTemplate,
      VisualTreeAsset environmentPanelTemplate,
      VisualTreeAsset actorPanelTemplate,
      VisualTreeAsset actionPanelTemplate,
      VisualTreeAsset turnButtonTemplate)
    {
    }

    [Token(Token = "0x600361E")]
    [Address(RVA = "0x3532FBC", Offset = "0x3532FBC", VA = "0x3532FBC")]
    public void Show()
    {
    }

    [Token(Token = "0x600361F")]
    [Address(RVA = "0x35330F8", Offset = "0x35330F8", VA = "0x35330F8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6003620")]
    [Address(RVA = "0x3533158", Offset = "0x3533158", VA = "0x3533158")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6003621")]
    [Address(RVA = "0x3533190", Offset = "0x3533190", VA = "0x3533190")]
    public void Play()
    {
    }

    [Token(Token = "0x6003622")]
    [Address(RVA = "0x35331AC", Offset = "0x35331AC", VA = "0x35331AC")]
    public void Clear()
    {
    }
  }
}
