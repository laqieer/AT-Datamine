// Decompiled with JetBrains decompiler
// Type: UnitView.Input.Flick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitView.Input
{
  [Token(Token = "0x20003F4")]
  public class Flick : ISlideHandler
  {
    [Token(Token = "0x40016B7")]
    [FieldOffset(Offset = "0x10")]
    private Threshold threshold;

    [Token(Token = "0x60016BB")]
    [Address(RVA = "0x2488D1C", Offset = "0x2488D1C", VA = "0x2488D1C")]
    public Flick(Threshold threshold)
    {
    }

    [Token(Token = "0x60016BC")]
    [Address(RVA = "0x2488D44", Offset = "0x2488D44", VA = "0x2488D44", Slot = "4")]
    public bool Done(Slide.OutputData slideData) => new bool();
  }
}
