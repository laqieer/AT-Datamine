-- このluaスクリプトは、CO_101011_0705.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
play_head_motion(Actor003, "Nod", 0.3, 0.3, true)
wait_time(0.2)
play_head_motion(Actor005, "Nod", 0.3, 0.4, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(6,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
stop_head_motion(Actor003)
stop_head_motion(Actor005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:何人かに聞いてみたんだけど<br>見た覚えはないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07050002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:うーん<br>もう他に行った場所を覚えてないよ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050003")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor004,"to Sit01_Nod")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:今日はここまでにしよう？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050005")

	open_select_window_tag(Actor001,"Normal","CO_101011_07050007","CO_101011_07050008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まだ付き合うよ<br>気になる場所があれば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07050010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:嬉しいけど、今日はもう遅いし<br>帰ろ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:だって、大切なものなんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07050012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:でも…<br>今日はやめとく
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そっか<br>きっと見つかるよ、諦めないで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07050015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺ならいつでも付き合うから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07050016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…うん<br>……うん！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050017")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ありがとね、ノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07050019")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
