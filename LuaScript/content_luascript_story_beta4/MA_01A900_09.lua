-- このluaスクリプトは、MA_01A900_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-154,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",125,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
tegami = setup_prop_object(10106004)
 --tegami_offset = {0,-0.08,0,358.654,30.0615,275.411}
tegami_offset = {-0.003,-0.009,0.027,-2.151,21.552,172.55}
off_active(tegami)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
load_image("101030500", "content_still_10103050_image", "101030500_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090002")

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor001,"to Wlk")
set_common_look_at(Actor001,Actor002)
turn_lookat(Actor001,Actor002,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:私…ギネヴィアさんに初めて手紙を出したとき<br>そのなかで尋ねたんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090005")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:「あなたのようになるには、どうしたら？」と
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090006")


	--★★エレイン★★:ギネヴィアさんは<br>「こんなこと、はじめて言われた」と笑って
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090007")

	change_face(Actor002,"Smile")

	--★★エレイン★★:「超しんどいけど、戦う」と答えてくれた
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:だから、なんとなくわかります<br>ずっとふたりについてきた私だから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:泣いているんですね<br>先輩とギネヴィアさんは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090011")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:女の子ってね<br>悲しくなくても泣くんですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:悔しいときや怒ったときも<br>いっぱい涙が出るんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090014")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:でもそれは…もし、私だったら…こんな状況で<br>私だったら、私が泣くとしたら、その理由は…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090015")

	change_face(Actor002,"Normal")

	--★★エレイン★★:「先輩を悲しませたくない」から
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_090019","MA_01A900_090020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…泣かれたら<br>悲しいじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_090022")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:そうなんですけど！<br>そうなんですけど、そうさせたくないんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090024")

	change_face(Actor002,"Sad")

	--★★エレイン★★:そうさせたくないのに涙が出てくるから<br>余計に自分に腹が立ったりするんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:「怖い」って<br>言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_090027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:怖くって、泣くしかなかったんだと思います<br>これから待っていることを考えると、当然です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090029")

	change_face(Actor002,"Sad")

	--★★エレイン★★:でもそのなかでも、一番怖いのは<br>先輩を辛い気持ちにさせることです…きっと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090030")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★エレイン★★:おなじ…だから、わかるんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090032")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:同じ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_090034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:ギネヴィアさんのように変わりたくて<br>先輩のそばに行きたくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090036")

-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:………同じ、くらい<br>ギネヴィアさんと同じくらい、私…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090037")


	--★★エレイン★★:…言えない気持ちがあるのが<br>わかる、から…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:このキズの痛みが引くまでずっと<br>戦い続けたふたりのために
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090041")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor002,"to LookFor")
se_play("SE_ADV_MA_01B112_49_Cloth")
lookat_weight(Actor001,0.5,0.03,0.7,0.25)
keep_delay_ik_lookat(Actor001,Actor002, "Loc_weapon_constrint_L",0.5)
wait_time(1.5)
PlayActionDirect(Actor002,"to Show")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
show_image("101030500", 0.0, 0.0, 0,true,false)
fadein(1.5)
setup_small_camera_start(RndCamera004)
set_common_look_at(Actor001,Actor002)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(3.0)
hide_image(0)
PlayActionDirect(Actor001,"to ReadLetter")
se_play("SE_ADV_MA_01105_28_Paper")
on_active(tegami)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", tegami_offset)
 --setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:手紙…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_090043")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:ギネヴィアさんに渡してください
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090044")

-- ▼直接出力
off_parent(tegami)
off_active(tegami)
-- ▲直接出力

	--★★エレイン★★:いえないきもちを、したためました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A900_090045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start()
wait_time(1.0)
play_head_motion(Actor001,"Nod",0.3, 1.0, false)
wait_time(1.0)
lookat_delay_weight_reset(Actor001,0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,0,0.4)
wait_time(0.4)
slidemove(Actor001,{1.082,0,8.5},5)
wait_time(0.5)
turn_chara(Actor002,62,2.0)
lookat_position(Actor002,{1.082,0,8.5})
wait_time(5.5)
setup_small_camera_start(Camera002)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Sad01")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:………いえなくて、いいって覚悟したのに
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A900_090047")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン★★:超、しんどいな
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A900_090049")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10106004)
tegami_offset = {-0.003,-0.009,0.027,-2.151,21.552,172.55}
load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
load_image_preload("101030500", "content_still_10103050_image", "101030500_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
