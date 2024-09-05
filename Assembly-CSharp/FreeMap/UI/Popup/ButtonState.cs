// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.ButtonState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001644")]
  public class ButtonState
  {
    [Token(Token = "0x17001394")]
    private string TextReceipt
    {
      [Token(Token = "0x6007E4F"), Address(RVA = "0x21AE25C", Offset = "0x21AE25C", VA = "0x21AE25C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001395")]
    private string TextRemove
    {
      [Token(Token = "0x6007E50"), Address(RVA = "0x21AE264", Offset = "0x21AE264", VA = "0x21AE264")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001396")]
    private string TextAutoMove
    {
      [Token(Token = "0x6007E51"), Address(RVA = "0x21AE26C", Offset = "0x21AE26C", VA = "0x21AE26C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001397")]
    private string TextComplete
    {
      [Token(Token = "0x6007E52"), Address(RVA = "0x21AE274", Offset = "0x21AE274", VA = "0x21AE274")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001398")]
    private string TextBack
    {
      [Token(Token = "0x6007E53"), Address(RVA = "0x21AE27C", Offset = "0x21AE27C", VA = "0x21AE27C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001399")]
    private string TextClose
    {
      [Token(Token = "0x6007E54"), Address(RVA = "0x21AE284", Offset = "0x21AE284", VA = "0x21AE284")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700139A")]
    private string TextMap
    {
      [Token(Token = "0x6007E55"), Address(RVA = "0x21AE28C", Offset = "0x21AE28C", VA = "0x21AE28C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007E56")]
    [Address(RVA = "0x21AE294", Offset = "0x21AE294", VA = "0x21AE294", Slot = "4")]
    public virtual void SetButtons(
      IQuestUIEvent questUI,
      QuestButtonLayoutControUI questButtonLayout)
    {
    }

    [Token(Token = "0x6007E57")]
    [Address(RVA = "0x21AE298", Offset = "0x21AE298", VA = "0x21AE298")]
    public ButtonState()
    {
    }

    [Token(Token = "0x2001645")]
    public class Default : ButtonState
    {
      [Token(Token = "0x6007E58")]
      [Address(RVA = "0x21AE2A0", Offset = "0x21AE2A0", VA = "0x21AE2A0", Slot = "4")]
      public override void SetButtons(
        IQuestUIEvent questUI,
        QuestButtonLayoutControUI questButtonLayout)
      {
      }

      [Token(Token = "0x6007E59")]
      [Address(RVA = "0x21AE418", Offset = "0x21AE418", VA = "0x21AE418")]
      public Default()
      {
      }
    }

    [Token(Token = "0x2001646")]
    public static class Tracker
    {
      [Token(Token = "0x2001647")]
      public class OnReceiptable : ButtonState
      {
        [Token(Token = "0x6007E5A")]
        [Address(RVA = "0x21AE420", Offset = "0x21AE420", VA = "0x21AE420", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent uiEvent,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E5B")]
        [Address(RVA = "0x21AE794", Offset = "0x21AE794", VA = "0x21AE794")]
        public OnReceiptable()
        {
        }
      }

      [Token(Token = "0x2001648")]
      public class OnUnReceiptable : ButtonState
      {
        [Token(Token = "0x6007E5C")]
        [Address(RVA = "0x21AE79C", Offset = "0x21AE79C", VA = "0x21AE79C", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent uiEvent,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E5D")]
        [Address(RVA = "0x21AEB2C", Offset = "0x21AEB2C", VA = "0x21AEB2C")]
        public OnUnReceiptable()
        {
        }
      }

      [Token(Token = "0x2001649")]
      public class OnReceiptingSubQuest : ButtonState
      {
        [Token(Token = "0x6007E5E")]
        [Address(RVA = "0x21AEB34", Offset = "0x21AEB34", VA = "0x21AEB34", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E5F")]
        [Address(RVA = "0x21AEFA4", Offset = "0x21AEFA4", VA = "0x21AEFA4")]
        public OnReceiptingSubQuest()
        {
        }
      }

      [Token(Token = "0x200164A")]
      public class OnReceiptingAreaEventQuest : ButtonState
      {
        [Token(Token = "0x6007E60")]
        [Address(RVA = "0x21AEFAC", Offset = "0x21AEFAC", VA = "0x21AEFAC", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E61")]
        [Address(RVA = "0x21AF320", Offset = "0x21AF320", VA = "0x21AF320")]
        public OnReceiptingAreaEventQuest()
        {
        }
      }

      [Token(Token = "0x200164B")]
      public class OnReceiptingAreaEventQuestParallel : ButtonState
      {
        [Token(Token = "0x6007E62")]
        [Address(RVA = "0x21AF328", Offset = "0x21AF328", VA = "0x21AF328", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E63")]
        [Address(RVA = "0x21AF5A4", Offset = "0x21AF5A4", VA = "0x21AF5A4")]
        public OnReceiptingAreaEventQuestParallel()
        {
        }
      }
    }

    [Token(Token = "0x200164C")]
    public static class PocketBook
    {
      [Token(Token = "0x200164D")]
      public class OnReceiptable : ButtonState
      {
        [Token(Token = "0x6007E64")]
        [Address(RVA = "0x21AF5AC", Offset = "0x21AF5AC", VA = "0x21AF5AC", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E65")]
        [Address(RVA = "0x21AF824", Offset = "0x21AF824", VA = "0x21AF824")]
        public OnReceiptable()
        {
        }
      }

      [Token(Token = "0x200164E")]
      public class OnReceiptingSubQuest : ButtonState
      {
        [Token(Token = "0x6007E66")]
        [Address(RVA = "0x21AF82C", Offset = "0x21AF82C", VA = "0x21AF82C", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E67")]
        [Address(RVA = "0x21AFBA0", Offset = "0x21AFBA0", VA = "0x21AFBA0")]
        public OnReceiptingSubQuest()
        {
        }
      }

      [Token(Token = "0x200164F")]
      public class OnReceiptingAreaEventQuest : ButtonState
      {
        [Token(Token = "0x6007E68")]
        [Address(RVA = "0x21AFBA8", Offset = "0x21AFBA8", VA = "0x21AFBA8", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E69")]
        [Address(RVA = "0x21AFE20", Offset = "0x21AFE20", VA = "0x21AFE20")]
        public OnReceiptingAreaEventQuest()
        {
        }
      }

      [Token(Token = "0x2001650")]
      public class OnReceiptingAreaEventQuestParallel : ButtonState
      {
        [Token(Token = "0x6007E6A")]
        [Address(RVA = "0x21AFE28", Offset = "0x21AFE28", VA = "0x21AFE28", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E6B")]
        [Address(RVA = "0x21AFFA0", Offset = "0x21AFFA0", VA = "0x21AFFA0")]
        public OnReceiptingAreaEventQuestParallel()
        {
        }
      }
    }

    [Token(Token = "0x2001651")]
    public static class Npc
    {
      [Token(Token = "0x2001652")]
      public class OnReceipt : ButtonState
      {
        [Token(Token = "0x6007E6C")]
        [Address(RVA = "0x21AFFA8", Offset = "0x21AFFA8", VA = "0x21AFFA8", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E6D")]
        [Address(RVA = "0x21B0220", Offset = "0x21B0220", VA = "0x21B0220")]
        public OnReceipt()
        {
        }
      }

      [Token(Token = "0x2001653")]
      public class OnUnRecipt : ButtonState
      {
        [Token(Token = "0x6007E6E")]
        [Address(RVA = "0x21B0228", Offset = "0x21B0228", VA = "0x21B0228", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E6F")]
        [Address(RVA = "0x21B03A0", Offset = "0x21B03A0", VA = "0x21B03A0")]
        public OnUnRecipt()
        {
        }
      }

      [Token(Token = "0x2001654")]
      public class OnReceiptingSubQuest : ButtonState
      {
        [Token(Token = "0x6007E70")]
        [Address(RVA = "0x21B03A8", Offset = "0x21B03A8", VA = "0x21B03A8", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E71")]
        [Address(RVA = "0x21B0818", Offset = "0x21B0818", VA = "0x21B0818")]
        public OnReceiptingSubQuest()
        {
        }
      }

      [Token(Token = "0x2001655")]
      public class OnComplete : ButtonState
      {
        [Token(Token = "0x6007E72")]
        [Address(RVA = "0x21B0820", Offset = "0x21B0820", VA = "0x21B0820", Slot = "4")]
        public override void SetButtons(
          IQuestUIEvent questUI,
          QuestButtonLayoutControUI questButtonLayout)
        {
        }

        [Token(Token = "0x6007E73")]
        [Address(RVA = "0x21B0A54", Offset = "0x21B0A54", VA = "0x21B0A54")]
        public OnComplete()
        {
        }
      }
    }

    [Token(Token = "0x2001656")]
    public class OnCompleted : ButtonState.Default
    {
      [Token(Token = "0x6007E74")]
      [Address(RVA = "0x21B0A5C", Offset = "0x21B0A5C", VA = "0x21B0A5C", Slot = "4")]
      public override void SetButtons(
        IQuestUIEvent questUI,
        QuestButtonLayoutControUI questButtonLayout)
      {
      }

      [Token(Token = "0x6007E75")]
      [Address(RVA = "0x21B0A60", Offset = "0x21B0A60", VA = "0x21B0A60")]
      public OnCompleted()
      {
      }
    }

    [Token(Token = "0x2001657")]
    public class OnExpired : ButtonState.Default
    {
      [Token(Token = "0x6007E76")]
      [Address(RVA = "0x21B0A68", Offset = "0x21B0A68", VA = "0x21B0A68", Slot = "4")]
      public override void SetButtons(
        IQuestUIEvent questUI,
        QuestButtonLayoutControUI questButtonLayout)
      {
      }

      [Token(Token = "0x6007E77")]
      [Address(RVA = "0x21B0A6C", Offset = "0x21B0A6C", VA = "0x21B0A6C")]
      public OnExpired()
      {
      }
    }
  }
}
