-- このluaスクリプトは、MA_01C110_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110131_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110131_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110131_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_001)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,CharaPos110131_01_101)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110131)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:学園内の様子を見てこなくていいのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:久しぶりに会う連中もいるだろう<br>挨拶してくるといい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_220004","MA_01C110_220005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そう思って挨拶しにきたんだよ<br>まずはあんたの顔が見たかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220007")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:それは光栄だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:元気なようで安心した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:もう少し早く捜索隊を出せれば良かったんだがな<br>学園の復興に手間取ってしまった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220010")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:それにしても<br>妖精の森に呼ばれていたとは思わなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あとで行くよ<br>それより
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ごめん<br>大事なときにいられなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:気にするな<br>弟弟子の尻拭いは兄弟子の務めだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それに俺たちもさがすのが遅れた<br>…まさか、妖精の森にいたとはな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220017")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:わからないんだ。どうして森にいたのか<br>どうやって森に着いたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220019")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:あのときのお前たちにとって<br>森にいるのが最善だったということだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:もしかしたら、そのまま森にいたほうが<br>お前たちにとっては良かったのかもしれん
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どういう意味だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_220022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…いや、なんでもないさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_220023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:このあいだ、さ<br>ディナタンとロジーの里に行ってきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_9010002")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ロジーの里に？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ<br>父さんとブライアンにお別れをしたくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_9010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ディナタンは<br>師匠のことを覚えていたか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end()
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_9010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:そうか<br>それは良かった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010008")


	--★★ランスロット★★:師匠は俺を守ってキラーズとなり<br>お前を守って聖遺物化した
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010009")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…優しい人、だったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010010")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_9010011")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
IN_RUN(Actor003,CharaPos110131_01_001)
turn_lookat(Actor002,Actor003,0.5)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:どうした？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01C110_9010012")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:敵襲よ…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_9010013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110131)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
