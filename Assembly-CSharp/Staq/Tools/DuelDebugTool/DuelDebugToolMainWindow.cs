// Decompiled with JetBrains decompiler
// Type: Staq.Tools.DuelDebugTool.DuelDebugToolMainWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UIElements;

#nullable disable
namespace Staq.Tools.DuelDebugTool
{
  [Token(Token = "0x2000988")]
  public class DuelDebugToolMainWindow : MonoBehaviour
  {
    [Token(Token = "0x4002C53")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VisualTreeAsset leftPanelTemplate;
    [Token(Token = "0x4002C54")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private VisualTreeAsset environmentPanelTemplate;
    [Token(Token = "0x4002C55")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private VisualTreeAsset actorPanelTemplate;
    [Token(Token = "0x4002C56")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private VisualTreeAsset actionPanelTemplate;
    [Token(Token = "0x4002C57")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private VisualTreeAsset turnButtonTemplate;
    [Token(Token = "0x4002C58")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private DuelManager duelManager;
    [Token(Token = "0x4002C59")]
    [FieldOffset(Offset = "0x48")]
    private UIDocument _uiDocument;
    [Token(Token = "0x4002C5A")]
    [FieldOffset(Offset = "0x50")]
    private DuelDebugToolController _controller;
    [Token(Token = "0x4002C5B")]
    [FieldOffset(Offset = "0x58")]
    private bool isInitialized;

    [Token(Token = "0x600362E")]
    [Address(RVA = "0x353413C", Offset = "0x353413C", VA = "0x353413C")]
    public void Start()
    {
    }

    [Token(Token = "0x600362F")]
    [Address(RVA = "0x353426C", Offset = "0x353426C", VA = "0x353426C")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x6003630")]
    [Address(RVA = "0x3534374", Offset = "0x3534374", VA = "0x3534374")]
    public void PressInitialize()
    {
    }

    [Token(Token = "0x6003631")]
    [Address(RVA = "0x35343A8", Offset = "0x35343A8", VA = "0x35343A8")]
    public void PressPlay()
    {
    }

    [Token(Token = "0x6003632")]
    [Address(RVA = "0x35343DC", Offset = "0x35343DC", VA = "0x35343DC")]
    public void PressClear()
    {
    }

    [Token(Token = "0x6003633")]
    [Address(RVA = "0x3534414", Offset = "0x3534414", VA = "0x3534414")]
    public DuelDebugToolMainWindow()
    {
    }
  }
}
