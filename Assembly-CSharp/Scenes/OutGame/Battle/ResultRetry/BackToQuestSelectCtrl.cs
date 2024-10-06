// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.BackToQuestSelectCtrl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037BD")]
  public class BackToQuestSelectCtrl
  {
    [Token(Token = "0x400F3AA")]
    [FieldOffset(Offset = "0x18")]
    private QuestInfo _questInfo;

    [Token(Token = "0x6015F02")]
    [Address(RVA = "0x232A4B8", Offset = "0x232A4B8", VA = "0x232A4B8")]
    public BackToQuestSelectCtrl(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x1700488C")]
    public bool Executable
    {
      [Token(Token = "0x6015F03"), Address(RVA = "0x232A4E8", Offset = "0x232A4E8", VA = "0x232A4E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015F04"), Address(RVA = "0x232A4F0", Offset = "0x232A4F0", VA = "0x232A4F0")] private set
      {
      }
    }

    [Token(Token = "0x1700488D")]
    public bool OccupancyProcessing
    {
      [Token(Token = "0x6015F05"), Address(RVA = "0x232A4FC", Offset = "0x232A4FC", VA = "0x232A4FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015F06")]
    [Address(RVA = "0x232A50C", Offset = "0x232A50C", VA = "0x232A50C")]
    public void Exec()
    {
    }
  }
}
