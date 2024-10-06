-- このluaスクリプトは、MA_01C201_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115073)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…ギネヴィアさん…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_150002")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:おかえりなさい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_150003")


	--★★ギネヴィア★★:…ただいま
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150005")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_150006","MA_01C201_150007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おかえり、ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_150009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:無事でよかった<br>みんな心配してたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_150010")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:…あたりまえでしょ<br>あたりまえじゃないかもだけど
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フラフラじゃないか、大丈夫か！？<br>ガレス、なにか温かいものをギネヴィアに！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_150013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Surprise")

	--★★ガレス★★:う、うん<br>すぐ準備するね～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C201_150014")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:私、毛布を持ってきます
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C201_150015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:心配無用よ<br>そこまで弱ってない…つもりだから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150016")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットのことは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_150018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:知ってる
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150019")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…だから帰ってきた
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150020")

	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか…<br>俺は――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_150021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:………
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150022")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力

	--★★ギネヴィア★★:…少しだけ休ませて<br>ちゃんと話をするから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150023")


	--★★ギネヴィア★★:おねがい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C201_150024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
PlayActionDirect(Actor001,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Surp")
PlayActionDirect(Actor004,"to  Std_Surp")
PlayActionDirect(Actor005,"to  Std_Surp")
change_face(Actor001,"Surprise")
change_face(Actor002,"Sad")
change_face(Actor004,"Surprise")
change_face(Actor005,"Surprise")
change_face(Actor003,"Pain")
set_battlecontroller(Actor003,"fig_swd","AC_TL_Fig_Swd_Idle_Run_F","ToAbnormal")
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115073)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
