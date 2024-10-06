// Decompiled with JetBrains decompiler
// Type: FreeMap.Handler.FreeMapSubQuestCancellationHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Handler
{
  [Token(Token = "0x200192E")]
  public class FreeMapSubQuestCancellationHandler
  {
    [Token(Token = "0x170016FA")]
    protected IEnumerable<SubQuestTaskInfo> cancelTaskList
    {
      [Token(Token = "0x6008F30"), Address(RVA = "0x4B062D4", Offset = "0x4B062D4", VA = "0x4B062D4")] get
      {
        return (IEnumerable<SubQuestTaskInfo>) null;
      }
      [Token(Token = "0x6008F31"), Address(RVA = "0x4B062DC", Offset = "0x4B062DC", VA = "0x4B062DC")] private set
      {
      }
    }

    [Token(Token = "0x170016FB")]
    protected SubQuestCompleteInfo cancelCompleteInfo
    {
      [Token(Token = "0x6008F32"), Address(RVA = "0x4B062E4", Offset = "0x4B062E4", VA = "0x4B062E4")] get
      {
        return (SubQuestCompleteInfo) null;
      }
      [Token(Token = "0x6008F33"), Address(RVA = "0x4B062EC", Offset = "0x4B062EC", VA = "0x4B062EC")] private set
      {
      }
    }

    [Token(Token = "0x170016FC")]
    protected SubQuestReceiptInfo cancelReceiptedInfo
    {
      [Token(Token = "0x6008F34"), Address(RVA = "0x4B062F4", Offset = "0x4B062F4", VA = "0x4B062F4")] get
      {
        return (SubQuestReceiptInfo) null;
      }
      [Token(Token = "0x6008F35"), Address(RVA = "0x4B062FC", Offset = "0x4B062FC", VA = "0x4B062FC")] private set
      {
      }
    }

    [Token(Token = "0x6008F36")]
    [Address(RVA = "0x4B06304", Offset = "0x4B06304", VA = "0x4B06304")]
    public FreeMapSubQuestCancellationHandler(SubQuestData cancellationData)
    {
    }

    [Token(Token = "0x6008F37")]
    [Address(RVA = "0x4B06344", Offset = "0x4B06344", VA = "0x4B06344", Slot = "4")]
    public virtual void InvokeCancellation(IFreeMapLocationControll locationController)
    {
    }

    [Token(Token = "0x6008F38")]
    [Address(RVA = "0x4B063EC", Offset = "0x4B063EC", VA = "0x4B063EC")]
    protected void UpdateFlagSaveData()
    {
    }
  }
}
