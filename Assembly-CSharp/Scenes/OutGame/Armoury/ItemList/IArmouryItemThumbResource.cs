// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ItemList.IArmouryItemThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Armoury.ItemList
{
  [Token(Token = "0x2003869")]
  internal interface IArmouryItemThumbResource : 
    INewModified,
    ISelectModified,
    IAmountChangedModified
  {
    [Token(Token = "0x17004926")]
    Item ItemData { [Token(Token = "0x60162C1")] get; }
  }
}
