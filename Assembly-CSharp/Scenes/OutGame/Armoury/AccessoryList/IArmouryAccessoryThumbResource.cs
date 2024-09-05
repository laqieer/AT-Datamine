// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.IArmouryAccessoryThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x20038A7")]
  internal interface IArmouryAccessoryThumbResource : 
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x1700495C")]
    Accessory AccessoryData { [Token(Token = "0x6016457")] get; }
  }
}
