// Decompiled with JetBrains decompiler
// Type: Story.Tracker.ITrackingTargetQuestTaskProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Tracker
{
  [Token(Token = "0x20005D3")]
  public interface ITrackingTargetQuestTaskProgress
  {
    [Token(Token = "0x170004B7")]
    int UniqueKey { [Token(Token = "0x60021AF")] get; }

    [Token(Token = "0x170004B8")]
    bool IsActive { [Token(Token = "0x60021B0")] get; }

    [Token(Token = "0x170004B9")]
    bool IsCompleted { [Token(Token = "0x60021B1")] get; }

    [Token(Token = "0x170004BA")]
    int Current { [Token(Token = "0x60021B2")] get; }

    [Token(Token = "0x170004BB")]
    int Max { [Token(Token = "0x60021B3")] get; }

    [Token(Token = "0x170004BC")]
    string Text { [Token(Token = "0x60021B4")] get; }
  }
}
