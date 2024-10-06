-- このluaスクリプトは、MA_01C110_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110131_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110131_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110131_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_005)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
-- ▼直接出力
 --turn_chara(Actor003,21.157,0)
turn_chara(Actor001,93.251,0)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {3.6,0,13})
set_rot(Actor003, {0,-110,0})
CameraEX = set_camera({-1.337,1.193,11.65,-3.756,79.741,0,28.99837})
 --CameraEX = set_camera({0.946,1.778,3.958,11.383,10.14,0,28.99837})
Camera003 = manager.RegisterExclusiveCamera(CameraEX, Actor003)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110131)
	Actor001 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ノワール★★:ん？あれは…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C110_380002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディンドラン★★:パーシヴァル様、大丈夫ですか<br>唇がだいぶ紫色ですけど
	Talk(Actor001,"CHRNAME_DINDRANE","speech","L","MA_01C110_380003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★パーシヴァル★★:だ、大丈夫に決まってるだろ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380004")

	open_select_window_tag(Actor003,"Normal","MA_01C110_380005","MA_01C110_380006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
 --CloseTalkWindow()
 --IN_WALK(Actor003,CharaPos110131_01_005)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{0.985,0,12.028}, 1.5)
wait_time(1.2)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
wait_time(0.2)
turn_chara(Actor003,-70,0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor003,0.8,0.02,0.5,0.1,1.0)
keep_ik_lookat(Actor003, Actor002, "J_Head")
turn_chara(Actor002,170,0)
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:パーシヴァル、緊張してるのか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C110_380008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:なっ…ノワール！なんでここに！？<br>っていうか、別にボクは緊張なんてしてない！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Pain")

	--★★パーシヴァル★★:そもそも、MCを務めるのは初めてじゃないんだ<br>これくらい軽くこなしてみせるさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Appl")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディンドラン★★:さすがはパーシヴァル様<br>五月祭のMCも素晴らしかったですものんね
	Talk(Actor001,"CHRNAME_DINDRANE","speech","L","MA_01C110_380012")

	change_face(Actor001,"Smile")

	--★★ディンドラン★★:ところで、緊張には<br>掌に文字を書いて飲むといいそうですよ
	Talk(Actor001,"CHRNAME_DINDRANE","speech","L","MA_01C110_380013")

-- ▼直接出力
turn_chara(Actor002,-110,0.4)
PlayActionDirect(Actor002,"to  Std_Surp")
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:だから緊張してないって言ってるだろ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor002,140,0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:…さて、ノワール<br>悪いけど、どこかへ行ってくれるかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380015")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:舞台に上がる前に<br>気持ちを作っておきたいんでね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:ああ、わかった。がんばれよ<br>MC、楽しみにしてるからな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C110_380017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:言われなくても
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380018")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
turn_chara(Actor002,-120,0)
lookat_delay_weight_reset(Actor002 , 1)
setup_small_camera_start(RndCamera001)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:これからボクはもっと大きなことに<br>立ち向かわなきゃならないんだからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:これくらいで緊張してる場合じゃないんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380021")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ディンドラン★★:パーシヴァル様…
	Talk(Actor001,"CHRNAME_DINDRANE","speech","L","MA_01C110_380023")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…ボクはもうあの頃のボクじゃない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:大切なものを奪われて<br>泣き寝入りなんてゴメンだからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380025")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ボクは、戦わなくちゃならないんだ<br>…だからアーサー、あなたのことは必ず…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
SkipDefaultMotion(Actor002)
setup_small_camera_start(RndCamera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ボクはもう、あの頃のボクじゃないんだ<br>だから緊張なんて、す、するわけ…！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01C110_380028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ノワール★★:（…すごく緊張しているみたいだな<br>そっとしておいてあげよう）
	Talk(Actor003,"CHRNAME_NOIR","mind","L","MA_01C110_380030")

	goto Block1end

::Block1end::
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Speculation")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110131)
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
