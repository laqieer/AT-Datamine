-- このluaスクリプトは、EA_069_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",120,CharaPos110191_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_003)
	Camera002 = SetTemplate("Actor002",145,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_005)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-19.5,0,-9.1})
set_pos(Actor003,{-18,0,-9.3})
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Sad")
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor004,"","narration","L","EA_069_0120003")

-- ▼直接出力
wait_time(0.7)
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(0.1)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002, -19.5, 0, -11.7, 2)
wait_time(2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002,0.45,0.3,0.85,0.4,1.02)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ヴォールス_002","0007")
-- ▲直接出力

	--★★ヴォールス★★:どうしたんだ、浮かない顔をして<br>なにか気になることでも？
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_069_0120007")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Normal")
setup_small_camera_start(Camera001)
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,25,0.8)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001,0.45,0.1,0.85,0.2,1.02)
wait_time(0.4)
setup_small_camera_start(Camera002)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ギネマウア_004","0036")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネマウア★★:…お気遣いありがとうございますお優しいのですね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力

	--★★ヴォールス★★:クラスメイトだからな<br>転入生に優しくするのは当然だ
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_069_0120009")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ヴォールス★★:まだ慣れないことも多いだろう<br>助けになれることがあれば言ってくれ
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_069_0120010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:ありがとうございます<br>でも大丈夫ですよ、私は
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120011")

-- ▼直接出力
Appear(Actor003)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力

	--★★ギネマウア★★:私たちがログレスに来て<br>もう4ヶ月も経っているのですから――
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120012")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0002")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:あ、いたいた！<br>ギネマウア先輩！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120013")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.2)
lookat_delay_weight(Actor001,0.6,0.6,0.6,0.6,0.3)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.4)
lookat_delay_weight(Actor002,0.45,0.2,0.55,0.3,0.4)
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003, -18.3, 0, -11.3, 1)
wait_time(0.95)
turn_chara(Actor003,-150,0.1)
wait_time(0.1)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ギネマウア_004","0028")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:ラグネル様？<br>私になにかご用ですか？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120015")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:あたしがってわけじゃないんだけど<br>ギネヴィア様のことでちょっと
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120016")

-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor002,0.45,0.6,0.55,0.6,1.0)
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:殿下の？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120017")

	open_select_window_tag(Actor001,"Normal","EA_069_0120019","EA_069_0120020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ギネマウア","0002")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:殿下になにかあったのでしょうか？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ラグネル★★:なにかあった、というより<br>現在進行形でやってるというか
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120024")

	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:…？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0037")
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120028")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.2)
lookat_delay_weight(Actor001,0.6,0.6,0.6,0.6,0.6)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0028")
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:そんな、気にしないでください！<br>転入生に優しくするのは当然！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:なんたって、あたしとギネヴィア様は<br>クラスメイトなんですからね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120030")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor002,0.6,0.6,0.6,0.6,0.6)
PlayPartVoiceDirect("ギネマウア_004","0037")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:それで、いったいなにが？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120032")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:さっきのバイブス学の実地授業でギネヴィア様、あんまりうまくいかなくて
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120033")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラグネル★★:それで、授業が終わった後もまだやるんだって言い張っちゃってですね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120034")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0034")
PlayActionDirect(Actor003,"to  Std_Sad02")
SkipDefaultMotion(Actor003)
-- ▲直接出力

	--★★ラグネル★★:なんていうか、その…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120035")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…また、駄々をこねているんですね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120036")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0025")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★ラグネル★★:平たく言うと、そんな感じです
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120037")


	--★★ラグネル★★:ランスロット先生のご指導の下近くの訓練場で居残り鍛錬中です
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120038")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス★★:だがランスロットはこの後任務の予定がなかったか？
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_069_0120039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ラグネル★★:そうなんですよね～
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120040")


	--★★ラグネル★★:だから特訓なら空いてるあたしたちが…って<br>言ったんですけど先生じゃないから駄目みたいで
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120041")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0025")
-- ▲直接出力

	--★★ラグネル★★:まぁランスロット先生のことだから<br>大丈夫なんだろうとは思うんですけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_069_0120042")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0038")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:…わかりました<br>侍女として、私が殿下を迎えに行きます
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0120043")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,55,0.4)
wait_time(0.4)
slidemove(Actor001, -15, 0, -4.7, 4)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
