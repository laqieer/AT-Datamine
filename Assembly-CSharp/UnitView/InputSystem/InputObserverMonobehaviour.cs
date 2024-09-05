// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputObserverMonobehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003EF")]
  public class InputObserverMonobehaviour : MonoBehaviour
  {
    [Token(Token = "0x40016AB")]
    [FieldOffset(Offset = "0x18")]
    private InputEvent inputEvent;
    [Token(Token = "0x40016AC")]
    [FieldOffset(Offset = "0x20")]
    private IInputEventHandler eventHandler;

    [Token(Token = "0x60016AE")]
    [Address(RVA = "0x24885DC", Offset = "0x24885DC", VA = "0x24885DC")]
    public void Initialize(IInputEventHandler eventHandler)
    {
    }

    [Token(Token = "0x60016AF")]
    [Address(RVA = "0x24885E4", Offset = "0x24885E4", VA = "0x24885E4")]
    private void Awake()
    {
    }

    [Token(Token = "0x60016B0")]
    [Address(RVA = "0x24885FC", Offset = "0x24885FC", VA = "0x24885FC")]
    private void Update()
    {
    }

    [Token(Token = "0x60016B1")]
    [Address(RVA = "0x2488874", Offset = "0x2488874", VA = "0x2488874")]
    private void EventObserve(InputEventDataEditable eventData)
    {
    }

    [Token(Token = "0x60016B2")]
    [Address(RVA = "0x2488CF8", Offset = "0x2488CF8", VA = "0x2488CF8")]
    public InputObserverMonobehaviour()
    {
    }
  }
}
