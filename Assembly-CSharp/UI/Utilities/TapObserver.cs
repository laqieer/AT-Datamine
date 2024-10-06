// Decompiled with JetBrains decompiler
// Type: UI.Utilities.TapObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UI.Utilities
{
  [Token(Token = "0x2000891")]
  public class TapObserver
  {
    [Token(Token = "0x4002857")]
    [FieldOffset(Offset = "0x10")]
    private bool executed;
    [Token(Token = "0x4002858")]
    [FieldOffset(Offset = "0x11")]
    private bool pointerDown;
    [Token(Token = "0x4002859")]
    [FieldOffset(Offset = "0x14")]
    private float downTime;
    [Token(Token = "0x400285A")]
    private const float longTapThreshold = 1f;
    [Token(Token = "0x400285B")]
    [FieldOffset(Offset = "0x18")]
    private TapObserver.IEventListener listener;

    [Token(Token = "0x60030FA")]
    [Address(RVA = "0x3C12C60", Offset = "0x3C12C60", VA = "0x3C12C60")]
    public void Register(TapObserver.IEventListener listener)
    {
    }

    [Token(Token = "0x60030FB")]
    [Address(RVA = "0x3C12C68", Offset = "0x3C12C68", VA = "0x3C12C68")]
    public void PointerDown()
    {
    }

    [Token(Token = "0x60030FC")]
    [Address(RVA = "0x3C12C8C", Offset = "0x3C12C8C", VA = "0x3C12C8C")]
    public void PointerUp(bool dragging)
    {
    }

    [Token(Token = "0x60030FD")]
    [Address(RVA = "0x3C12D4C", Offset = "0x3C12D4C", VA = "0x3C12D4C")]
    public void PointerExit()
    {
    }

    [Token(Token = "0x60030FE")]
    [Address(RVA = "0x3C12D6C", Offset = "0x3C12D6C", VA = "0x3C12D6C")]
    public void OnUpdate()
    {
    }

    [Token(Token = "0x60030FF")]
    [Address(RVA = "0x3C12DB4", Offset = "0x3C12DB4", VA = "0x3C12DB4")]
    private bool IsLongTap() => new bool();

    [Token(Token = "0x6003100")]
    [Address(RVA = "0x3C12DF8", Offset = "0x3C12DF8", VA = "0x3C12DF8")]
    private void OnLongTap()
    {
    }

    [Token(Token = "0x6003101")]
    [Address(RVA = "0x3C12D60", Offset = "0x3C12D60", VA = "0x3C12D60")]
    private void Executed()
    {
    }

    [Token(Token = "0x6003102")]
    [Address(RVA = "0x3C12D44", Offset = "0x3C12D44", VA = "0x3C12D44")]
    private void Clear()
    {
    }

    [Token(Token = "0x6003103")]
    [Address(RVA = "0x3C12EA8", Offset = "0x3C12EA8", VA = "0x3C12EA8")]
    public TapObserver()
    {
    }

    [Token(Token = "0x2000892")]
    public interface IEventListener
    {
      [Token(Token = "0x6003104")]
      void OnTap();

      [Token(Token = "0x6003105")]
      void OnLongTap();
    }
  }
}
