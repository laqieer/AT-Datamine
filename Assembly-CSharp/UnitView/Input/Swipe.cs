// Decompiled with JetBrains decompiler
// Type: UnitView.Input.Swipe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitView.Input
{
  [Token(Token = "0x20003FB")]
  public class Swipe : ISlideHandler
  {
    [Token(Token = "0x40016C2")]
    [FieldOffset(Offset = "0x10")]
    private Threshold threshold;

    [Token(Token = "0x60016DA")]
    [Address(RVA = "0x24893CC", Offset = "0x24893CC", VA = "0x24893CC")]
    public Swipe(Threshold threshold)
    {
    }

    [Token(Token = "0x60016DB")]
    [Address(RVA = "0x24893F4", Offset = "0x24893F4", VA = "0x24893F4", Slot = "4")]
    public bool Done(Slide.OutputData slideData) => new bool();
  }
}
