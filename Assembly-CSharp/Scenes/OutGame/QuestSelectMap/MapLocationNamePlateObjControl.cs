// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationNamePlateObjControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033C8")]
  public class MapLocationNamePlateObjControl : MonoBehaviour
  {
    [Token(Token = "0x400E0EC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text locationName;
    [Token(Token = "0x400E0ED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector inDirector;
    [Token(Token = "0x400E0EE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayableDirector outDirector;

    [Token(Token = "0x170043C2")]
    public Text LocationName
    {
      [Token(Token = "0x6014598"), Address(RVA = "0x206FFFC", Offset = "0x206FFFC", VA = "0x206FFFC")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x170043C3")]
    public PlayableDirector InDirector
    {
      [Token(Token = "0x6014599"), Address(RVA = "0x2070004", Offset = "0x2070004", VA = "0x2070004")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x170043C4")]
    public PlayableDirector OutDirector
    {
      [Token(Token = "0x601459A"), Address(RVA = "0x207000C", Offset = "0x207000C", VA = "0x207000C")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x601459B")]
    [Address(RVA = "0x2070014", Offset = "0x2070014", VA = "0x2070014")]
    public MapLocationNamePlateObjControl()
    {
    }
  }
}
