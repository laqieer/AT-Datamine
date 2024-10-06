// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestContainerColum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E59")]
  public class ObliviaeQuestContainerColum : MonoBehaviour
  {
    [Token(Token = "0x400C6D9")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int CONTAINER_IN_OBJECT_COUNT;
    [Token(Token = "0x400C6DA")]
    [FieldOffset(Offset = "0x18")]
    [Header("左・右の順で入れること")]
    [SerializeField]
    private ObliviaeQuestStageThumbnail[] questThumb;

    [Token(Token = "0x17003D8E")]
    private ObliviaeQuestContainerColumData ContainerData
    {
      [Token(Token = "0x60121BF"), Address(RVA = "0x45880B4", Offset = "0x45880B4", VA = "0x45880B4")] get
      {
        return (ObliviaeQuestContainerColumData) null;
      }
      [Token(Token = "0x60121C0"), Address(RVA = "0x45880BC", Offset = "0x45880BC", VA = "0x45880BC")] set
      {
      }
    }

    [Token(Token = "0x60121C1")]
    [Address(RVA = "0x45880C4", Offset = "0x45880C4", VA = "0x45880C4")]
    public void Setup(ObliviaeQuestContainerColumData containerData)
    {
    }

    [Token(Token = "0x60121C2")]
    [Address(RVA = "0x458852C", Offset = "0x458852C", VA = "0x458852C")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60121C3")]
    [Address(RVA = "0x4588534", Offset = "0x4588534", VA = "0x4588534")]
    public ObliviaeQuestContainerColum()
    {
    }

    [Token(Token = "0x60121C4")]
    [Address(RVA = "0x458853C", Offset = "0x458853C", VA = "0x458853C")]
    static ObliviaeQuestContainerColum()
    {
    }
  }
}
