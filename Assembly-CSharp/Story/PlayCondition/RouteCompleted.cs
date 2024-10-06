// Decompiled with JetBrains decompiler
// Type: Story.PlayCondition.RouteCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.PlayCondition
{
  [Token(Token = "0x200060B")]
  public class RouteCompleted : IStoryPlayCondition
  {
    [Token(Token = "0x4001DBB")]
    [FieldOffset(Offset = "0x10")]
    private int conditionChapterID;
    [Token(Token = "0x4001DBC")]
    [FieldOffset(Offset = "0x14")]
    private int conditionRouteID;

    [Token(Token = "0x60022FE")]
    [Address(RVA = "0x2DA2FEC", Offset = "0x2DA2FEC", VA = "0x2DA2FEC")]
    public RouteCompleted(int conditionChapterID, int conditionRouteID)
    {
    }

    [Token(Token = "0x60022FF")]
    [Address(RVA = "0x2DA3044", Offset = "0x2DA3044", VA = "0x2DA3044", Slot = "4")]
    public bool IsPlayable() => new bool();

    [Token(Token = "0x6002300")]
    [Address(RVA = "0x2DA30C4", Offset = "0x2DA30C4", VA = "0x2DA30C4", Slot = "5")]
    public string Reason() => (string) null;
  }
}
