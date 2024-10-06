-- このluaスクリプトは、MA_01C900_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Anger")

	--★★マルディサント★★:あんたがディーナを選ばなきゃ<br>ディーナはあんたの妹でいられた…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210002")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★マルディサント★★:継承者の劔になんかならなきゃ──
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210003")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:誰かがすべきことなんだよ。マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")

	--★★マルディサント★★:ディーナじゃなくたって<br>いいじゃねえか！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C900_210007","MA_01C900_210008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ディナタンが選んでくれたんだ<br>この道を
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_210010")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:………兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210011")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:最低だぜ、あんた
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210012")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:ディーナが選んでくれたァ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210013")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:土壇場で責任逃れかよ<br>あんたの意志はどこいっちまったんだよ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺がディナタンに戦いを強制した<br>マルディサントの言う通り──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_210017")

	change_face(Actor001,"Normal")

	--★★ノワール★★:継承者の劔になんてさせなければ<br>ディナタンをこんな目に遭わせないで済んだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_210018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★マルディサント★★:そーだよ<br>あんたがディーナを連れていっちまった…！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210019")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:あんたは家族を守るんじゃなく戦いの手段にした<br>自分勝手な想いで、クソみてえな独占欲で
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210020")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…私が応えたんだよ。マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210021")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:ディーナ…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もう、置いていかないと決めたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_210023")

	goto Block1end

::Block1end::
	change_face(Actor002,"Anger")

	--★★ディナタン★★:兄さんを責めてどうするの<br>私たちを止めてどうするの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210025")


	--★★ディナタン★★:それで<br>なにか良くなるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210026")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:ディーナが
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…私が？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210028")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★マルディサント★★:………ディーナが、消えちまうよぉ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:消えないよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210030")


	--★★マルディサント★★:ディーナはこんなことしたくねえんじゃねえのか<br>キモチ押し殺して、やってきたんじゃねえのか
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210031")


	--★★マルディサント★★:このまま本当のディーナが<br>消えちまう気がすんだよ、こわいんだよぉ…！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210032")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:マァル………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:ディーナの気持ちを…聞かせてくれよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210034")

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:…私、兄さんが好き
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210036")

-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:だから私、兄さんと私が<br>本当の兄妹じゃなくてよかったって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ちょっとだけ思ってたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210038")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんが兄さんじゃないなら<br>私がこんなふうに兄さんを好きでも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210039")


	--★★ディナタン★★:許してもらえるのかなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:大好きだよ、兄さん<br>兄妹としてじゃなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210041")

	change_face(Actor001,"Sad")

	--★★ノワール★★:……俺は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_210042")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:答えはいらないの<br>伝えたかっただけだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:だって私は兄さんの…<br>継承者の武器になったんだもの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210044")


	--★★ディナタン★★:この気持ちがあってもなくても<br>それは間違いない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210045")

-- ▼直接出力
set_common_look_at(Actor002,Actor003,0.8)
-- ▲直接出力

	--★★ディナタン★★:だから…ね、マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:ディーナ…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210047")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:ごめんね、マァル<br>――ありがとう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210049")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")

	--★★マルディサント★★:…………う、わああああん…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210050")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:泣かないでマァル…私…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210052")

	PlayAction(Actor003,"to  Std_No")

	--★★マルディサント★★:うぅ…う……うう…<br>アタシは…――アタシは
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210053")


	--★★マルディサント★★:アタシはあんたの武器だ<br>ディーナ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_210054")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…ありがとう、マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_210055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
