-- このluaスクリプトは、MA_01C110_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_006)
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
-- ▼直接出力
Hide(Actor003)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
load_sound("VO_story01")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101021","002","101021002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101060","001","101060001")
	Actor005 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor006 = InitializeCharacter_2DOnly("101012","004","101012004")
	Actor007 = InitializeCharacter_2DOnly("101021","003","101021003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここは…故郷の村？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_060002")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:私たちどうして…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060003")


	--★★ディナタン★★:また帰って来たの…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:あれは…父さん！？<br>いや、そんなはずはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_060006")

-- ▼直接出力
CloseTalkWindow()　
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ブルーノ★★:おさがりより<br>新しいほうがいだろ？
	Talk(Actor007,"CHRNAME_BRUNO","speech","L","MA_01C110_060008")

	change_face(Actor005,"Sad")

	--★★ノワール・幼少★★:…だって、父さんみたいになりたいんだもん
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01C110_060009")

	change_face(Actor006,"Surprise")

	--★★ディナタン・幼少★★:お、お母さん、私には…？
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C110_060010")

	change_face(Actor004,"Smile")

	--★★セレスティ★★:私とそっくりな髪型を教えてあげるっ
	Talk(Actor004,"NPCNAME_0163","speech","L","MA_01C110_060011")


	--★★ディナタン・幼少★★:そっくりな髪型！？
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01C110_060012")

-- ▼直接出力
CloseTalkWindow()　
hide_image(BLACK_WHITE_TIME)
setup_small_camera_start(Camera001)
Appear(Actor003)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:これは…記憶…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_060014")

-- ▼直接出力
setup_small_camera_start()
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ブルーノ2★★:…ただいま
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:…あなた、誰？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060018")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_060019")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私大切なことを忘れて…<br>ううん、思い出した……！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060020")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")

	--★★ディナタン★★:父さん…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060021")

-- ▼直接出力
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ブルーノ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ブルーノ2★★:本当に大切なことをお前たちに<br>教えられなかった
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060022")


	--★★ブルーノ2★★:何故お前が継承者に選ばれたのか<br>何故お前でなければならなかったのか
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060023")


	--★★ブルーノ2★★:何故お前たちがとも共にいるのか
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:…父さん、なんのこと…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_060025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ブルーノ2★★:すべては妖精の願い<br>いや――…
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Serious")

	--★★ノワール★★:ディナタン気をつけろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C110_060028")

	on_cutin(1,Actor001,"Serious")

	--★★ノワール★★:これは父さんじゃない<br>俺たちを惑わす――幻だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C110_060029")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ブルーノ", "肯定2")
-- ▲直接出力
	close_cutin()
	change_face(Actor003,"Serious")

	--★★ブルーノ2★★:幻かどうか確かめてみるか？<br>ノワール
	Talk(Actor003,"CHRNAME_BRUNO2","speech","L","MA_01C110_060030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("VO_story01")
	InitializeLoad_Preload()
	load_area_scene_preload(114061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101021","002","101021002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101012","004","101012004")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
