// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.TriangleState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001675")]
  public class TriangleState
  {
    [Token(Token = "0x6007ECD")]
    [Address(RVA = "0x21B3ACC", Offset = "0x21B3ACC", VA = "0x21B3ACC", Slot = "4")]
    public virtual void SetTriangle(TriangleUI triangleUI)
    {
    }

    [Token(Token = "0x6007ECE")]
    [Address(RVA = "0x21B3AD0", Offset = "0x21B3AD0", VA = "0x21B3AD0")]
    public TriangleState()
    {
    }

    [Token(Token = "0x2001676")]
    public class None : TriangleState
    {
      [Token(Token = "0x6007ECF")]
      [Address(RVA = "0x21B3AD8", Offset = "0x21B3AD8", VA = "0x21B3AD8", Slot = "4")]
      public override void SetTriangle(TriangleUI triangleUI)
      {
      }

      [Token(Token = "0x6007ED0")]
      [Address(RVA = "0x21B0CE0", Offset = "0x21B0CE0", VA = "0x21B0CE0")]
      public None()
      {
      }
    }

    [Token(Token = "0x2001677")]
    public class OnReceipt : TriangleState
    {
      [Token(Token = "0x6007ED1")]
      [Address(RVA = "0x21B3B04", Offset = "0x21B3B04", VA = "0x21B3B04", Slot = "4")]
      public override void SetTriangle(TriangleUI triangleUI)
      {
      }

      [Token(Token = "0x6007ED2")]
      [Address(RVA = "0x21B3130", Offset = "0x21B3130", VA = "0x21B3130")]
      public OnReceipt()
      {
      }
    }
  }
}
