-- このluaスクリプトは、PT2_01B_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さん、あらためて<br>ＧＳの達成、おめでとう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_09_0020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう。少し時間がかかっちゃったけど<br>これでようやくスタートラインに立てたのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0020003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:それにしても選んだのが最強騎士だなんて<br>順当すぎて面白みないわねぇ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_09_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:確かに、順当と言われれば<br>そうなのかもしれないですけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_09_0020005")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんがランス兄ちゃんを選んだのは<br>最強騎士だからってだけじゃないよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_09_0020006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0020007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0020008")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ストップ！<br>変な気遣い、する必要ないからね？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_09_0020009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:わたしもディナタンも、ふたりなら<br>必ずブリテンを救ってくれると信じてる
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_09_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん。精一杯サポートするから<br>これまでと一緒にね！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_09_0020011")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:だから約束して<br>ふたりでなんでも背負い込もうとしないって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_09_0020012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:そうよ<br>苦しいときには遠慮なくわたしたちを頼りなさい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_09_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう、ふたりとも<br>これからもよろしく頼むよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0020014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
