// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Data.GuildAttendInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;

#nullable disable
namespace Scenes.Guild.Data
{
  [Token(Token = "0x2002C16")]
  public class GuildAttendInfo
  {
    [Token(Token = "0x17003B58")]
    public int YesterdayAttendCount
    {
      [Token(Token = "0x6011391"), Address(RVA = "0x4A185F4", Offset = "0x4A185F4", VA = "0x4A185F4")] get
      {
        return new int();
      }
      [Token(Token = "0x6011392"), Address(RVA = "0x4A185FC", Offset = "0x4A185FC", VA = "0x4A185FC")] private set
      {
      }
    }

    [Token(Token = "0x17003B59")]
    public int TodayAttendCount
    {
      [Token(Token = "0x6011393"), Address(RVA = "0x4A18604", Offset = "0x4A18604", VA = "0x4A18604")] get
      {
        return new int();
      }
      [Token(Token = "0x6011394"), Address(RVA = "0x4A1860C", Offset = "0x4A1860C", VA = "0x4A1860C")] private set
      {
      }
    }

    [Token(Token = "0x6011395")]
    [Address(RVA = "0x4A18614", Offset = "0x4A18614", VA = "0x4A18614")]
    public void Apply(APIGuildAttendResponse res)
    {
    }

    [Token(Token = "0x6011396")]
    [Address(RVA = "0x4A18634", Offset = "0x4A18634", VA = "0x4A18634")]
    public GuildAttendInfo()
    {
    }
  }
}
