// Decompiled with JetBrains decompiler
// Type: StaqData.BreakableObjectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002091")]
  public class BreakableObjectInfo
  {
    [Token(Token = "0x17002A07")]
    public int BreakableObjectID
    {
      [Token(Token = "0x600C4F9"), Address(RVA = "0x19FF3C4", Offset = "0x19FF3C4", VA = "0x19FF3C4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A08")]
    public bool IsOpened
    {
      [Token(Token = "0x600C4FA"), Address(RVA = "0x19FF3CC", Offset = "0x19FF3CC", VA = "0x19FF3CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C4FB"), Address(RVA = "0x19FF3D4", Offset = "0x19FF3D4", VA = "0x19FF3D4")] private set
      {
      }
    }

    [Token(Token = "0x600C4FC")]
    [Address(RVA = "0x19FEFB8", Offset = "0x19FEFB8", VA = "0x19FEFB8")]
    public BreakableObjectInfo(int breakableObject, bool isOpened)
    {
    }

    [Token(Token = "0x600C4FD")]
    [Address(RVA = "0x19FF294", Offset = "0x19FF294", VA = "0x19FF294")]
    public void BrokenUpdate()
    {
    }
  }
}
