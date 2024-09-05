// Decompiled with JetBrains decompiler
// Type: Story.Tracker.ITrackingTargetQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Tracker
{
  [Token(Token = "0x20005D2")]
  public interface ITrackingTargetQuest
  {
    [Token(Token = "0x170004B0")]
    int UniqueKey { [Token(Token = "0x60021A8")] get; }

    [Token(Token = "0x170004B1")]
    string Title { [Token(Token = "0x60021A9")] get; }

    [Token(Token = "0x170004B2")]
    bool Enable { [Token(Token = "0x60021AA")] get; }

    [Token(Token = "0x170004B3")]
    bool Completable { [Token(Token = "0x60021AB")] get; }

    [Token(Token = "0x170004B4")]
    bool Completed { [Token(Token = "0x60021AC")] get; }

    [Token(Token = "0x170004B5")]
    ITrackingTargetQuestTaskProgress[] Progresses { [Token(Token = "0x60021AD")] get; }

    [Token(Token = "0x170004B6")]
    ITrackingTargetQuestTaskProgress[] AllProgresses { [Token(Token = "0x60021AE")] get; }
  }
}
