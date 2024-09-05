// Decompiled with JetBrains decompiler
// Type: Battle.Unit.VfxFlagContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E2")]
  public struct VfxFlagContainer
  {
    [Token(Token = "0x400937A")]
    [FieldOffset(Offset = "0x0")]
    public bool badStatus;
    [Token(Token = "0x400937B")]
    [FieldOffset(Offset = "0x1")]
    public bool positive;
    [Token(Token = "0x400937C")]
    [FieldOffset(Offset = "0x2")]
    public bool negative;

    [Token(Token = "0x600D4F0")]
    [Address(RVA = "0x19E8E90", Offset = "0x19E8E90", VA = "0x19E8E90")]
    public void Mark(VfxFlagContainer container)
    {
    }

    [Token(Token = "0x600D4F1")]
    [Address(RVA = "0x19E8EC8", Offset = "0x19E8EC8", VA = "0x19E8EC8")]
    public void UnMark()
    {
    }
  }
}
