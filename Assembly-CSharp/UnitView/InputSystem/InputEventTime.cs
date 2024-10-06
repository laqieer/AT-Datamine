// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputEventTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003E6")]
  public class InputEventTime
  {
    [Token(Token = "0x17000278")]
    public InputEventTime.Event PointerDown
    {
      [Token(Token = "0x600168C"), Address(RVA = "0x24879E4", Offset = "0x24879E4", VA = "0x24879E4")] get
      {
        return (InputEventTime.Event) null;
      }
    }

    [Token(Token = "0x17000279")]
    public InputEventTime.Event PointerUp
    {
      [Token(Token = "0x600168D"), Address(RVA = "0x24879EC", Offset = "0x24879EC", VA = "0x24879EC")] get
      {
        return (InputEventTime.Event) null;
      }
    }

    [Token(Token = "0x1700027A")]
    public float PointedTime
    {
      [Token(Token = "0x600168E"), Address(RVA = "0x2487050", Offset = "0x2487050", VA = "0x2487050")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600168F")]
    [Address(RVA = "0x2487624", Offset = "0x2487624", VA = "0x2487624")]
    public void Clear()
    {
    }

    [Token(Token = "0x6001690")]
    [Address(RVA = "0x24876FC", Offset = "0x24876FC", VA = "0x24876FC")]
    public InputEventTime()
    {
    }

    [Token(Token = "0x20003E7")]
    public class Event
    {
      [Token(Token = "0x1700027B")]
      public float Time
      {
        [Token(Token = "0x6001691"), Address(RVA = "0x2487A04", Offset = "0x2487A04", VA = "0x2487A04")] get
        {
          return new float();
        }
        [Token(Token = "0x6001692"), Address(RVA = "0x2487A0C", Offset = "0x2487A0C", VA = "0x2487A0C")] private set
        {
        }
      }

      [Token(Token = "0x6001693")]
      [Address(RVA = "0x24877DC", Offset = "0x24877DC", VA = "0x24877DC")]
      public void Keep()
      {
      }

      [Token(Token = "0x6001694")]
      [Address(RVA = "0x24879F4", Offset = "0x24879F4", VA = "0x24879F4")]
      public void Clear()
      {
      }

      [Token(Token = "0x6001695")]
      [Address(RVA = "0x2487A14", Offset = "0x2487A14", VA = "0x2487A14")]
      private float GetCurrentTime() => new float();

      [Token(Token = "0x6001696")]
      [Address(RVA = "0x24879FC", Offset = "0x24879FC", VA = "0x24879FC")]
      public Event()
      {
      }
    }
  }
}
