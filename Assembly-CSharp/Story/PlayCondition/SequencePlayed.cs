// Decompiled with JetBrains decompiler
// Type: Story.PlayCondition.SequencePlayed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.PlayCondition
{
  [Token(Token = "0x200060C")]
  public class SequencePlayed : IStoryPlayCondition
  {
    [Token(Token = "0x4001DBD")]
    [FieldOffset(Offset = "0x10")]
    private int conditionChapaterID;
    [Token(Token = "0x4001DBE")]
    [FieldOffset(Offset = "0x14")]
    private int conditionSequenceID;

    [Token(Token = "0x6002301")]
    [Address(RVA = "0x2DA3018", Offset = "0x2DA3018", VA = "0x2DA3018")]
    public SequencePlayed(int conditionChapterID, int conditionSequenceID)
    {
    }

    [Token(Token = "0x6002302")]
    [Address(RVA = "0x2DA316C", Offset = "0x2DA316C", VA = "0x2DA316C", Slot = "4")]
    public bool IsPlayable() => new bool();

    [Token(Token = "0x6002303")]
    [Address(RVA = "0x2DA323C", Offset = "0x2DA323C", VA = "0x2DA323C", Slot = "5")]
    public string Reason() => (string) null;
  }
}
