// Decompiled with JetBrains decompiler
// Type: StaqData.IEquipmentFilter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002020")]
  public interface IEquipmentFilter<TResult>
  {
    [Token(Token = "0x600BFFE")]
    List<TResult> FilteredList<TEquipment>(List<TEquipment> equipments);
  }
}
