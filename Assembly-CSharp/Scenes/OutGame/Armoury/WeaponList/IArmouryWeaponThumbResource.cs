// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.IArmouryWeaponThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x2003828")]
  internal interface IArmouryWeaponThumbResource : 
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x170048E7")]
    Weapon WeaponData { [Token(Token = "0x601612F")] get; }
  }
}
