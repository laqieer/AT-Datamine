-- このluaスクリプトは、MA_01A110_47.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
load_image("101030180", "content_still_10103018_image", "101030180_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102018)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","003","101030003","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★エレイン★★:冷や冷やさせて<br>ごめんなさい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470002")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★エレイン★★:だけど、先輩…っ！<br>私、できました！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、見てたよ<br>すごく堂々としてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_470005")


	--★★エレイン★★:全部先輩の、おかげです！<br>先輩が、私を支えてくれたから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470006")


	--★★エレイン★★:ほんとに…ほんとにありがとうございます！<br>先輩、私――
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470007")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:…──す、すみません！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470009")


	--★★エレイン★★:ごめん、なさい………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…お祭りなんて<br>はじめてだったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_470012")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002, 0, 1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:え…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:みんなとなにかを作るのが<br>こんなに楽しいことだなんて初めて知った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_470015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:だから俺のほうこそ<br>ありがとう、エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_470016")


	--★★エレイン★★:先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:汗、たくさんかいてる<br>そのままじゃ体が冷えるよ。行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_470018")

-- ▼直接出力
CloseTalkWindow() 
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-100,0.5)
wait_time(0.4)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{1.78,0, 1.426}, 3)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
show_image("101030180", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:私の台本<br>もらってくれませんか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A110_470022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:あ、わ、私、モノをなくしちゃったりするんです<br>だから…先輩に預かっていて欲しくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470023")


	--★★エレイン★★:この、思い出とか<br>代役をしてくださったこと、とか
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470024")

	change_face(Actor002,"Shy")

	--★★エレイン★★:先輩に<br>もらってほしくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470026")


	--★★エレイン★★:…もう、行かなきゃですよね<br>もう終わりですもんね、わかってます
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470028")

	change_face(Actor002,"Sad")

	--★★エレイン★★:嘘も、おわり
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:エレイン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A110_470031")


	--★★エレイン★★:だけど、やっぱり──
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:ちょっとだけ<br>冷えてしまったので
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A110_470033")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 1.5)
wait_time(1.5)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(0.6)
wait_time(0.6)
-- ▲直接出力

	--★★エレイン★★:もう…ほんのすこしだけ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_470035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030180", "content_still_10103018_image", "101030180_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102018)
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","003","101030003","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
