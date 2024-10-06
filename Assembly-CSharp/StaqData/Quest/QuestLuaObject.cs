// Decompiled with JetBrains decompiler
// Type: StaqData.Quest.QuestLuaObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.Quest
{
  [Token(Token = "0x2002150")]
  public class QuestLuaObject
  {
    [Token(Token = "0x4008D3B")]
    [FieldOffset(Offset = "0x20")]
    public ProgressLuaObject[] Progress;
    [Token(Token = "0x4008D3C")]
    [FieldOffset(Offset = "0x28")]
    public RewardLuaObject[] Rewards;

    [Token(Token = "0x17002CA7")]
    public string QuestName
    {
      [Token(Token = "0x600CC12"), Address(RVA = "0x1BABDAC", Offset = "0x1BABDAC", VA = "0x1BABDAC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CC13"), Address(RVA = "0x1BABDB4", Offset = "0x1BABDB4", VA = "0x1BABDB4")] set
      {
      }
    }

    [Token(Token = "0x17002CA8")]
    public string Description
    {
      [Token(Token = "0x600CC14"), Address(RVA = "0x1BABDBC", Offset = "0x1BABDBC", VA = "0x1BABDBC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CC15"), Address(RVA = "0x1BABDC4", Offset = "0x1BABDC4", VA = "0x1BABDC4")] set
      {
      }
    }

    [Token(Token = "0x600CC16")]
    [Address(RVA = "0x1BAB3E0", Offset = "0x1BAB3E0", VA = "0x1BAB3E0")]
    public QuestLuaObject()
    {
    }
  }
}
