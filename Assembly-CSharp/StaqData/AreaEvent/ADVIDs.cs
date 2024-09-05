// Decompiled with JetBrains decompiler
// Type: StaqData.AreaEvent.ADVIDs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData.AreaEvent
{
  [Token(Token = "0x200215B")]
  public class ADVIDs
  {
    [Token(Token = "0x17002CC8")]
    public int Receipt
    {
      [Token(Token = "0x600CC71"), Address(RVA = "0x1BAFB68", Offset = "0x1BAFB68", VA = "0x1BAFB68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CC9")]
    public int Progress
    {
      [Token(Token = "0x600CC72"), Address(RVA = "0x1BAFB70", Offset = "0x1BAFB70", VA = "0x1BAFB70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600CC73")]
    [Address(RVA = "0x1BACA78", Offset = "0x1BACA78", VA = "0x1BACA78")]
    public ADVIDs(IEnumerable<StoryAreaEventQuestTaskData> tasks)
    {
    }
  }
}
