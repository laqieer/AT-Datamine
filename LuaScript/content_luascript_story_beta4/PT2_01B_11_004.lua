-- このluaスクリプトは、PT2_01B_11_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん、もう起きてきたの？<br>休日の朝くらいゆっくり寝てたらいいのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:聖杯の在処に関する情報が<br>いつ入ってくるかわからないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それより、ディナタンこそ疲れてないか？<br>療養院の手伝いで忙しいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私は大丈夫だよ<br>ごめんね、聖杯探索を手伝ってあげられなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ディナタンたちが学園を守ってくれてるから<br>俺たちは安心して出撃できるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:これからも学園を空けることが多いと思うけど<br>そのあいだのことはよろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん。任せて、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そういえば、学園祭はどうだった？<br>芝居をやったって聞いたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:そうなの。マァルが脚本と演出と主役の<br>３役を同時にやったんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:最初は演技指導が厳しくて大変だったけど<br>みんなだんだんマァルの熱意に感化されてきて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040011")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:最後は一致団結して<br>すごくいいお芝居に仕上がってたよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040012")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうだったのか<br>それはぜひ見てみたかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040013")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私も見て欲しかったな<br>それに兄さんと一緒に露店も回りたかったし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:来年は一緒に回ろうか<br>もしくは演劇に一緒に出るとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:せっかくならどっちもやりたいな<br>約束だよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_11_0040016")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:ああ。約束だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0040017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
