// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ElementInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000447")]
  public struct ElementInfo
  {
    [Token(Token = "0x170002D8")]
    public Element Attack
    {
      [Token(Token = "0x6001847"), Address(RVA = "0x2490408", Offset = "0x2490408", VA = "0x2490408")] readonly get
      {
        return new Element();
      }
      [Token(Token = "0x6001848"), Address(RVA = "0x2490414", Offset = "0x2490414", VA = "0x2490414")] private set
      {
      }
    }

    [Token(Token = "0x170002D9")]
    public Element Nature
    {
      [Token(Token = "0x6001849"), Address(RVA = "0x249041C", Offset = "0x249041C", VA = "0x249041C")] readonly get
      {
        return new Element();
      }
      [Token(Token = "0x600184A"), Address(RVA = "0x2490428", Offset = "0x2490428", VA = "0x2490428")] private set
      {
      }
    }

    [Token(Token = "0x600184B")]
    [Address(RVA = "0x248FF98", Offset = "0x248FF98", VA = "0x248FF98")]
    public static ElementInfo CreateDummy() => new ElementInfo();
  }
}
