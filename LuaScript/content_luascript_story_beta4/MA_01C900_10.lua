-- このluaスクリプトは、MA_01C900_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",142,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",-62,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:準備は終わった？<br>兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、ディナタンは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:いつでもいけるよ。私、準備は早いほうなの<br>知らなかった？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうだったな<br>…お前は昔からしっかりしてたよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…なぁ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100007")


	--★★ディナタン★★:なに？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100008")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:聞きたいことがあるんだ<br>森でのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:森のなかでのことを俺は覚えていない<br>でもディナタンは覚えている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:なぁ、あのとき――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100012")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:森が忘れたほうがいいって思ったんなら<br>きっと忘れたほうがいいことなんだよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100014")


	--★★ディナタン★★:迷っても不安でもそれでも<br>私たちにはやらなきゃいけないことがある
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100015")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:そうでしょ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:…あぁ、そうだな<br>――そうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100017")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:…ねえ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100020")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:戦いが終わって平和になったら<br>話したいことがあるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:だからアーサー様を倒して<br>ブリテンを平和にしなくちゃ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_100023")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:全部終わったら、ちゃんと話すから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100024")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:だから今はアーサーを倒すことだけを<br>考えよう?
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_100025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
