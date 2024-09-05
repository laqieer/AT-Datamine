// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestUIStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.SubQuest;
using Il2CppDummyDll;
using StaqData;
using StaqData.AreaEvent;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001662")]
  public class QuestUIStateHandler
  {
    [Token(Token = "0x400651D")]
    [FieldOffset(Offset = "0x10")]
    private PlateState plateState;
    [Token(Token = "0x400651E")]
    [FieldOffset(Offset = "0x18")]
    private ButtonState buttonState;
    [Token(Token = "0x400651F")]
    [FieldOffset(Offset = "0x20")]
    private TriangleState triangleState;

    [Token(Token = "0x6007E8C")]
    [Address(RVA = "0x21B0BEC", Offset = "0x21B0BEC", VA = "0x21B0BEC")]
    private QuestUIStateHandler()
    {
    }

    [Token(Token = "0x6007E8D")]
    [Address(RVA = "0x21AD68C", Offset = "0x21AD68C", VA = "0x21AD68C")]
    public void Apply(QuestUI questUI)
    {
    }

    [Token(Token = "0x6007E8E")]
    [Address(RVA = "0x21B0BF4", Offset = "0x21B0BF4", VA = "0x21B0BF4")]
    public static QuestUIStateHandler Default() => (QuestUIStateHandler) null;

    [Token(Token = "0x2001663")]
    public class Factory
    {
      [Token(Token = "0x6007E8F")]
      [Address(RVA = "0x21B0CE8", Offset = "0x21B0CE8", VA = "0x21B0CE8")]
      private static QuestUIStateHandler Create(
        QuestUIStateHandler.Factory.ISummoner summoner,
        QuestUIStateHandler.Factory.IContent content,
        bool completed,
        bool expired,
        bool receipting,
        bool completable,
        bool closest,
        bool receiptable)
      {
        return (QuestUIStateHandler) null;
      }

      [Token(Token = "0x6007E90")]
      [Address(RVA = "0x21B0FA0", Offset = "0x21B0FA0", VA = "0x21B0FA0")]
      public Factory()
      {
      }

      [Token(Token = "0x2001664")]
      public interface ISummoner
      {
      }

      [Token(Token = "0x2001665")]
      public interface IContent
      {
        [Token(Token = "0x6007E91")]
        QuestUIStateHandler OnReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceiptable);

        [Token(Token = "0x6007E92")]
        QuestUIStateHandler OnCompleted(QuestUIStateHandler.Factory.ISummoner summoner);

        [Token(Token = "0x6007E93")]
        QuestUIStateHandler OnExpired(QuestUIStateHandler.Factory.ISummoner summoner);

        [Token(Token = "0x6007E94")]
        QuestUIStateHandler OnComplete(QuestUIStateHandler.Factory.ISummoner summoner);

        [Token(Token = "0x6007E95")]
        QuestUIStateHandler OnReceipting(QuestUIStateHandler.Factory.ISummoner summoner);

        [Token(Token = "0x6007E96")]
        QuestUIStateHandler OnMoveToReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceiptable);

        [Token(Token = "0x6007E97")]
        QuestUIStateHandler OnMoveToComplete(QuestUIStateHandler.Factory.ISummoner summoner);
      }

      [Token(Token = "0x2001666")]
      public class AreaEventQuest : QuestUIStateHandler.Factory.IContent
      {
        [Token(Token = "0x4006520")]
        [FieldOffset(Offset = "0x10")]
        private bool parallel;

        [Token(Token = "0x6007E98")]
        [Address(RVA = "0x21B0FA8", Offset = "0x21B0FA8", VA = "0x21B0FA8")]
        public AreaEventQuest(bool parallel)
        {
        }

        [Token(Token = "0x6007E99")]
        [Address(RVA = "0x21B0FD0", Offset = "0x21B0FD0", VA = "0x21B0FD0", Slot = "9")]
        public QuestUIStateHandler OnMoveToReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceiptable = true)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9A")]
        [Address(RVA = "0x21B0FD4", Offset = "0x21B0FD4", VA = "0x21B0FD4", Slot = "4")]
        public QuestUIStateHandler OnReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceiptable = true)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9B")]
        [Address(RVA = "0x21B0FD8", Offset = "0x21B0FD8", VA = "0x21B0FD8", Slot = "8")]
        public QuestUIStateHandler OnReceipting(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9C")]
        [Address(RVA = "0x21B127C", Offset = "0x21B127C", VA = "0x21B127C", Slot = "10")]
        public QuestUIStateHandler OnMoveToComplete(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9D")]
        [Address(RVA = "0x21B1520", Offset = "0x21B1520", VA = "0x21B1520", Slot = "7")]
        public QuestUIStateHandler OnComplete(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9E")]
        [Address(RVA = "0x21B1524", Offset = "0x21B1524", VA = "0x21B1524", Slot = "5")]
        public QuestUIStateHandler OnCompleted(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007E9F")]
        [Address(RVA = "0x21B17C4", Offset = "0x21B17C4", VA = "0x21B17C4", Slot = "6")]
        public QuestUIStateHandler OnExpired(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EA0")]
        public static void ReceiptingAreaEventQuest<T, TParallel>(
          QuestUIStateHandler stateHandler,
          bool parallel)
          where T : ButtonState, new()
          where TParallel : ButtonState, new()
        {
        }

        [Token(Token = "0x2001667")]
        public static class Receipting
        {
          [Token(Token = "0x6007EA1")]
          [Address(RVA = "0x21B10A4", Offset = "0x21B10A4", VA = "0x21B10A4")]
          public static QuestUIStateHandler OnTracker(bool parallel) => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EA2")]
          [Address(RVA = "0x21B1190", Offset = "0x21B1190", VA = "0x21B1190")]
          public static QuestUIStateHandler OnPocketBook(bool parallel)
          {
            return (QuestUIStateHandler) null;
          }
        }

        [Token(Token = "0x2001668")]
        public static class MovetoComplete
        {
          [Token(Token = "0x6007EA3")]
          [Address(RVA = "0x21B1348", Offset = "0x21B1348", VA = "0x21B1348")]
          public static QuestUIStateHandler OnTracker(bool parallel) => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EA4")]
          [Address(RVA = "0x21B1434", Offset = "0x21B1434", VA = "0x21B1434")]
          public static QuestUIStateHandler OnPocketBook(bool parallel)
          {
            return (QuestUIStateHandler) null;
          }
        }

        [Token(Token = "0x2001669")]
        public static class Completed
        {
          [Token(Token = "0x6007EA5")]
          [Address(RVA = "0x21B15EC", Offset = "0x21B15EC", VA = "0x21B15EC")]
          public static QuestUIStateHandler OnTracker(bool parallel) => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EA6")]
          [Address(RVA = "0x21B16D8", Offset = "0x21B16D8", VA = "0x21B16D8")]
          public static QuestUIStateHandler OnPocketBook(bool parallel)
          {
            return (QuestUIStateHandler) null;
          }
        }
      }

      [Token(Token = "0x200166A")]
      public class SubQuest : QuestUIStateHandler.Factory.IContent
      {
        [Token(Token = "0x6007EA7")]
        [Address(RVA = "0x21B17C8", Offset = "0x21B17C8", VA = "0x21B17C8", Slot = "4")]
        public QuestUIStateHandler OnReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceipable)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EA8")]
        [Address(RVA = "0x21B1C84", Offset = "0x21B1C84", VA = "0x21B1C84", Slot = "8")]
        public QuestUIStateHandler OnReceipting(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EA9")]
        [Address(RVA = "0x21B204C", Offset = "0x21B204C", VA = "0x21B204C", Slot = "9")]
        public QuestUIStateHandler OnMoveToReceipt(
          QuestUIStateHandler.Factory.ISummoner summoner,
          bool isReceiptable)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EAA")]
        [Address(RVA = "0x21B2338", Offset = "0x21B2338", VA = "0x21B2338", Slot = "10")]
        public QuestUIStateHandler OnMoveToComplete(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EAB")]
        [Address(RVA = "0x21B25D0", Offset = "0x21B25D0", VA = "0x21B25D0", Slot = "7")]
        public QuestUIStateHandler OnComplete(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EAC")]
        [Address(RVA = "0x21B2998", Offset = "0x21B2998", VA = "0x21B2998", Slot = "5")]
        public QuestUIStateHandler OnCompleted(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EAD")]
        [Address(RVA = "0x21B2D60", Offset = "0x21B2D60", VA = "0x21B2D60", Slot = "6")]
        public QuestUIStateHandler OnExpired(QuestUIStateHandler.Factory.ISummoner summoner)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EAE")]
        [Address(RVA = "0x21B3128", Offset = "0x21B3128", VA = "0x21B3128")]
        public SubQuest()
        {
        }

        [Token(Token = "0x200166B")]
        public static class Receipt
        {
          [Token(Token = "0x6007EAF")]
          [Address(RVA = "0x21B1A40", Offset = "0x21B1A40", VA = "0x21B1A40")]
          public static QuestUIStateHandler OnTracker(bool isReceipable)
          {
            return (QuestUIStateHandler) null;
          }

          [Token(Token = "0x6007EB0")]
          [Address(RVA = "0x21B18DC", Offset = "0x21B18DC", VA = "0x21B18DC")]
          public static QuestUIStateHandler OnNPC(bool isReceipable) => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EB1")]
          [Address(RVA = "0x21B1B74", Offset = "0x21B1B74", VA = "0x21B1B74")]
          public static QuestUIStateHandler OnPocketBook(bool isReceipable)
          {
            return (QuestUIStateHandler) null;
          }
        }

        [Token(Token = "0x200166C")]
        public static class MovetoReceipt
        {
          [Token(Token = "0x6007EB2")]
          [Address(RVA = "0x21B2118", Offset = "0x21B2118", VA = "0x21B2118")]
          public static QuestUIStateHandler OnTracker(bool isReceipable)
          {
            return (QuestUIStateHandler) null;
          }

          [Token(Token = "0x6007EB3")]
          [Address(RVA = "0x21B2228", Offset = "0x21B2228", VA = "0x21B2228")]
          public static QuestUIStateHandler OnPocketBook(bool isReceipable)
          {
            return (QuestUIStateHandler) null;
          }
        }

        [Token(Token = "0x200166D")]
        public class Receipting
        {
          [Token(Token = "0x6007EB4")]
          [Address(RVA = "0x21B1E74", Offset = "0x21B1E74", VA = "0x21B1E74")]
          public static QuestUIStateHandler OnTracker() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EB5")]
          [Address(RVA = "0x21B1D88", Offset = "0x21B1D88", VA = "0x21B1D88")]
          public static QuestUIStateHandler OnNPC() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EB6")]
          [Address(RVA = "0x21B1F60", Offset = "0x21B1F60", VA = "0x21B1F60")]
          public static QuestUIStateHandler OnPocketBook() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EB7")]
          [Address(RVA = "0x21B3138", Offset = "0x21B3138", VA = "0x21B3138")]
          public Receipting()
          {
          }
        }

        [Token(Token = "0x200166E")]
        public static class MovetoComplete
        {
          [Token(Token = "0x6007EB8")]
          [Address(RVA = "0x21B23F8", Offset = "0x21B23F8", VA = "0x21B23F8")]
          public static QuestUIStateHandler OnTracker() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EB9")]
          [Address(RVA = "0x21B24E4", Offset = "0x21B24E4", VA = "0x21B24E4")]
          public static QuestUIStateHandler OnPocketBook() => (QuestUIStateHandler) null;
        }

        [Token(Token = "0x200166F")]
        public static class Complete
        {
          [Token(Token = "0x6007EBA")]
          [Address(RVA = "0x21B27C0", Offset = "0x21B27C0", VA = "0x21B27C0")]
          public static QuestUIStateHandler OnTracker() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EBB")]
          [Address(RVA = "0x21B26D4", Offset = "0x21B26D4", VA = "0x21B26D4")]
          public static QuestUIStateHandler OnNPC() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EBC")]
          [Address(RVA = "0x21B28AC", Offset = "0x21B28AC", VA = "0x21B28AC")]
          public static QuestUIStateHandler OnPocketBook() => (QuestUIStateHandler) null;
        }

        [Token(Token = "0x2001670")]
        public static class Completed
        {
          [Token(Token = "0x6007EBD")]
          [Address(RVA = "0x21B2B88", Offset = "0x21B2B88", VA = "0x21B2B88")]
          public static QuestUIStateHandler OnTracker() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EBE")]
          [Address(RVA = "0x21B2A9C", Offset = "0x21B2A9C", VA = "0x21B2A9C")]
          public static QuestUIStateHandler OnNPC() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EBF")]
          [Address(RVA = "0x21B2C74", Offset = "0x21B2C74", VA = "0x21B2C74")]
          public static QuestUIStateHandler OnPocketBook() => (QuestUIStateHandler) null;
        }

        [Token(Token = "0x2001671")]
        public static class Expired
        {
          [Token(Token = "0x6007EC0")]
          [Address(RVA = "0x21B2F50", Offset = "0x21B2F50", VA = "0x21B2F50")]
          public static QuestUIStateHandler OnTracker() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EC1")]
          [Address(RVA = "0x21B2E64", Offset = "0x21B2E64", VA = "0x21B2E64")]
          public static QuestUIStateHandler OnNPC() => (QuestUIStateHandler) null;

          [Token(Token = "0x6007EC2")]
          [Address(RVA = "0x21B303C", Offset = "0x21B303C", VA = "0x21B303C")]
          public static QuestUIStateHandler OnPocketBook() => (QuestUIStateHandler) null;
        }
      }

      [Token(Token = "0x2001672")]
      public class Tracker : QuestUIStateHandler.Factory.ISummoner
      {
        [Token(Token = "0x6007EC3")]
        [Address(RVA = "0x21B3140", Offset = "0x21B3140", VA = "0x21B3140")]
        public static QuestUIStateHandler CreateMainQuest() => (QuestUIStateHandler) null;

        [Token(Token = "0x6007EC4")]
        [Address(RVA = "0x21B322C", Offset = "0x21B322C", VA = "0x21B322C")]
        public static QuestUIStateHandler CreateSubQuest(SubQuestData quest)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EC5")]
        [Address(RVA = "0x21B33CC", Offset = "0x21B33CC", VA = "0x21B33CC")]
        public static QuestUIStateHandler CreateAreaEventQuest(AreaEventQuestData quest)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EC6")]
        [Address(RVA = "0x21B33C4", Offset = "0x21B33C4", VA = "0x21B33C4")]
        public Tracker()
        {
        }
      }

      [Token(Token = "0x2001673")]
      public class PocketBook : QuestUIStateHandler.Factory.ISummoner
      {
        [Token(Token = "0x6007EC7")]
        [Address(RVA = "0x21B34E0", Offset = "0x21B34E0", VA = "0x21B34E0")]
        public static QuestUIStateHandler CreateSubQuest(SubQuestData quest)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EC8")]
        [Address(RVA = "0x21B3680", Offset = "0x21B3680", VA = "0x21B3680")]
        public static QuestUIStateHandler CreateSubQuest(
          SubQuestData quest,
          FreeMapSubQuestEventUIParam param)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007EC9")]
        [Address(RVA = "0x21B3818", Offset = "0x21B3818", VA = "0x21B3818")]
        public static QuestUIStateHandler CreateAreaEventQuest(AreaEventQuestData quest)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007ECA")]
        [Address(RVA = "0x21B3678", Offset = "0x21B3678", VA = "0x21B3678")]
        public PocketBook()
        {
        }
      }

      [Token(Token = "0x2001674")]
      public class Npc : QuestUIStateHandler.Factory.ISummoner
      {
        [Token(Token = "0x6007ECB")]
        [Address(RVA = "0x21B392C", Offset = "0x21B392C", VA = "0x21B392C")]
        public static QuestUIStateHandler CreateSubQuest(SubQuestData quest)
        {
          return (QuestUIStateHandler) null;
        }

        [Token(Token = "0x6007ECC")]
        [Address(RVA = "0x21B3AC4", Offset = "0x21B3AC4", VA = "0x21B3AC4")]
        public Npc()
        {
        }
      }
    }
  }
}
