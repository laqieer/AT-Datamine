// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.IArmouryMindEquipmentThumbResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x2003850")]
  internal interface IArmouryMindEquipmentThumbResource : 
    INewModified,
    ISelectModified,
    IFavoriteModified,
    IUpdateView
  {
    [Token(Token = "0x1700490E")]
    bool IsPossessing { [Token(Token = "0x601622C")] get; }

    [Token(Token = "0x1700490F")]
    MindEquipment MindEquipmentData { [Token(Token = "0x601622D")] get; }
  }
}
