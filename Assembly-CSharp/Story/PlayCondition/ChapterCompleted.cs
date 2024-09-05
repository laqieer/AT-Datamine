// Decompiled with JetBrains decompiler
// Type: Story.PlayCondition.ChapterCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.PlayCondition
{
  [Token(Token = "0x2000607")]
  public class ChapterCompleted : IStoryPlayCondition
  {
    [Token(Token = "0x4001DBA")]
    [FieldOffset(Offset = "0x10")]
    private int conditionChapaterID;

    [Token(Token = "0x60022F5")]
    [Address(RVA = "0x2DA2CEC", Offset = "0x2DA2CEC", VA = "0x2DA2CEC")]
    public ChapterCompleted(int conditionChapterID)
    {
    }

    [Token(Token = "0x60022F6")]
    [Address(RVA = "0x2DA2D14", Offset = "0x2DA2D14", VA = "0x2DA2D14", Slot = "4")]
    public bool IsPlayable() => new bool();

    [Token(Token = "0x60022F7")]
    [Address(RVA = "0x2DA2DD8", Offset = "0x2DA2DD8", VA = "0x2DA2DD8", Slot = "5")]
    public string Reason() => (string) null;
  }
}
