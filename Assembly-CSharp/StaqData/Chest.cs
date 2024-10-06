// Decompiled with JetBrains decompiler
// Type: StaqData.Chest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002090")]
  public class Chest
  {
    [Token(Token = "0x17002A05")]
    public int ChestID
    {
      [Token(Token = "0x600C4F4"), Address(RVA = "0x19FF3A8", Offset = "0x19FF3A8", VA = "0x19FF3A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A06")]
    public bool IsOpened
    {
      [Token(Token = "0x600C4F5"), Address(RVA = "0x19FF3B0", Offset = "0x19FF3B0", VA = "0x19FF3B0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C4F6"), Address(RVA = "0x19FF3B8", Offset = "0x19FF3B8", VA = "0x19FF3B8")] private set
      {
      }
    }

    [Token(Token = "0x600C4F7")]
    [Address(RVA = "0x19FEF84", Offset = "0x19FEF84", VA = "0x19FEF84")]
    public Chest(int chestID, bool opened)
    {
    }

    [Token(Token = "0x600C4F8")]
    [Address(RVA = "0x19FF19C", Offset = "0x19FF19C", VA = "0x19FF19C")]
    public void Opened()
    {
    }
  }
}
