// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.PlateState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001658")]
  public class PlateState
  {
    [Token(Token = "0x6007E78")]
    [Address(RVA = "0x21B0A74", Offset = "0x21B0A74", VA = "0x21B0A74", Slot = "4")]
    public virtual void SetPlate(QuestStatePlateUI plateUI)
    {
    }

    [Token(Token = "0x6007E79")]
    [Address(RVA = "0x21B0A78", Offset = "0x21B0A78", VA = "0x21B0A78")]
    public PlateState()
    {
    }

    [Token(Token = "0x2001659")]
    public class Hide : PlateState
    {
      [Token(Token = "0x6007E7A")]
      [Address(RVA = "0x21B0A80", Offset = "0x21B0A80", VA = "0x21B0A80", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E7B")]
      [Address(RVA = "0x21B0A84", Offset = "0x21B0A84", VA = "0x21B0A84")]
      public Hide()
      {
      }
    }

    [Token(Token = "0x200165A")]
    public class ReceiptNone : PlateState
    {
      [Token(Token = "0x6007E7C")]
      [Address(RVA = "0x21B0A8C", Offset = "0x21B0A8C", VA = "0x21B0A8C", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E7D")]
      [Address(RVA = "0x21B0AB0", Offset = "0x21B0AB0", VA = "0x21B0AB0")]
      public ReceiptNone()
      {
      }
    }

    [Token(Token = "0x200165B")]
    public class OnReceiptable : PlateState
    {
      [Token(Token = "0x6007E7E")]
      [Address(RVA = "0x21B0AB8", Offset = "0x21B0AB8", VA = "0x21B0AB8", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E7F")]
      [Address(RVA = "0x21B0ADC", Offset = "0x21B0ADC", VA = "0x21B0ADC")]
      public OnReceiptable()
      {
      }
    }

    [Token(Token = "0x200165C")]
    public class OnReceipted : PlateState
    {
      [Token(Token = "0x6007E80")]
      [Address(RVA = "0x21B0AE4", Offset = "0x21B0AE4", VA = "0x21B0AE4", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E81")]
      [Address(RVA = "0x21B0B08", Offset = "0x21B0B08", VA = "0x21B0B08")]
      public OnReceipted()
      {
      }
    }

    [Token(Token = "0x200165D")]
    public class OnCompletable : PlateState
    {
      [Token(Token = "0x6007E82")]
      [Address(RVA = "0x21B0B10", Offset = "0x21B0B10", VA = "0x21B0B10", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E83")]
      [Address(RVA = "0x21B0B34", Offset = "0x21B0B34", VA = "0x21B0B34")]
      public OnCompletable()
      {
      }
    }

    [Token(Token = "0x200165E")]
    public class OnComplete : PlateState
    {
      [Token(Token = "0x6007E84")]
      [Address(RVA = "0x21B0B3C", Offset = "0x21B0B3C", VA = "0x21B0B3C", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E85")]
      [Address(RVA = "0x21B0B60", Offset = "0x21B0B60", VA = "0x21B0B60")]
      public OnComplete()
      {
      }
    }

    [Token(Token = "0x200165F")]
    public class OnCompleted : PlateState
    {
      [Token(Token = "0x6007E86")]
      [Address(RVA = "0x21B0B68", Offset = "0x21B0B68", VA = "0x21B0B68", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E87")]
      [Address(RVA = "0x21B0B8C", Offset = "0x21B0B8C", VA = "0x21B0B8C")]
      public OnCompleted()
      {
      }
    }

    [Token(Token = "0x2001660")]
    public class OnExpired : PlateState
    {
      [Token(Token = "0x6007E88")]
      [Address(RVA = "0x21B0B94", Offset = "0x21B0B94", VA = "0x21B0B94", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E89")]
      [Address(RVA = "0x21B0BB8", Offset = "0x21B0BB8", VA = "0x21B0BB8")]
      public OnExpired()
      {
      }
    }

    [Token(Token = "0x2001661")]
    public class OnUnAcceptable : PlateState
    {
      [Token(Token = "0x6007E8A")]
      [Address(RVA = "0x21B0BC0", Offset = "0x21B0BC0", VA = "0x21B0BC0", Slot = "4")]
      public override void SetPlate(QuestStatePlateUI plateUI)
      {
      }

      [Token(Token = "0x6007E8B")]
      [Address(RVA = "0x21B0BE4", Offset = "0x21B0BE4", VA = "0x21B0BE4")]
      public OnUnAcceptable()
      {
      }
    }
  }
}
