// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.OutGameMenuBelowScreenBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A21")]
  public class OutGameMenuBelowScreenBase : MonoBehaviour
  {
    [Token(Token = "0x400FE7D")]
    [FieldOffset(Offset = "0x18")]
    public bool isDirection;
    [Token(Token = "0x400FE7E")]
    [FieldOffset(Offset = "0x19")]
    public bool isOperationPossible;
    [Token(Token = "0x400FE7F")]
    [FieldOffset(Offset = "0x20")]
    public OutGameMenuOperationPossible operationPossibleEvent;
    [Token(Token = "0x400FE80")]
    [FieldOffset(Offset = "0x28")]
    public OutGameMenuOnBackScene onBackSceneEvent;
    [Token(Token = "0x400FE81")]
    [FieldOffset(Offset = "0x30")]
    public OutGameMenuBelowScreenHandler belowScreenHandler;
    [Token(Token = "0x400FE82")]
    public const float ScreenBaseSizeW = 1335f;
    [Token(Token = "0x400FE83")]
    [FieldOffset(Offset = "0x38")]
    public float screenDiff;
    [Token(Token = "0x400FE84")]
    [FieldOffset(Offset = "0x40")]
    private Canvas canvas;

    [Token(Token = "0x6016D80")]
    [Address(RVA = "0x2C59E24", Offset = "0x2C59E24", VA = "0x2C59E24")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016D81")]
    [Address(RVA = "0x2C59E74", Offset = "0x2C59E74", VA = "0x2C59E74", Slot = "4")]
    public virtual void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6016D82")]
    [Address(RVA = "0x2C59E78", Offset = "0x2C59E78", VA = "0x2C59E78", Slot = "5")]
    public virtual IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016D83")]
    [Address(RVA = "0x2C59F00", Offset = "0x2C59F00", VA = "0x2C59F00", Slot = "6")]
    public virtual void Destroy()
    {
    }

    [Token(Token = "0x6016D84")]
    [Address(RVA = "0x2C59F04", Offset = "0x2C59F04", VA = "0x2C59F04", Slot = "7")]
    public virtual void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6016D85")]
    [Address(RVA = "0x2C59F08", Offset = "0x2C59F08", VA = "0x2C59F08", Slot = "8")]
    public virtual void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6016D86")]
    [Address(RVA = "0x2C59F0C", Offset = "0x2C59F0C", VA = "0x2C59F0C", Slot = "9")]
    public virtual void OnBackSubScene()
    {
    }

    [Token(Token = "0x6016D87")]
    [Address(RVA = "0x2C59F10", Offset = "0x2C59F10", VA = "0x2C59F10")]
    public void SetBelowScreenHandler(OutGameMenuBelowScreenHandler handler)
    {
    }

    [Token(Token = "0x6016D88")]
    [Address(RVA = "0x2C59F18", Offset = "0x2C59F18", VA = "0x2C59F18", Slot = "10")]
    public virtual void SetBackSpace()
    {
    }

    [Token(Token = "0x6016D89")]
    public bool DownCast<T>(
      ChangeBelowScreenParameter changeBelowScreenParameter,
      out T derivedParameter)
      where T : ChangeBelowScreenParameter
    {
      return new bool();
    }

    [Token(Token = "0x6016D8A")]
    [Address(RVA = "0x2C59F1C", Offset = "0x2C59F1C", VA = "0x2C59F1C")]
    public void SetCanvasEnabled(bool isEnabled)
    {
    }

    [Token(Token = "0x6016D8B")]
    [Address(RVA = "0x2C59FB0", Offset = "0x2C59FB0", VA = "0x2C59FB0")]
    public OutGameMenuSubScene GetOutGameMenuSubScene() => (OutGameMenuSubScene) null;

    [Token(Token = "0x6016D8C")]
    [Address(RVA = "0x2C59FF8", Offset = "0x2C59FF8", VA = "0x2C59FF8")]
    public OutGameMenuBelowScreenBase()
    {
    }
  }
}
