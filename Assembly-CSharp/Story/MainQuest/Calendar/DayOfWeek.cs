// Decompiled with JetBrains decompiler
// Type: Story.MainQuest.Calendar.DayOfWeek
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.MainQuest.Calendar
{
  [Token(Token = "0x2000679")]
  public class DayOfWeek
  {
    [Token(Token = "0x1700056B")]
    public DayofweekEnum DayId
    {
      [Token(Token = "0x600250C"), Address(RVA = "0x2F35934", Offset = "0x2F35934", VA = "0x2F35934")] get
      {
        return new DayofweekEnum();
      }
    }

    [Token(Token = "0x600250D")]
    [Address(RVA = "0x2F3590C", Offset = "0x2F3590C", VA = "0x2F3590C")]
    public DayOfWeek(DayofweekEnum dayId)
    {
    }
  }
}
