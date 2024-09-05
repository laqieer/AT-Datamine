// Decompiled with JetBrains decompiler
// Type: Story.ContentTutorialBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x200055A")]
  public sealed class ContentTutorialBattle : Content
  {
    [Token(Token = "0x4001BD4")]
    [FieldOffset(Offset = "0x20")]
    private ITutorialBattleDirection direction;

    [Token(Token = "0x6001EF4")]
    [Address(RVA = "0x2A01308", Offset = "0x2A01308", VA = "0x2A01308")]
    public ContentTutorialBattle(ITutorialBattleDirection direction)
    {
    }

    [Token(Token = "0x6001EF5")]
    [Address(RVA = "0x2A01330", Offset = "0x2A01330", VA = "0x2A01330", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001EF6")]
    [Address(RVA = "0x2A01444", Offset = "0x2A01444", VA = "0x2A01444")]
    private IEnumerator BattleStartSequence() => (IEnumerator) null;
  }
}
