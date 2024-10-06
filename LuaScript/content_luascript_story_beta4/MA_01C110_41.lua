-- このluaスクリプトは、MA_01C110_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110261_43","110261_43_h")
Include("content_adv_advsmall_110261_43","Template110261_43_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110261_43_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110261_43_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110261_43_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110261_43_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110261_43_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110261_43,CameraPos110261_43_006)
	InitializeTemplateRandomCamera110261_43()
	InitializeTemplate110261_43()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Joy")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Dinatan_Theme")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110261)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Laugh")

	--★★ランスロット★★:ディナタンの歌、久しぶりに聞いたな
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_410002")

	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:わたしはちゃんと聞くの初めてかも
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_410003")

	open_select_window_tag(Actor002,"Normal","MA_01C110_410004","MA_01C110_410005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor002,"Smile")

	--★★ノワール★★:元気になるだろ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:そうね。なんだか<br>あたたかいものに包まれているみたい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_410008")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ディナタン★★:～♪
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_410028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ノワール★★:キズが癒される気がするって<br>みんな言ってた
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410010")

	change_face(Actor002,"Sad")

	--★★ノワール★★:ブライアンも、傭兵団のみんなも<br>…父さんも
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410011")

-- ▼直接出力
bgm_play("BGM_ADV_Dinatan_Stage_End")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayAction(Actor001,"to  Std_Joy")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:………
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_410012")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Surprise")

	--★★ノワール★★:ステージ上で歌っている<br>ディナタンを見るのは俺も初めてだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:すごい歓声ね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_410015")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003, Actor002, "J_Head")
lookat_delay_weight(Actor003, 1.0,0,0.5,0.3,0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:かわいい妹が<br>みんなのものになっちゃいそうで寂しい？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_410016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayAction(Actor001,"to  Std_Joy")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:そんなことは…！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410017")

-- ▼直接出力
bgm_play("BGM_ADV_Dinatan_Stage_End")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:…ちょっと、あるかも
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410018")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to Std_Loop")
lookat_delay_weight_reset(Actor003, 0.6)
set_enable_auto_lookat(Actor003, true)
se_play("SE_ADV_MA_01C110_41_Cheers_01")
wait_time(3.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
 --DontChangeRandomCamera(false)
 --setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★パーシヴァル★★:いやあ、素晴らしい歌声だったね！<br>ボクもなんだか力がみなぎってきたよ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_410020")

-- ▼直接出力
bgm_play("BGM_ADV_Dinatan_Theme")
-- ▲直接出力
-- ▼直接出力
 --setup_small_camera_start()
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★パーシヴァル★★:今のボクなら<br>どんな困難にも立ち向かえそうな気がするよ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_410021")

	PlayAction(Actor005,"to  Std_Joy")

	--★★パーシヴァル★★:ディナタンの歌はまさに女神の祝福！<br>ボクたちにパワーを与えてくれる希望の歌だ！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_410022")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:そ、そんな大げさな…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_410023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:でも、私の歌でみなさんが<br>元気になってくれたならとても嬉しいです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_410024")

-- ▼直接出力
 --DontChangeRandomCamera(false)
-- ▲直接出力

	--★★パーシヴァル★★:元気もらったもらった！<br>この調子で次の曲もいってみようじゃないか！
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01C110_410025")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
se_play("SE_ADV_MA_01C110_41_Cheers_02")
wait_time(2.8)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
wait_time(2.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…？ディナタンの様子が――
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01C110_410027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Dinatan_Theme")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110261)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110261_43)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
