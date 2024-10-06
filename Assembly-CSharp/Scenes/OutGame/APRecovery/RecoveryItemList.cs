// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.RecoveryItemList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x200396B")]
  public class RecoveryItemList
  {
    [Token(Token = "0x400FAF9")]
    [FieldOffset(Offset = "0x10")]
    private List<EnergyRecoveryItem> _recoveryItems;
    [Token(Token = "0x400FAFA")]
    [FieldOffset(Offset = "0x18")]
    private int _recoveryItemNum;

    [Token(Token = "0x601692C")]
    [Address(RVA = "0x42ED548", Offset = "0x42ED548", VA = "0x42ED548")]
    public RecoveryItemList(PlayerProfile playerProfile)
    {
    }

    [Token(Token = "0x17004A59")]
    public int TotalNum
    {
      [Token(Token = "0x601692D"), Address(RVA = "0x42F1110", Offset = "0x42F1110", VA = "0x42F1110")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601692E")]
    [Address(RVA = "0x42ECE7C", Offset = "0x42ECE7C", VA = "0x42ECE7C")]
    public ApPaymentData PaymentData(int index) => (ApPaymentData) null;

    [Token(Token = "0x601692F")]
    [Address(RVA = "0x42ECF40", Offset = "0x42ECF40", VA = "0x42ECF40")]
    public int Amount(int index) => new int();
  }
}
