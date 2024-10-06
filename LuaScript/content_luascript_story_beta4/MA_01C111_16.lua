-- このluaスクリプトは、MA_01C111_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_01","110081_01_h")
Include("content_adv_advsmall_110081_01","Template110081_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110081_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110081_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_002)
	Camera003 = SetTemplate("Actor003",160,CharaPos110081_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110081_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110081_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_006)
	InitializeTemplateRandomCamera110081_01()
	InitializeTemplate110081_01()
-- ▼直接出力
set_rot(Actor003,{0,150,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115084)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:今日も…いいの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160002")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor003,true)
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:水臭いなあ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C111_160003")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リオネス","肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:むしろその顔を見るために<br>頑張っているみたいなところがあるぞ！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to Finger")

	--★★リオネス★★:空腹は最も優れた調味料ともい言う！<br>動いて疲れた体には美味なゴハンが一番だ！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160005")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
 --PlayPartVoice("ガレス","喜び")
-- ▲直接出力

	--★★ガレス★★:学園のアイドルとそのマネージャー…<br>そして継承者に助力は惜しまないぞ
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C111_160006")

-- ▼直接出力
setup_small_camera_end()
change_face(Actor004,"Normal")
change_face(Actor005,"Normal")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_160007","MA_01C111_160008","MA_01C111_160009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor002,false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:敏腕マネージャーがいてくれて助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_160011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うんうん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160012")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:そりゃどーも<br>けどアイドルの私生活は家族が支えてこそだろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_160013")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:油断してんじゃねーぞ<br>オニーサン
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_160014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アイドルはオフが大事だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_160016")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リオネス★★:食事くらいで支えられていればいいけど…
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:じゅうぶんすぎるくらいだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160018")

-- ▼直接出力
 --PlayPartVoice("ディナタン","照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:みんなとお話してるときは<br>オフみたいなものだし、いつも…楽しいたのしい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:次のライブはいつ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_160022")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
 --PlayPartVoice("ガレス","驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガレス★★:わー！ハードスケジュール！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C111_160023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("マルディサント","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:ウチのアイドルを搾取しようったって<br>マネージャーが許さねえぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_160024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:注文はなんでもつけて！<br>好みの料理にカスタマイズしてあげる～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C111_160026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…ありがとう、ガレス
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160028")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:アンタらのご馳走をたらふく食うために<br>働いてるみたいなとこあるぜ、アタシらも
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_160029")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,80,0.5)
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ふふ、マァル<br>建前くらいちゃんとなさい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_160031")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:平和ノタメニ戦イマース
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C111_160033")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
set_pos(Actor002,{-5.82,0,10.18})
set_pos(Actor004,{-3.5,0,9.6})
turn_lookat_position(Actor002,{-5.44,0,13.31},0)
turn_lookat_position(Actor004,{-3.5,0,15.32},0)
Camera001=setup_small_camera_resetting(Actor001,CharaPos003,CameraPos003)
Camera005=setup_small_camera_resetting(Actor005,CharaPos005,CameraPos005)
set_rot(Actor001,{0,10,0})
set_rot(Actor005,{0,-60,0})
lookat_weight_reset(Actor001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor005,"Normal")
set_enable_auto_lookat_all(false)
lookat_weight_reset(Actor005)
setup_small_camera_start(RndCamera004)
wait_time(1)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-5.44,0,13.31},1.8)
wait_time(0.2)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-3.5,0,15.32},3.0)
fadein(FADE_TIME)
wait_time(3.0)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
Hide(Actor002)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("リオネス","挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★リオネス★★:ノワール
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160035")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,135,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力

	--★★リオネス★★:…ディナタン、細いよな
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160036")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_160037")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★リオネス★★:ダイエット…というわけでもないよなぁ<br>なに何か聞いてるか？
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160038")

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_160039")

-- ▼直接出力
setup_small_camera_start(Camera005)
 --PlayPartVoice("リオネス","悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★リオネス★★:頼まれたんだ
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Sad01")
-- ▲直接出力

	--★★リオネス★★:ごはん<br>少なくしてくれって?
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","MA_01C111_160041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115084)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
