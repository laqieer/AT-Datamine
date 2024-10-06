-- このluaスクリプトは、MA_01107_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113021_01","113021_01_h")
Include("content_adv_advsmall_113021_01","Template113021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-105,CharaPos113021_01_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_011)
	Camera002 = SetTemplate("Actor002",-90,CharaPos113021_01_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_012)
	Camera003 = SetTemplate("Actor003",35,CharaPos113021_01_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName113021_01,CameraPos113021_01_010)
	InitializeTemplateRandomCamera113021_01()
	InitializeTemplate113021_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor001,{3.6,0.051,3.9})
set_pos(Actor002,{3.3,0.051,3})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0.5,0.03,0.7,0)
lookat_weight(Actor002,0.6,0.03,0.7,0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{1.2,0.051,3.9},1.7)
wait_time(1.2)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{0.9,0.051,3},1.7)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,105,0.5)
-- ▲直接出力

	--★★トリスタン★★:おかえり。遅かったね<br>戦果の報告でもしに来たの？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410002")


	--★★ノワール★★:…？<br>なにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410003")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力

	--★★トリスタン★★:大切な人を消すことになったとしたらさ<br>うまく踏み切れる心の持ち主？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:なにを言ってるんだ、トリスタン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力

	--★★トリスタン★★:キズは癒すべきじゃなかった<br>信用すべきじゃなかったと後悔するよ、きっと
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410006")

	change_face(Actor003,"Anger")

	--★★トリスタン★★:血の繋がりも、縁の繋がりも
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410007")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:………脱走したんだよ<br><ruby=ブライアン>キミの義父上</ruby>がね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410008")

	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:…ブライアンが脱走だって！？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01107_410010")

	PlayAction(Actor002,"to  Std_Surp")
	on_cutin(2,Actor002,"Surprise")

	--★★ディナタン★★:そんな…！？<br>キズが完全に癒えたわけじゃないのに！
	Talk(Actor002,"CHRNAME_DINATAN","speech","N","MA_01107_410011")

	close_cutin()
	PlayAction(Actor003,"to  Std_Talk")

	--★★トリスタン★★:鍵は外から開けられていた<br>手引きした者がいる
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…どうして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:言ったはずだよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410014")


	--★★トリスタン★★:「偽ってる時点でいつか裏切られる<br>信じたって無駄だ」って
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410015")

	PlayAction(Actor003,"to  Std_Worry")

	--★★トリスタン★★:魔女のもとにでも帰ったのかな
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01107_410018","MA_01107_410019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ちがう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410021")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄、さん…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_410022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンたちが言っていた<br>あの人はずっと悪役を演じ続けていると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410023")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ずっと嘘をついていると
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…うん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_410025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410027")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:兄さん、私は信じないよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_410028")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:言い切れる？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01107_410029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:言い切れることなんて<br>世のなかありません
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_410030")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:だけど信じてあげなくちゃならないこともある<br>信じ続けたいと思うことがあります
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_410031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ。そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410032")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:本当は、ちがうはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_410034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
